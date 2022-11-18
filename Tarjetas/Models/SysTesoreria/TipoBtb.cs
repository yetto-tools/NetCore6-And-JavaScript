using System;
using System.Collections.Generic;

namespace Tarjetas.Models.SysTesoreria
{
    public partial class TipoBtb
    {
        public TipoBtb()
        {
            Empleados = new HashSet<Empleado>();
        }

        public byte CodigoTipoBtb { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public byte Estado { get; set; }
        public string UsuarioIng { get; set; }
        public DateTime FechaIng { get; set; }
        public byte Tesoreria { get; set; }
        public string TextoComprobante { get; set; }

        public virtual ICollection<Empleado> Empleados { get; set; }
    }
}
