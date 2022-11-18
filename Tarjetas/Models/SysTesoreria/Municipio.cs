using System;
using System.Collections.Generic;

namespace Tarjetas.Models.SysTesoreria
{
    public partial class Municipio
    {
        public Municipio()
        {
            PersonaHists = new HashSet<PersonaHist>();
            Personas = new HashSet<Persona>();
        }

        public short CodigoDepartamento { get; set; }
        public short CodigoMunicipio { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public byte Estado { get; set; }
        public string UsuarioIng { get; set; }
        public DateTime FechaIng { get; set; }

        public virtual Departamento CodigoDepartamentoNavigation { get; set; }
        public virtual ICollection<PersonaHist> PersonaHists { get; set; }
        public virtual ICollection<Persona> Personas { get; set; }
    }
}
