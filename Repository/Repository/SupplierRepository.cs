using Microsoft.EntityFrameworkCore;
using Models;
using Repository.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace Repository
{
    public class SupplierRepository : Repository<Supplier>, ISupplierRepository
    {
        public SupplierRepository(BDPruebaSinergiaSSContext context) : base(context){}

        public IEnumerable<Supplier> GetSuppliers()
        {
            return _context.Suppliers.FromSqlRaw(@"exec sp_GetSuppliers").ToList();
        }
    }
}