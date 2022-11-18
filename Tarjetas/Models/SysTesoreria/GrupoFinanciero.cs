using System;
using System.Collections.Generic;

namespace Tarjetas.Models.SysTesoreria
{
    public partial class GrupoFinanciero
    {
        public GrupoFinanciero()
        {
            Bancos = new HashSet<Banco>();
        }

        public short CodigoGrupoFinanciero { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public byte Estado { get; set; }
        public string UsuarioIng { get; set; }
        public DateTime FechaIng { get; set; }

        public virtual ICollection<Banco> Bancos { get; set; }
    }
}
