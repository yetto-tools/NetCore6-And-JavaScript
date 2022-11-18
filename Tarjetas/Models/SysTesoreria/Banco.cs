using System;
using System.Collections.Generic;

namespace Tarjetas.Models.SysTesoreria
{
    public partial class Banco
    {
        public Banco()
        {
            CuentaBancaria = new HashSet<CuentaBancarium>();
            TransaccionArqueos = new HashSet<TransaccionArqueo>();
            TransaccionCajaChicaCheques = new HashSet<TransaccionCajaChicaCheque>();
            Transaccions = new HashSet<Transaccion>();
        }

        public short CodigoBanco { get; set; }
        public short CodigoGrupoFinanciero { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public byte Estado { get; set; }
        public string UsuarioIng { get; set; }
        public DateTime FechaIng { get; set; }
        public byte Tesoreria { get; set; }

        public virtual GrupoFinanciero CodigoGrupoFinancieroNavigation { get; set; }
        public virtual ICollection<CuentaBancarium> CuentaBancaria { get; set; }
        public virtual ICollection<TransaccionArqueo> TransaccionArqueos { get; set; }
        public virtual ICollection<TransaccionCajaChicaCheque> TransaccionCajaChicaCheques { get; set; }
        public virtual ICollection<Transaccion> Transaccions { get; set; }
    }
}
