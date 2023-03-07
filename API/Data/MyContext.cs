using API.Data.Model;
using API.Data.Seed;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;
//using Pomelo.EntityFrameworkCore.MySql.Infrastructure;
using System.Data.Common;
using System.Diagnostics.Contracts;
using System.Reflection.Metadata;

namespace API.Data
{
    public class MyContext : DbContext
    {

        protected readonly IConfiguration Configuration;
        public DbSet<Categoria> Categorias { get; set; }

        public DbSet<Producto> Productos { get; set; }



        //public static void Configure(DbContextOptionsBuilder<MyContext> builder, string connectionString)
        //{
        //    var serverVersion = ServerVersion.AutoDetect(connectionString);
        //    builder.UseMySql(connectionString, serverVersion);
        //}

        //public static void Configure(DbContextOptionsBuilder<MyContext> builder, DbConnection connection)
        //{
        //    var serverVersion = ServerVersion.AutoDetect(connection.ConnectionString)
        //    builder.UseMySql(connection, serverVersion);
        //}


        public MyContext(IConfiguration configuration)
        {
            Configuration = configuration;
        }


        //public static void Configure(DbContextOptionsBuilder<MyContext> builder, string connectionString)
        //{
        //    //
        //    builder.UseMySql(connectionString,
        //        mySqlOptionsAction => mySqlOptionsAction.ServerVersion(new Version(), ServerType.MySql));
        //}

        //public static void Configure(DbContextOptionsBuilder<MyContext> builder, DbConnection connection)
        //{
        //    //
        //    builder.UseMySql(connection);
        //}

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            var connectionString = Configuration.GetConnectionString("Default");
            options.UseMySQL(connectionString);
        }


        //protected override void OnConfiguring(DbContextOptionsBuilder options ,DbConnection connection)
        //{
        //    var connectionString = Configuration.GetConnectionString("Default");
        //    var serverVersion = ServerVersion.AutoDetect(connection.ConnectionString)
        //    options.UseMySQL(connectionString, serverVersion);
        //}


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Categoria>()
            //.Property(c => c.Id)
            //.ValueGeneratedOnAdd();

            //modelBuilder.Entity<Producto>()
            //.Property(p => p.Id)
            //.ValueGeneratedOnAdd();

            modelBuilder.ApplyConfigurationsFromAssembly(GetType().Assembly);

            modelBuilder.Seed();

            base.OnModelCreating(modelBuilder);

        }

    }
}
