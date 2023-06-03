using Pharmacy_Management_System1.Model.Product;
using ShopMigrations;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy_Management_System1.Model.Payment
{
    public class PaymentService : IPaymentService
    {
        private ShopDbContext _context = new ShopDbContext();
        public PaymentService(ShopDbContext dbcontext) { _context = dbcontext; }

        public string AddPayment(AddPaymentRequest request)
        {
            var findPayment = this._context.PaymentDetails.FirstOrDefault(p => p.OrderId == request.OrderId);
            if (findPayment != null)
                return "Payment Already Exists";

            var newPayment = new PaymentDetails
            {
                Amount = request.Amount,
                OrderId = request.OrderId,
            };
            this._context.PaymentDetails.Add(newPayment);
            this._context.SaveChanges();
            return "Payment Added";
        }


        public PaymentDetails GetPaymentById(int paymentId)
        {
            var findPayment = this._context.PaymentDetails.FirstOrDefault(p => p.Id == paymentId);
            if (findPayment == null)
                return new PaymentDetails();
            return findPayment;
        }

        public string UpdatePayment(UpdatePaymentRequest request)
        {
            var findPayment = this._context.PaymentDetails.FirstOrDefault(p => p.OrderId == request.OrderId && p.DeletedOn == null);
            if (findPayment == null)
                return "Payment Not Found";
            findPayment.Amount = request.Amount;
            findPayment.OrderId = request.OrderId;
            this._context.PaymentDetails.AddOrUpdate(findPayment);
            this._context.SaveChanges();
            return "Payment Updated.";
        }

        public string DeletePayment(int paymentId)
        {
            var findPayment = this._context.Product.FirstOrDefault(p => p.Id == paymentId);
            if (findPayment == null)
                return "Payment Not Found";
            findPayment.DeletedOn = DateTime.Now;
            this._context.Product.AddOrUpdate(findPayment);
            this._context.SaveChanges();
            return "Payment Deleted";
        }

        public List<PaymentDetails> GetAllPayments()
        {
            var payments = this._context.PaymentDetails.Where(p => p.DeletedOn == null).ToList();
            return payments;
        }
    }
}
