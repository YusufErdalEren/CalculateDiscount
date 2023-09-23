using CalculateDiscount.Service.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateDiscount.Service.Strategy.Interfaces
{
    public interface IDiscountStrategy
    {
        decimal CalculateDiscount(Bill bill);
    }
}
