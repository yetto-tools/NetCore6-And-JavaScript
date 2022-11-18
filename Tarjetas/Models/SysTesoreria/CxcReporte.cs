using System;
using System.Collections.Generic;

namespace Tarjetas.Models.SysTesoreria
{
    public partial class CxcReporte
    {
        public CxcReporte()
        {
            CxcReporteDetalleArqueos = new HashSet<CxcReporteDetalleArqueo>();
            CxcReporteDetalles = new HashSet<CxcReporteDetalle>();
        }

        public int CodigoReporte { get; set; }
        public short AnioOperacion { get; set; }
        public byte SemanaOperacion { get; set; }
        public byte CodigoEstado { get; set; }
        public string UsuarioIng { get; set; }
        public DateTime FechaIng { get; set; }
        public string UsuarioAct { get; set; }
        public DateTime? FechaAct { get; set; }

        public virtual EstadoReporteCxc CodigoEstadoNavigation { get; set; }
        public virtual ReporteCaja CodigoReporteNavigation { get; set; }
        public virtual ICollection<CxcReporteDetalleArqueo> CxcReporteDetalleArqueos { get; set; }
        public virtual ICollection<CxcReporteDetalle> CxcReporteDetalles { get; set; }
    }
}
