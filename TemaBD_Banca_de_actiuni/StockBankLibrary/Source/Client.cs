using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockBankLibrary
{
    public class Client
    {
        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string Cnp { get => cnp; set => cnp = value; }
        public ClientDetails ClientDetailsProp { get => clientDetails; set => clientDetails = value; }


        private string firstName;
        private string lastName;
        private string cnp;

        private ClientDetails clientDetails;

        public Client()
        {
            clientDetails = new ClientDetails();
        }
    }
}
