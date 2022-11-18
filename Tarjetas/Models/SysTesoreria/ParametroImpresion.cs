using System;
using System.Collections.Generic;

namespace Tarjetas.Models.SysTesoreria
{
    public partial class ParametroImpresion
    {
        public short CodigoConfiguracion { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public string NombreImpresora { get; set; }
        public short NumeroCopias { get; set; }
        public byte Estado { get; set; }
        public string UsuarioIng { get; set; }
        public DateTime FechaIng { get; set; }
        public string Ip { get; set; }
        public int Puerto { get; set; }
    }
}
