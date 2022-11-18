using System;
using System.Collections.Generic;

namespace Tarjetas.Models.SysTesoreria
{
    public partial class TipoOperacion
    {
        public TipoOperacion()
        {
            Operacions = new HashSet<Operacion>();
        }

        public short CodigoTipoOperacion { get; set; }
        public string Nombre { get; set; }
        public string Id { get; set; }
        public short Signo { get; set; }
        public string Descripcion { get; set; }
        public byte Estado { get; set; }
        public string UsuarioIng { get; set; }
        public DateTime FechaIng { get; set; }

        public virtual ICollection<Operacion> Operacions { get; set; }
    }
}
