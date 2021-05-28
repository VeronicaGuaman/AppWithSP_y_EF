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
        public List<Product> GetProductById(int id)
        {
            
            var param = new SqlParameter("@id", id);
            return _context.Products.FromSqlInterpolated($"sp_GetProductById {param}").ToList();
            //return _context.Products.FromSqlRaw($"exec sp_GetProductById {param}").Single();
        }

        public IEnumerable<Product> GetProducts()
        {
            return _context.Products.FromSqlRaw(@"exec sp_GetProducts").ToList();           
        }
    }
}
