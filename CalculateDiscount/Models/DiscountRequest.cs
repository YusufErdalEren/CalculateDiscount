using CalculateDiscount.Service.Models;

namespace CalculateDiscount.Models
{
    public class DiscountRequest
    {
        public User User { get; set; }
        public Bill Bill { get; set; }
    }
}
