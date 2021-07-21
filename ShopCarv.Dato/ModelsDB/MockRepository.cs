using ShopCarv.Dato.ModelsDB.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopCarv.Dato.ModelsDB
{
    public class MockRepository : IRepository
    {
        public void AddProduct(Product _product)
        {
            throw new NotImplementedException();
        }

        public Product GetProduct(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Product> GetProducts()
        {
            var _products = new List<Product>();
            _products.Add(new Product { Id = 1, Name = "Product nuevas de prueba" });
            _products.Add(new Product { Id = 2, Name = "Product nuevas de prueba 1" });
            _products.Add(new Product { Id = 3, Name = "Product nuevas de prueba 2" });
            _products.Add(new Product { Id = 4, Name = "Product nuevas de prueba 3" });
            return _products;
        }

        public bool ProductExists(int id)
        {
            throw new NotImplementedException();
        }

        public void RemoveProduct(Product _product)
        {
            throw new NotImplementedException();
        }

        public Task<bool> SaveAllAsync()
        {
            throw new NotImplementedException();
        }

        public void UpdateProduct(Product _product)
        {
            throw new NotImplementedException();
        }
    }
}
