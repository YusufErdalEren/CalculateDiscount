using CalculateDiscount.Service.Models;
using CalculateDiscount.Service.Strategy.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateDiscount.Service.Strategy
{
    public class DefaultDiscountStrategy : IDiscountStrategy
    {
        public decimal CalculateDiscount(Bill bill)
        {
            return 0;
        }
    }
}
