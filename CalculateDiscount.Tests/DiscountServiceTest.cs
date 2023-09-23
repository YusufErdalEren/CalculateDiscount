using CalculateDiscount.Service.Models;
using CalculateDiscount.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CalculateDiscount.Service.Models.Enums;
using Xunit;

namespace CalculateDiscount.Tests
{
    public class DiscountServiceTest
    {
        [Fact]
        public static void DiscountService_CalculateDiscount_ReturnsCorrectDiscount()
        {
            var user = new User { UserId = 1, Type = UserType.Employee, CreateDate = DateTime.Now.AddYears(-3) };
            var item = new BillItem { BillItemId = 1, Price = 550, Type = ItemType.OtherStore };
            var bill = new Bill { BillId = 1, UserId = 1, BillItem = item };

            var discountService = new DiscountService();

            decimal discount = discountService.CalculateDiscount(user, bill);

            Assert.Equal(190, discount);
        }
    }
}
