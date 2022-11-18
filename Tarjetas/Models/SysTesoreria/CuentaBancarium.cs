using System;
using System.Collections.Generic;

namespace Tarjetas.Models.SysTesoreria
{
    public partial class CuentaBancarium
    {
        public CuentaBancarium()
        {
            DepositoBtbs = new HashSet<DepositoBtb>();
        }

        public short CodigoBanco { get; set; }
        public string NumeroCuenta { get; set; }
        public byte CodigoTipoCuenta { get; set; }
        public string NombreCuenta { get; set; }
        public string Descripcion { get; set; }
        public byte Tesoreria { get; set; }
        public byte Estado { get; set; }
        public string UsuarioIng { get; set; }
        public DateTime FechaIng { get; set; }
        public short? CodigoEmpresa { get; set; }

        public virtual Banco CodigoBancoNavigation { get; set; }
        public virtual Empresa CodigoEmpresaNavigation { get; set; }
        public virtual ICollection<DepositoBtb> DepositoBtbs { get; set; }
    }
}
