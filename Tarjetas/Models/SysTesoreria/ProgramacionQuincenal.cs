using System;
using System.Collections.Generic;

namespace Tarjetas.Models.SysTesoreria
{
    public partial class ProgramacionQuincenal
    {
        public int CodigoProgramacion { get; set; }
        public short Anio { get; set; }
        public byte NumeroMes { get; set; }
        public byte NumeroQuincena { get; set; }
        public int CodigoQuincena { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public byte Estado { get; set; }
        public string UsuarioIng { get; set; }
        public DateTime FechaIng { get; set; }
    }
}
