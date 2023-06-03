using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy_Management_System1.Model.Product
{
    public class AddProductRequest
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public int Quantity { get; set; }
        public float Discount { get; set; }
    }

    public class UpdateProductRequest : AddProductRequest
    {
        public int Id { get; set; }
    }
}
