using StockBankLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TemaBD_Banca_de_actiuni.ContentForms
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void OnLoginClick(object sender, EventArgs e)
        {
            // TODO:
            // verify that the fields are completed correctly

            var loginUsername = loginUsernameTextBox.Text;
            var loginPassword = loginPasswordTextBox.Text;

            var foundClientId = DataBase.LogInToDatabase(loginUsername, loginPassword);

            if(foundClientId == -1)
            {
                MessageBox.Show("Error while trying to login.");
                return;
            }

            if (foundClientId == 0)
            {
                MessageBox.Show("Username or Password incorrect!");
                return;
            }


            Account loginAccount = DataBase.GetClientInfoFromDatabase(foundClientId);

            if(loginAccount == null)
            {
                MessageBox.Show("Error at database client search!\nTry again!");
                return;
            }

            MainForm.Instance.account = new Account();

            MainForm.Instance.account.InitializeAccount(loginAccount);

            //MessageBox.Show(loginAccount.ToString());
            //MessageBox.Show(MainForm.Instance.account.ToString());

            MainForm.Instance.OpenContentForm(new ContentForms.HomeForm());
            MainForm.Instance.LogIn();
        }

        private void OnRegisterClick(object sender, EventArgs e)
        {
            MainForm.Instance.OpenContentForm(new ContentForms.RegisterForm());
        }
    }
}
