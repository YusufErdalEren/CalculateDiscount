using CalculateDiscount.Service.Interfaces;
using CalculateDiscount.Service.Models;
using CalculateDiscount.Service.Strategy.Interfaces;
using CalculateDiscount.Service.Strategy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CalculateDiscount.Service.Models.Enums;
using CalculateDiscount.Service.Helper;

namespace CalculateDiscount.Service
{
    public class DiscountService : IDiscountService
    {
        public decimal CalculateDiscount(User user, Bill bill)
        {
            decimal discount = 0;

            IDiscountStrategy discountStrategy = StrategyHelper.GetDiscountStrategy(user);
            discount = discountStrategy.CalculateDiscount(bill);

            decimal totalAmount = CalculateHelper.CalculateTotalAmountWithoutGroceries(bill);
            discount += CalculateHelper.CalculateDiscountForTotalAmount(totalAmount);

            return discount;
        }
    }
}
