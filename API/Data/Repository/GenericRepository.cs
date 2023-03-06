using Microsoft.EntityFrameworkCore;

namespace API.Data.Repository
{
    public interface IGenericRepository<TEntity> where TEntity : class
    {
        void Create(TEntity model);
        void Edit(TEntity model);
        void Delete(int id);
        Task<TEntity> GetByIdAsync(int id);
        Task<IEnumerable<TEntity>> ListAsync();


    }

    public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class
    {
        private readonly MyContext _context;
        private readonly DbSet<TEntity> DbSet;
        public GenericRepository(MyContext context)
        {
            _context = context;

        }
        public void Create(TEntity model)
        {
            DbSet.Add(model);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void Edit(TEntity model)
        {
            throw new NotImplementedException();
        }

        public async Task<TEntity> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<TEntity>> ListAsync()
        {
            return await DbSet.ToListAsync();
        }
    }
}
