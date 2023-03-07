using API.Application.Validation;
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
        //bool IsValid();
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
            var producto = dbSet.Find(id);
            dbSet.Remove(producto);
            _context.SaveChanges();
        }

        public void Edit(Producto producto)
        {
            dbSet.Update(producto);
            _context.SaveChanges();
        }

        public async Task<Producto> GetProductoByIdAsync(int id)
        {
            var producto = await dbSet.FindAsync(id);

            return producto;

        }

        public async Task<IEnumerable<Producto>> ListProductoAsync()
        {
            return await dbSet.ToListAsync();
        }

        //public bool IsValid()
        //{
        //    var validationResult = new ProductoValidation().Validate();
        //    return validationResult.IsValid;
        //}
    }
}
