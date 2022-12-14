using System;
using System.Collections.Generic;

namespace Tarjetas.Models.SysTesoreria
{
    public partial class Empleado
    {
        public Empleado()
        {
            DepositoBtbs = new HashSet<DepositoBtb>();
            EmpleadoHists = new HashSet<EmpleadoHist>();
            Suspensions = new HashSet<Suspension>();
            Vendedors = new HashSet<Vendedor>();
        }

        public short CodigoEmpresa { get; set; }
        public string CodigoEmpleado { get; set; }
        public string CodigoTipoIdentificacion { get; set; }
        public string Cui { get; set; }
        public string Nit { get; set; }
        public string CorreoElectronico { get; set; }
        public string NumeroAfiliacion { get; set; }
        public byte EmpleadoExterno { get; set; }
        public short CodigoArea { get; set; }
        public short CodigoSeccion { get; set; }
        public short CodigoPuesto { get; set; }
        public short CodigoTipoCuenta { get; set; }
        public short CodigoUbicacion { get; set; }
        public string NumeroCuenta { get; set; }
        public decimal MontoDevengado { get; set; }
        public byte CodigoJornada { get; set; }
        public byte CodigoFrecuenciaPago { get; set; }
        public byte Igss { get; set; }
        public byte BonoDeLey { get; set; }
        public byte RetencionIsr { get; set; }
        public DateTime FechaIngreso { get; set; }
        public DateTime? FechaEgreso { get; set; }
        public short? CodigoMotivoBaja { get; set; }
        public string Observaciones { get; set; }
        public short CodigoEstado { get; set; }
        public string UsuarioIng { get; set; }
        public DateTime FechaIng { get; set; }
        public string UsuarioAct { get; set; }
        public DateTime? FechaAct { get; set; }
        public byte BackToBack { get; set; }
        public byte Actualizado { get; set; }
        public decimal MontoDescuentoPrestamo { get; set; }
        public byte SaldoPrestamo { get; set; }
        public decimal SalarioDiario { get; set; }
        public byte EnPlanilla { get; set; }
        public decimal BonoDecreto372001 { get; set; }
        public byte CodigoTipoBtb { get; set; }
        public string Foto { get; set; }
        public byte PagoPendiente { get; set; }

        public virtual Area CodigoAreaNavigation { get; set; }
        public virtual Empresa CodigoEmpresaNavigation { get; set; }
        public virtual EstadoEmpleado CodigoEstadoNavigation { get; set; }
        public virtual FrecuenciaPago CodigoFrecuenciaPagoNavigation { get; set; }
        public virtual Jornadum CodigoJornadaNavigation { get; set; }
        public virtual MotivoBaja CodigoMotivoBajaNavigation { get; set; }
        public virtual Puesto CodigoPuestoNavigation { get; set; }
        public virtual Seccion CodigoSeccionNavigation { get; set; }
        public virtual TipoBtb CodigoTipoBtbNavigation { get; set; }
        public virtual TipoCuentum CodigoTipoCuentaNavigation { get; set; }
        public virtual Ubicacion CodigoUbicacionNavigation { get; set; }
        public virtual Persona CuiNavigation { get; set; }
        public virtual ICollection<DepositoBtb> DepositoBtbs { get; set; }
        public virtual ICollection<EmpleadoHist> EmpleadoHists { get; set; }
        public virtual ICollection<Suspension> Suspensions { get; set; }
        public virtual ICollection<Vendedor> Vendedors { get; set; }
    }
}
