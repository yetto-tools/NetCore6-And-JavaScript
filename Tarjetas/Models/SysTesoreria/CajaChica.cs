using System;
using System.Collections.Generic;

namespace Tarjetas.Models.SysTesoreria
{
    public partial class CajaChica
    {
        public CajaChica()
        {
            ReporteCajaChicas = new HashSet<ReporteCajaChica>();
            UsuarioCajaChicas = new HashSet<UsuarioCajaChica>();
        }

        public short CodigoCajaChica { get; set; }
        public short CodigoEmpresa { get; set; }
        public string NombreCajaChica { get; set; }
        public decimal MontoLimite { get; set; }
        public decimal MontoDisponible { get; set; }
        public string NombreConceptoAnticipo { get; set; }
        public byte IncluirEnReporteCajaTesoreria { get; set; }
        public string Observaciones { get; set; }
        public byte Estado { get; set; }
        public string UsuarioIng { get; set; }
        public DateTime FechaIng { get; set; }
        public string UsuarioAct { get; set; }
        public DateTime? FechaAct { get; set; }

        public virtual Empresa CodigoEmpresaNavigation { get; set; }
        public virtual ICollection<ReporteCajaChica> ReporteCajaChicas { get; set; }
        public virtual ICollection<UsuarioCajaChica> UsuarioCajaChicas { get; set; }
    }
}
