using System;
using System.Collections.Generic;

namespace Tarjetas.Models.SysTesoreria
{
    public partial class TipoRutum
    {
        public TipoRutum()
        {
            Ruta = new HashSet<Rutum>();
        }

        public byte CodigoTipoRuta { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public byte Estado { get; set; }
        public string UsuarioIng { get; set; }
        public DateTime FechaIng { get; set; }

        public virtual ICollection<Rutum> Ruta { get; set; }
    }
}
