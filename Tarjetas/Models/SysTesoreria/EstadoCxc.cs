using System;
using System.Collections.Generic;

namespace Tarjetas.Models.SysTesoreria
{
    public partial class EstadoCxc
    {
        public EstadoCxc()
        {
            CuentaPorCobrarArqueos = new HashSet<CuentaPorCobrarArqueo>();
            CuentaPorCobrars = new HashSet<CuentaPorCobrar>();
        }

        public byte CodigoEstadoCxc { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public byte Estado { get; set; }
        public string UsuarioIng { get; set; }
        public DateTime FechaIng { get; set; }

        public virtual ICollection<CuentaPorCobrarArqueo> CuentaPorCobrarArqueos { get; set; }
        public virtual ICollection<CuentaPorCobrar> CuentaPorCobrars { get; set; }
    }
}
