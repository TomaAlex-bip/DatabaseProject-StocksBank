using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockBankLibrary
{
    public class Transaction
    {

        public uint TransactionId { get; set; }
        public string TransactionDetails { get; set; }
        public string TransactionDate { get; set; }
        public string TransactionHour { get; set; }
        public float TransactionCash { get; set; }
        public string TransactionIban { get; set; }


        public Transaction(uint id, string details, string date, string hour, float cash, string iban)
        {
            TransactionId = id;
            TransactionDetails = details;
            TransactionDate = date;
            TransactionHour = hour;
            TransactionCash = cash;
            TransactionIban = iban;
        }

        public string Display
        {
            get
            {
                return "ID: " + TransactionId.ToString().PadLeft(9, '0') + "\tDETAILS: " + TransactionDetails;
            }
        }

        

    }
}
