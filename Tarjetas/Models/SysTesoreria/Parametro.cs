using System;
using System.Collections.Generic;

namespace Tarjetas.Models.SysTesoreria
{
    public partial class Parametro
    {
        public Parametro()
        {
            DetalleParametros = new HashSet<DetalleParametro>();
        }

        public short CodigoParametro { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public byte Estado { get; set; }
        public string UsuarioIng { get; set; }
        public DateTime FechaIng { get; set; }

        public virtual ICollection<DetalleParametro> DetalleParametros { get; set; }
    }
}
