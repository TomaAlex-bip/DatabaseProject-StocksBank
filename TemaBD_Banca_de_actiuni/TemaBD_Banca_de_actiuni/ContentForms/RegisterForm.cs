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
    public partial class RegisterForm : Form
    {

        MainForm mainForm;

        public RegisterForm()
        {
            InitializeComponent();

            mainForm = MainForm.Instance;

        }

        private void OnRegisterClick(object sender, EventArgs e)
        {
            string lastName = lastNameTextBox.Text;
            string firstName = firstNameTextBox.Text;
            string birthDate = birthDateTimePicker.Text;
            string cnp = CnpTextBox.Text;
            string gender = genderComboBox.Text;
            string city = cityTextBox.Text;
            string address = addressTextBox.Text;
            string phone = phoneTextBox.Text;
            string email = emailTextBox.Text;
            string username = usernameTextBox.Text;
            string password = passwordTextBox.Text;
            string repeatPassword = repeatPasswordTextBox.Text;

            const char separator = ',';
            birthDate = birthDate.Split(separator)[1];
            birthDate = birthDate.Replace(" ", ".");
            birthDate = birthDate.Substring(1);

            /*
            int lastClientId = DataBase.GetLastClientId();

            if(lastClientId == -1)
            {
                MessageBox.Show("Error while trying to register!\n Client ID invalid!");
                return;
            }
            */

            int generatedClientId = new Random().Next(1, 999999999);
            if (DataBase.CheckForExistingClientId(generatedClientId) == -1)
            {
                MessageBox.Show($"Error while generating client ID");
                return;
            }
            while (DataBase.CheckForExistingClientId(generatedClientId) != 0)
            {
                generatedClientId = new Random().Next(1, 999999999);
            }



            if (gender == "")
            {
                MessageBox.Show("Please select you gender!");
                return;
            }
            
            if(password != repeatPassword)
            {
                MessageBox.Show("Passwords are not the same!");
                return;
            }

            string generatedIban = "RO" + new Random().Next(1, 99999999).ToString().PadLeft(8, '0');
            if(DataBase.CheckForExistingIban(generatedIban) == -1)
            {
                MessageBox.Show($"Error while generating IBAN");
                return;
            }
            while (DataBase.CheckForExistingIban(generatedIban) != 0)
            {
                generatedIban = "RO" + new Random().Next(1, 99999999).ToString().PadLeft(8, '0');
            }

            mainForm.account.InitializeAccount(username, password, generatedClientId, generatedIban,
                                               0f, 0.02f,
                                               lastName, firstName, cnp, birthDate, gender, 
                                               city, address, phone, email);


            var operation = DataBase.InsertNewClientAccount(mainForm.account);
            if (operation == "success")
            {
                MessageBox.Show("Registered succesfully");
                mainForm.account = null;
                mainForm.OpenContentForm(new ContentForms.LoginForm());
            }
            else
            {
                operation = operation.ToLower();
                if(operation.Contains("client_first_name_ck"))
                {
                    MessageBox.Show("Please provide a valid first name!");
                }
                else if (operation.Contains("client_last_name_ck"))
                {
                    MessageBox.Show("Please provide a valid last name!");
                }
                else if (operation.Contains("client_cnp_ck"))
                {
                    MessageBox.Show("Please provide a valid CNP!\n" +
                        "The format is 13 digits, make sure there are no other characters.");
                }
                else if (operation.Contains("valoarea este prea mare pentru coloana")
                    && operation.Contains("cnp"))
                {
                    MessageBox.Show("Please provide a valid CNP!\n" +
                        "The format is 13 digits, make sure there are no other characters.");
                }
                else if (operation.Contains("cnp_uk"))
                {
                    MessageBox.Show("Please provide a valid CNP!\n" +
                        "There is already an account with this CNP.");
                }
                else if (operation.Contains("client_details_phone_ck"))
                {
                    MessageBox.Show("Please provide a valid phone number!\n" +
                        "The format is 10 digits, starting with 0. Make sure there are no other characters.");
                }
                else if (operation.Contains("valoarea este prea mare pentru coloana")
                    && operation.Contains("phone"))
                {
                    MessageBox.Show("Please provide a valid phone number!\n" +
                        "The format is 10 digits, starting with 0. Make sure there are no other characters.");
                }
                else if (operation.Contains("client_details_email_ck"))
                {
                    MessageBox.Show("Please provide a valid email address!\n" +
                        "The format is xxxxx@xxxxx.com");
                }
                else if (operation.Contains("client_details_phone_uk"))
                {
                    MessageBox.Show("Please provide a valid phone number!\n" +
                        "There is already an account with this phone number.");
                }
                else if (operation.Contains("client_details_email_uk"))
                {
                    MessageBox.Show("Please provide a valid email address!\n" +
                        "There is already an account with this email address.");
                }
                else if (operation.Contains("username_uk"))
                {
                    MessageBox.Show("Please provide a valid username!\n" +
                        "There is already an account with this username.");
                }
                else if (operation.Contains("null"))
                {
                    MessageBox.Show("Please complete all the required fields(*)");
                }
                else
                {
                    MessageBox.Show("Cannot register:\n" + operation);
                }
            }

            
        }

        private void OnLoginClick(object sender, EventArgs e)
        {
            mainForm.OpenContentForm(new ContentForms.LoginForm());
        }
    }
}
