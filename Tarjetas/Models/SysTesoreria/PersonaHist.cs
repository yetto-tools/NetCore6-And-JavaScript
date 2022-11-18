using System;
using System.Collections.Generic;

namespace Tarjetas.Models.SysTesoreria
{
    public partial class PersonaHist
    {
        public long CodigoHistorial { get; set; }
        public string Cui { get; set; }
        public string PrimerNombre { get; set; }
        public string SegundoNombre { get; set; }
        public string TercerNombre { get; set; }
        public string PrimerApellido { get; set; }
        public string SegundoApellido { get; set; }
        public string ApellidoCasada { get; set; }
        public string NombreCompleto { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string CodigoGenero { get; set; }
        public string CorreoElectronico { get; set; }
        public short CodigoDepartamentoResidencia { get; set; }
        public short CodigoMunicipioResidencia { get; set; }
        public byte Zona { get; set; }
        public string DireccionResidencia { get; set; }
        public short CodigoEstado { get; set; }
        public string UsuarioIng { get; set; }
        public DateTime FechaIng { get; set; }
        public string UsuarioAct { get; set; }
        public DateTime? FechaAct { get; set; }
        public byte NoIncluidoEnPlanilla { get; set; }
        public short? CodigoArea { get; set; }

        public virtual Municipio Codigo { get; set; }
        public virtual Area CodigoAreaNavigation { get; set; }
    }
}
