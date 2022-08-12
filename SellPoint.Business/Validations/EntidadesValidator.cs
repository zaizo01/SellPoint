using FluentValidation;
using SellPoint.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SellPoint.Business.Validations
{
    public class EntidadesValidator: AbstractValidator<Entidades>
    {
        public EntidadesValidator()
        {

            List<string> TiposEdentidades = new List<string>() { "Física", "Jurídica" };
            List<string> TiposDocumentos = new List<string>() { "RNC", "Cédula", "Pasaporte" };
            List<string> Roles = new List<string>() { "Admin", "Supervisor", "User" };

            RuleFor(entidad => entidad.Descripcion)
                .NotEmpty().WithMessage("La descripcion es requerida.")
                .Length(120);

            RuleFor(entidad => entidad.Direccion)
                .NotEmpty().WithMessage("La direccion es requerida.");

            RuleFor(entidad => entidad.Localidad)
                .NotEmpty().WithMessage("La localidad es requerida.")
                .Length(40);

            RuleFor(entidad => entidad.TipoEntidad)
                .NotEmpty().WithMessage("El tipo de edentidad es requerida.")
                .Must(entidad => TiposEdentidades.Contains(entidad)).WithMessage("El tipo de edentidad debe ser Física o Jurídica.")
                .Length(8);

            RuleFor(entidad => entidad.TipoDocumento)
                .NotEmpty().WithMessage("El tipo de documento es requerido.")
                .Must(entidad => TiposDocumentos.Contains(entidad)).WithMessage("El tipo de documento debe ser uno de los siguientes RNC, Cédula o Pasaporte.")
                .Length(9);

            RuleFor(entidad => entidad.NumeroDocumento)
                .NotEmpty().WithMessage("El numero de documento es requerido.");

            RuleFor(entidad => entidad.Telefonos)
                .NotEmpty().WithMessage("El telefono es requerido.")
                .Length(60);

            RuleFor(entidad => entidad.URLPaginaWeb)
                 
                .Length(120);

            RuleFor(entidad => entidad.URLFacebook) 
                .Length(120);

            RuleFor(entidad => entidad.URLInstagram)
                .Length(120);

            RuleFor(entidad => entidad.URLTwitter)
                .Length(120);

            RuleFor(entidad => entidad.URLTiktok)
                .Length(120);

            RuleFor(entidad => entidad.CodigoPostal)
                .Length(10); 

            RuleFor(entidad => entidad.LimiteCredito)
                .NotEmpty().WithMessage("El campo es requerido.")
                .GreaterThan(0).WithMessage("El limite debe ser mayor a 0.");
             
            RuleFor(entidad => entidad.UserNameEntidad)
                .NotEmpty().WithMessage("El Nombre de usuario es requerido.")
                .Length(60);

            RuleFor(entidad => entidad.PassworEntidad)
                .NotEmpty().WithMessage("La contraseña es requerida.")
                .Length(30);

            RuleFor(entidad => entidad.RolUserEntidad)
                .NotEmpty().WithMessage("El rol es requerido.")
                .Must(entidad => TiposDocumentos.Contains(entidad)).WithMessage("El rol debe ser uno de los siguientes Admin, Superviso o User.")
                .Length(10);

            RuleFor(entidad => entidad.Status)
                .NotEmpty().WithMessage("El estatus es requerido.")
                .Length(10);
            
        }
    }
}
