namespace FinalQualification.Data.Repositories.Interfaces.Base
{
    public interface IRepository<T>
    {
        Task<IEnumerable<T>> GetAll();
        Task Create(T entity);
        Task<T> GetById(long id);
        Task Update(T entity);
        Task Delete(T entity);
    }
}
