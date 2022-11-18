using System;
using System.Collections.Generic;

namespace Tarjetas.Models.SysTesoreria
{
    public partial class PagosYDescuento
    {
        public PagosYDescuento()
        {
            CuentaPorCobrarArqueos = new HashSet<CuentaPorCobrarArqueo>();
            CuentaPorCobrars = new HashSet<CuentaPorCobrar>();
        }

        public int CodigoPago { get; set; }
        public short CodigoTipoPlanilla { get; set; }
        public short CodigoEmpresa { get; set; }
        public string CodigoEmpleado { get; set; }
        public byte CodigoFrecuenciaPago { get; set; }
        public short CodigoOperacion { get; set; }
        public short Anio { get; set; }
        public byte Mes { get; set; }
        public int CodigoQuincena { get; set; }
        public byte NumeroSemana { get; set; }
        public decimal Monto { get; set; }
        public byte CodigoEstado { get; set; }
        public string UsuarioIng { get; set; }
        public DateTime FechaIng { get; set; }
        public string UsuarioAct { get; set; }
        public DateTime? FechaAct { get; set; }
        public decimal MontoDescuento { get; set; }
        public decimal MontoCalculado { get; set; }
        public decimal MontoPlanillaExcel { get; set; }

        public virtual FrecuenciaPago CodigoFrecuenciaPagoNavigation { get; set; }
        public virtual Operacion CodigoOperacionNavigation { get; set; }
        public virtual TipoPlanilla CodigoTipoPlanillaNavigation { get; set; }
        public virtual ICollection<CuentaPorCobrarArqueo> CuentaPorCobrarArqueos { get; set; }
        public virtual ICollection<CuentaPorCobrar> CuentaPorCobrars { get; set; }
    }
}
