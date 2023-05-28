using Pharmacy_Management_System1.Model.Order;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy_Management_System1.Model.Payment
{
    public class PaymentDetails
    {
        public int Id { get; set; }
        public string Amount { get; set; }
        public int OrderId { get; set; }
        public DateTime? DeletedOn { get; set; }

        public OrderEntity Order { get; set; }
    }
}
