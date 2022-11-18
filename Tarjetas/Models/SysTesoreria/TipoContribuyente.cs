using System;
using System.Collections.Generic;

namespace Tarjetas.Models.SysTesoreria
{
    public partial class TipoContribuyente
    {
        public TipoContribuyente()
        {
            Contribuyentes = new HashSet<Contribuyente>();
        }

        public short CodigoTipoContribuyente { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public byte Estado { get; set; }
        public string UsuarioIng { get; set; }
        public DateTime FechaIng { get; set; }

        public virtual ICollection<Contribuyente> Contribuyentes { get; set; }
    }
}
