using System;
using System.Collections.Generic;

namespace Tarjetas.Models.SysTesoreria
{
    public partial class TrasladoLiquidacion
    {
        public TrasladoLiquidacion()
        {
            TrasladoLiquidacionDetalles = new HashSet<TrasladoLiquidacionDetalle>();
        }

        public long CodigoTraslado { get; set; }
        public short AnioOperacion { get; set; }
        public byte SemanaOperacion { get; set; }
        public DateTime FechaGeneracion { get; set; }
        public string UsuarioGeneracion { get; set; }
        public DateTime? FechaTraslado { get; set; }
        public string UsuarioTraslado { get; set; }
        public string Observaciones { get; set; }
        public byte CodigoEstado { get; set; }
        public string UsuarioIng { get; set; }
        public DateTime FechaIng { get; set; }
        public string UsuarioAct { get; set; }
        public DateTime? FechaAct { get; set; }

        public virtual EstadoTrasladoLiquidacion CodigoEstadoNavigation { get; set; }
        public virtual ICollection<TrasladoLiquidacionDetalle> TrasladoLiquidacionDetalles { get; set; }
    }
}
