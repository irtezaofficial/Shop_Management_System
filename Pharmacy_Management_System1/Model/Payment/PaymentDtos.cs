using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy_Management_System1.Model.Payment
{
    public class AddPaymentRequest
    {
        public string Amount { get; set; }
        public int OrderId { get; set; }
    }

    public class UpdatePaymentRequest : AddPaymentRequest
    {
        public int Id { get; set; }
    }
}
