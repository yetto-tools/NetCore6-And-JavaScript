using System;
using System.Collections.Generic;

namespace Tarjetas.Models.SysTesoreria
{
    public partial class Concepto
    {
        public Concepto()
        {
            ReporteCajaDetalles = new HashSet<ReporteCajaDetalle>();
        }

        public short CodigoConcepto { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public short OrdenReporteCaja { get; set; }
        public byte Estado { get; set; }
        public string UsuarioIng { get; set; }
        public DateTime FechaIng { get; set; }

        public virtual ICollection<ReporteCajaDetalle> ReporteCajaDetalles { get; set; }
    }
}
