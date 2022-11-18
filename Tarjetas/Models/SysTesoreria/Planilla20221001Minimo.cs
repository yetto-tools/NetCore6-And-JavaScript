using System;
using System.Collections.Generic;

namespace Tarjetas.Models.SysTesoreria
{
    public partial class Planilla20221001Minimo
    {
        public string Row { get; set; }
        public string CodigoEmpleado { get; set; }
        public string Nombre { get; set; }
        public string NombreSinTilde { get; set; }
        public string FechaIngreso { get; set; }
        public int? CodEstado { get; set; }
        public string Estado { get; set; }
        public string Cui { get; set; }
        public int? CodTipoCuenta { get; set; }
        public string TipoCuenta { get; set; }
        public string NumeroCuenta { get; set; }
        public string FechaEgreso { get; set; }
        public string CodEmpresa { get; set; }
        public string Empresa { get; set; }
        public string EmpresaSinTilde { get; set; }
        public int? CodArea { get; set; }
        public string Area { get; set; }
        public string AreaSinTilde { get; set; }
        public int? CodSeccion { get; set; }
        public string Seccion { get; set; }
        public string SeccionSinTilde { get; set; }
        public string FechaNacimiento { get; set; }
        public int? Edad { get; set; }
        public string CodGenero { get; set; }
        public string Genero { get; set; }
        public int? CodPuesto { get; set; }
        public string Puesto { get; set; }
        public string PuestoSinTilde { get; set; }
        public string AfiliacionIgss { get; set; }
        public string Nit { get; set; }
        public int? CodHorario { get; set; }
        public string Horario { get; set; }
        public int? CodFrecuenciaPago { get; set; }
        public string FrecuenciaPago { get; set; }
        public string HorasDoblesSabados { get; set; }
        public string DocumentoAusencias { get; set; }
        public string DescuentoSeptimodiaPorAusencias { get; set; }
        public string DescuentoIngresosTarde { get; set; }
    }
}
