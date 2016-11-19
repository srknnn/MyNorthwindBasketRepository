using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthwindBasketApplication
{
    class Customer
    {
        public string CustomerID { get; set; }

        public string CompanyName { get; set; }

        public override string ToString()
        {
            return CompanyName ;
        }
    }
}
