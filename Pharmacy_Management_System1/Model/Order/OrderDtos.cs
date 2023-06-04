using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy_Management_System1.Model.Order
{
    public class AddToCartRequest
    {
        public int UserId { get; set; }
        public int Quantity { get; set; }
        public string ProductName { get; set; }
    }

    public class RemoveFromCartRequest
    {

    }
}
