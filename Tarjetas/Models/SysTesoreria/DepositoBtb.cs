using System;
using System.Collections.Generic;

namespace Tarjetas.Models.SysTesoreria
{
    public partial class DepositoBtb
    {
        public long CodigoDepositoBtb { get; set; }
        public short CodigoTipoPlanilla { get; set; }
        public short AnioPlanilla { get; set; }
        public byte MesPlanilla { get; set; }
        public short CodigoEmpresa { get; set; }
        public string CodigoEmpleado { get; set; }
        public byte CodigoFrecuenciaPago { get; set; }
        public short CodigoOperacion { get; set; }
        public short AnioOperacion { get; set; }
        public byte SemanaOperacion { get; set; }
        public int CodigoReporte { get; set; }
        public short CodigoBancoDeposito { get; set; }
        public string NumeroCuenta { get; set; }
        public string NumeroBoleta { get; set; }
        public decimal Monto { get; set; }
        public string Observaciones { get; set; }
        public byte Estado { get; set; }
        public string UsuarioIng { get; set; }
        public DateTime FechaIng { get; set; }
        public string UsuarioAct { get; set; }
        public DateTime? FechaAct { get; set; }
        public byte DiaOperacion { get; set; }

        public virtual Empleado CodigoEmp { get; set; }
        public virtual FrecuenciaPago CodigoFrecuenciaPagoNavigation { get; set; }
        public virtual Operacion CodigoOperacionNavigation { get; set; }
        public virtual ReporteCaja CodigoReporteNavigation { get; set; }
        public virtual TipoPlanilla CodigoTipoPlanillaNavigation { get; set; }
        public virtual CuentaBancarium CuentaBancarium { get; set; }
    }
}
