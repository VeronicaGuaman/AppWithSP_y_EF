using Models;
using System.Collections.Generic;

namespace Repository.Interfaces
{
    public interface ISupplierRepository : IRepository<Supplier>
    {
        IEnumerable<Supplier> GetSuppliers();
    }
}
