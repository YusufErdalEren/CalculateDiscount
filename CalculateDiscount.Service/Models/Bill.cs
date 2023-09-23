using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateDiscount.Service.Models
{
    public class Bill
    {
        public Bill()
        {
            BillItem = new BillItem();
        }
        public int BillId { get; set; }
        public int UserId { get; set; }
        public BillItem BillItem { get; set; }
    }
}
