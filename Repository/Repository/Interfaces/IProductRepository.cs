using Models;
using System.Collections.Generic;

namespace Repository.Interfaces
{
    public interface IProductRepository : IRepository<Product>
    {
        Product GetProductById(int id);
        IEnumerable<Product> GetProducts();
    }
}
