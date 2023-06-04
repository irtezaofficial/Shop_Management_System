using Pharmacy_Management_System1.Model.Rider;
using ShopMigrations;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy_Management_System1.Model.Product
{
    public class ProductService : IProductService
    {
        private ShopDbContext _context = new ShopDbContext();
        public ProductService(ShopDbContext dbcontext) { _context = dbcontext; }

        public string AddProduct(AddProductRequest request)
        {
            var findProduct = this._context.Product.FirstOrDefault(p => p.Name.Contains(request.Name));
            if (findProduct != null)
                return "Product Already Exists";

            var newProduct = new ProductEntity
            {
                Name = request.Name,
                Discount = request.Discount,
                Price = request.Price,
                Quantity = request.Quantity,
            };
            this._context.Product.Add(newProduct);
            this._context.SaveChanges();
            return "Product Added";
        }


        public ProductEntity GetProductByName(string productName)
        {
            var findProduct = this._context.Product.FirstOrDefault(p => p.Name == productName);
            if (findProduct == null)
                return new ProductEntity();
            return findProduct;
        }

        public string UpdateProduct(UpdateProductRequest request)
        {
            var findProduct = this._context.Product.FirstOrDefault(p => p.Id == request.Id && p.DeletedOn == null);
            if (findProduct == null)
                return "Product Not Found";
            findProduct.Name = request.Name;
            findProduct.Discount = request.Discount;
            findProduct.Price = request.Price;
            findProduct.Quantity = request.Quantity;
            this._context.Product.AddOrUpdate(findProduct);
            this._context.SaveChanges();
            return "Product Updated.";
        }

        public string DeleteProduct(int productId)
        {
            var findProduct = this._context.Product.FirstOrDefault(p => p.Id == productId);
            if (findProduct == null)
                return "Product Not Found";
            findProduct.DeletedOn = DateTime.Now;
            this._context.Product.AddOrUpdate(findProduct);
            this._context.SaveChanges();
            return "Product Deleted";
        }

        public List<ProductEntity> GetAllProducts()
        {
            var products = this._context.Product.Where(p => p.DeletedOn == null).ToList();
            return products;
        }
    }
}
