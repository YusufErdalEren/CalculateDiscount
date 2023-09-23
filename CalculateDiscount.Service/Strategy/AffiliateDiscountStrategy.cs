using CalculateDiscount.Service.Models;
using CalculateDiscount.Service.Strategy.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CalculateDiscount.Service.Models.Enums;

namespace CalculateDiscount.Service.Strategy
{
    public class AffiliateDiscountStrategy : IDiscountStrategy
    {
        public decimal CalculateDiscount(Bill bill)
        {
            decimal discount = 0;
            discount = bill.BillItem.Type != ItemType.Grocery ? (bill.BillItem.Price * (decimal)0.1) : discount;               

            return discount; 
        }
    }
}
