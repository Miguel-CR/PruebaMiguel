

using API.Application;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace API.Data.Model
{
    public class Producto
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
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
        [JsonConverter(typeof(JsonToByteArrayConverter))]
        public byte[] Imagen { get; set; }


        [Column(TypeName = "int")]

        public int CategoriaId { get; set; }

        public Categoria? Categoria { get; set; }





    }
}
