using System;
using System.Collections.Generic;

namespace Tarjetas.Models.SysTesoreria
{
    public partial class EstadoReporteCajaChica
    {
        public EstadoReporteCajaChica()
        {
            ReporteCajaChicas = new HashSet<ReporteCajaChica>();
        }

        public byte CodigoEstado { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public byte Estado { get; set; }
        public string UsuarioIng { get; set; }
        public DateTime FechaIng { get; set; }

        public virtual ICollection<ReporteCajaChica> ReporteCajaChicas { get; set; }
    }
}
