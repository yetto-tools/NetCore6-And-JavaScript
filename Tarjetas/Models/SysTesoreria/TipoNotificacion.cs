using System;
using System.Collections.Generic;

namespace Tarjetas.Models.SysTesoreria
{
    public partial class TipoNotificacion
    {
        public short CodigoTipoNotificacion { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public byte Estado { get; set; }
        public string UsuarioIng { get; set; }
        public DateTime FechaIng { get; set; }
        public string UsuarioAct { get; set; }
        public DateTime? FechaAct { get; set; }
    }
}
