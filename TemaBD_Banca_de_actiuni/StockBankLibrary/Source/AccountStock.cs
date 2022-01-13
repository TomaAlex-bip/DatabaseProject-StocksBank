using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockBankLibrary
{
    public class AccountStock
    {

        public uint ClientId { get; private set; }
        public string StockId {get; private set;}
        public ulong Ammount { get; private set; }
        public string Display 
        {
            get
            {
                return string.Format(" {0}\t  -   {1}", StockId, Ammount.ToString("N0").Replace(".", " "));
            }
        }

        public string DisplaySimple { get => StockId; }

        public AccountStock(uint clientId, string stockId, ulong ammount)
        {
            ClientId = clientId;
            StockId = stockId;
            Ammount = ammount;
        }

    }
}
