using System;
using System.Collections.Generic;

namespace Tarjetas.Models.SysTesoreria
{
    public partial class ReporteCaja
    {
        public ReporteCaja()
        {
            CuentaPorCobrarArqueos = new HashSet<CuentaPorCobrarArqueo>();
            CuentaPorCobrars = new HashSet<CuentaPorCobrar>();
            CxcReportes = new HashSet<CxcReporte>();
            DepositoBtbs = new HashSet<DepositoBtb>();
            ReporteCajaDetalles = new HashSet<ReporteCajaDetalle>();
            SaldosIniciales = new HashSet<SaldosIniciale>();
            TransaccionArqueos = new HashSet<TransaccionArqueo>();
            Transaccions = new HashSet<Transaccion>();
        }

        public int CodigoReporte { get; set; }
        public short Anio { get; set; }
        public byte NumeroSemana { get; set; }
        public string Observaciones { get; set; }
        public byte CodigoEstado { get; set; }
        public string UsuarioIng { get; set; }
        public DateTime FechaIng { get; set; }
        public string UsuarioAct { get; set; }
        public DateTime? FechaAct { get; set; }
        public byte Arqueo { get; set; }

        public virtual EstadoReporteCaja CodigoEstadoNavigation { get; set; }
        public virtual ICollection<CuentaPorCobrarArqueo> CuentaPorCobrarArqueos { get; set; }
        public virtual ICollection<CuentaPorCobrar> CuentaPorCobrars { get; set; }
        public virtual ICollection<CxcReporte> CxcReportes { get; set; }
        public virtual ICollection<DepositoBtb> DepositoBtbs { get; set; }
        public virtual ICollection<ReporteCajaDetalle> ReporteCajaDetalles { get; set; }
        public virtual ICollection<SaldosIniciale> SaldosIniciales { get; set; }
        public virtual ICollection<TransaccionArqueo> TransaccionArqueos { get; set; }
        public virtual ICollection<Transaccion> Transaccions { get; set; }
    }
}
