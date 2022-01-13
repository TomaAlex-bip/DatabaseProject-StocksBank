using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockBankLibrary.Source
{
    public class Statistic
    {

        public float Profit { get; private set; }
        public float Commission { get; private set; }
        public float AverageBuyPrice { get; private set; }
        public float AverageSellPrice { get; private set; }
        public long TotalSold { get; private set; }


        public Statistic(float profit, float comm, float avgBuy, float avgSell, long sold)
        {
            Profit = profit;
            Commission = comm;
            AverageBuyPrice = avgBuy;
            AverageSellPrice = avgSell;
            TotalSold = sold;
        }


    }
}
