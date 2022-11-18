using System;
using System.Collections.Generic;

namespace Tarjetas.Models.SysTesoreria
{
    public partial class EstadoSolicitudCorreccion
    {
        public EstadoSolicitudCorreccion()
        {
            TransaccionArqueos = new HashSet<TransaccionArqueo>();
            TransaccionCajaChicas = new HashSet<TransaccionCajaChica>();
            Transaccions = new HashSet<Transaccion>();
        }

        public byte CodigoEstadoSolicitudCorreccion { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public byte Estado { get; set; }
        public string UsuarioIng { get; set; }
        public DateTime FechaIng { get; set; }
        public string UsuarioAct { get; set; }
        public DateTime? FechaAct { get; set; }

        public virtual ICollection<TransaccionArqueo> TransaccionArqueos { get; set; }
        public virtual ICollection<TransaccionCajaChica> TransaccionCajaChicas { get; set; }
        public virtual ICollection<Transaccion> Transaccions { get; set; }
    }
}
