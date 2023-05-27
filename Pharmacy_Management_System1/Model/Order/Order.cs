using Pharmacy_Management_System1.Model.Order.OrderDetail;
using Pharmacy_Management_System1.Model.Rider;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy_Management_System1.Model.Order
{
    public enum OrderStatus
    {
        Draft = 0,
        Purchased = 1,
        InProgress = 2,
        Delivered = 3,
        Cancelled = 4

    }
    public class OrderEntity
    {
        public int Id { get; set; }
        public OrderStatus Status { get; set; }
        public int RiderId { get; set; }
        public int UserId { get; set; }

        public RiderEntity Rider { get; set; }
        public UserEntity User { get; set; }
        public List<OrderDetailEntity> OrderDetails { get; set; }
    }
}
