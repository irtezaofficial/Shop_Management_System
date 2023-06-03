using Pharmacy_Management_System1.Model.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy_Management_System1.Model.Payment
{
    public interface IPaymentService
    {
        string AddPayment(AddPaymentRequest request);
        PaymentDetails GetPaymentById(int paymentId);
        string UpdatePayment(UpdatePaymentRequest request);
        string DeletePayment(int paymentId);
        List<PaymentDetails> GetAllPayments();
    }
}
