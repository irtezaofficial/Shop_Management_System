using Microsoft.EntityFrameworkCore;
using Pharmacy_Management_System1.Model.Order.OrderDetail;
using Pharmacy_Management_System1.Model.Product;
using ShopMigrations;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy_Management_System1.Model.Order
{
    public class OrderService : IOrderService
    {
        private ShopDbContext _context = new ShopDbContext();
        public OrderService(ShopDbContext dbcontext) { _context = dbcontext; }
        public string AddToCart(AddToCartRequest request)
        {
            var order = this._context.Order.FirstOrDefault(o => o.UserId == request.UserId);
            order = order ?? new OrderEntity();

            var findProduct = this._context.Product.FirstOrDefault(p => p.Name.Contains(request.ProductName));
            if (findProduct == null)
                return "Product Not Found";

            if (findProduct.Quantity < request.Quantity)
                return "Product Quantity exceeds";

            var total = order.TotalAmount;
            order.Status = OrderStatus.Draft;
            order.UserId = request.UserId;
            order.OrderDetails = order.OrderDetails ?? new List<OrderDetailEntity>();
            var orderDetail = new OrderDetailEntity()
            {
                ProductId = findProduct.Id,
                Quantity = request.Quantity,
                Discount = Convert.ToInt32(findProduct.Discount),
                Total = findProduct.Price * request.Quantity
            };
            total += orderDetail.Total-orderDetail.Discount;
            order.OrderDetails.Add(orderDetail);
            order.TotalAmount = total;
            this._context.Order.AddOrUpdate(order);
            this._context.SaveChanges();
            return "Order Added";
        }

        public string Checkout(int userId)
        {
            var order = this._context.Order.FirstOrDefault(o => o.UserId == userId);
            if(order == null)
                return "Order Not Found";
            order.Status = OrderStatus.Purchased;
            this._context.Order.AddOrUpdate(order);
            this._context.SaveChanges();
            return "Checkout Successull";
        }

        public OrderEntity GetCurrentUserCart(int userId)
        {
            var order = this._context.Order.Include(o => o.OrderDetails).ThenInclude(od => od.Product)
            .FirstOrDefault(o => o.UserId == userId && o.Status == OrderStatus.Draft);
            order = order ?? new OrderEntity();
            return order;
        }
    }
}
