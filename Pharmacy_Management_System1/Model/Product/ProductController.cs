using Pharmacy_Management_System1.Model.Rider;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy_Management_System1.Model.Product
{
    public class ProductController
    {
        private readonly IProductService _productService;
        public ProductController(IProductService productService) { _productService = productService; }

        public string AddProduct(AddProductRequest request)
        {
            return this._productService.AddProduct(request);
        }

        public ProductEntity GetProductByName(string productName)
        {
            return this._productService.GetProductByName(productName);
        }

        public string UpdateProduct(UpdateProductRequest request)
        {
            return this._productService.UpdateProduct(request);
        }

        public string DeleteProduct(int productId)
        {
            return this._productService.DeleteProduct(productId);
        }

        public List<ProductEntity> GetProductList()
        {
            return this._productService.GetAllProducts();
        }
    }
}
