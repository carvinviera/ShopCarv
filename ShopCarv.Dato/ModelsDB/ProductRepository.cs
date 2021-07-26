namespace ShopCarv.Dato.ModelsDB
{
    using Entities;
    public class ProductRepository : GenericRepository<Product>, IProductRepository
    {
        public ProductRepository(DataContext context) : base(context)
        {

        }
    }
}
