using System;
using System.Collections.Generic;

namespace Tarjetas.Models.SysTesoreria
{
    public partial class PlanillaOctubre2022
    {
        public int? Correlativo { get; set; }
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string NombreSinTilde { get; set; }
        public string FechaIngreso { get; set; }
        public string CodEstatus { get; set; }
        public string Estatus { get; set; }
        public string Cui { get; set; }
        public string CodTipoCuenta { get; set; }
        public string TipoCuenta { get; set; }
        public string CuentaBancaria { get; set; }
        public string FechaEgreso { get; set; }
        public byte? CodEmpresa { get; set; }
        public string Empresa { get; set; }
        public string EmpresaSinTilde { get; set; }
        public byte? CodArea { get; set; }
        public string Area { get; set; }
        public string AreaSinTilde { get; set; }
        public byte? CodSeccion { get; set; }
        public string Seccion { get; set; }
        public string SeccionSinTilde { get; set; }
        public string FechaNacimiento { get; set; }
        public string CodGenero { get; set; }
        public string Genero { get; set; }
        public string CodPuesto { get; set; }
        public string Puesto { get; set; }
        public string PuestoSinTilde { get; set; }
        public string Afiliacion { get; set; }
        public string Nit { get; set; }
        public string CodHorario { get; set; }
        public string Horario { get; set; }
        public string CodFrecuenciaPago { get; set; }
        public string FrecuenciaPago { get; set; }
    }
}
