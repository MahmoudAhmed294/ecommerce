namespace BackEnd.Repositories.BaseRepositories
{
    public interface IBaseRepository<T> where T : class
    {

        Task<IEnumerable<T>> GetAll();
        Task<IQueryable<T>> GetAllWithPagination(int page, int pageSize);
        Task<T> GetById(object id);
        Task Insert(T obj);
        Task Update(T obj, object id);
        Task Delete(object id);
        Task Save();

    }
}
