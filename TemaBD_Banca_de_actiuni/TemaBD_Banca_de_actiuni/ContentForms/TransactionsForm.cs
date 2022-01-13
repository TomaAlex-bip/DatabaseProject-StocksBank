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
    public partial class TransactionsForm : Form
    {

        private const float maxDepositValue = 10000000.0f;
        private const float maxWithdrawValue = 10000000.0f;
        private const float maxTransferValue = 1000000.0f;


        private List<Transaction> transactionsList = new List<Transaction>();

        private BindingSource transactionsBinding = new BindingSource();

        public TransactionsForm()
        {
            InitializeComponent();

        }


        public void UpdateData(uint clientId)
        {
            transactionsBinding.DataSource = transactionsList;
            transactionsHistoryListBox.DataSource = transactionsBinding;
            
            transactionsHistoryListBox.DisplayMember = "Display";
            transactionsHistoryListBox.ValueMember = "TransactionId";

            transactionsList = DataBase.GetClientTransactons(clientId);

            transactionsBinding.ResetBindings(false);
        }

        private void OnDepositButtonClick(object sender, EventArgs e)
        {
            float ammount = (float)depositNumeric.Value;
            if (ammount == 0.0f)
            {
                MessageBox.Show("Cannot deposit 0 ron!");
                return;
            }
            if(ammount > maxDepositValue)
            {
                ammount = maxDepositValue;
                depositNumeric.Value = (decimal)ammount;
                MessageBox.Show($"Cannot deposit more than {maxDepositValue.ToString("N2")} ron!");
                return;
            }

            uint clientId = MainForm.Instance.account.ClientId;
            
            var operation = DataBase.MakeDatabaseTransaction(clientId, "deposit", ammount);

            if(operation == "success")
            {
                MessageBox.Show($"Successfully deposited {ammount.ToString("N2")} ron.");
                //depositNumeric.Value = 0;
            }
            else
            {
                MessageBox.Show("Error while trying to deposit!\n" + operation);
                return;
            }

            MainForm.Instance.account.Balance = DataBase.GetClientInfoFromDatabase((int)clientId).Balance;
            MainForm.Instance.accountForm.UpdateAccountDetails(MainForm.Instance.account);
            
            // din motive, nu inteleg de ce, daca apelez doar o data nu merge
            UpdateData(clientId);
            UpdateData(clientId);


        }

        private void OnWithdrawButtonClick(object sender, EventArgs e)
        {
            float ammount = (float)withdrawNumeric.Value;
            if (ammount == 0.0f)
            {
                MessageBox.Show("Cannot withdraw 0 ron!");
                return;
            }
            if (ammount > maxWithdrawValue)
            {
                ammount = maxWithdrawValue;
                withdrawNumeric.Value = (decimal)ammount;
                MessageBox.Show($"Cannot withdraw more than {maxWithdrawValue.ToString("N2")} ron!");
                return;
            }

            uint clientId = MainForm.Instance.account.ClientId;

            var operation = DataBase.MakeDatabaseTransaction(clientId, "withdraw", ammount);
            operation = operation.ToLower();

            if (operation == "success")
            {
                MessageBox.Show($"Successfully withdrawn {ammount.ToString("N2")} ron.");
                //withdrawNumeric.Value = 0;
            }
            else if(operation.Contains("account_balance_ck"))
            {
                MessageBox.Show("Error while trying to withdraw!\nNot enough balance!");
                return;
            }
            else
            {
                MessageBox.Show("Error\n" + operation);
                return;
            }

            MainForm.Instance.account.Balance = DataBase.GetClientInfoFromDatabase((int)clientId).Balance;
            MainForm.Instance.accountForm.UpdateAccountDetails(MainForm.Instance.account);

            // din motive, nu inteleg de ce, daca apelez doar o data nu merge
            UpdateData(clientId);
            UpdateData(clientId);
        }

        private void OnTransferButtonClick(object sender, EventArgs e)
        {
            float ammount = (float)transferNumeric.Value;
            if(ammount == 0.0f)
            {
                MessageBox.Show("Cannot transfer 0 ron!");
                return;
            }
            if (ammount > maxTransferValue)
            {
                ammount = maxTransferValue;
                transferNumeric.Value = (decimal)ammount;
                MessageBox.Show($"Cannot transfer more than {maxTransferValue.ToString("N2")} ron!");
                return;
            }

            string transferIban = transferIbanTextbox.Text;
            uint clientId = MainForm.Instance.account.ClientId;
            float commission = MainForm.Instance.account.Commission;

            var operation = DataBase.MakeDatabaseTransaction(clientId, "transfer", ammount, transferIban, commission);

            if (operation == "success")
            {
                MessageBox.Show($"Successfully transfered {ammount.ToString("N2")} ron to {transferIban}.");
                //transferIbanTextbox.Text = "";
                //transferNumeric.Value = 0;
            }
            else if(operation == "invalid_iban")
            {
                MessageBox.Show($"IBAN: {transferIban} nonexistent!\nMake sure you wrote it properly!");
            }
            else
            {
                MessageBox.Show("Error while trying to transfer!\n" + operation);
                return;
            }

            MainForm.Instance.account.Balance = DataBase.GetClientInfoFromDatabase((int)clientId).Balance;
            MainForm.Instance.accountForm.UpdateAccountDetails(MainForm.Instance.account);

            // din motive, nu inteleg de ce, daca apelez doar o data nu merge
            UpdateData(clientId);
            UpdateData(clientId);
        }

        private void OnRefreshButton(object sender, EventArgs e)
        {
            UpdateData(MainForm.Instance.account.ClientId);
        }

        private void OnTransactionSelect(object sender, EventArgs e)
        {
            Transaction selectedTransaction = (Transaction)transactionsHistoryListBox.SelectedItem;

            transactionIdLabel.Text = selectedTransaction.TransactionId.ToString().PadLeft(9, '0');
            transactionDetailsLabel.Text = selectedTransaction.TransactionDetails;
            transactionDateLabel.Text = selectedTransaction.TransactionDate;
            transactionHourLabel.Text = selectedTransaction.TransactionHour;
            transactionCashLabel.Text = selectedTransaction.TransactionCash.ToString("N2").Replace(".", " ").Replace(",", ".");
            transactionIbanLabel.Text = selectedTransaction.TransactionIban;
        }
    }
}
