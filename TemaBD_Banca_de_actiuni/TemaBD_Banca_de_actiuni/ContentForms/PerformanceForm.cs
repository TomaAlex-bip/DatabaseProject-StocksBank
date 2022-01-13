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
    public partial class PerformanceForm : Form
    {
        public PerformanceForm()
        {
            InitializeComponent();
        }

        List<AccountStock> stocksList = new List<AccountStock>();

        BindingSource stocksBinding = new BindingSource();

        

        private void UpdatePerformanceDetails(string stockId)
        {
            var clientId = MainForm.Instance.account.ClientId;

            var stat = DataBase.GetStatistic(clientId, stockId);

            if (stat == null)
                return;

            averageBuyPrice.Text = stat.AverageBuyPrice.ToString("N4") + " RON";
            averageSellPrice.Text = stat.AverageSellPrice.ToString("N4") + " RON";
            totalStocksSold.Text = stat.TotalSold.ToString("N0").Replace(".", " ");
            profitLabel.Text = stat.Profit.ToString("N2") + " RON";
            commissionLabel.Text = stat.Commission.ToString("N2") + " RON";

        }

        public void UpdateData()
        {
            var clientId = MainForm.Instance.account.ClientId;

            stocksBinding.DataSource = stocksList;
            stockComboBox.DataSource = stocksBinding;

            stockComboBox.DisplayMember = "DisplaySimple";
            stockComboBox.ValueMember = "StockId";

            stocksList = DataBase.GetAccountStocks(clientId, true);

            stocksBinding.ResetBindings(false);

            totalDeposits.Text = DataBase.GetTotalActions(clientId, "deposit").ToString("N2").Replace(".", " ") + " RON";
            totalWithdraws.Text = DataBase.GetTotalActions(clientId, "withdraw").ToString("N2").Replace(".", " ") + " RON";
            totalTransfers.Text = DataBase.GetTotalActions(clientId, "transfer").ToString("N2").Replace(".", " ") + " RON";

        }

        private void OnPerformaceStockSelected(object sender, EventArgs e)
        {
            var i = (AccountStock)stockComboBox.SelectedItem;
            var stockId = i.StockId;

            UpdatePerformanceDetails(stockId);
        }
    }
}
