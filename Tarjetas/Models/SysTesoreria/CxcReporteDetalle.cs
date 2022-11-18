using System;
using System.Collections.Generic;

namespace Tarjetas.Models.SysTesoreria
{
    public partial class CxcReporteDetalle
    {
        public int CodigoReporte { get; set; }
        public short AnioOperacion { get; set; }
        public byte SemanaOperacion { get; set; }
        public short CodigoOperacion { get; set; }
        public string CodigoEntidad { get; set; }
        public short CodigoCategoria { get; set; }
        public decimal SaldoInicial { get; set; }
        public decimal MontoDevolucion { get; set; }
        public decimal SaldoFinal { get; set; }
        public string Observaciones { get; set; }
        public byte Estado { get; set; }
        public string UsuarioIng { get; set; }
        public DateTime FechaIng { get; set; }
        public decimal MontoSolicitado { get; set; }

        public virtual EntidadCategorium CodigoCategoriaNavigation { get; set; }
        public virtual Operacion CodigoOperacionNavigation { get; set; }
        public virtual CxcReporte CxcReporte { get; set; }
    }
}
