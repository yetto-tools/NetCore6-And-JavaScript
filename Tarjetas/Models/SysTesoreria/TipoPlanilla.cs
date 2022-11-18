using System;
using System.Collections.Generic;

namespace Tarjetas.Models.SysTesoreria
{
    public partial class TipoPlanilla
    {
        public TipoPlanilla()
        {
            DepositoBtbs = new HashSet<DepositoBtb>();
            PagosYDescuentos = new HashSet<PagosYDescuento>();
            Transaccions = new HashSet<Transaccion>();
        }

        public short CodigoTipoPlanilla { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public byte Estado { get; set; }
        public string UsuarioIng { get; set; }
        public DateTime FechaIng { get; set; }

        public virtual ICollection<DepositoBtb> DepositoBtbs { get; set; }
        public virtual ICollection<PagosYDescuento> PagosYDescuentos { get; set; }
        public virtual ICollection<Transaccion> Transaccions { get; set; }
    }
}
