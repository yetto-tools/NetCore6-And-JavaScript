using System;
using System.Collections.Generic;

namespace Tarjetas.Models.SysTesoreria
{
    public partial class Cliente
    {
        public string CodigoCliente { get; set; }
        public string NombreCompleto { get; set; }
        public string NombreCorto { get; set; }
        public short CodigoTipoCliente { get; set; }
        public string Descripcion { get; set; }
        public byte Estado { get; set; }
        public string UsuarioIng { get; set; }
        public DateTime FechaIng { get; set; }
        public string CodigoClienteOrigen { get; set; }

        public virtual TipoCliente CodigoTipoClienteNavigation { get; set; }
    }
}
