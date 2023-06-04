using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy_Management_System1.Model.Order
{
    public interface IOrderService
    {
        string AddToCart(AddToCartRequest request);
        string Checkout(int userId);
        OrderEntity GetCurrentUserCart(int userId);
    }
}
