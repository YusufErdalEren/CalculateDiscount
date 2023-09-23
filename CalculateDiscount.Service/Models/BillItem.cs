using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CalculateDiscount.Service.Models.Enums;

namespace CalculateDiscount.Service.Models
{
    public class BillItem
    {
        public int BillItemId { get; set; }
        public decimal Price { get; set; }
        public ItemType Type { get; set; }
    }
}
