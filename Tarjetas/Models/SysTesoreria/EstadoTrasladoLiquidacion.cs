using System;
using System.Collections.Generic;

namespace Tarjetas.Models.SysTesoreria
{
    public partial class EstadoTrasladoLiquidacion
    {
        public EstadoTrasladoLiquidacion()
        {
            TrasladoLiquidacions = new HashSet<TrasladoLiquidacion>();
        }

        public byte CodigoEstadoTraslado { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public byte Estado { get; set; }
        public string UsuarioIng { get; set; }
        public DateTime FechaIng { get; set; }

        public virtual ICollection<TrasladoLiquidacion> TrasladoLiquidacions { get; set; }
    }
}
