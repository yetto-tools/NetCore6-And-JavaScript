using System;
using System.Collections.Generic;

namespace Tarjetas.Models.SysTesoreria
{
    public partial class TipoDocumento
    {
        public TipoDocumento()
        {
            TransaccionArqueos = new HashSet<TransaccionArqueo>();
            Transaccions = new HashSet<Transaccion>();
        }

        public byte CodigoTipoDocumento { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public byte Estado { get; set; }
        public string UsuarioIng { get; set; }
        public DateTime FechaIng { get; set; }

        public virtual ICollection<TransaccionArqueo> TransaccionArqueos { get; set; }
        public virtual ICollection<Transaccion> Transaccions { get; set; }
    }
}
