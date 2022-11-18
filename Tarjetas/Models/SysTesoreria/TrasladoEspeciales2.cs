using System;
using System.Collections.Generic;

namespace Tarjetas.Models.SysTesoreria
{
    public partial class TrasladoEspeciales2
    {
        public TrasladoEspeciales2()
        {
            TrasladoDetalleEspeciales2s = new HashSet<TrasladoDetalleEspeciales2>();
        }

        public int CodigoTraslado { get; set; }
        public DateTime FechaOperacion { get; set; }
        public DateTime? FechaRecepcion { get; set; }
        public string UsuarioRecepcion { get; set; }
        public string ObservacionesRecepcion { get; set; }
        public byte CodigoEstado { get; set; }
        public string UsuarioIng { get; set; }
        public DateTime FechaIng { get; set; }
        public string UsuarioAct { get; set; }
        public DateTime? FechaAct { get; set; }

        public virtual EstadoTrasladoEspeciales2 CodigoEstadoNavigation { get; set; }
        public virtual ICollection<TrasladoDetalleEspeciales2> TrasladoDetalleEspeciales2s { get; set; }
    }
}
