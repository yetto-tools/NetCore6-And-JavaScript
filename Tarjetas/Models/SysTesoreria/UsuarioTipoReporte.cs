using System;
using System.Collections.Generic;

namespace Tarjetas.Models.SysTesoreria
{
    public partial class UsuarioTipoReporte
    {
        public int CodigoTipoReporte { get; set; }
        public string IdUsuario { get; set; }
        public byte Estado { get; set; }
        public string UsuarioIng { get; set; }
        public DateTime FechaIng { get; set; }

        public virtual TipoReporte CodigoTipoReporteNavigation { get; set; }
        public virtual Usuario IdUsuarioNavigation { get; set; }
    }
}
