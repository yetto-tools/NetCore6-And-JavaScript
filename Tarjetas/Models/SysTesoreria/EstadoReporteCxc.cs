using System;
using System.Collections.Generic;

namespace Tarjetas.Models.SysTesoreria
{
    public partial class EstadoReporteCxc
    {
        public EstadoReporteCxc()
        {
            CxcReportes = new HashSet<CxcReporte>();
        }

        public byte CodigoEstadoReporte { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public byte Estado { get; set; }
        public string UsuarioIng { get; set; }
        public DateTime FechaIng { get; set; }

        public virtual ICollection<CxcReporte> CxcReportes { get; set; }
    }
}
