using System;
using System.Collections.Generic;

namespace Tarjetas.Models.SysTesoreria
{
    public partial class Empresa
    {
        public Empresa()
        {
            CajaChicas = new HashSet<CajaChica>();
            CuentaBancaria = new HashSet<CuentaBancarium>();
            Empleados = new HashSet<Empleado>();
            TransaccionArqueos = new HashSet<TransaccionArqueo>();
            Transaccions = new HashSet<Transaccion>();
            TrasladoLiquidacionDetalles = new HashSet<TrasladoLiquidacionDetalle>();
            UsuarioEmpresas = new HashSet<UsuarioEmpresa>();
        }

        public short CodigoEmpresa { get; set; }
        public string NombreRazonSocial { get; set; }
        public string NombreComercial { get; set; }
        public string CodigoQsystem { get; set; }
        public string Direccion { get; set; }
        public string Nit { get; set; }
        public byte Estado { get; set; }
        public string UsuarioIng { get; set; }
        public DateTime FechaIng { get; set; }
        public byte Tesoreria { get; set; }
        public string Observaciones { get; set; }
        public string NombreCorto { get; set; }
        public byte CodigoTipoEmpresa { get; set; }

        public virtual TipoEmpresa CodigoTipoEmpresaNavigation { get; set; }
        public virtual ICollection<CajaChica> CajaChicas { get; set; }
        public virtual ICollection<CuentaBancarium> CuentaBancaria { get; set; }
        public virtual ICollection<Empleado> Empleados { get; set; }
        public virtual ICollection<TransaccionArqueo> TransaccionArqueos { get; set; }
        public virtual ICollection<Transaccion> Transaccions { get; set; }
        public virtual ICollection<TrasladoLiquidacionDetalle> TrasladoLiquidacionDetalles { get; set; }
        public virtual ICollection<UsuarioEmpresa> UsuarioEmpresas { get; set; }
    }
}
