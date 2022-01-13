using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockBankLibrary
{
    public class ClientDetails
    {
        public string BirthDate { get => birthDate; set => birthDate = value; }
        public char Genre { get => genre; set => genre = value; }
        public string City { get => city; set => city = value; }
        public string Address { get => address; set => address = value; }
        public string Phone { get => phone; set => phone = value; }
        public string Email { get => email; set => email = value; }

        private string birthDate;
        private char genre;
        private string city;
        private string address;
        private string phone;
        private string email;

        public ClientDetails()
        {
            email = null;
        }

    }
}
