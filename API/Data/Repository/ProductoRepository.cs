using API.Data.Model;
using Microsoft.EntityFrameworkCore;

namespace API.Data.Repository
{
    public interface IProductoRepository
    {
        void Create(Producto producto);
        void Edit(Producto producto);
        void Delete(int id);
        Task<Producto> GetProductoByIdAsync(int id);
        Task<IEnumerable<Producto>> ListProductiAsync();
    }
    public class ProductoRepository : IProductoRepository
    {
        private readonly MyContext _context;
        private readonly DbSet<Producto> dbSet;
        public ProductoRepository(MyContext context)
        {
            _context = context;
        }
        public void Create(Producto producto)
        {
            dbSet.Add(producto);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void Edit(Producto producto)
        {
            throw new NotImplementedException();
        }

        public async Task<Producto> GetProductoByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Producto>> ListProductiAsync()
        {
            return await dbSet.ToListAsync();
        }
    }
}
