using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CalculateDiscount.Service.Models.Enums;

namespace CalculateDiscount.Service.Models
{
    public class User
    {
        public int UserId { get; set; }
        public UserType Type { get; set; }
        public DateTime CreateDate { get; set; }
    }
}
