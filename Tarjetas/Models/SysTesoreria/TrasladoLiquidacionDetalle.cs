using System;
using System.Collections.Generic;

namespace Tarjetas.Models.SysTesoreria
{
    public partial class TrasladoLiquidacionDetalle
    {
        public long CodigoTransaccion { get; set; }
        public long? CodigoTransaccionAnt { get; set; }
        public long CodigoTraslado { get; set; }
        public short? CodigoEmpresa { get; set; }
        public DateTime FechaOperacion { get; set; }
        public byte DiaOperacion { get; set; }
        public string CodigoVendedor { get; set; }
        public short Ruta { get; set; }
        public short CodigoCanalVenta { get; set; }
        public decimal Monto { get; set; }
        public byte CodigoTipoTraslado { get; set; }
        public byte Estado { get; set; }
        public string UsuarioIng { get; set; }
        public DateTime FechaIng { get; set; }
        public string UsuarioAct { get; set; }
        public DateTime? FechaAct { get; set; }

        public virtual CanalVentum CodigoCanalVentaNavigation { get; set; }
        public virtual Empresa CodigoEmpresaNavigation { get; set; }
        public virtual Transaccion CodigoTransaccionAntNavigation { get; set; }
        public virtual Transaccion CodigoTransaccionNavigation { get; set; }
        public virtual TrasladoLiquidacion CodigoTrasladoNavigation { get; set; }
        public virtual Vendedor CodigoVendedorNavigation { get; set; }
        public virtual Rutum RutaNavigation { get; set; }
    }
}
