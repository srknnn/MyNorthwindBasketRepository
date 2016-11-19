﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthwindBasketApplication
{
    class Product
    {
        public int ProductID { get; set;}

        public string ProductName { get; set; }

        public int UnitsInStock { get; set; }

        public override string ToString()
        {
            return ProductName;
        }
    }   
}
