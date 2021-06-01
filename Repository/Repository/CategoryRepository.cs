using Microsoft.EntityFrameworkCore;
using Models;
using Repository.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace Repository
{
    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        public CategoryRepository(BDPruebaSinergiaSSContext context) : base(context) {}

        public IEnumerable<Category> GetCategories()
        {
            return _context.Categories.FromSqlRaw(@"exec sp_GetCategories").ToList();
        }
    }
}
