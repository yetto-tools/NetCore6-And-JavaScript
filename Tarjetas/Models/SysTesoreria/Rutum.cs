using System;
using System.Collections.Generic;

namespace Tarjetas.Models.SysTesoreria
{
    public partial class Rutum
    {
        public Rutum()
        {
            ConfigVendedorRuta = new HashSet<ConfigVendedorRutum>();
            TrasladoLiquidacionDetalles = new HashSet<TrasladoLiquidacionDetalle>();
        }

        public short Ruta { get; set; }
        public string Nombre { get; set; }
        public string NombreCorto { get; set; }
        public string Descripcion { get; set; }
        public byte CodigoTipoRuta { get; set; }
        public short CodigoCanalVenta { get; set; }
        public byte MigracionCompleta { get; set; }
        public byte Estado { get; set; }
        public string UsuarioIng { get; set; }
        public DateTime FechaIng { get; set; }
        public string UsuarioAct { get; set; }
        public DateTime? FechaAct { get; set; }

        public virtual CanalVentum CodigoCanalVentaNavigation { get; set; }
        public virtual TipoRutum CodigoTipoRutaNavigation { get; set; }
        public virtual ICollection<ConfigVendedorRutum> ConfigVendedorRuta { get; set; }
        public virtual ICollection<TrasladoLiquidacionDetalle> TrasladoLiquidacionDetalles { get; set; }
    }
}
