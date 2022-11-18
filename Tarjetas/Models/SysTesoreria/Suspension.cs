using System;
using System.Collections.Generic;

namespace Tarjetas.Models.SysTesoreria
{
    public partial class Suspension
    {
        public int CodigoSuspension { get; set; }
        public short CodigoEmpresa { get; set; }
        public string CodigoEmpleado { get; set; }
        public DateTime FechaInicioSuspension { get; set; }
        public DateTime FechaFinSuspension { get; set; }
        public short CodigoMotivoSuspension { get; set; }
        public string Observaciones { get; set; }
        public DateTime? FechaAlta { get; set; }
        public byte Estado { get; set; }
        public string UsuarioIng { get; set; }
        public DateTime FechaIng { get; set; }
        public string UsuarioAct { get; set; }
        public DateTime? FechaAct { get; set; }

        public virtual Empleado CodigoEmp { get; set; }
        public virtual MotivoSuspension CodigoMotivoSuspensionNavigation { get; set; }
    }
}
