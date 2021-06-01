using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Models;
using Repository.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace Repository
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        public ProductRepository(BDPruebaSinergiaSSContext context) : base(context)
        {
        }
        public Product GetProductById(int id)
        {            
            var param = new SqlParameter("@id", id);
            var product = _context.Products.FromSqlInterpolated($"sp_GetProductById {param}").ToList();
            return product.FirstOrDefault();
        }

        public IEnumerable<Product> GetProducts()
        {
            return _context.Products.FromSqlRaw(@"exec sp_GetProducts").ToList();           
        }
    }
}
