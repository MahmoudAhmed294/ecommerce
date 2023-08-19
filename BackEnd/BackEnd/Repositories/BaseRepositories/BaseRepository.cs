namespace BackEnd.Repositories.BaseRepositories
{
    public class BaseRepository<T> : IBaseRepository<T> where T : class
    {

        #region Fields
        private EcommerceContext _context = null;
        private readonly DbSet<T> table = null;
        #endregion

        #region Constructors
        public BaseRepository(EcommerceContext context)
        {
            _context = context;
            table = _context.Set<T>();
        }
        #endregion

        #region Methods

        #region Get
        public virtual async Task<IEnumerable<T>> GetAll()
        {
            return await table.ToListAsync();
        }

        public virtual async Task<IQueryable<T>> GetAllWithPagination(int page, int pageSize)
        {
            int skip = (page - 1) * pageSize;
            return table.Skip(skip).Take(pageSize * 1).AsQueryable();
        }

        public virtual async Task<T> GetById(object id)
        {
            return await table.FindAsync(id);
        }
        #endregion

        #region Insert
        public virtual async Task Insert(T obj)
        {
            await table.AddAsync(obj);
        }
        #endregion

        #region Update
        public virtual async Task Update(T obj, object id)
        {
            T? existingEntity = await _context.Set<T>().FindAsync(id);
            if (existingEntity == null)
                return;

            _context.Entry(existingEntity).CurrentValues.SetValues(obj);
        }
        #endregion

        #region Delete
        public virtual async Task Delete(object id)
        {
            T existing = await table.FindAsync(id);
            if (existing == null)
                return;

            table.Remove(existing);
        }
        #endregion

        #region Save
        public virtual async Task Save()
        {
            await table.SingleAsync();
        }
        #endregion

        #endregion

    }
}
