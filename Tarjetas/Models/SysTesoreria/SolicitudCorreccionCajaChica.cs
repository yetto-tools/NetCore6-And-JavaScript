using System;
using System.Collections.Generic;

namespace Tarjetas.Models.SysTesoreria
{
    public partial class SolicitudCorreccionCajaChica
    {
        public long CodigoTransaccion { get; set; }
        public long? CodigoTransaccionCorrecta { get; set; }
        public byte CodigoTipoCorreccion { get; set; }
        public string ObservacionesSolicitud { get; set; }
        public string ObservacionesAprobacion { get; set; }
        public byte Resultado { get; set; }
        public string UsuarioAprobacion { get; set; }
        public DateTime? FechaAprobacion { get; set; }
        public byte Estado { get; set; }
        public string UsuarioIng { get; set; }
        public DateTime FechaIng { get; set; }
        public string UsuarioAct { get; set; }
        public DateTime? FechaAct { get; set; }

        public virtual TransaccionCajaChica CodigoTransaccionCorrectaNavigation { get; set; }
        public virtual TransaccionCajaChica CodigoTransaccionNavigation { get; set; }
    }
}
