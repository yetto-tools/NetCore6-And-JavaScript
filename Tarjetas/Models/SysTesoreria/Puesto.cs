using System;
using System.Collections.Generic;

namespace Tarjetas.Models.SysTesoreria
{
    public partial class Puesto
    {
        public Puesto()
        {
            EmpleadoHists = new HashSet<EmpleadoHist>();
            Empleados = new HashSet<Empleado>();
        }

        public short CodigoPuesto { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public byte Estado { get; set; }
        public string UsuarioIng { get; set; }
        public DateTime FechaIng { get; set; }

        public virtual ICollection<EmpleadoHist> EmpleadoHists { get; set; }
        public virtual ICollection<Empleado> Empleados { get; set; }
    }
}
