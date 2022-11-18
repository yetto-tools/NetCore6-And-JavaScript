using System;
using System.Collections.Generic;

namespace Tarjetas.Models.SysTesoreria
{
    public partial class EstadoTrasladoEspeciales2
    {
        public EstadoTrasladoEspeciales2()
        {
            TrasladoEspeciales2s = new HashSet<TrasladoEspeciales2>();
        }

        public byte CodigoEstadoTraslado { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public byte Estado { get; set; }
        public string UsuarioIng { get; set; }
        public DateTime FechaIng { get; set; }

        public virtual ICollection<TrasladoEspeciales2> TrasladoEspeciales2s { get; set; }
    }
}
