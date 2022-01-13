using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockBankLibrary
{
    public class BvbStock
    {

        public string StockId { get; private set; }
        public string StockName { get; private set; }
        public ulong InitialAmmount { get; private set; }
        public ulong AvailableAmmount { get; private set; }
        public float CurrentPrice{ get; private set; }
        public float OldPrice{ get; private set; }

        public string Display
        {
            get
            {
                var change = 0f;
                if(CurrentPrice > OldPrice)
                {
                    change = ((CurrentPrice - OldPrice) / OldPrice) * 100f;
                }
                else if(OldPrice > CurrentPrice)
                {
                    change = -(((OldPrice - CurrentPrice) / CurrentPrice) * 100f);
                }

                if(change >= 0)
                {
                    return string.Format(" {0}\t     {1:N4}\t       +{2:N2}%", StockId, CurrentPrice, change);
                }
                return string.Format(" {0}\t     {1:N4}\t       {2:N2}%", StockId, CurrentPrice, change);
            }
        }

        public BvbStock(string id, string name, ulong initialAmmount, ulong availableAmmount, float currentPrice, float oldPrice)
        {
            StockId = id;
            StockName = name;
            InitialAmmount = initialAmmount;
            AvailableAmmount = availableAmmount;
            CurrentPrice = currentPrice;
            OldPrice = oldPrice;
        }



    }
}
