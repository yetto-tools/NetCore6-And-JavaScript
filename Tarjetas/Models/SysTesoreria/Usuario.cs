
namespace Tarjetas.Models.SysTesoreria
{
    public partial class Usuario
    {
        public Usuario()
        {
            ConfigUsuarioOperacions = new HashSet<ConfigUsuarioOperacion>();
            UsuarioCajaChicas = new HashSet<UsuarioCajaChica>();
            UsuarioEmpresas = new HashSet<UsuarioEmpresa>();
            UsuarioRols = new HashSet<UsuarioRol>();
            UsuarioTipoReportes = new HashSet<UsuarioTipoReporte>();
        }

        public string IdUsuario { get; set; }
        public string NombreUsuario { get; set; }
        public string Contrasenia { get; set; }
        public string Cui { get; set; }
        public byte SuperAdmin { get; set; }
        public byte Estado { get; set; }
        public string UsuarioIng { get; set; }
        public DateTime FechaIng { get; set; }
        public byte SetSemanaAnt { get; set; }
        public byte SemanaAExcluir { get; set; }

        public virtual Persona CuiNavigation { get; set; }
        public virtual ICollection<ConfigUsuarioOperacion> ConfigUsuarioOperacions { get; set; }
        public virtual ICollection<UsuarioCajaChica> UsuarioCajaChicas { get; set; }
        public virtual ICollection<UsuarioEmpresa> UsuarioEmpresas { get; set; }
        public virtual ICollection<UsuarioRol> UsuarioRols { get; set; }
        public virtual ICollection<UsuarioTipoReporte> UsuarioTipoReportes { get; set; }
    }
}
