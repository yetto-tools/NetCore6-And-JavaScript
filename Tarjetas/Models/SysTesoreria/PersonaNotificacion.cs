using System;
using System.Collections.Generic;

namespace Tarjetas.Models.SysTesoreria
{
    public partial class PersonaNotificacion
    {
        public string Cui { get; set; }
        public short CodigoTipoNotificacion { get; set; }
        public byte Estado { get; set; }
        public string UsuarioIng { get; set; }
        public DateTime FechaIng { get; set; }

        public virtual Persona CuiNavigation { get; set; }
    }
}
