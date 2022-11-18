using System;
using System.Collections.Generic;

namespace Tarjetas.Models.SysTesoreria
{
    public partial class TransaccionCajaChicaCheque
    {
        public long CodigoTransaccion { get; set; }
        public short CodigoBanco { get; set; }
        public string NumeroCheque { get; set; }
        public decimal Monto { get; set; }
        public DateTime FechaCheque { get; set; }
        public byte Estado { get; set; }
        public string UsuarioIng { get; set; }
        public DateTime FechaIng { get; set; }
        public string UsuarioAct { get; set; }
        public DateTime? FechaAct { get; set; }

        public virtual Banco CodigoBancoNavigation { get; set; }
    }
}
