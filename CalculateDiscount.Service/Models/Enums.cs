using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateDiscount.Service.Models
{
    public class Enums
    {
        public enum UserType
        {
            Employee = 1,
            Affiliate = 2,
            LongTimeCustomer = 3
        }

        public enum ItemType
        {
            Grocery = 1,
            OtherStore = 2
        }
    }
}
