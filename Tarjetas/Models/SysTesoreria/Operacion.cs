using System;
using System.Collections.Generic;

namespace Tarjetas.Models.SysTesoreria
{
    public partial class Operacion
    {
        public Operacion()
        {
            ConfigUsuarioOperacions = new HashSet<ConfigUsuarioOperacion>();
            CuentaPorCobrarArqueos = new HashSet<CuentaPorCobrarArqueo>();
            CuentaPorCobrars = new HashSet<CuentaPorCobrar>();
            CxcReporteDetalleArqueos = new HashSet<CxcReporteDetalleArqueo>();
            CxcReporteDetalles = new HashSet<CxcReporteDetalle>();
            DepositoBtbs = new HashSet<DepositoBtb>();
            Entidads = new HashSet<Entidad>();
            PagosYDescuentos = new HashSet<PagosYDescuento>();
            ReporteCajaDetalles = new HashSet<ReporteCajaDetalle>();
            SaldosIniciales = new HashSet<SaldosIniciale>();
            TransaccionArqueoCodigoOperacionCajaNavigations = new HashSet<TransaccionArqueo>();
            TransaccionArqueoCodigoOperacionNavigations = new HashSet<TransaccionArqueo>();
            TransaccionCajaChicas = new HashSet<TransaccionCajaChica>();
            TransaccionCodigoOperacionCajaNavigations = new HashSet<Transaccion>();
            TransaccionCodigoOperacionNavigations = new HashSet<Transaccion>();
        }

        public short CodigoOperacion { get; set; }
        public short? CodigoOperacionPadre { get; set; }
        public short CodigoCategoriaOperacion { get; set; }
        public short CodigoTipoOperacion { get; set; }
        public string NombreOperacion { get; set; }
        public string NombreReporteCaja { get; set; }
        public string Descripcion { get; set; }
        public byte HabilitarParaCaja { get; set; }
        public byte Estado { get; set; }
        public string UsuarioIng { get; set; }
        public DateTime FechaIng { get; set; }
        public short? CodigoConcepto { get; set; }
        public byte AplicaCajaChica { get; set; }
        public byte ConfigEntidadGenerica { get; set; }
        public byte Grupo01 { get; set; }
        public byte Grupo02 { get; set; }
        public byte Grupo03 { get; set; }

        public virtual CategoriaOperacion CodigoCategoriaOperacionNavigation { get; set; }
        public virtual TipoOperacion CodigoTipoOperacionNavigation { get; set; }
        public virtual ICollection<ConfigUsuarioOperacion> ConfigUsuarioOperacions { get; set; }
        public virtual ICollection<CuentaPorCobrarArqueo> CuentaPorCobrarArqueos { get; set; }
        public virtual ICollection<CuentaPorCobrar> CuentaPorCobrars { get; set; }
        public virtual ICollection<CxcReporteDetalleArqueo> CxcReporteDetalleArqueos { get; set; }
        public virtual ICollection<CxcReporteDetalle> CxcReporteDetalles { get; set; }
        public virtual ICollection<DepositoBtb> DepositoBtbs { get; set; }
        public virtual ICollection<Entidad> Entidads { get; set; }
        public virtual ICollection<PagosYDescuento> PagosYDescuentos { get; set; }
        public virtual ICollection<ReporteCajaDetalle> ReporteCajaDetalles { get; set; }
        public virtual ICollection<SaldosIniciale> SaldosIniciales { get; set; }
        public virtual ICollection<TransaccionArqueo> TransaccionArqueoCodigoOperacionCajaNavigations { get; set; }
        public virtual ICollection<TransaccionArqueo> TransaccionArqueoCodigoOperacionNavigations { get; set; }
        public virtual ICollection<TransaccionCajaChica> TransaccionCajaChicas { get; set; }
        public virtual ICollection<Transaccion> TransaccionCodigoOperacionCajaNavigations { get; set; }
        public virtual ICollection<Transaccion> TransaccionCodigoOperacionNavigations { get; set; }
    }
}
