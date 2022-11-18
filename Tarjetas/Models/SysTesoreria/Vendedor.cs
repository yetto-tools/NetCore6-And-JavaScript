using System;
using System.Collections.Generic;

namespace Tarjetas.Models.SysTesoreria
{
    public partial class Vendedor
    {
        public Vendedor()
        {
            ConfigVendedorRuta = new HashSet<ConfigVendedorRutum>();
            TransaccionArqueos = new HashSet<TransaccionArqueo>();
            Transaccions = new HashSet<Transaccion>();
            TrasladoLiquidacionDetalles = new HashSet<TrasladoLiquidacionDetalle>();
        }

        public string CodigoVendedor { get; set; }
        public string Cui { get; set; }
        public short? CodigoEmpresa { get; set; }
        public string CodigoEmpleado { get; set; }
        public string NombreCompleto { get; set; }
        public string Descripcion { get; set; }
        public byte Estado { get; set; }
        public string UsuarioIng { get; set; }
        public DateTime FechaIng { get; set; }

        public virtual Empleado CodigoEmp { get; set; }
        public virtual Persona CuiNavigation { get; set; }
        public virtual ICollection<ConfigVendedorRutum> ConfigVendedorRuta { get; set; }
        public virtual ICollection<TransaccionArqueo> TransaccionArqueos { get; set; }
        public virtual ICollection<Transaccion> Transaccions { get; set; }
        public virtual ICollection<TrasladoLiquidacionDetalle> TrasladoLiquidacionDetalles { get; set; }
    }
}
