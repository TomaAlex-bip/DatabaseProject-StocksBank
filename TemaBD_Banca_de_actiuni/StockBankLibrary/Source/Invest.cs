using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockBankLibrary
{
    public class Invest
    {

        public uint InvestId { get; private set; }
        public string InvestmentStock { get; private set; }
        public int Ammount { get; private set; }
        public string InvestmentDate { get; private set; }
        public string InvestmentHour { get; private set; }
        public float InvestmentStockPrice { get; private set; }

        public string Display
        {
            get
            {
                return "ID: " + InvestId.ToString().PadLeft(9, '0') + "\tDETAILS: " 
                    + InvestmentStock + "\t(" + Ammount.ToString("N0").Replace(".", " ") + ") ";
            }
        }

        public Invest(uint id, string stockId, int ammount, string date, string hour, float price)
        {
            InvestId = id;
            InvestmentStock = stockId;
            Ammount = ammount;
            InvestmentDate = date;
            InvestmentHour = hour;
            InvestmentStockPrice = price;
        }


    }
}
