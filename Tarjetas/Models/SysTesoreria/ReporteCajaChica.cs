using System;
using System.Collections.Generic;

namespace Tarjetas.Models.SysTesoreria
{
    public partial class ReporteCajaChica
    {
        public ReporteCajaChica()
        {
            TransaccionCajaChicas = new HashSet<TransaccionCajaChica>();
        }

        public int CodigoReporte { get; set; }
        public short CodigoCajaChica { get; set; }
        public short AnioOperacion { get; set; }
        public byte SemanaOperacion { get; set; }
        public DateTime FechaGeneracion { get; set; }
        public string Observaciones { get; set; }
        public byte CodigoEstado { get; set; }
        public string UsuarioIng { get; set; }
        public DateTime FechaIng { get; set; }
        public string UsuarioAct { get; set; }
        public DateTime? FechaAct { get; set; }
        public decimal MontoSaldoInicial { get; set; }
        public DateTime? FechaRecepcionReembolso { get; set; }
        public string UsuarioRecepcionReembolso { get; set; }
        public byte ReembolsoRecibido { get; set; }
        public decimal MontoReembolsoCalculado { get; set; }
        public decimal MontoReembolso { get; set; }
        public string ObservacionesRecepcionReembolso { get; set; }
        public decimal MontoAsignado { get; set; }
        public byte Arqueo { get; set; }

        public virtual CajaChica CodigoCajaChicaNavigation { get; set; }
        public virtual EstadoReporteCajaChica CodigoEstadoNavigation { get; set; }
        public virtual ICollection<TransaccionCajaChica> TransaccionCajaChicas { get; set; }
    }
}
