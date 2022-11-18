using System;
using System.Collections.Generic;

namespace Tarjetas.Models.SysTesoreria
{
    public partial class ProgramacionSemanal
    {
        public int CodigoProgramacion { get; set; }
        public short Anio { get; set; }
        public DateTime Fecha { get; set; }
        public byte NumeroSemana { get; set; }
        public byte NumeroDia { get; set; }
        public byte Estado { get; set; }
        public string UsuarioIng { get; set; }
        public DateTime FechaIng { get; set; }
    }
}
