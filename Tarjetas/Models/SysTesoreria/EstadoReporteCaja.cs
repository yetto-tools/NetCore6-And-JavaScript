using System;
using System.Collections.Generic;

namespace Tarjetas.Models.SysTesoreria
{
    public partial class EstadoReporteCaja
    {
        public EstadoReporteCaja()
        {
            ReporteCajas = new HashSet<ReporteCaja>();
        }

        public byte CodigoEstadoReporteCaja { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public byte Estado { get; set; }
        public string UsuarioIng { get; set; }
        public DateTime FechaIng { get; set; }

        public virtual ICollection<ReporteCaja> ReporteCajas { get; set; }
    }
}
