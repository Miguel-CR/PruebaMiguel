

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Data.Model
{
    public class Producto
    {
        [Key]
        public int Id { get; set; }

        [Column(TypeName = "VARCHAR(70)")]
        public string Nombre { get; set; }

        [Column(TypeName = "VARCHAR(250)")]
        public string Detalle { get; set; }

        [Column(TypeName = "Decimal(6,2)")]
        public float Precio { get; set; }

        [Column(TypeName = "bit ")]
        public bool Descuento { get; set; }

        [Column(TypeName = "Blob")]
        public byte[] Imagen { get; set; }


        [Column(TypeName = "int")]

        public int CategoriaId { get; set; }

        public Categoria Categoria { get; set; }





    }
}
