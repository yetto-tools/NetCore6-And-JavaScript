using System;
using System.Collections.Generic;

namespace Tarjetas.Models.SysTesoreria
{
    public partial class EstadoDepuracionEspeciales2
    {
        public EstadoDepuracionEspeciales2()
        {
            TrasladoDetalleEspeciales2s = new HashSet<TrasladoDetalleEspeciales2>();
        }

        public byte CodigoEstadoDepuracion { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public byte Estado { get; set; }
        public string UsuarioIng { get; set; }
        public DateTime FechaIng { get; set; }

        public virtual ICollection<TrasladoDetalleEspeciales2> TrasladoDetalleEspeciales2s { get; set; }
    }
}
