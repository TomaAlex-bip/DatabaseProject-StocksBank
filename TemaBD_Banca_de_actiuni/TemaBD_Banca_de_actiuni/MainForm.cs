using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

using StockBankLibrary;
using StockBankLibrary.Source;
using TemaBD_Banca_de_actiuni.ContentForms;

namespace TemaBD_Banca_de_actiuni
{
    public partial class MainForm : Form
    {
        public static MainForm Instance { get; private set; }
        public bool LogedIn { get; private set; }

        public Account account { get; set; }


        public Form homeForm { get; private set; }
        public Form loginForm { get; private set; }
        public Form registerForm { get; private set; }
        public AccountForm accountForm { get; private set; }
        public TransactionsForm transactionsForm { get; private set; }
        public StocksForm stocksForm { get; private set; }
        public InvestForm investForm { get; private set; }
        public PerformanceForm performanceForm { get; private set; }

        private Form currentContentForm;

        private bool sideMenuOpen = false;


        private Thread updateBvbThread;
        

        public MainForm()
        {
            InitializeComponent();

            if(Instance == null)
            {
                Instance = this;
            }
            else
            {
                return;
            }

            Start();
        }



        private void Start ()
        {
            InitializeChildForms();

            DataBase.MakeDatabaseConnection();
            MessageBox.Show("Connected to database succesfully");

            account = new Account();


            LogOut();
            //sideMenuOpen = false;
            //sideMenuPanel.Size = new Size(0, sideMenuPanel.Size.Height);

            OpenContentForm(loginForm);

            headerLabel.Text = "Home";

            updateBvbThread = new Thread(UpdateBVB);
            updateBvbThread.Start();
        }




        private void UpdateBVB()
        {
            int updateSeconds = 30;

            Random rng = new Random();
            List<BvbStock> stocks = new List<BvbStock>();
            stocks = DataBase.GetBVBStocks("stock_id", "ASC");

            List<double> x = new List<double>();
            List<double> scale = new List<double>();
            List<float> priceModiffier = new List<float>();
            foreach(BvbStock s in stocks)
            {

                var xtemp = rng.NextDouble() * 1000;
                var scaletemp = rng.NextDouble() * 100;

                x.Add(xtemp);
                scale.Add(scaletemp);

                var noise = Perlin.OctavePerlin(xtemp/scaletemp, 0f, 0f, 2, 0.25) - 0.6f;


                priceModiffier.Add((float)(s.CurrentPrice / noise));
            }
            
            
            var sw = Stopwatch.StartNew();

            while(true)
            {
                //Thread.Sleep(10000);


                if((sw.ElapsedMilliseconds / 1000.0) <= updateSeconds)
                {
                    bvbUpdateLabel.Text = (updateSeconds - sw.ElapsedMilliseconds / 1000.0).ToString("N0");
                }

                if((sw.ElapsedMilliseconds /1000.0) >= updateSeconds)
                {
                    for (int i = 0; i < stocks.Count; i++)
                    {
                        var noise = Perlin.OctavePerlin(x[i] / scale[i], 0f, 0f, 2, 0.25) - 0.6f;

                        var newPrice = Math.Abs(noise * priceModiffier[i]);

                        while(newPrice > 999f)
                        {
                            newPrice /= 1.69f;
                        }

                        //Console.Write("i" +i+": "  + (newPrice).ToString("N4") + "   ");
                        Console.Write("i" +i+": "  + (float)newPrice + "   ");

                        DataBase.UpdateBvbStock(stocks[i].StockId, (float)newPrice);

                        x[i] += 1;
                    
                    }

                    //MessageBox.Show("Update BVB");
                    Console.Write("\n");

                    investForm.UpdateData();
                    investForm.UpdateData();

                    sw.Restart();

                }


            }
        }




        private void InitializeChildForms()
        {
            homeForm = new ContentForms.HomeForm();
            loginForm = new ContentForms.LoginForm();
            registerForm = new ContentForms.RegisterForm();
            accountForm = new ContentForms.AccountForm();
            transactionsForm = new ContentForms.TransactionsForm();
            stocksForm = new ContentForms.StocksForm();
            investForm = new ContentForms.InvestForm();
            performanceForm = new ContentForms.PerformanceForm();
        }




        public void LogIn()
        {
            accountForm.UpdateAccountDetails(account);
            transactionsForm.UpdateData(account.ClientId);
            investForm.UpdateData();
            stocksForm.UpdateData();
            performanceForm.UpdateData();

            LogedIn = true;
            sideMenuAccountButton.Enabled = true;
            sideMenuInvestButton.Enabled = true;
            sideMenuSettingsButton.Enabled = true;
            sideMenuStocksButton.Enabled = true;
            sideMenuTransactionsButton.Enabled = true;
        }


        public void LogOut()
        {
            LogedIn = false;
            sideMenuAccountButton.Enabled = false;
            sideMenuInvestButton.Enabled = false;
            sideMenuSettingsButton.Enabled = false;
            sideMenuStocksButton.Enabled = false;
            sideMenuTransactionsButton.Enabled = false;
        }

        private void SwitchSideMenu()
        {
            sideMenuOpen = !sideMenuOpen;

            if (sideMenuOpen)
            {
                //open the side menu
               // sideMenuPanel.Size = new Size(200, sideMenuPanel.Size.Height);

            }
            else
            {
                //close the side menu
                //sideMenuPanel.Size = new Size(0, sideMenuPanel.Size.Height);
            }
        }


        public void OpenContentForm(Form contentForm)
        {
            if (contentForm == currentContentForm)
            {
                return;
            }
            currentContentForm = contentForm;
            currentContentForm.TopLevel = false;
            currentContentForm.FormBorderStyle = FormBorderStyle.None;
            currentContentForm.Dock = DockStyle.Fill;

            contentPanel.Controls.Add(currentContentForm);
            contentPanel.Tag = currentContentForm;

            currentContentForm.BringToFront();
            currentContentForm.Show();

        }


        private void ChangeHeaderTitle(Button sender)
        {
            headerLabel.Text = sender.Text;
        }





        private void OnSideMenuClick(object sender, EventArgs e)
        {
            SwitchSideMenu();
        }

        private void OnSideMenuHomeClick(object sender, EventArgs e)
        {
            // sideMenuOpen = false;
            // sideMenuPanel.Size = new Size(0, sideMenuPanel.Size.Height);

            SwitchSideMenu();

            if(LogedIn)
            {
                OpenContentForm(homeForm);
            }
            else
            {
                OpenContentForm(loginForm);
            }


            ChangeHeaderTitle((Button)sender);

        }

        private void OnSideMenuAccountClick(object sender, EventArgs e)
        {
            SwitchSideMenu();

            OpenContentForm(accountForm);

            ChangeHeaderTitle((Button)sender);

            var updatedAccount = DataBase.GetClientInfoFromDatabase((int)account.ClientId);
            accountForm.UpdateAccountDetails(updatedAccount);
        }

        private void OnSideMenuTransactionsClick(object sender, EventArgs e)
        {
            SwitchSideMenu();

            OpenContentForm(transactionsForm);

            ChangeHeaderTitle((Button)sender);

            transactionsForm.UpdateData(account.ClientId);
        }

        private void OnSideMenuStocksClick(object sender, EventArgs e)
        {
            SwitchSideMenu();

            OpenContentForm(stocksForm);

            ChangeHeaderTitle((Button)sender);

            stocksForm.UpdateData();
            stocksForm.UpdateData();
        }

        private void OnSideMenuInvestClick(object sender, EventArgs e)
        {
            SwitchSideMenu();

            OpenContentForm(investForm);

            ChangeHeaderTitle((Button)sender);

            investForm.UpdateData();
        }

        private void OnSideMenuPerformanceClick(object sender, EventArgs e)
        {
            SwitchSideMenu();

            OpenContentForm(performanceForm);

            ChangeHeaderTitle((Button)sender);

            performanceForm.UpdateData();
            performanceForm.UpdateData();
        }

        private void OnFormClosing(object sender, FormClosingEventArgs e)
        {
            updateBvbThread.Abort();

            DataBase.DisconnectFromDatabase();

            MessageBox.Show("Good Bye!");

        }
    }
}
