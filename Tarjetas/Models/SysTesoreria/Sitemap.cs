using System;
using System.Collections.Generic;

namespace Tarjetas.Models.SysTesoreria
{
    public partial class Sitemap
    {
        public Sitemap()
        {
            RolSitemaps = new HashSet<RolSitemap>();
        }

        public int CodigoSitemap { get; set; }
        public short CodigoSistema { get; set; }
        public string Titulo { get; set; }
        public string Descripcion { get; set; }
        public string NombreController { get; set; }
        public string NombreAction { get; set; }
        public int? CodigoSitemapPadre { get; set; }
        public byte Nivel { get; set; }
        public byte Estado { get; set; }
        public string UsuarioIng { get; set; }
        public DateTime FechaIng { get; set; }
        public string UsuarioAct { get; set; }
        public DateTime? FechaAct { get; set; }

        public virtual Sistema CodigoSistemaNavigation { get; set; }
        public virtual ICollection<RolSitemap> RolSitemaps { get; set; }
    }
}
