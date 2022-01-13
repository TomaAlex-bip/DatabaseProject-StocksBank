using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockBankLibrary
{
    public class Account
    {
        public uint ClientId { get => clientId; set => clientId = value; }
        public string Iban { get => iban; set => iban = value; }
        public float Balance { get => balance; set => balance = value; }
        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public float Commission { get => commission; private set => commission = value; }
        public Client ClientProp { get => client; set => client = value; }

        private uint clientId;

        private string iban;

        private float balance;
        private float commission;

        private string username;
        private string password;

        private Client client;

        public Account()
        {
            balance = 0.0f;
            commission = 0.02f;
            client = new Client();
        }

        public void InitializeAccount(string username, string password, int clientId, string generatedIban, 
                                      float balance, float commission,
                                      string lastName, string firstName, string cnp, string birthDate, 
                                      string gender, string city, string address, string phone, string email)
        {
            ClientProp.LastName = lastName;
            ClientProp.FirstName = firstName;
            ClientProp.Cnp = cnp;
            ClientProp.ClientDetailsProp.BirthDate = birthDate;
            ClientProp.ClientDetailsProp.Genre = gender[0];
            ClientProp.ClientDetailsProp.City = city;
            ClientProp.ClientDetailsProp.Address = address;
            ClientProp.ClientDetailsProp.Phone = phone;
            if (email != "") ClientProp.ClientDetailsProp.Email = email;

            Username = username;
            Password = password;
            ClientId = (uint)clientId;
            Iban = generatedIban;

            Balance = balance;
            Commission = commission;
        }

        public void InitializeAccount(Account acc)
        {
            ClientProp.LastName = acc.ClientProp.LastName;
            ClientProp.FirstName = acc.ClientProp.FirstName; ;
            ClientProp.Cnp = acc.ClientProp.Cnp; ;
            ClientProp.ClientDetailsProp.BirthDate = acc.ClientProp.ClientDetailsProp.BirthDate;
            ClientProp.ClientDetailsProp.Genre = acc.ClientProp.ClientDetailsProp.Genre;
            ClientProp.ClientDetailsProp.City = acc.ClientProp.ClientDetailsProp.City;
            ClientProp.ClientDetailsProp.Address = acc.ClientProp.ClientDetailsProp.Address;
            ClientProp.ClientDetailsProp.Phone = acc.ClientProp.ClientDetailsProp.Phone;
            ClientProp.ClientDetailsProp.Email = acc.ClientProp.ClientDetailsProp.Email;

            Username = acc.Username;
            Password = acc.Password;
            ClientId = acc.ClientId;
            Iban = acc.Iban;

            balance = acc.Balance;
            commission = acc.Commission;
        }


    }
}
