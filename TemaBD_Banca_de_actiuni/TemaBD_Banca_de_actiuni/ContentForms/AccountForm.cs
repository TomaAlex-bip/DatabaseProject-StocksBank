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
    public partial class AccountForm : Form
    {
        public AccountForm()
        {
            InitializeComponent();
        }

        private Account tempAccount;

        private bool visiblePassword = false;

        public void UpdateAccountDetails(Account account)
        {
            tempAccount = account;
            clientIdLabel.Text = account.ClientId.ToString().PadLeft(9, '0');
            ibanLabel.Text = account.Iban;
            usernameLabel.Text = account.Username;
            passwordLabel.Text = "**********";

            balanceLabel.Text = account.Balance.ToString("N2").Replace(".", " ");
            commissionLabel.Text = (account.Commission * 100).ToString() + "%";

            firstNameLabel.Text = account.ClientProp.FirstName;
            lastNameLabel.Text = account.ClientProp.LastName;
            cnpLabel.Text = account.ClientProp.Cnp;
            birthDateLabel.Text = account.ClientProp.ClientDetailsProp.BirthDate;
            genderLabel.Text = account.ClientProp.ClientDetailsProp.Genre + "";
            cityLabel.Text = account.ClientProp.ClientDetailsProp.City;
            addressLabel.Text = account.ClientProp.ClientDetailsProp.Address;
            phoneLabel.Text = account.ClientProp.ClientDetailsProp.Phone;
            
            emailLabel.Text = account.ClientProp.ClientDetailsProp.Email;

            if(addressLabel.Text.Length >= 45)
                addressLabel.Text = addressLabel.Text.Insert(40, "\n");
        }

        private void OnShowPasswordClick(object sender, EventArgs e)
        {
            SwitchPasswordVisibility();
        }

        private void SwitchPasswordVisibility()
        {
            visiblePassword = !visiblePassword;
            if(visiblePassword)
            {
                showPasswordButton.Text = "hide password";
                passwordLabel.Text = tempAccount.Password;
            }
            else
            {
                showPasswordButton.Text = "show password";
                passwordLabel.Text = "**********";
            }
        }

    }
}
