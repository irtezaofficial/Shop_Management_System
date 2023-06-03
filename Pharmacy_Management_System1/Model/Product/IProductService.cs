using Pharmacy_Management_System1.Model.Rider;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy_Management_System1.Model.Product
{
    public interface IProductService
    {
        string AddProduct(AddProductRequest request);
        ProductEntity GetProductById(int productId);
        string UpdateProduct(UpdateProductRequest request);
        string DeleteProduct(int productId);
        List<ProductEntity> GetAllProducts();
    }
}
