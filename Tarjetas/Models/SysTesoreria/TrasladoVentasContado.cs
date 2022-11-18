using System;
using System.Collections.Generic;

namespace Tarjetas.Models.SysTesoreria
{
    public partial class TrasladoVentasContado
    {
        public int CodigoTraslado { get; set; }
        public DateTime FechaOperacion { get; set; }
        public decimal MontoEfectivo { get; set; }
        public decimal MontoCheques { get; set; }
        public decimal MontoTransferencia { get; set; }
        public decimal Monto { get; set; }
        public DateTime? FechaRecepcion { get; set; }
        public string UsuarioRecepcion { get; set; }
        public string ObservacionesGeneracion { get; set; }
        public string ObservacionesRecepcion { get; set; }
        public short AnioOperacion { get; set; }
        public byte SemanaOperacion { get; set; }
        public byte DiaOperacion { get; set; }
        public short CodigoEstado { get; set; }
        public string UsuarioIng { get; set; }
        public DateTime FechaIng { get; set; }
        public string UsuarioAct { get; set; }
        public DateTime? FechaAct { get; set; }

        public virtual EstadoTrasladoCaja CodigoEstadoNavigation { get; set; }
    }
}
