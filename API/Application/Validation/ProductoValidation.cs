using API.Data.Model;
using FluentValidation;
using System.Data;

namespace API.Application.Validation
{
    public class ProductoValidation : AbstractValidator<Producto>
    {
        string msj = "El {PropertyName} no puede ser nulo.";
        public ProductoValidation()
        {
            ValidarNombre();
        }
        private void ValidarNombre()
        {
            RuleFor(x => x.Nombre).NotEmpty().WithMessage("El nombre no puede estar vacio").Length(1, 70).WithMessage("El campo nombre debe de tener de 1 a 70 caracteres");
        }
    }
}
