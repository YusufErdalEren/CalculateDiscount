using CalculateDiscount.Service.Models;
using CalculateDiscount.Service.Strategy.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateDiscount.Service.Interfaces
{
    public interface IDiscountService
    {
        decimal CalculateDiscount(User user, Bill bill);
    }
}
