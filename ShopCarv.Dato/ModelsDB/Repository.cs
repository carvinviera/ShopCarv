namespace ShopCarv.Dato.ModelsDB
{
    using ShopCarv.Dato.ModelsDB.Entities;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    public class Repository : IRepository
    {
        private readonly DataContext db;
        public Repository(DataContext db)
        {
            this.db = db;
        }

        public IEnumerable<Product> GetProducts()
        {
            return this.db.Products.OrderBy(p => p.Name);
        }

        public Product GetProduct(int id)
        {
            return this.db.Products.Find(id);
        }

        public void AddProduct(Product _product)
        {
            this.db.Products.Add(_product);
        }

        public void UpdateProduct(Product _product)
        {
            this.db.Products.Update(_product);
        }
        public void RemoveProduct(Product _product)
        {
            this.db.Products.Remove(_product);
        }

        public async Task<bool> SaveAllAsync()
        {
            return await this.db.SaveChangesAsync() > 0;
        }

        public bool ProductExists(int id)
        {
            return this.db.Products.Any(p => p.Id == id);
        }
    }
}
