using Models;
using System.Collections.Generic;

namespace Repository.Interfaces
{
    public interface ICategoryRepository : IRepository<Category>
    {
        IEnumerable<Category> GetCategories();
    }
}
