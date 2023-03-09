﻿// <auto-generated />
using API.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace API.Migrations
{
    [DbContext(typeof(MyContext))]
    partial class MyContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("API.Data.Model.Categoria", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("VARCHAR(70)");

                    b.HasKey("Id");

                    b.ToTable("Categorias");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Nombre = "Desayuno"
                        },
                        new
                        {
                            Id = 2,
                            Nombre = "Bebidas"
                        },
                        new
                        {
                            Id = 3,
                            Nombre = "Platos fuertes"
                        },
                        new
                        {
                            Id = 4,
                            Nombre = "Postres"
                        });
                });

            modelBuilder.Entity("API.Data.Model.Producto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("CategoriaId")
                        .HasColumnType("int");

                    b.Property<bool>("Descuento")
                        .HasColumnType("bit ");

                    b.Property<string>("Detalle")
                        .IsRequired()
                        .HasColumnType("VARCHAR(250)");

                    b.Property<byte[]>("Imagen")
                        .IsRequired()
                        .HasColumnType("Blob");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("VARCHAR(70)");

                    b.Property<decimal>("Precio")
                        .HasColumnType("Decimal(6,2)");

                    b.HasKey("Id");

                    b.HasIndex("CategoriaId");

                    b.ToTable("Productos");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoriaId = 1,
                            Descuento = false,
                            Detalle = "Desayuno tipico de Costa Rica arroz, frijoles, salsa Lizano y olores.",
                            Imagen = new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                            Nombre = "Pinto",
                            Precio = 2500m
                        },
                        new
                        {
                            Id = 2,
                            CategoriaId = 3,
                            Descuento = false,
                            Detalle = "Platillo tipico de Costa Rica, arroz, pollo demenuzado, frijoles molidos y papas tostadas.",
                            Imagen = new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                            Nombre = "Arroz con pollo",
                            Precio = 4500m
                        },
                        new
                        {
                            Id = 3,
                            CategoriaId = 2,
                            Descuento = true,
                            Detalle = "Bebida a base de arroz licuado con mani.",
                            Imagen = new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                            Nombre = "Orchata",
                            Precio = 2500m
                        },
                        new
                        {
                            Id = 4,
                            CategoriaId = 2,
                            Descuento = false,
                            Detalle = "Fresco en agua de Cas",
                            Imagen = new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                            Nombre = "Freco de Cas",
                            Precio = 2000m
                        },
                        new
                        {
                            Id = 5,
                            CategoriaId = 3,
                            Descuento = false,
                            Detalle = "Corte de carne con pure de papa y esalada",
                            Imagen = new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                            Nombre = "Corte de carne Rib Eye",
                            Precio = 14500m
                        },
                        new
                        {
                            Id = 6,
                            CategoriaId = 4,
                            Descuento = true,
                            Detalle = "Postre a base de coco con caramelo",
                            Imagen = new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                            Nombre = "Flan de coco",
                            Precio = 3500m
                        });
                });

            modelBuilder.Entity("API.Data.Model.Producto", b =>
                {
                    b.HasOne("API.Data.Model.Categoria", "Categoria")
                        .WithMany("Productos")
                        .HasForeignKey("CategoriaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Categoria");
                });

            modelBuilder.Entity("API.Data.Model.Categoria", b =>
                {
                    b.Navigation("Productos");
                });
#pragma warning restore 612, 618
        }
    }
}
