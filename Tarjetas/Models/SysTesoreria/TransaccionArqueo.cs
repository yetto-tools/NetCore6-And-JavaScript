using System;
using System.Collections.Generic;

namespace Tarjetas.Models.SysTesoreria
{
    public partial class TransaccionArqueo
    {
        public TransaccionArqueo()
        {
            CuentaPorCobrarArqueos = new HashSet<CuentaPorCobrarArqueo>();
        }

        public long CodigoTransaccion { get; set; }
        public int CodigoReporte { get; set; }
        public string CodigoSeguridad { get; set; }
        public short? CodigoEmpresa { get; set; }
        public short CodigoOperacion { get; set; }
        public short CodigoOperacionCaja { get; set; }
        public byte CodigoTipoCxc { get; set; }
        public long? CodigoCxc { get; set; }
        public short CodigoArea { get; set; }
        public short CodigoCategoriaEntidad { get; set; }
        public string CodigoEntidad { get; set; }
        public byte CodigoTipoOperacion { get; set; }
        public string CodigoTipoTransaccion { get; set; }
        public byte CodigoTipoDocumento { get; set; }
        public byte Efectivo { get; set; }
        public byte Deposito { get; set; }
        public byte Cheque { get; set; }
        public string NitProveedor { get; set; }
        public string SerieFactura { get; set; }
        public int? NumeroDocumento { get; set; }
        public DateTime? FechaDocumento { get; set; }
        public byte ConcederIva { get; set; }
        public string NitEmpresaConcedeIva { get; set; }
        public short? CodigoBancoDeposito { get; set; }
        public string NumeroCuenta { get; set; }
        public string NumeroBoleta { get; set; }
        public long NumeroRecibo { get; set; }
        public DateTime FechaRecibo { get; set; }
        public DateTime FechaOperacion { get; set; }
        public short AnioOperacion { get; set; }
        public byte SemanaOperacion { get; set; }
        public byte DiaOperacion { get; set; }
        public int? CodigoBoletaComision { get; set; }
        public short Ruta { get; set; }
        public string CodigoVendedor { get; set; }
        public byte SemanaComision { get; set; }
        public short AnioComision { get; set; }
        public decimal MontoEfectivo { get; set; }
        public decimal MontoCheques { get; set; }
        public decimal Monto { get; set; }
        public byte CodigoFrecuenciaPago { get; set; }
        public byte CodigoTipoPago { get; set; }
        public long CodigoPlanilla { get; set; }
        public long CodigoPagoPlanilla { get; set; }
        public short AnioPlanilla { get; set; }
        public byte MesPlanilla { get; set; }
        public byte SemanaPlanilla { get; set; }
        public int CodigoQuincenaPlanilla { get; set; }
        public byte CodigoBonoExtra { get; set; }
        public byte TipoEspeciales1 { get; set; }
        public string Observaciones { get; set; }
        public DateTime? FechaConfirmacion { get; set; }
        public string MotivoAnulacion { get; set; }
        public string UsuarioAnulacion { get; set; }
        public DateTime? FechaAnulacion { get; set; }
        public short CodigoEstado { get; set; }
        public string UsuarioIng { get; set; }
        public DateTime FechaIng { get; set; }
        public string UsuarioAct { get; set; }
        public DateTime? FechaAct { get; set; }
        public short AnioSueldoIndirecto { get; set; }
        public byte MesSueldoIndirecto { get; set; }
        public byte ComplementoConta { get; set; }
        public byte Revisado { get; set; }
        public byte ResultadoRevision { get; set; }
        public string ObservacionesRevision { get; set; }
        public string UsuarioRevision { get; set; }
        public DateTime? FechaRevision { get; set; }
        public byte Liquidacion { get; set; }
        public byte Correccion { get; set; }
        public byte CodigoTipoDocDeposito { get; set; }
        public string NumeroVoucher { get; set; }
        public byte CodigoEstadoSolicitudCorreccion { get; set; }
        public long? CodigoTransaccionAnt { get; set; }
        public string NombreProveedor { get; set; }

        public virtual Area CodigoAreaNavigation { get; set; }
        public virtual Banco CodigoBancoDepositoNavigation { get; set; }
        public virtual BonoExtra CodigoBonoExtraNavigation { get; set; }
        public virtual EntidadCategorium CodigoCategoriaEntidadNavigation { get; set; }
        public virtual CuentaPorCobrar CodigoCxcNavigation { get; set; }
        public virtual Empresa CodigoEmpresaNavigation { get; set; }
        public virtual EstadoTransaccion CodigoEstadoNavigation { get; set; }
        public virtual EstadoSolicitudCorreccion CodigoEstadoSolicitudCorreccionNavigation { get; set; }
        public virtual FrecuenciaPago CodigoFrecuenciaPagoNavigation { get; set; }
        public virtual Operacion CodigoOperacionCajaNavigation { get; set; }
        public virtual Operacion CodigoOperacionNavigation { get; set; }
        public virtual ReporteCaja CodigoReporteNavigation { get; set; }
        public virtual TipoCxc CodigoTipoCxcNavigation { get; set; }
        public virtual TipoDocumento CodigoTipoDocumentoNavigation { get; set; }
        public virtual TipoPago CodigoTipoPagoNavigation { get; set; }
        public virtual Vendedor CodigoVendedorNavigation { get; set; }
        public virtual Contribuyente NitEmpresaConcedeIvaNavigation { get; set; }
        public virtual Contribuyente NitProveedorNavigation { get; set; }
        public virtual ICollection<CuentaPorCobrarArqueo> CuentaPorCobrarArqueos { get; set; }
    }
}
