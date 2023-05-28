using Pharmacy_Management_System1.Model.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy_Management_System1.Model.Order.OrderDetail
{
    public class OrderDetailEntity
    {
        public int Id { get; set; }
        public int Quantity { get; set; }
        public int Total { get; set; }
        public int Discount { get; set; }
        public int ProductId { get; set; }
        public int OrderId { get; set; }
        public DateTime? DeletedOn { get; set; }

        public ProductEntity Product { get; set; }
        public OrderEntity Order { get; set; }        
    }
}
