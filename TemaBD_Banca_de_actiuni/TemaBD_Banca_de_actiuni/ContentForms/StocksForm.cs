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
    public partial class StocksForm : Form
    {

        private List<AccountStock> accountStocks = new List<AccountStock>();
        private BindingSource accountStocksBinding = new BindingSource();

        private List<Invest> investStocks = new List<Invest>();
        private BindingSource investStocksBinding = new BindingSource();

        public StocksForm()
        {
            InitializeComponent();
        }



        public void UpdateData()
        {
            accountStocksBinding.DataSource = accountStocks;
            ownedStocksListBox.DataSource = accountStocksBinding;

            ownedStocksListBox.DisplayMember = "Display";
            ownedStocksListBox.ValueMember = "StockId";

            accountStocks = DataBase.GetAccountStocks(MainForm.Instance.account.ClientId);

            accountStocksBinding.ResetBindings(false);


            investStocksBinding.DataSource = investStocks;
            investmentHistoryListBox.DataSource = investStocksBinding;

            investmentHistoryListBox.DisplayMember = "Display";
            
            investmentHistoryListBox.ValueMember = "Display";

            investStocks = DataBase.GetInvestmentsFromDatabase(MainForm.Instance.account.ClientId);

            investStocksBinding.ResetBindings(false);

        }


        private void OnStocksSellButton(object sender, EventArgs e)
        {

        }

        private void OnStocksBuyButton(object sender, EventArgs e)
        {

        }

        private void OnSelectedStockChanged(object sender, EventArgs e)
        {
            UpdateStockDetails();
            UpdateStockDetails();

            UpdateData();
            UpdateData();
        }

        private void UpdateStockDetails()
        {
            AccountStock accountStock = (AccountStock)ownedStocksListBox.SelectedItem;

            BvbStock s = DataBase.GetBvbStock(accountStock.StockId);

            stockDetailsCodeLabel.Text = s.StockId;
            stockDetailsNameLabel.Text = s.StockName;
            stockDetailsAvailableLabel.Text = s.AvailableAmmount.ToString();
            stockDetailsTotalLabel.Text = s.InitialAmmount.ToString();
            stockDetailsCurrentPriceLabel.Text = s.CurrentPrice.ToString("N4");
            stockDetailsOldPriceLabel.Text = s.OldPrice.ToString("N4");

            string change = (((s.CurrentPrice / s.OldPrice) - 1f) * 100f).ToString("N4");
            change += " %";
            if (s.CurrentPrice / s.OldPrice >= 1f)
                change = change.Insert(0, "+ ");
            stockDetailsChangeLabel.Text = change;

            string majorShareholder = DataBase.GetMajorShareholderStock(s.StockId);
            stockDetailsMajorShareholderLabel.Text = majorShareholder;

            float ownedPercent = DataBase.GetOwnedPercentStock(MainForm.Instance.account.ClientId, s.StockId);
            if (ownedPercent != 0f)
                percentLabel.Text = ownedPercent.ToString("N6") + " %";
            else
                percentLabel.Text = "0,0 %";

            totalStocksOwnedLabel.Text = accountStock.Ammount.ToString("N0").Replace(".", " ");

        }



        private void UpdateHistoryDetails()
        {

            Invest i = (Invest)investmentHistoryListBox.SelectedItem;

            historyAmmount.Text = i.Ammount.ToString("N0").Replace(".", " ");
            historyDate.Text = i.InvestmentDate;
            historyHour.Text = i.InvestmentHour;
            historyPrice.Text = i.InvestmentStockPrice.ToString("N4");
            historyTicker.Text = i.InvestmentStock;

        }

        private void OnInvestmentHistoryChanged(object sender, EventArgs e)
        {
            UpdateHistoryDetails();
            UpdateHistoryDetails();

            UpdateData();
            UpdateData();
        }
    }
}
