using Models;
using System.Collections.Generic;

namespace Repository.Interfaces
{
    public interface IBrandRepository : IRepository<Brand>
    {
        IEnumerable<Brand> GetBrands();
    }
}
