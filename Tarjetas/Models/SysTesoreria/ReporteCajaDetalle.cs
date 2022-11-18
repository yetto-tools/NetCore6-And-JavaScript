using System;
using System.Collections.Generic;

namespace Tarjetas.Models.SysTesoreria
{
    public partial class ReporteCajaDetalle
    {
        public long CodigoDetalleReporte { get; set; }
        public int CodigoReporte { get; set; }
        public short CodigoConcepto { get; set; }
        public short CodigoOperacion { get; set; }
        public byte CodigoTipoOperacion { get; set; }
        public short CodigoCategoriaEntidad { get; set; }
        public string CodigoEntidad { get; set; }
        public string NombreEntidad { get; set; }
        public string NombreEntidadCompleto { get; set; }
        public long? CodigoTransaccion { get; set; }
        public decimal SaldoAnterior { get; set; }
        public decimal MontoLunes { get; set; }
        public decimal MontoMartes { get; set; }
        public decimal MontoMiercoles { get; set; }
        public decimal MontoJueves { get; set; }
        public decimal MontoViernes { get; set; }
        public decimal MontoSabado { get; set; }
        public decimal MontoDevoluciones { get; set; }
        public byte Estado { get; set; }
        public string UsuarioIng { get; set; }
        public DateTime FechaIng { get; set; }
        public string UsuarioAct { get; set; }
        public DateTime? FechaAct { get; set; }
        public decimal MontoDomingo { get; set; }

        public virtual EntidadCategorium CodigoCategoriaEntidadNavigation { get; set; }
        public virtual Concepto CodigoConceptoNavigation { get; set; }
        public virtual Operacion CodigoOperacionNavigation { get; set; }
        public virtual ReporteCaja CodigoReporteNavigation { get; set; }
        public virtual Transaccion CodigoTransaccionNavigation { get; set; }
    }
}
