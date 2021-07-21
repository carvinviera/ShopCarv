using ShopCarv.Dato.ModelsDB.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ShopCarv.Dato.ModelsDB
{
    public interface IRepository
    {
        void AddProduct(Product _product);
        Product GetProduct(int id);
        IEnumerable<Product> GetProducts();
        bool ProductExists(int id);
        void RemoveProduct(Product _product);
        Task<bool> SaveAllAsync();
        void UpdateProduct(Product _product);
    }
}