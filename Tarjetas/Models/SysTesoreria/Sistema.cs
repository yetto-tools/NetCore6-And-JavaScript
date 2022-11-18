using System;
using System.Collections.Generic;

namespace Tarjetas.Models.SysTesoreria
{
    public partial class Sistema
    {
        public Sistema()
        {
            Secuencia = new HashSet<Secuencium>();
            Sitemaps = new HashSet<Sitemap>();
        }

        public short CodigoSistema { get; set; }
        public string Nombre { get; set; }
        public string NombreCorto { get; set; }
        public string Descripcion { get; set; }
        public byte Estado { get; set; }
        public string UsuarioIng { get; set; }
        public DateTime FechaIng { get; set; }

        public virtual ICollection<Secuencium> Secuencia { get; set; }
        public virtual ICollection<Sitemap> Sitemaps { get; set; }
    }
}
