using CalculateDiscount.Service.Models;
using CalculateDiscount.Service.Strategy.Interfaces;
using CalculateDiscount.Service.Strategy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CalculateDiscount.Service.Models.Enums;

namespace CalculateDiscount.Service.Helper
{
    public static class StrategyHelper
    {
        public static IDiscountStrategy GetDiscountStrategy(User user)
        {
            if (user.Type == UserType.Employee)
            {
                return new EmployeeDiscountStrategy();
            }
            else if (user.Type == UserType.Affiliate)
            {
                return new AffiliateDiscountStrategy();
            }
            else if (user.Type == UserType.LongTimeCustomer && (int)(DateTime.Now.Subtract(user.CreateDate).TotalDays / 365) >= 2)
            {
                return new LongTimeCustomerDiscountStrategy();
            }

            return new DefaultDiscountStrategy(); 
        }       
    }
}
