using System;
using System.Collections.Generic;

namespace Tarjetas.Models.SysTesoreria
{
    public partial class Contribuyente
    {
        public Contribuyente()
        {
            TransaccionArqueoNitEmpresaConcedeIvaNavigations = new HashSet<TransaccionArqueo>();
            TransaccionArqueoNitProveedorNavigations = new HashSet<TransaccionArqueo>();
            TransaccionCajaChicas = new HashSet<TransaccionCajaChica>();
            TransaccionNitEmpresaConcedeIvaNavigations = new HashSet<Transaccion>();
            TransaccionNitProveedorNavigations = new HashSet<Transaccion>();
        }

        public string Nit { get; set; }
        public string Nombre { get; set; }
        public short CodigoTipoContribuyente { get; set; }
        public string Descripcion { get; set; }
        public byte Estado { get; set; }
        public string UsuarioIng { get; set; }
        public DateTime FechaIng { get; set; }

        public virtual TipoContribuyente CodigoTipoContribuyenteNavigation { get; set; }
        public virtual EmpresaConcedeIva EmpresaConcedeIva { get; set; }
        public virtual ICollection<TransaccionArqueo> TransaccionArqueoNitEmpresaConcedeIvaNavigations { get; set; }
        public virtual ICollection<TransaccionArqueo> TransaccionArqueoNitProveedorNavigations { get; set; }
        public virtual ICollection<TransaccionCajaChica> TransaccionCajaChicas { get; set; }
        public virtual ICollection<Transaccion> TransaccionNitEmpresaConcedeIvaNavigations { get; set; }
        public virtual ICollection<Transaccion> TransaccionNitProveedorNavigations { get; set; }
    }
}
