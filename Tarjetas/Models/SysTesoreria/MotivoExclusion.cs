using System;
using System.Collections.Generic;

namespace Tarjetas.Models.SysTesoreria
{
    public partial class MotivoExclusion
    {
        public MotivoExclusion()
        {
            TransaccionCajaChicas = new HashSet<TransaccionCajaChica>();
        }

        public byte CodigoMotivoExclusion { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public byte Estado { get; set; }
        public string UsuarioIng { get; set; }
        public DateTime FechaIng { get; set; }

        public virtual ICollection<TransaccionCajaChica> TransaccionCajaChicas { get; set; }
    }
}
