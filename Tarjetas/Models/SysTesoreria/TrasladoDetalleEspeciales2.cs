using System;
using System.Collections.Generic;

namespace Tarjetas.Models.SysTesoreria
{
    public partial class TrasladoDetalleEspeciales2
    {
        public string Serie { get; set; }
        public long Pedido { get; set; }
        public string Empresa { get; set; }
        public int CodigoTraslado { get; set; }
        public string CodigoCliente { get; set; }
        public string NombreCliente { get; set; }
        public string CodigoEntidad { get; set; }
        public string NombreEntidad { get; set; }
        public decimal Monto { get; set; }
        public DateTime FechaGrabado { get; set; }
        public byte Modificacion { get; set; }
        public byte Estado { get; set; }
        public byte CodigoEstadoDepuracion { get; set; }
        public string UsuarioIng { get; set; }
        public DateTime FechaIng { get; set; }
        public string UsuarioAct { get; set; }
        public DateTime? FechaAct { get; set; }

        public virtual EstadoDepuracionEspeciales2 CodigoEstadoDepuracionNavigation { get; set; }
        public virtual TrasladoEspeciales2 CodigoTrasladoNavigation { get; set; }
    }
}
