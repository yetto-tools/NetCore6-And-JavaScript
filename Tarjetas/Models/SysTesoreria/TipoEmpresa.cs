using System;
using System.Collections.Generic;

namespace Tarjetas.Models.SysTesoreria
{
    public partial class TipoEmpresa
    {
        public TipoEmpresa()
        {
            Empresas = new HashSet<Empresa>();
        }

        public byte CodigoTipoEmpresa { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public byte Estado { get; set; }
        public string UsuarioIng { get; set; }
        public DateTime FechaIng { get; set; }

        public virtual ICollection<Empresa> Empresas { get; set; }
    }
}
