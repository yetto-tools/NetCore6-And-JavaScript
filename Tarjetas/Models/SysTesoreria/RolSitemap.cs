using System;
using System.Collections.Generic;

namespace Tarjetas.Models.SysTesoreria
{
    public partial class RolSitemap
    {
        public int CodigoRol { get; set; }
        public int CodigoSitemap { get; set; }
        public byte Estado { get; set; }
        public string UsuarioIng { get; set; }
        public DateTime FechaIng { get; set; }

        public virtual Rol CodigoRolNavigation { get; set; }
        public virtual Sitemap CodigoSitemapNavigation { get; set; }
    }
}
