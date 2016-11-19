using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthwindBasketApplication
{
    class Employee
    {
        public int EmployeeID { get; set; }

        public string EmployeFirstName { get; set; }

        public string EmployeeLastName { get; set; }

        public string FullName
        {
            get { return EmployeFirstName+" "+EmployeeLastName; }
           
        }

        public override string ToString()
        {
            return FullName;
        }
        
    }
}
