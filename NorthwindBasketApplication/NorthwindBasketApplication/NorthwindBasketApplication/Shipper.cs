using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthwindBasketApplication
{
    class Shipper
    {
        public int shipperID { get; set; }

        public string shipperName { get; set; }

        public override string ToString()
        {
            return shipperName;
        }
    }
}
