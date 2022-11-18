using System;
using System.Collections.Generic;

namespace Tarjetas.Models.SysTesoreria
{
    public partial class EntidadCategorium
    {
        public EntidadCategorium()
        {
            CuentaPorCobrarArqueoCodigoCategoriaEntidadNavigations = new HashSet<CuentaPorCobrarArqueo>();
            CuentaPorCobrarArqueoCodigoCategoriaNavigations = new HashSet<CuentaPorCobrarArqueo>();
            CuentaPorCobrarCodigoCategoriaEntidadNavigations = new HashSet<CuentaPorCobrar>();
            CuentaPorCobrarCodigoCategoriaNavigations = new HashSet<CuentaPorCobrar>();
            CxcReporteDetalleArqueos = new HashSet<CxcReporteDetalleArqueo>();
            CxcReporteDetalles = new HashSet<CxcReporteDetalle>();
            Entidads = new HashSet<Entidad>();
            ReporteCajaDetalles = new HashSet<ReporteCajaDetalle>();
            SaldosIniciales = new HashSet<SaldosIniciale>();
            TransaccionArqueos = new HashSet<TransaccionArqueo>();
            Transaccions = new HashSet<Transaccion>();
        }

        public short CodigoCategoriaEntidad { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public byte Estado { get; set; }
        public string UsuarioIng { get; set; }
        public DateTime FechaIng { get; set; }
        public byte ExcluirRegistroEntidad { get; set; }
        public byte IncluirConfigOperacion { get; set; }

        public virtual ICollection<CuentaPorCobrarArqueo> CuentaPorCobrarArqueoCodigoCategoriaEntidadNavigations { get; set; }
        public virtual ICollection<CuentaPorCobrarArqueo> CuentaPorCobrarArqueoCodigoCategoriaNavigations { get; set; }
        public virtual ICollection<CuentaPorCobrar> CuentaPorCobrarCodigoCategoriaEntidadNavigations { get; set; }
        public virtual ICollection<CuentaPorCobrar> CuentaPorCobrarCodigoCategoriaNavigations { get; set; }
        public virtual ICollection<CxcReporteDetalleArqueo> CxcReporteDetalleArqueos { get; set; }
        public virtual ICollection<CxcReporteDetalle> CxcReporteDetalles { get; set; }
        public virtual ICollection<Entidad> Entidads { get; set; }
        public virtual ICollection<ReporteCajaDetalle> ReporteCajaDetalles { get; set; }
        public virtual ICollection<SaldosIniciale> SaldosIniciales { get; set; }
        public virtual ICollection<TransaccionArqueo> TransaccionArqueos { get; set; }
        public virtual ICollection<Transaccion> Transaccions { get; set; }
    }
}
