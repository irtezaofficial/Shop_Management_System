using Pharmacy_Management_System1.Model.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy_Management_System1.Model.Payment
{
    public class PaymentController
    {
        private readonly IPaymentService _paymentService;
        public PaymentController(IPaymentService paymentService) { _paymentService = paymentService; }

        public string AddPayment(AddPaymentRequest request)
        {
            return this._paymentService.AddPayment(request);
        }

        public PaymentDetails GetPaymentById(int paymentId)
        {
            return this._paymentService.GetPaymentById(paymentId);
        }

        public string UpdatePayment(UpdatePaymentRequest request)
        {
            return this._paymentService.UpdatePayment(request);
        }

        public string DeletePayment(int productId)
        {
            return this._paymentService.DeletePayment(productId);
        }

        public List<PaymentDetails> GetPaymentList()
        {
            return this._paymentService.GetAllPayments();
        }
    }
}
