namespace Repository.Interfaces
{
    public interface IRepository<T> where T : class
    {
        void Save();
        void SaveAsync();
        void Create(T entity);
        void Delete(T entity);
        void Update(T entity);
    }
}
