using System;
using System.Collections.Generic;

namespace Tarjetas.Models.SysTesoreria
{
    public partial class CategoriaReporte
    {
        public CategoriaReporte()
        {
            TipoReportes = new HashSet<TipoReporte>();
        }

        public short CodigoCategoria { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public byte Estado { get; set; }
        public string UsuarioIng { get; set; }
        public DateTime FechaIng { get; set; }

        public virtual ICollection<TipoReporte> TipoReportes { get; set; }
    }
}
