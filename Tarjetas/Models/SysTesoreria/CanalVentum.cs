using System;
using System.Collections.Generic;

namespace Tarjetas.Models.SysTesoreria
{
    public partial class CanalVentum
    {
        public CanalVentum()
        {
            ConfigVendedorRuta = new HashSet<ConfigVendedorRutum>();
            Ruta = new HashSet<Rutum>();
            Transaccions = new HashSet<Transaccion>();
            TrasladoLiquidacionDetalles = new HashSet<TrasladoLiquidacionDetalle>();
        }

        public short CodigoCanalVenta { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public byte Estado { get; set; }
        public string UsuarioIng { get; set; }
        public DateTime FechaIng { get; set; }
        public short CodigoCategoriaEntidad { get; set; }

        public virtual ICollection<ConfigVendedorRutum> ConfigVendedorRuta { get; set; }
        public virtual ICollection<Rutum> Ruta { get; set; }
        public virtual ICollection<Transaccion> Transaccions { get; set; }
        public virtual ICollection<TrasladoLiquidacionDetalle> TrasladoLiquidacionDetalles { get; set; }
    }
}
