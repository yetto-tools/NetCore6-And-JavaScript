using System;
using System.Collections.Generic;

namespace Tarjetas.Models.SysTesoreria
{
    public partial class ConfigSueldosIndirecto
    {
        public short Anio { get; set; }
        public byte Mes { get; set; }
        public decimal Monto { get; set; }
        public byte Estado { get; set; }
        public string UsuarioIng { get; set; }
        public DateTime FechaIng { get; set; }
    }
}
