using System;
using System.Collections.Generic;

namespace Tarjetas.Models.SysTesoreria
{
    public partial class ConfigVendedorRutum
    {
        public int CodigoConfiguracion { get; set; }
        public string CodigoVendedor { get; set; }
        public short CodigoCanalVenta { get; set; }
        public short Ruta { get; set; }
        public string Descripcion { get; set; }
        public byte Estado { get; set; }
        public string UsuarioIng { get; set; }
        public DateTime FechaIng { get; set; }
        public string UsuarioAct { get; set; }
        public DateTime? FechaAct { get; set; }

        public virtual CanalVentum CodigoCanalVentaNavigation { get; set; }
        public virtual Vendedor CodigoVendedorNavigation { get; set; }
        public virtual Rutum RutaNavigation { get; set; }
    }
}
