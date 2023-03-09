using API.Data.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations;

namespace API.Data.Seed
{
    public static class InitialValues
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Categoria>().HasData(new Categoria { Id = 1, Nombre = "Desayuno" });
            modelBuilder.Entity<Categoria>().HasData(new Categoria { Id = 2, Nombre = "Bebidas" });
            modelBuilder.Entity<Categoria>().HasData(new Categoria { Id = 3, Nombre = "Platos fuertes" });
            modelBuilder.Entity<Categoria>().HasData(new Categoria { Id = 4, Nombre = "Postres" });


            modelBuilder.Entity<Producto>().HasData(new Producto { Id = 1, Nombre = "Pinto", Detalle = "Desayuno tipico arroz, frijoles, salsa Lizano y olores", Precio = 2500, Descuento = false, CategoriaId = 1, Imagen = new byte[0x20] });
            modelBuilder.Entity<Producto>().HasData(new Producto { Id = 2, Nombre = "Arroz con pollo", Detalle = "Arroz, pollo, frijoles molidos", Precio = 4500, Descuento = false, CategoriaId = 3, Imagen = new byte[0x20] });
            modelBuilder.Entity<Producto>().HasData(new Producto { Id = 3, Nombre = "Orchata", Detalle = "Bebida a base de arroz licuado con mani", Precio = 2500, Descuento = true, CategoriaId = 2, Imagen = new byte[0x20] });
            modelBuilder.Entity<Producto>().HasData(new Producto { Id = 4, Nombre = "Fresco de Cas", Detalle = "Fresco en agua de Cas", Precio = 2000, Descuento = false, CategoriaId = 2, Imagen = new byte[0x20] });
            modelBuilder.Entity<Producto>().HasData(new Producto { Id = 5, Nombre = "Corte de carne Rib Eye", Detalle = "Corte de carne con pure de papa y esalada", Precio = 10000, Descuento = false, CategoriaId = 3, Imagen = new byte[0x20] });
            modelBuilder.Entity<Producto>().HasData(new Producto { Id = 6, Nombre = "Flan de coco", Detalle = "Postre a base de coco con caramelo", Precio = 3500, Descuento = true, CategoriaId = 4, Imagen = new byte[0x20] });



        }
    }
}
