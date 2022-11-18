using System;
using System.Collections.Generic;

namespace Tarjetas.Models.SysTesoreria
{
    public partial class FrecuenciaPago
    {
        public FrecuenciaPago()
        {
            DepositoBtbs = new HashSet<DepositoBtb>();
            EmpleadoHists = new HashSet<EmpleadoHist>();
            Empleados = new HashSet<Empleado>();
            PagosYDescuentos = new HashSet<PagosYDescuento>();
            TransaccionArqueos = new HashSet<TransaccionArqueo>();
            Transaccions = new HashSet<Transaccion>();
        }

        public byte CodigoFrecuenciaPago { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public byte Estado { get; set; }
        public string UsuarioIng { get; set; }
        public DateTime FechaIng { get; set; }

        public virtual ICollection<DepositoBtb> DepositoBtbs { get; set; }
        public virtual ICollection<EmpleadoHist> EmpleadoHists { get; set; }
        public virtual ICollection<Empleado> Empleados { get; set; }
        public virtual ICollection<PagosYDescuento> PagosYDescuentos { get; set; }
        public virtual ICollection<TransaccionArqueo> TransaccionArqueos { get; set; }
        public virtual ICollection<Transaccion> Transaccions { get; set; }
    }
}
