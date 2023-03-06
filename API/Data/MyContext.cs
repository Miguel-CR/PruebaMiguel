using API.Data.Model;
using API.Data.Seed;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;
using System.Reflection.Metadata;

namespace API.Data
{
    public class MyContext : DbContext
    {

        protected readonly IConfiguration Configuration;
        public DbSet<Producto> Productos { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public MyContext(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            var connectionString = Configuration.GetConnectionString("Default");
            options.UseMySQL(connectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.ApplyConfigurationsFromAssembly(GetType().Assembly);
            modelBuilder.Seed();
            base.OnModelCreating(modelBuilder);

        }



        //public MyContext(DbContextOptions<MyContext> options) : base(options) { }
        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.ApplyConfigurationsFromAssembly(GetType().Assembly);
        //    base.OnModelCreating(modelBuilder);

        //}

    }
}
