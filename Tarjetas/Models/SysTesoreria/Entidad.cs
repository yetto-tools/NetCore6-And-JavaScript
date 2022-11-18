using System;
using System.Collections.Generic;

namespace Tarjetas.Models.SysTesoreria
{
    public partial class Entidad
    {
        public Entidad()
        {
            EmpresaConcedeIvas = new HashSet<EmpresaConcedeIva>();
            EntidadProveedors = new HashSet<EntidadProveedor>();
        }

        public int CodigoEntidad { get; set; }
        public short CodigoCategoriaEntidad { get; set; }
        public string NombreCompleto { get; set; }
        public string Descripcion { get; set; }
        public byte Estado { get; set; }
        public string UsuarioIng { get; set; }
        public DateTime FechaIng { get; set; }
        public short CodigoOperacion { get; set; }
        public string UsuarioAct { get; set; }
        public DateTime? FechaAct { get; set; }
        public byte ConcedeIva { get; set; }

        public virtual EntidadCategorium CodigoCategoriaEntidadNavigation { get; set; }
        public virtual Operacion CodigoOperacionNavigation { get; set; }
        public virtual ICollection<EmpresaConcedeIva> EmpresaConcedeIvas { get; set; }
        public virtual ICollection<EntidadProveedor> EntidadProveedors { get; set; }
    }
}
