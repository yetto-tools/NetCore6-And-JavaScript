using System;
using System.Collections.Generic;

namespace Tarjetas.Models.SysTesoreria
{
    public partial class TipoReporte
    {
        public TipoReporte()
        {
            UsuarioTipoReportes = new HashSet<UsuarioTipoReporte>();
        }

        public int CodigoTipoReporte { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public string NombreControlador { get; set; }
        public string NombreAccion { get; set; }
        public byte Pdf { get; set; }
        public byte Excel { get; set; }
        public byte Web { get; set; }
        public byte Estado { get; set; }
        public string UsuarioIng { get; set; }
        public DateTime FechaIng { get; set; }
        public string UsuarioAct { get; set; }
        public DateTime? FechaAct { get; set; }
        public short CodigoCategoria { get; set; }

        public virtual CategoriaReporte CodigoCategoriaNavigation { get; set; }
        public virtual ICollection<UsuarioTipoReporte> UsuarioTipoReportes { get; set; }
    }
}
