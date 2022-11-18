using System;
using System.Collections.Generic;

namespace Tarjetas.Models.SysTesoreria
{
    public partial class SaldosIniciale
    {
        public int CodigoSaldoInicial { get; set; }
        public short CodigoOperacion { get; set; }
        public short CodigoCategoriaEntidad { get; set; }
        public string CodigoEntidad { get; set; }
        public decimal Monto { get; set; }
        public short AnioOperacion { get; set; }
        public byte SemanaOperacion { get; set; }
        public int CodigoReporte { get; set; }
        public string Descripcion { get; set; }
        public byte CodigoEstado { get; set; }
        public string UsuarioIng { get; set; }
        public DateTime FechaIng { get; set; }
        public string UsuarioAct { get; set; }
        public DateTime? FechaAct { get; set; }

        public virtual EntidadCategorium CodigoCategoriaEntidadNavigation { get; set; }
        public virtual Operacion CodigoOperacionNavigation { get; set; }
        public virtual ReporteCaja CodigoReporteNavigation { get; set; }
    }
}
