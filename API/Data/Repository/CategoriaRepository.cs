using API.Data.Model;
using Microsoft.EntityFrameworkCore;

namespace API.Data.Repository
{

    public interface ICategoriaRepository
    {
        Task<Categoria> GetCategoriaByIdAsync(int id);
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
        public async Task<Categoria> GetCategoriaByIdAsync(int id)
        {
            var categoria = await dbSet.FindAsync(id);

            return categoria;
        }

        public async Task<IEnumerable<Categoria>> ListCategoriaAsync()
        {
            return await dbSet.ToListAsync();
        }
    }
}
