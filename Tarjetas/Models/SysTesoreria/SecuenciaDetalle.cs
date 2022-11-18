using System;
using System.Collections.Generic;

namespace Tarjetas.Models.SysTesoreria
{
    public partial class SecuenciaDetalle
    {
        public int CodigoSecuenciaDet { get; set; }
        public short CodigoSecuencia { get; set; }
        public short Anio { get; set; }
        public long SigValor { get; set; }
        public byte Incremento { get; set; }

        public virtual Secuencium CodigoSecuenciaNavigation { get; set; }
    }
}
