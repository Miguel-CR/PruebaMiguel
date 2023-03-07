using API.Data.Model;
using Microsoft.EntityFrameworkCore;

namespace API.Data.Repository
{

    public interface ICategoriaRepository
    {
        Task<Categoria> GetByIdAsync(int id);
        Task<IEnumerable<Categoria>> ListCategoriaAsync();
    }
    public class CategoriaRepository : ICategoriaRepository
    {
        private readonly MyContext _context;
        private readonly DbSet<Categoria> dbSet;
        public CategoriaRepository(MyContext context)
        {
            _context = context;
            dbSet = _context.Set<Categoria>();
        }
        public async Task<Categoria> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Categoria>> ListCategoriaAsync()
        {
            return await dbSet.ToListAsync();
        }
    }
}
