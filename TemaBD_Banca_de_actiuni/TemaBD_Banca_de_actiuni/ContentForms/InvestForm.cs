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
    public partial class InvestForm : Form
    {

        private List<BvbStock> stocksList = new List<BvbStock>();

        private BindingSource stocksBinding = new BindingSource();



        private bool tickerSortAsc = false;
        private bool priceSortAsc = false;
        private bool changeSortAsc = false;


        public InvestForm()
        {
            InitializeComponent();
        }


        public void UpdateData(string orderColumn = "", string orderType = "")
        {
            stocksBinding.DataSource = stocksList;
            availableStocksListBox.DataSource = stocksBinding;

            availableStocksListBox.DisplayMember = "Display";
            availableStocksListBox.ValueMember = "StockId";

            if (orderColumn == "")
                stocksList = DataBase.GetBVBStocks();
            else
                stocksList = DataBase.GetBVBStocks(orderColumn, orderType);
            
            stocksBinding.ResetBindings(false);
        }

        private void OnSortByTickerButton(object sender, EventArgs e)
        {
            tickerSortAsc = !tickerSortAsc;
            if(tickerSortAsc)
            {
                UpdateData("stock_id", "ASC");
                UpdateData("stock_id", "ASC");
            }
            else
            {
                UpdateData("stock_id", "DESC");
                UpdateData("stock_id", "DESC");
            }
            priceSortAsc = false;
            changeSortAsc = false;
        }
        private void OnSortByPriceButton(object sender, EventArgs e)
        {
            priceSortAsc = !priceSortAsc;
            if (priceSortAsc)
            {
                UpdateData("current_value", "ASC");
                UpdateData("current_value", "ASC");
            }
            else
            {
                UpdateData("current_value", "DESC");
                UpdateData("current_value", "DESC");
            }
            tickerSortAsc = false;
            changeSortAsc = false;
        }
        private void OnSortByChangeButton(object sender, EventArgs e)
        {
            changeSortAsc = !changeSortAsc;
            if (changeSortAsc)
            {
                UpdateData("current_value/last_value", "ASC");
                UpdateData("current_value/last_value", "ASC");
            }
            else
            {
                UpdateData("current_value/last_value", "DESC");
                UpdateData("current_value/last_value", "DESC");
            }
            tickerSortAsc = false;
            priceSortAsc = false;
        }

        private void OnSelectedStockChange(object sender, EventArgs e)
        {

            UpdateStockDetails();

        }

        private void UpdateStockDetails()
        {
            BvbStock s = (BvbStock)availableStocksListBox.SelectedItem;

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
            if(ownedPercent != 0f)
                percentLabel.Text = ownedPercent.ToString("N6") + " %";
            else
                percentLabel.Text = "0,0 %";

        }

        private void OnStockSellButton(object sender, EventArgs e)
        {
            var selectedStock = (BvbStock)availableStocksListBox.SelectedItem;
            var stock = DataBase.GetBvbStock(selectedStock.StockId);
            int sellAmmount = (int)stockActionsSellNumeric.Value;
            float sellPrice = sellAmmount * stock.CurrentPrice;
            float commission = sellAmmount * stock.CurrentPrice * MainForm.Instance.account.Commission;
            float totalPrice = sellPrice - commission;

            if (sellAmmount == 0)
            {
                MessageBox.Show("Sell ammount can't be 0!");
                return;
            }

            ulong ownAmmount = DataBase.GetTotalOwnedStock(MainForm.Instance.account.ClientId, selectedStock.StockId);

            if( (ulong)sellAmmount > ownAmmount)
            {
                MessageBox.Show($"You don't have {sellAmmount} stocks at {selectedStock.StockId}!\n" +
                    $"Your stocks at {selectedStock.StockId} = {ownAmmount}.");
                return;
            }

            var res = MessageBox.Show($"Sell {sellAmmount.ToString("N0")} stocks at {stock.StockId} - {stock.StockName} ?" +
                $"\nYou will get {totalPrice.ToString("N2")} RON ({sellPrice.ToString("N2")} - {commission.ToString("N2")} commission)",
                "STONKS", MessageBoxButtons.YesNo);

            switch (res)
            {
                case DialogResult.Yes:

                    var operation = DataBase.MakeAnInvestment(MainForm.Instance.account.ClientId, stock.StockId, -sellAmmount);

                    if (operation == "success")
                    {
                        MessageBox.Show($"Succesfully sold {sellAmmount.ToString("N0")} stocks at {stock.StockId} - {stock.StockName}");
                        UpdateData();
                        UpdateData();
                        UpdateStockDetails();
                    }
                    else if (operation.Contains("account_balance_ck")) // TODO change
                    {
                        MessageBox.Show("You don't have enough money!");
                    }
                    else if (operation.Contains("bvb_ammount_left_ck")) // TODO change
                    {
                        MessageBox.Show("Not enough stocks to buy!");
                    }
                    else
                    {
                        MessageBox.Show(operation);
                    }



                    break;

                case DialogResult.No:
                    //MessageBox.Show("Ai scapat!");
                    break;
            }
        }
        private void OnStockBuyButton(object sender, EventArgs e)
        {
            var selectedStock = (BvbStock)availableStocksListBox.SelectedItem;
            var stock = DataBase.GetBvbStock(selectedStock.StockId);
            int buyAmmount = (int)stockActionsBuyNumeric.Value;
            float payPrice = buyAmmount * stock.CurrentPrice;

            if (buyAmmount == 0)
            {
                MessageBox.Show("Buy ammount can't be 0!");
                return;
            }

            var res = MessageBox.Show($"Buy {buyAmmount.ToString("N0")} stocks at {stock.StockId} - {stock.StockName} ?" +
                $"\nYou will pay {payPrice.ToString("N2")} RON.\n",
                "STONKS", MessageBoxButtons.YesNo);

            switch (res)
            {
                case DialogResult.Yes:

                    var operation = DataBase.MakeAnInvestment(MainForm.Instance.account.ClientId, stock.StockId, buyAmmount);

                    if(operation == "success")
                    {
                        MessageBox.Show($"Succesfully aquisitioned {buyAmmount.ToString("N0")} stocks at {stock.StockId} - {stock.StockName}");
                        UpdateData();
                        UpdateData();
                        UpdateStockDetails();
                    }
                    else if(operation.Contains("account_balance_ck"))
                    {
                        MessageBox.Show("You don't have enough money!");
                    }
                    else if(operation.Contains("bvb_ammount_left_ck"))
                    {
                        MessageBox.Show("Not enough stocks to buy!");
                    }
                    else
                    {
                        MessageBox.Show(operation);
                    }

                        

                    break;

                case DialogResult.No:
                    //MessageBox.Show("Ai scapat!");
                    break;
            }

        }
    }
}
