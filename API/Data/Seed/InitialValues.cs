using API.Data.Model;
using Microsoft.EntityFrameworkCore;

namespace API.Data.Seed
{
    public static class InitialValues
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Categoria>().HasData(new Categoria { Id = 1, Nombre = "Desayuno" });
            modelBuilder.Entity<Producto>().HasData(new Producto { Id = 1, Nombre = "Pinto", Detalle = "Desayuno tipico de Costa Rica, arroz, frijoles, salsa Lizano y olores.", Precio = 2500, Descuento = false, CategoriaId = 1, Imagen = new byte[0x20] });

        }
    }
}
