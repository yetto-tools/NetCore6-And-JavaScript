using System;
using System.Collections.Generic;

namespace Tarjetas.Models.SysTesoreria
{
    public partial class Rol
    {
        public Rol()
        {
            RolSitemaps = new HashSet<RolSitemap>();
            UsuarioRols = new HashSet<UsuarioRol>();
        }

        public int CodigoRol { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public byte Estado { get; set; }
        public string UsuarioIng { get; set; }
        public DateTime FechaIng { get; set; }

        public virtual ICollection<RolSitemap> RolSitemaps { get; set; }
        public virtual ICollection<UsuarioRol> UsuarioRols { get; set; }
    }
}
