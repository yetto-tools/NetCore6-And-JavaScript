using System;
using System.Collections.Generic;

namespace Tarjetas.Models.SysTesoreria
{
    public partial class Secuencium
    {
        public Secuencium()
        {
            SecuenciaDetalles = new HashSet<SecuenciaDetalle>();
        }

        public short CodigoSecuencia { get; set; }
        public short CodigoSistema { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public byte Estado { get; set; }
        public string UsuarioIng { get; set; }
        public DateTime FechaIng { get; set; }

        public virtual Sistema CodigoSistemaNavigation { get; set; }
        public virtual ICollection<SecuenciaDetalle> SecuenciaDetalles { get; set; }
    }
}
