using System;
using System.Collections.Generic;

namespace Tarjetas.Models.SysTesoreria
{
    public partial class MotivoSuspension
    {
        public MotivoSuspension()
        {
            Suspensions = new HashSet<Suspension>();
        }

        public short CodigoMotivoSuspension { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public byte Estado { get; set; }
        public string UsuarioIng { get; set; }
        public DateTime FechaIng { get; set; }

        public virtual ICollection<Suspension> Suspensions { get; set; }
    }
}
