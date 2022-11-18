using System;
using System.Collections.Generic;

namespace Tarjetas.Models.SysTesoreria
{
    public partial class CuentaPorCobrarArqueo
    {
        public long Correlativo { get; set; }
        public long CodigoCxc { get; set; }
        public byte CodigoTipoCxc { get; set; }
        public short CodigoCategoriaEntidad { get; set; }
        public short CodigoCategoria { get; set; }
        public string CodigoEntidad { get; set; }
        public string NombreEntidad { get; set; }
        public DateTime? FechaPrestamo { get; set; }
        public DateTime? FechaInicioPago { get; set; }
        public short AnioOperacion { get; set; }
        public byte SemanaOperacion { get; set; }
        public decimal Monto { get; set; }
        public string Observaciones { get; set; }
        public long CodigoTransaccion { get; set; }
        public int CodigoReporte { get; set; }
        public int? CodigoPlanilla { get; set; }
        public short CodigoOperacion { get; set; }
        public byte CodigoEstado { get; set; }
        public string UsuarioIng { get; set; }
        public DateTime FechaIng { get; set; }
        public string UsuarioAct { get; set; }
        public DateTime? FechaAct { get; set; }
        public byte CargaInicial { get; set; }
        public int? CodigoPago { get; set; }

        public virtual TransaccionArqueo Codigo { get; set; }
        public virtual EntidadCategorium CodigoCategoriaEntidadNavigation { get; set; }
        public virtual EntidadCategorium CodigoCategoriaNavigation { get; set; }
        public virtual EstadoCxc CodigoEstadoNavigation { get; set; }
        public virtual Operacion CodigoOperacionNavigation { get; set; }
        public virtual PagosYDescuento CodigoPagoNavigation { get; set; }
        public virtual ReporteCaja CodigoReporteNavigation { get; set; }
        public virtual TipoCxc CodigoTipoCxcNavigation { get; set; }
    }
}
