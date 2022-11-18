using System;
using System.Collections.Generic;

namespace Tarjetas.Models.SysTesoreria
{
    public partial class CategoriaOperacion
    {
        public CategoriaOperacion()
        {
            Operacions = new HashSet<Operacion>();
        }

        public short CodigoCategoriaOperacion { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public byte Estado { get; set; }
        public string UsuarioIng { get; set; }
        public DateTime FechaIng { get; set; }

        public virtual ICollection<Operacion> Operacions { get; set; }
    }
}
