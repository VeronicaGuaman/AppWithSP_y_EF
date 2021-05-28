using Microsoft.EntityFrameworkCore;
using Models;
//using Models;
using Repository.Interfaces;

namespace Repository
{

    public class Repository<T> : IRepository<T> where T : class
    {
        protected BDPruebaSinergiaSSContext _context;

        public Repository(BDPruebaSinergiaSSContext context)
        {
            _context = context;
        }
        protected void Save() => _context.SaveChanges();
        protected void SaveAsync() => _context.SaveChangesAsync();
        public void Create(T entity)
        {
            _context.Add(entity);
            Save();
        }

        public void Delete(T entity)
        {
            _context.Remove(entity);
            Save();
        }


        public void Update(T entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
            Save();
        }

        void IRepository<T>.Save()
        {
            throw new System.NotImplementedException();
        }

        void IRepository<T>.SaveAsync()
        {
            throw new System.NotImplementedException();
        }
    }
}
