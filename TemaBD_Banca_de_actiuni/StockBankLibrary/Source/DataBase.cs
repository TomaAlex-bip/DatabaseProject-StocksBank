using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;
using System.Configuration;
using StockBankLibrary.Source;

namespace StockBankLibrary
{
    public static class DataBase
    {

        private static OracleConnection DBconnection =
            new OracleConnection(ConfigurationManager.ConnectionStrings["DBconnection"].ConnectionString);

        private static bool ConnectToDatabase()
        {
            try
            {
                DBconnection.Open();
            }
            catch
            {
                return false;
            }
            return true;
        }
        public static bool DisconnectFromDatabase()
        {
            try
            {
                DBconnection.Close();
            }
            catch
            {
                return false;
            }
            return true;
        }
        public static void MakeDatabaseConnection()
        {
            bool connected = false;

            while(!connected)
            {
                connected = ConnectToDatabase();
            }
        }

        public static string InsertNewClientAccount(Account account)
        {
            

            OracleTransaction transaction = DBconnection.BeginTransaction(System.Data.IsolationLevel.ReadCommitted);
            OracleCommand command = DBconnection.CreateCommand();
            
            try
            {
                command.CommandText =
                    "INSERT INTO client(client_id, first_name, last_name, cnp) " +
                    $"VALUES({account.ClientId}, " +
                    $"'{ account.ClientProp.FirstName }', " +
                    $"'{ account.ClientProp.LastName }', " +
                    $"'{ account.ClientProp.Cnp }')";
                command.ExecuteNonQuery();

                command.CommandText =
                "INSERT INTO client_details(client_id, birth_date, genre, city, address, phone, email) " +
                    $"VALUES({account.ClientId}, " +
                    $"TO_DATE('{account.ClientProp.ClientDetailsProp.BirthDate}', 'DD.MONTH.YYYY')," +
                    $"'{account.ClientProp.ClientDetailsProp.Genre}', " +
                    $"'{ account.ClientProp.ClientDetailsProp.City }', " +
                    $"'{ account.ClientProp.ClientDetailsProp.Address }', " +
                    $"'{ account.ClientProp.ClientDetailsProp.Phone }', " +
                    $"'{ account.ClientProp.ClientDetailsProp.Email }')";
                command.ExecuteNonQuery();

                string comm = account.Commission.ToString();
                comm.Replace(",", ".");
                command.CommandText = 
                    "INSERT INTO account(client_id, iban, balance, username, password, commission) " +
                    $"VALUES({account.ClientId}, " +
                    $"'{ account.Iban }', " +
                    $" { account.Balance }, " +
                    $"'{ account.Username }', " +
                    $"'{ Cryptography.Encrypt(account.Password) }', " +
                    $" 0.02 )";
                command.ExecuteNonQuery();

                transaction.Commit();
            }
            catch(OracleException e)
            {
                transaction.Rollback();

                command.Dispose();
                transaction.Dispose();
                return "db_insert_err: " + e.ToString();
            }

            command.Dispose();
            transaction.Dispose();
            return "success";
        }

        public static int GetLastClientId()
        {
            int lastCliendId = 0;
            try
            {
                OracleCommand command = DBconnection.CreateCommand();
                command.CommandText = "SELECT MAX(client_id) FROM client";
                
                OracleDataReader dataReader = command.ExecuteReader();

                while(dataReader.Read())
                {
                    lastCliendId = dataReader.GetInt32(0);
                }

                command.Dispose();
                dataReader.Dispose();

            }
            catch (OracleException)
            {
                return -1;
            }

            return lastCliendId;

        }
        public static int CheckForExistingIban(string generatedIban)
        {
            int ceva = 0;
            try
            {
                OracleCommand command = DBconnection.CreateCommand();
                command.CommandText = 
                    "SELECT client_id FROM account " +
                    $"WHERE iban = '{generatedIban}' ";

                OracleDataReader dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    ceva = dataReader.GetInt32(0);
                }

                command.Dispose();
                dataReader.Dispose();

            }
            catch (OracleException)
            {
                return -1;
            }

            return ceva;

        }
        public static int CheckForExistingClientId(int generatedClientId)
        {
            int client = 0;
            try
            {
                OracleCommand command = DBconnection.CreateCommand();
                command.CommandText = 
                    "SELECT client_id FROM account " +
                    $"WHERE client_id = {generatedClientId}";
                OracleDataReader dataReader = command.ExecuteReader();

                while(dataReader.Read())
                {
                    client = dataReader.GetInt32(0);
                }
            }
            catch(OracleException)
            {
                return -1;
            }
            return client;
        }

        public static int LogInToDatabase(string username, string password)
        {

            int foundClientId = 0;
            try
            {
                OracleCommand command = DBconnection.CreateCommand();
                command.CommandText = 
                    $"SELECT client_id FROM account " +
                    $"WHERE username = '{username}' " +
                    $"AND password = '{Cryptography.Encrypt(password)}'";

                OracleDataReader dataReader = command.ExecuteReader();

                while(dataReader.Read())
                {
                    foundClientId = dataReader.GetInt32(0);
                }

                command.Dispose();
                dataReader.Dispose();

            }
            catch(OracleException)
            {
                return -1;
            }

            return foundClientId;
        }

        public static Account GetClientInfoFromDatabase(int clientId)
        {
            Account account = new Account();
            try
            {
                OracleCommand command = DBconnection.CreateCommand();

                command.CommandText =
                    "SELECT a.iban, a.balance, a.username, a.password, a.commission, " +
                    "c.first_name, c.last_name, c.cnp, cd.birth_date, cd.genre, " +
                    "cd.city, cd.address, cd.phone, cd.email " +
                    "FROM account a, client c, client_details cd " +
                    "WHERE a.client_id = c.client_id AND c.client_id = cd.client_id " +
                    $"AND c.client_id = {clientId} ";


                OracleDataReader dataReader = command.ExecuteReader();

                while(dataReader.Read())
                {
                    var iban = dataReader.GetString(0);
                    var balance = dataReader.GetFloat(1);
                    var username = dataReader.GetString(2);
                    
                    var encryptedPassword = dataReader.GetString(3);
                    var deryptedPassword = Cryptography.Decrypt(encryptedPassword);


                    var commission = dataReader.GetFloat(4);

                    var first_name = dataReader.GetString(5);
                    var last_name = dataReader.GetString(6);
                    var cnp = dataReader.GetString(7);

                    var birth_date = dataReader.GetString(8);
                    var genre = dataReader.GetString(9);
                    var city = dataReader.GetString(10);
                    var address = dataReader.GetString(11);
                    var phone = dataReader.GetString(12);
                    var email = "";
                    try
                    {
                        email = dataReader.GetString(13);
                    }
                    catch(Exception)
                    {
                        email = "";
                    }

                    account.InitializeAccount(username, deryptedPassword, clientId, iban,
                                              balance, commission,
                                              last_name, first_name, cnp, birth_date,
                                              genre, city, address, phone, email);

                    command.Dispose();
                    dataReader.Dispose();

                    return account;
                }
            }
            catch(OracleException)
            {
                return null;
            }

            return null;
        }

        public static string MakeDatabaseTransaction(uint clientId, string type, float ammount, string transactionIban = null, float commission = 0f)
        {
            OracleTransaction transaction = DBconnection.BeginTransaction(System.Data.IsolationLevel.ReadCommitted);
            try
            {
                OracleCommand command = DBconnection.CreateCommand();
                OracleCommand commandUpdate1 = DBconnection.CreateCommand();
                OracleCommand commandUpdate2 = DBconnection.CreateCommand();

                switch(type)
                {
                    case "deposit":
                        command.CommandText =
                            $"INSERT INTO transaction(client_id, transaction_details, transaction_date, transaction_cash) " +
                            $"VALUES({clientId}, 'deposit', sysdate, {ammount.ToString("0.00").Replace(",", ".")}) ";

                        commandUpdate1.CommandText =
                            $"UPDATE account " +
                            $"SET balance = NVL(balance, 0) + {ammount.ToString("0.00").Replace(",", ".")} " +
                            $"WHERE client_id = {clientId} ";

                        break;


                    case "withdraw":
                        command.CommandText =
                            $"INSERT INTO transaction(client_id, transaction_details, transaction_date, transaction_cash) " +
                            $"VALUES({clientId}, 'withdraw', sysdate, {ammount.ToString("0.00").Replace(",", ".")}) ";

                        commandUpdate1.CommandText =
                            $"UPDATE account " +
                            $"SET balance = NVL(balance, 0) - {ammount.ToString("0.00").Replace(",", ".")} " +
                            $"WHERE client_id = {clientId} ";

                        break;


                    case "transfer":

                        OracleCommand checkIban = DBconnection.CreateCommand();
                        checkIban.CommandText = 
                            $"SELECT client_id FROM account WHERE iban = '{transactionIban}' ";

                        OracleDataReader reader = checkIban.ExecuteReader();
                        int ok = 0;
                        while(reader.Read())
                        {
                            ok = reader.GetInt32(0);
                        }
                        if(ok == -1 || ok == 0)
                        {
                            checkIban.Dispose();
                            reader.Dispose();
                            transaction.Dispose();
                            command.Dispose();
                            return "invalid_iban";
                        }

                        command.CommandText =
                            $"INSERT INTO transaction(client_id, transaction_details, transaction_date, transaction_cash, transaction_iban) " +
                            $"VALUES({clientId}, 'transfer', sysdate, {ammount.ToString("0.00").Replace(",", ".")}, '{transactionIban}') ";

                        commandUpdate1.CommandText = 
                            $"UPDATE account " +
                            $"SET balance = NVL(balance, 0) + {ammount.ToString("0.00").Replace(",", ".")} " +
                            $"WHERE iban = '{transactionIban}' ";

                        commandUpdate2.CommandText = 
                            $"UPDATE account " +
                            $"SET balance = balance - {ammount.ToString("0.00").Replace(",", ".")} " +
                            $" * (1 + {commission.ToString("0.00").Replace(",", ".")}) " +
                            $"WHERE client_id = {clientId} ";

                        break;
                }

                
                command.ExecuteNonQuery();
                commandUpdate1.ExecuteNonQuery();
                if(type == "transfer") commandUpdate2.ExecuteNonQuery();

                transaction.Commit();

                transaction.Dispose();
                command.Dispose();

                return "success";
            }
            catch(OracleException e)
            {
                transaction.Rollback();
                return "error: " + e.ToString();
            }
        }
        public static string MakeAnInvestment(uint clientId, string stockId, int ammount)
        {
            OracleTransaction transaction = DBconnection.BeginTransaction(System.Data.IsolationLevel.ReadCommitted);
            try
            {
                if (ammount > 0) // BUY
                {
                    OracleCommand command = DBconnection.CreateCommand();
                    command.CommandText =
                        $"INSERT INTO invest(client_id, stock_id, ammount, aquisition_date, aquisition_price) " +
                        $"VALUES({clientId}, '{stockId}', {ammount}, sysdate, (SELECT current_value FROM bvb WHERE stock_id = '{stockId}')) ";
                    command.ExecuteNonQuery();

                    OracleCommand commandUpdate1 = DBconnection.CreateCommand();
                    commandUpdate1.CommandText =
                        "UPDATE account " +
                        $"SET balance = balance - {ammount} * (SELECT current_value FROM bvb WHERE stock_id = '{stockId}')" +
                        $"WHERE client_id = {clientId} ";
                    commandUpdate1.ExecuteNonQuery();

                    OracleCommand commandUpdate2 = DBconnection.CreateCommand();
                    commandUpdate2.CommandText =
                        $"UPDATE bvb SET ammount_left = ammount_left - {ammount} WHERE stock_id = '{stockId}' ";
                    commandUpdate2.ExecuteNonQuery();

                    transaction.Commit();
                    return "success";
                }
                else if (ammount < 0) // SELL
                {
                    OracleCommand command = DBconnection.CreateCommand();
                    command.CommandText =
                        $"INSERT INTO invest(client_id, stock_id, ammount, aquisition_date, aquisition_price) " +
                        $"VALUES({clientId}, '{stockId}', {ammount}, sysdate, (SELECT current_value FROM bvb WHERE stock_id = '{stockId}')) ";
                    command.ExecuteNonQuery();

                    ammount = Math.Abs(ammount);
                    OracleCommand commandUpdate1 = DBconnection.CreateCommand();
                    commandUpdate1.CommandText =
                        "UPDATE account " +
                        $"SET balance = balance + {ammount} * (SELECT current_value FROM bvb WHERE stock_id = '{stockId}') * (1-commission) " +
                        $"WHERE client_id = {clientId} ";
                    commandUpdate1.ExecuteNonQuery();

                    OracleCommand commandUpdate2 = DBconnection.CreateCommand();
                    commandUpdate2.CommandText =
                        $"UPDATE bvb SET ammount_left = ammount_left + {ammount} WHERE stock_id = '{stockId}' ";
                    commandUpdate2.ExecuteNonQuery();

                    transaction.Commit();
                    return "success";
                }
                else
                {
                    return "error ammount null";
                }
            }
            catch(OracleException e)
            {
                transaction.Rollback();
                string rez = "error: " + e.ToString();
                return rez.ToLower();
            }
        }

        public static List<Transaction> GetClientTransactons(uint clientId)
        {
            List<Transaction> transactions = new List<Transaction>();
            try
            {
                OracleCommand command = DBconnection.CreateCommand();

                command.CommandText = 
                    $"SELECT transaction_id, transaction_details, " +
                    $"TO_CHAR(transaction_date, 'DD.MM.YYYY'), TO_CHAR(transaction_date, 'HH24:MM:SS'), " +
                    $"transaction_cash, transaction_iban " +
                    $"FROM transaction " +
                    $"WHERE client_id = {clientId} " +
                    $"ORDER BY transaction_id DESC";

                OracleDataReader dataReader = command.ExecuteReader();

                while(dataReader.Read())
                {

                    var t_id = dataReader.GetInt32(0);
                    var t_details = dataReader.GetString(1);
                    var t_date = dataReader.GetString(2);
                    var t_hour = dataReader.GetString(3);
                    var t_cash = dataReader.GetFloat(4);
                    string t_iban;
                    try
                    {
                        t_iban = dataReader.GetString(5);
                    }
                    catch(Exception)
                    {
                        t_iban = "";
                    }

                    var t = new Transaction((uint)t_id, t_details, t_date, t_hour, t_cash, t_iban);

                    transactions.Add(t);
                }

                command.Dispose();
                dataReader.Dispose();

            }
            catch(OracleException)
            {
                return null;
            }

            return transactions;
            
        }
        public static List<BvbStock> GetBVBStocks(string orderColumn = "", string orderType = "")
        {
            List<BvbStock> stocks = new List<BvbStock>();

            try
            {
                OracleCommand command = DBconnection.CreateCommand();
                
                if(orderColumn == "")
                {
                    command.CommandText = 
                        "SELECT stock_id, stock_name, initial_ammount, ammount_left, " +
                        "current_value, last_value " +
                        "FROM bvb";
                }
                else
                {
                    command.CommandText =
                       "SELECT stock_id, stock_name, initial_ammount, ammount_left, " +
                       "current_value, last_value " +
                       $"FROM bvb ORDER BY {orderColumn} {orderType}";
                }

                OracleDataReader dataReader = command.ExecuteReader();

                while(dataReader.Read())
                {
                    var stock_id = dataReader.GetString(0);
                    var stock_name = dataReader.GetString(1);
                    var initial_ammount = dataReader.GetInt64(2);
                    var available_ammount = dataReader.GetInt64(3);
                    var current_value = dataReader.GetFloat(4);
                    var old_value = dataReader.GetFloat(5);

                    BvbStock s = new BvbStock(stock_id, stock_name, (ulong)initial_ammount, 
                        (ulong)available_ammount, current_value, old_value);

                    stocks.Add(s);
                }
            }
            catch
            {
                return null;
            }

            return stocks;
        }
        public static List<AccountStock> GetAccountStocks(uint clientId, bool countZero = false)
        {
            List<AccountStock> stocks = new List<AccountStock>();

            try
            {
                OracleCommand command = DBconnection.CreateCommand();

                command.CommandText =
                    "WITH stock_temp AS(" +
                    "SELECT client_id, stock_id, SUM(ammount) AS ammount " +
                    "FROM invest GROUP BY client_id, stock_id)" +
                    "SELECT stock_id, ammount " +
                    $"FROM stock_temp WHERE client_id = {clientId}";
                

                OracleDataReader dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    var stock_id = dataReader.GetString(0);
                    var ammount = dataReader.GetInt64(1);

                    if(countZero)
                    {
                        AccountStock s = new AccountStock(clientId, stock_id, (ulong)ammount);
                        stocks.Add(s);
                    }
                    else
                    {
                        if(ammount > 0)
                        {
                            AccountStock s = new AccountStock(clientId, stock_id, (ulong)ammount);
                            stocks.Add(s);
                        }
                    }
                }
            }
            catch
            {
                return null;
            }

            return stocks;
        }
        public static List<Invest> GetInvestmentsFromDatabase(uint clientId)
        {
            List<Invest> investList = new List<Invest>();

            try
            {
                OracleCommand command = DBconnection.CreateCommand();
                command.CommandText =
                    "SELECT invest_id, ammount, stock_id, TO_CHAR(aquisition_date, 'DD.MM.YYYY'), " +
                    "TO_CHAR(aquisition_date, 'HH:MM:SS'), aquisition_price " +
                    $"FROM invest WHERE client_id = {clientId} ORDER BY invest_id DESC ";

                OracleDataReader dataReader = command.ExecuteReader();

                while(dataReader.Read())
                {
                    var invest_id = dataReader.GetInt32(0);
                    var ammount = dataReader.GetInt32(1);
                    var stock_id = dataReader.GetString(2);
                    var invest_date = dataReader.GetString(3);
                    var invest_hour = dataReader.GetString(4);
                    var invest_price = dataReader.GetFloat(5);

                    Invest i = new Invest((uint)invest_id, stock_id, ammount, invest_date, invest_hour, invest_price);

                    investList.Add(i);
                }

                return investList;
            }
            catch
            {
                return null;
            }
            
        }

        public static BvbStock GetBvbStock(string stockId)
        {
            try
            {
                OracleCommand command = DBconnection.CreateCommand();
                command.CommandText = 
                    "SELECT stock_id, stock_name, initial_ammount, ammount_left, current_value, last_value " +
                    $"FROM bvb WHERE stock_id = '{stockId}'";

                OracleDataReader dataReader = command.ExecuteReader();

                while(dataReader.Read())
                {
                    var stock_id = dataReader.GetString(0);
                    var stock_name = dataReader.GetString(1);
                    var initial_ammount = dataReader.GetInt64(2);
                    var available_ammount = dataReader.GetInt64(3);
                    var current_value = dataReader.GetFloat(4);
                    var old_value = dataReader.GetFloat(5);

                    BvbStock s = new BvbStock(stock_id, stock_name, (ulong)initial_ammount,
                        (ulong)available_ammount, current_value, old_value);

                    return s;
                }
            }
            catch(OracleException)
            {
                return null;
            }
            return null;
        }
        public static ulong GetTotalOwnedStock(uint clientId, string stockId)
        {
            try
            {
                OracleCommand command = DBconnection.CreateCommand();
                command.CommandText = 
                    "SELECT SUM(ammount) FROM invest " +
                    $"WHERE client_id = {clientId} AND stock_id = '{stockId}' ";

                OracleDataReader dataReader = command.ExecuteReader();

                while(dataReader.Read())
                {
                    ulong rez = (ulong)dataReader.GetInt64(0);
                    return rez;
                }
            }
            catch
            {
                return 0;
            }
            return 0;
        }
        public static string GetMajorShareholderStock(string stockId)
        {
            try
            {
                OracleCommand command = DBconnection.CreateCommand();
                command.CommandText =
                    "WITH stock_temp AS( " +
                    "SELECT client_id, stock_id, SUM(ammount) AS ammount " +
                    "FROM invest " +
                    "GROUP BY client_id, stock_id) " +
                    "SELECT c.first_name || ' ' || c.last_name " +
                    "FROM stock_temp s, client c " +
                    $"WHERE s.ammount = (SELECT MAX(ammount) FROM stock_temp WHERE stock_id = '{stockId}') " +
                    $"AND s.stock_id = '{stockId}' AND s.client_id = c.client_id ";

                OracleDataReader dataReader = command.ExecuteReader();

                while(dataReader.Read())
                {
                    string name = dataReader.GetString(0);
                    return name;
                }
            }
            catch
            {
                return "";
            }
            return "";
        }

        public static float GetOwnedPercentStock(uint clientId, string stockId)
        {
            try
            {
                OracleCommand command = DBconnection.CreateCommand();
                command.CommandText =
                    "WITH stock_temp AS" +
                    "(SELECT client_id, stock_id, SUM(ammount) AS ammount " +
                    "FROM invest GROUP BY client_id, stock_id ) " +
                    "SELECT(s.ammount / b.initial_ammount * 100) " +
                    "FROM stock_temp s, client c, bvb b " +
                    "WHERE s.client_id = c.client_id AND b.stock_id = s.stock_id " +
                    $"AND c.client_id = {clientId} AND s.stock_id = '{stockId}'";

                OracleDataReader dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    float percent = dataReader.GetFloat(0);
                    return percent;
                }
            }
            catch
            {
                return 0f;
            }
            return 0f;
        }


        public static float GetTotalActions(uint clientId, string type)
        {
            try
            {
                OracleCommand command = DBconnection.CreateCommand();

                command.CommandText =
                    "SELECT SUM(transaction_cash) " +
                    "FROM transaction " +
                    $"WHERE client_id = {clientId} " +
                    $"AND transaction_details = '{type}' ";

                OracleDataReader dataReader = command.ExecuteReader();

                while(dataReader.Read())
                {
                    var total = dataReader.GetFloat(0);
                    return total;
                }
                return 0f;
            }
            catch
            {
                return 0f;
            }
        }
        public static float GetAveragePrice(uint clientId, string type, string stockId = "")
        {
            try
            {
                OracleCommand command = DBconnection.CreateCommand();

                if(type == "buy")
                {
                    if(stockId == "")
                        command.CommandText =
                            $"SELECT AVG(aquisition_price) FROM invest " +
                            $"WHERE client_id = {clientId} AND ammount > 0 ";
                    else
                        command.CommandText =
                            $"SELECT AVG(aquisition_price) FROM invest " +
                            $"WHERE client_id = 849230402 AND ammount > 0 AND stock_id = '{stockId}' ";
                }
                else if(type == "sell")
                {
                    if (stockId == "")
                        command.CommandText =
                            $"SELECT AVG(aquisition_price) FROM invest " +
                            $"WHERE client_id = {clientId} AND ammount < 0 ";
                    else
                        command.CommandText =
                            $"SELECT AVG(aquisition_price) FROM invest " +
                            $"WHERE client_id = 849230402 AND ammount < 0 AND stock_id = '{stockId}' ";
                }

                OracleDataReader dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    var price = dataReader.GetFloat(0);
                    return price;
                }
                return 0f;
            }
            catch
            {
                return 0f;
            }
        }
        public static long GetTotalSoldStocks(uint clientId, string stockId)
        {
            try
            {
                OracleCommand command = DBconnection.CreateCommand();

                command.CommandText =
                    $"SELECT -SUM(ammount) FROM invest " +
                    $"WHERE client_id = {clientId} " +
                    $"AND ammount < 0 " +
                    $"AND stock_id = {stockId} ";

                OracleDataReader dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    var total = dataReader.GetInt64(0);
                    return total;
                }
                return 0;
            }
            catch
            {
                return 0;
            }
        }

        public static Statistic GetStatistic(uint clientId, string stockId)
        {
            try
            {
                OracleCommand command = DBconnection.CreateCommand();

                command.CommandText =
                    $" WITH pret_mediu_achizitie AS( " +
                    $"  SELECT SUM(ammount * aquisition_price) / SUM(ammount) AS pret " +
                    $"  FROM invest WHERE stock_id = '{stockId}' " +
                    $"  AND client_id = {clientId} AND ammount > 0), " +
                    $"pret_mediu_vanzare AS( " +
                    $"  SELECT SUM(ammount* aquisition_price)/ SUM(ammount) AS pret " +
                    $"  FROM invest WHERE stock_id = '{stockId}' " +
                    $"  AND client_id = {clientId} AND ammount< 0), " +
                    $"actiuni_vandute AS( " +
                    $"  SELECT SUM(-ammount) AS numar " +
                    $"  FROM invest WHERE stock_id = '{stockId}' " +
                    $"  AND client_id = {clientId} AND ammount< 0) " +
                    $"" +
                    $"SELECT a.numar * pv.pret * (1 - a.commission) - a.numar * pa.pret, " +
                    $"a.numar * (pv.pret - pa.pret) * a.commission, " +
                    $"pv.pret, pa.pret, a.numar " +
                    $"FROM actiuni_vandute a, pret_mediu_achizitie pa, pret_mediu_vanzare pv, account a " +
                    $"WHERE a.client_id = {clientId} ";

                OracleDataReader dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    float profit = 0f;
                    float comm = 0f;
                    float buy = 0f;
                    float sell = 0f;
                    long sold = 0;

                    try
                    {
                        profit = dataReader.GetFloat(0);
                    }
                    catch { }
                    try
                    {
                        comm = dataReader.GetFloat(1);
                    }
                    catch { }
                    try
                    {
                        sell = dataReader.GetFloat(2);
                    }
                    catch { }
                    try
                    {
                        buy = dataReader.GetFloat(3);
                    }
                    catch { }
                    try
                    {
                        sold = dataReader.GetInt64(4);
                    }
                    catch { }

                    var rez = new Statistic(profit, comm, buy, sell, sold);

                    return rez;
                }
                return new Statistic(0f, 0f, 0f, 0f, 0);
            }
            catch
            {
                return new Statistic(0f, 0f, 0f, 0f, 0); ;
            }
        }

        public static bool UpdateBvbStock(string stockId, float newPrice)
        {
            OracleTransaction transaction = DBconnection.BeginTransaction(System.Data.IsolationLevel.ReadCommitted);
            try
            {
                OracleCommand command = DBconnection.CreateCommand();

                command.CommandText = 
                    $"UPDATE bvb SET last_value = current_value, " +
                    $"current_value = {newPrice.ToString("0.0000").Replace(",", ".")} " +
                    $"WHERE stock_id = '{stockId}' ";

                command.ExecuteNonQuery();

                transaction.Commit();

                return true;
            }
            catch
            {
                transaction.Rollback();
                return false;
            }
        }


    }
}
