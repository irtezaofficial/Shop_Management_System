using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy_Management_System1.Model.Order
{
    public class OrderController
    {
        private readonly IOrderService _orderService;
        public OrderController(IOrderService orderService) => _orderService = orderService;

        public string AddToCart(AddToCartRequest request)
        {
            return this._orderService.AddToCart(request);
        }

        public string Checkout(int userId)
        {
            return this._orderService.Checkout(userId);
        }

        public OrderEntity GetCurrentUserCart(int userId)
        {
            return _orderService.GetCurrentUserCart(userId);
        }
    }
}
