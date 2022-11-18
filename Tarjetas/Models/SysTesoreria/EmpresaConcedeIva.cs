using System;
using System.Collections.Generic;

namespace Tarjetas.Models.SysTesoreria
{
    public partial class EmpresaConcedeIva
    {
        public string Nit { get; set; }
        public string Observaciones { get; set; }
        public byte Estado { get; set; }
        public string UsuarioIng { get; set; }
        public DateTime FechaIng { get; set; }
        public int? CodigoEntidad { get; set; }

        public virtual Entidad CodigoEntidadNavigation { get; set; }
        public virtual Contribuyente NitNavigation { get; set; }
    }
}
