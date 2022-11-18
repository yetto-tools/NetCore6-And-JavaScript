using System;
using System.Collections.Generic;

namespace Tarjetas.Models.SysTesoreria
{
    public partial class TransaccionCajaChica
    {
        public TransaccionCajaChica()
        {
            SolicitudCorreccionCajaChicaCodigoTransaccionCorrectaNavigations = new HashSet<SolicitudCorreccionCajaChica>();
        }

        public long CodigoTransaccion { get; set; }
        public int? CodigoReporte { get; set; }
        public string CodigoTipoTransaccion { get; set; }
        public short CodigoCajaChica { get; set; }
        public short CodigoOperacion { get; set; }
        public string NitProveedor { get; set; }
        public string SerieFactura { get; set; }
        public long NumeroDocumento { get; set; }
        public DateTime FechaDocumento { get; set; }
        public string Descripcion { get; set; }
        public DateTime FechaOperacion { get; set; }
        public short AnioOperacion { get; set; }
        public byte SemanaOperacion { get; set; }
        public byte DiaOperacion { get; set; }
        public decimal Monto { get; set; }
        public string Observaciones { get; set; }
        public string ObservacionesAnulacion { get; set; }
        public string UsuarioAnulacion { get; set; }
        public DateTime? FechaAnulacion { get; set; }
        public byte ExcluirFactura { get; set; }
        public byte? CodigoMotivoExclusion { get; set; }
        public string ObservacionesExclusion { get; set; }
        public string UsuarioRevision { get; set; }
        public DateTime? FechaRevision { get; set; }
        public short? CodigoEstado { get; set; }
        public string UsuarioIng { get; set; }
        public DateTime FechaIng { get; set; }
        public string UsuarioAct { get; set; }
        public DateTime? FechaAct { get; set; }
        public string CodigoSeguridad { get; set; }
        public long? CodigoTransaccionAnt { get; set; }
        public byte Correccion { get; set; }
        public byte CodigoEstadoSolicitudCorreccion { get; set; }
        public byte CodigoEstadoRecepcion { get; set; }
        public string ObservacionesRecepcion { get; set; }
        public byte CodigoTipoDocumento { get; set; }

        public virtual EstadoSolicitudCorreccion CodigoEstadoSolicitudCorreccionNavigation { get; set; }
        public virtual MotivoExclusion CodigoMotivoExclusionNavigation { get; set; }
        public virtual Operacion CodigoOperacionNavigation { get; set; }
        public virtual ReporteCajaChica CodigoReporteNavigation { get; set; }
        public virtual Contribuyente NitProveedorNavigation { get; set; }
        public virtual SolicitudCorreccionCajaChica SolicitudCorreccionCajaChicaCodigoTransaccionNavigation { get; set; }
        public virtual ICollection<SolicitudCorreccionCajaChica> SolicitudCorreccionCajaChicaCodigoTransaccionCorrectaNavigations { get; set; }
    }
}
