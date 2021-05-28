using Microsoft.EntityFrameworkCore;
using Models;
using Repository.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace Repository
{
    public class BrandRepository : Repository<Brand>, IBrandRepository
    {
        public BrandRepository(BDPruebaSinergiaSSContext context) : base(context)
        {
        }

        public IEnumerable<Brand> GetBrands()
        {
            return _context.Brands.FromSqlRaw(@"exec sp_GetBrands").ToList();
        }
    }
}
