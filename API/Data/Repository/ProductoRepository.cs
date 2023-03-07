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
        Task<IEnumerable<Producto>> ListProductoAsync();
    }
    public class ProductoRepository : IProductoRepository
    {
        private readonly MyContext _context;
        private readonly DbSet<Producto> dbSet;
        public ProductoRepository(MyContext context)
        {
            _context = context;
            dbSet = _context.Set<Producto>();
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

        public async Task<IEnumerable<Producto>> ListProductoAsync()
        {
            return await dbSet.ToListAsync();
        }
    }
}
