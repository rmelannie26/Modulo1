using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Modulo1.Models
{
    public class EntidadFinanciera
    {
        public int IdEntidad { get; set; }
        public string CodigoEntidad { get; set; }
        public string NombreEntidad { get; set; }
        public string TelefonoEntidad { get; set; }
        public string CorreoElectronico { get; set; }
        public string Direccion { get; set; }
        public DateTime FechaDeRegistro { get; set; }
        public DateTime FechaDeModificacion { get; set; }
        public int IdTipoEntidad { get; set; }
        public bool Estado { get; set; } // 1 = Activo, 0 = Inactivo

        public TipoEntidad TipoEntidad { get; set; } // Relación
    }

    public class TipoEntidad
    {
        public int IdTipoEntidad { get; set; }
        public string Nombre { get; set; }
    }

}