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
        [Required, StringLength(120)]
        public string Descripcion { get; set; }
        [Required]
        public string Direccion { get; set; }
        [Required, StringLength(40)]
        public string Localidad { get; set; }
        [StringLength(8)]
        public string TipoEntidad { get; set; } = "Jurídica";
        [StringLength(9)]
        public string TipoDocumento { get; set; } = "RNC";
        [Required, MaxLength(15)]
        public long NumeroDocumento { get; set; }
        [Required, StringLength(60)]
        public string Telefonos { get; set; }
        [StringLength(120)]
        public string URLPaginaWeb { get; set; }
        [StringLength(120)]
        public string URLFacebook { get; set; }
        [StringLength(120)]
        public string URLInstagram { get; set; }
        [StringLength(120)]
        public string URLTwitter { get; set; }
        [StringLength(120)]
        public string URLTiktok { get; set; }
        [StringLength(10)]
        public string CodigoPostal { get; set; }
        [StringLength(255)]
        public string CoordenadasGps { get; set; }
        [MaxLength(15)]
        public int LimiteCredito { get; set; } = 0;
        [Required, StringLength(60)]
        public string UserNameEntidad { get; set; }
        [Required, StringLength(30)]
        public string PassworEntidad { get; set; }
        [StringLength(10)]
        public string RolUserEntidad { get; set; }
        public string Comentario { get; set; }
        [StringLength(10)]
        public string Status { get; set; } = "Activa";
        public bool NoEliminable { get; set; } = false;
        public DateTime FechaRegistro { get; set; } = DateTime.Now;
    }
}
