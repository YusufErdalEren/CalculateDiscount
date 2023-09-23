using CalculateDiscount.Service.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CalculateDiscount.Service.Models.Enums;

namespace CalculateDiscount.Service.Helper
{
    public static class CalculateHelper
    {
        public static decimal CalculateTotalAmountWithoutGroceries(Bill bill)
        {
            decimal totalAmount = 0;
            totalAmount = bill.BillItem.Type != ItemType.Grocery ? bill.BillItem.Price : totalAmount;

            return totalAmount;
        }

        public static decimal CalculateDiscountForTotalAmount(decimal totalAmount)
        {
            return (int)(totalAmount / 100) * 5;
        }
    }
}
