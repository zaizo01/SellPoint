using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SellPoint.Data.Entities
{
    public class Entidades
    {
        [Key]
        public int IdEntidad { get; set; }
        public string Descripcion { get; set; }
        public string Direccion { get; set; }
        public string Localidad { get; set; }
        public string TipoEntidad { get; set; } = "Jurídica";
        public string TipoDocumento { get; set; } = "RNC";
        public string NumeroDocumento { get; set; }
        public string Telefonos { get; set; }
        public string URLPaginaWeb { get; set; }
        public string URLFacebook { get; set; }
        public string URLInstagram { get; set; }
        public string URLTwitter { get; set; }
        public string URLTiktok { get; set; }
        public string CodigoPostal { get; set; }
        public string CoordenadasGps { get; set; }
        public int LimiteCredito { get; set; } = 0;
        public string UserNameEntidad { get; set; }
        public string PassworEntidad { get; set; }
        public string RolUserEntidad { get; set; } = "User";
        public string Comentario { get; set; }
        public string Status { get; set; } = "Activa";
        public bool NoEliminable { get; set; } = false;
        public DateTime FechaRegistro { get; set; } = DateTime.Now.Date;
    }
}
