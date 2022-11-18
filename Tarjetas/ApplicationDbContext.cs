using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Tarjetas.Models.SysTesoreria;

namespace Tarjetas
{
    public partial class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options): base(options)
        {
        }

        public virtual DbSet<Area> Areas { get; set; }
        public virtual DbSet<Banco> Bancos { get; set; }
        public virtual DbSet<BonoExtra> BonoExtras { get; set; }
        public virtual DbSet<CajaChica> CajaChicas { get; set; }
        public virtual DbSet<CanalVentum> CanalVenta { get; set; }
        public virtual DbSet<CategoriaOperacion> CategoriaOperacions { get; set; }
        public virtual DbSet<CategoriaReporte> CategoriaReportes { get; set; }
        public virtual DbSet<Cliente> Clientes { get; set; }
        public virtual DbSet<Concepto> Conceptos { get; set; }
        public virtual DbSet<ConfigSueldosIndirecto> ConfigSueldosIndirectos { get; set; }
        public virtual DbSet<ConfigUsuarioOperacion> ConfigUsuarioOperacions { get; set; }
        public virtual DbSet<ConfigVendedorRutum> ConfigVendedorRuta { get; set; }
        public virtual DbSet<Contribuyente> Contribuyentes { get; set; }
        public virtual DbSet<CuentaBancarium> CuentaBancaria { get; set; }
        public virtual DbSet<CuentaPorCobrar> CuentaPorCobrars { get; set; }
        public virtual DbSet<CuentaPorCobrarArqueo> CuentaPorCobrarArqueos { get; set; }
        public virtual DbSet<CxcReporte> CxcReportes { get; set; }
        public virtual DbSet<CxcReporteDetalle> CxcReporteDetalles { get; set; }
        public virtual DbSet<CxcReporteDetalleArqueo> CxcReporteDetalleArqueos { get; set; }
        public virtual DbSet<Departamento> Departamentos { get; set; }
        public virtual DbSet<DepositoBtb> DepositoBtbs { get; set; }
        public virtual DbSet<DetalleParametro> DetalleParametros { get; set; }
        public virtual DbSet<Empleado> Empleados { get; set; }
        public virtual DbSet<EmpleadoHist> EmpleadoHists { get; set; }
        public virtual DbSet<Empresa> Empresas { get; set; }
        public virtual DbSet<EmpresaConcedeIva> EmpresaConcedeIvas { get; set; }
        public virtual DbSet<Entidad> Entidads { get; set; }
        public virtual DbSet<EntidadCategorium> EntidadCategoria { get; set; }
        public virtual DbSet<EntidadProveedor> EntidadProveedors { get; set; }
        public virtual DbSet<EstadoCxc> EstadoCxcs { get; set; }
        public virtual DbSet<EstadoDepuracionEspeciales2> EstadoDepuracionEspeciales2s { get; set; }
        public virtual DbSet<EstadoEmpleado> EstadoEmpleados { get; set; }
        public virtual DbSet<EstadoReporteCaja> EstadoReporteCajas { get; set; }
        public virtual DbSet<EstadoReporteCajaChica> EstadoReporteCajaChicas { get; set; }
        public virtual DbSet<EstadoReporteCxc> EstadoReporteCxcs { get; set; }
        public virtual DbSet<EstadoSolicitudCorreccion> EstadoSolicitudCorreccions { get; set; }
        public virtual DbSet<EstadoTransaccion> EstadoTransaccions { get; set; }
        public virtual DbSet<EstadoTrasladoCaja> EstadoTrasladoCajas { get; set; }
        public virtual DbSet<EstadoTrasladoEspeciales2> EstadoTrasladoEspeciales2s { get; set; }
        public virtual DbSet<EstadoTrasladoLiquidacion> EstadoTrasladoLiquidacions { get; set; }
        public virtual DbSet<FormaPago> FormaPagos { get; set; }
        public virtual DbSet<FrecuenciaPago> FrecuenciaPagos { get; set; }
        public virtual DbSet<GrupoFinanciero> GrupoFinancieros { get; set; }
        public virtual DbSet<Jornadum> Jornada { get; set; }
        public virtual DbSet<MotivoBaja> MotivoBajas { get; set; }
        public virtual DbSet<MotivoExclusion> MotivoExclusions { get; set; }
        public virtual DbSet<MotivoSuspension> MotivoSuspensions { get; set; }
        public virtual DbSet<Municipio> Municipios { get; set; }
        public virtual DbSet<Operacion> Operacions { get; set; }
        public virtual DbSet<OtrosIngreso> OtrosIngresos { get; set; }
        public virtual DbSet<PagosYDescuento> PagosYDescuentos { get; set; }
        public virtual DbSet<Parametro> Parametros { get; set; }
        public virtual DbSet<ParametroImpresion> ParametroImpresions { get; set; }
        public virtual DbSet<Persona> Personas { get; set; }
        public virtual DbSet<PersonaHist> PersonaHists { get; set; }
        public virtual DbSet<PersonaNotificacion> PersonaNotificacions { get; set; }
        public virtual DbSet<Planilla20221001Minimo> Planilla20221001Minimos { get; set; }
        public virtual DbSet<PlanillaOctubre2022> PlanillaOctubre2022s { get; set; }
        public virtual DbSet<ProgramacionQuincenal> ProgramacionQuincenals { get; set; }
        public virtual DbSet<ProgramacionSemanal> ProgramacionSemanals { get; set; }
        public virtual DbSet<Puesto> Puestos { get; set; }
        public virtual DbSet<ReporteCaja> ReporteCajas { get; set; }
        public virtual DbSet<ReporteCajaChica> ReporteCajaChicas { get; set; }
        public virtual DbSet<ReporteCajaDetalle> ReporteCajaDetalles { get; set; }
        public virtual DbSet<Rol> Rols { get; set; }
        public virtual DbSet<RolSitemap> RolSitemaps { get; set; }
        public virtual DbSet<Rutum> Ruta { get; set; }
        public virtual DbSet<SaldosIniciale> SaldosIniciales { get; set; }
        public virtual DbSet<Seccion> Seccions { get; set; }
        public virtual DbSet<SecuenciaDetalle> SecuenciaDetalles { get; set; }
        public virtual DbSet<Secuencium> Secuencia { get; set; }
        public virtual DbSet<Sistema> Sistemas { get; set; }
        public virtual DbSet<Sitemap> Sitemaps { get; set; }
        public virtual DbSet<SolicitudCorreccion> SolicitudCorreccions { get; set; }
        public virtual DbSet<SolicitudCorreccionCajaChica> SolicitudCorreccionCajaChicas { get; set; }
        public virtual DbSet<Suspension> Suspensions { get; set; }
        public virtual DbSet<TipoBtb> TipoBtbs { get; set; }
        public virtual DbSet<TipoCliente> TipoClientes { get; set; }
        public virtual DbSet<TipoContribuyente> TipoContribuyentes { get; set; }
        public virtual DbSet<TipoCuentum> TipoCuenta { get; set; }
        public virtual DbSet<TipoCxc> TipoCxcs { get; set; }
        public virtual DbSet<TipoDocumento> TipoDocumentos { get; set; }
        public virtual DbSet<TipoEmpresa> TipoEmpresas { get; set; }
        public virtual DbSet<TipoNotificacion> TipoNotificacions { get; set; }
        public virtual DbSet<TipoOperacion> TipoOperacions { get; set; }
        public virtual DbSet<TipoPago> TipoPagos { get; set; }
        public virtual DbSet<TipoPlanilla> TipoPlanillas { get; set; }
        public virtual DbSet<TipoReporte> TipoReportes { get; set; }
        public virtual DbSet<TipoReporte1> TipoReportes1 { get; set; }
        public virtual DbSet<TipoRutum> TipoRuta { get; set; }
        public virtual DbSet<Transaccion> Transaccions { get; set; }
        public virtual DbSet<TransaccionArqueo> TransaccionArqueos { get; set; }
        public virtual DbSet<TransaccionCajaChica> TransaccionCajaChicas { get; set; }
        public virtual DbSet<TransaccionCajaChicaCheque> TransaccionCajaChicaCheques { get; set; }
        public virtual DbSet<TrasladoDetalleEspeciales2> TrasladoDetalleEspeciales2s { get; set; }
        public virtual DbSet<TrasladoEspeciales2> TrasladoEspeciales2s { get; set; }
        public virtual DbSet<TrasladoLiquidacion> TrasladoLiquidacions { get; set; }
        public virtual DbSet<TrasladoLiquidacionDetalle> TrasladoLiquidacionDetalles { get; set; }
        public virtual DbSet<TrasladoVentasContado> TrasladoVentasContados { get; set; }
        public virtual DbSet<Ubicacion> Ubicacions { get; set; }
        public virtual DbSet<Usuario> Usuarios { get; set; }
        public virtual DbSet<UsuarioCajaChica> UsuarioCajaChicas { get; set; }
        public virtual DbSet<UsuarioEmpresa> UsuarioEmpresas { get; set; }
        public virtual DbSet<UsuarioRol> UsuarioRols { get; set; }
        public virtual DbSet<UsuarioTipoReporte> UsuarioTipoReportes { get; set; }
        public virtual DbSet<Vendedor> Vendedors { get; set; }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    if (!optionsBuilder.IsConfigured)
        //    {
        //        optionsBuilder.UseSqlServer("Name=ConnectionStrings:DeploySysTesoreria");
        //    }
        //}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Area>(entity =>
            {
                entity.HasKey(e => e.CodigoArea)
                    .HasName("PK_RRHH_AREA");

                entity.ToTable("area", "db_rrhh");

                entity.HasIndex(e => e.Nombre, "UQ_RRHH_AREA_NOMBRE")
                    .IsUnique();

                entity.Property(e => e.CodigoArea)
                    .ValueGeneratedNever()
                    .HasColumnName("codigo_area");

                entity.Property(e => e.CodigoCategoria).HasColumnName("codigo_categoria");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("descripcion");

                entity.Property(e => e.Estado).HasColumnName("estado");

                entity.Property(e => e.FechaIng)
                    .HasColumnType("datetime")
                    .HasColumnName("fecha_ing");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("nombre");

                entity.Property(e => e.NombreCategoria)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nombre_categoria");

                entity.Property(e => e.UsuarioIng)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("usuario_ing");
            });

            modelBuilder.Entity<Banco>(entity =>
            {
                entity.HasKey(e => e.CodigoBanco)
                    .HasName("PK_ADMON_BANCO");

                entity.ToTable("banco", "db_admon");

                entity.HasIndex(e => e.Nombre, "UQ_ADMON_BANCO_NOMBRE")
                    .IsUnique();

                entity.Property(e => e.CodigoBanco)
                    .ValueGeneratedNever()
                    .HasColumnName("codigo_banco");

                entity.Property(e => e.CodigoGrupoFinanciero).HasColumnName("codigo_grupo_financiero");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("descripcion");

                entity.Property(e => e.Estado).HasColumnName("estado");

                entity.Property(e => e.FechaIng)
                    .HasColumnType("datetime")
                    .HasColumnName("fecha_ing");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("nombre");

                entity.Property(e => e.Tesoreria).HasColumnName("tesoreria");

                entity.Property(e => e.UsuarioIng)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("usuario_ing");

                entity.HasOne(d => d.CodigoGrupoFinancieroNavigation)
                    .WithMany(p => p.Bancos)
                    .HasForeignKey(d => d.CodigoGrupoFinanciero)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ADMON_BANCO_GRUPOF");
            });

            modelBuilder.Entity<BonoExtra>(entity =>
            {
                entity.HasKey(e => e.CodigoBonoExtra)
                    .HasName("PK_SIT_BONOEXTRA");

                entity.ToTable("bono_extra", "db_tesoreria");

                entity.HasIndex(e => e.Nombre, "UQ_SIT_BONOEXTRA_NOMBRE")
                    .IsUnique();

                entity.Property(e => e.CodigoBonoExtra).HasColumnName("codigo_bono_extra");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("descripcion");

                entity.Property(e => e.Estado).HasColumnName("estado");

                entity.Property(e => e.FechaIng)
                    .HasColumnType("datetime")
                    .HasColumnName("fecha_ing");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("nombre");

                entity.Property(e => e.UsuarioIng)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("usuario_ing");
            });

            modelBuilder.Entity<CajaChica>(entity =>
            {
                entity.HasKey(e => e.CodigoCajaChica)
                    .HasName("PK_ADMON_CAJACHICA");

                entity.ToTable("caja_chica", "db_admon");

                entity.Property(e => e.CodigoCajaChica)
                    .ValueGeneratedNever()
                    .HasColumnName("codigo_caja_chica");

                entity.Property(e => e.CodigoEmpresa).HasColumnName("codigo_empresa");

                entity.Property(e => e.Estado).HasColumnName("estado");

                entity.Property(e => e.FechaAct)
                    .HasColumnType("datetime")
                    .HasColumnName("fecha_act");

                entity.Property(e => e.FechaIng)
                    .HasColumnType("datetime")
                    .HasColumnName("fecha_ing");

                entity.Property(e => e.IncluirEnReporteCajaTesoreria).HasColumnName("incluir_en_reporte_caja_tesoreria");

                entity.Property(e => e.MontoDisponible)
                    .HasColumnType("decimal(15, 2)")
                    .HasColumnName("monto_disponible");

                entity.Property(e => e.MontoLimite)
                    .HasColumnType("decimal(15, 2)")
                    .HasColumnName("monto_limite");

                entity.Property(e => e.NombreCajaChica)
                    .IsRequired()
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("nombre_caja_chica");

                entity.Property(e => e.NombreConceptoAnticipo)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("nombre_concepto_anticipo");

                entity.Property(e => e.Observaciones)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("observaciones");

                entity.Property(e => e.UsuarioAct)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("usuario_act");

                entity.Property(e => e.UsuarioIng)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("usuario_ing");

                entity.HasOne(d => d.CodigoEmpresaNavigation)
                    .WithMany(p => p.CajaChicas)
                    .HasForeignKey(d => d.CodigoEmpresa)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ADMON_CAJACHICA_EMPRESA");
            });

            modelBuilder.Entity<CanalVentum>(entity =>
            {
                entity.HasKey(e => e.CodigoCanalVenta)
                    .HasName("PK_VENTAS_CANALVENTA");

                entity.ToTable("canal_venta", "db_ventas");

                entity.HasIndex(e => e.Nombre, "UQ_VENTAS_CANALVENTA_NOMBRE")
                    .IsUnique();

                entity.Property(e => e.CodigoCanalVenta)
                    .ValueGeneratedNever()
                    .HasColumnName("codigo_canal_venta");

                entity.Property(e => e.CodigoCategoriaEntidad).HasColumnName("codigo_categoria_entidad");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("descripcion");

                entity.Property(e => e.Estado).HasColumnName("estado");

                entity.Property(e => e.FechaIng)
                    .HasColumnType("datetime")
                    .HasColumnName("fecha_ing");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("nombre");

                entity.Property(e => e.UsuarioIng)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("usuario_ing");
            });

            modelBuilder.Entity<CategoriaOperacion>(entity =>
            {
                entity.HasKey(e => e.CodigoCategoriaOperacion)
                    .HasName("PK_SIT_CATEGOP");

                entity.ToTable("categoria_operacion", "db_tesoreria");

                entity.HasIndex(e => e.Nombre, "UQ_SIT_CATEGOP_NOMBRE")
                    .IsUnique();

                entity.Property(e => e.CodigoCategoriaOperacion)
                    .ValueGeneratedNever()
                    .HasColumnName("codigo_categoria_operacion");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("descripcion");

                entity.Property(e => e.Estado).HasColumnName("estado");

                entity.Property(e => e.FechaIng)
                    .HasColumnType("datetime")
                    .HasColumnName("fecha_ing");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("nombre");

                entity.Property(e => e.UsuarioIng)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("usuario_ing");
            });

            modelBuilder.Entity<CategoriaReporte>(entity =>
            {
                entity.HasKey(e => e.CodigoCategoria)
                    .HasName("PK_ADMON_CATREPORTE");

                entity.ToTable("categoria_reporte", "db_admon");

                entity.Property(e => e.CodigoCategoria)
                    .ValueGeneratedNever()
                    .HasColumnName("codigo_categoria");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("descripcion");

                entity.Property(e => e.Estado).HasColumnName("estado");

                entity.Property(e => e.FechaIng)
                    .HasColumnType("datetime")
                    .HasColumnName("fecha_ing");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("nombre");

                entity.Property(e => e.UsuarioIng)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("usuario_ing");
            });

            modelBuilder.Entity<Cliente>(entity =>
            {
                entity.HasKey(e => e.CodigoCliente)
                    .HasName("PK_VENTAS_CLIENTE");

                entity.ToTable("cliente", "db_ventas");

                entity.Property(e => e.CodigoCliente)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("codigo_cliente");

                entity.Property(e => e.CodigoClienteOrigen)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("codigo_cliente_origen");

                entity.Property(e => e.CodigoTipoCliente).HasColumnName("codigo_tipo_cliente");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("descripcion");

                entity.Property(e => e.Estado).HasColumnName("estado");

                entity.Property(e => e.FechaIng)
                    .HasColumnType("datetime")
                    .HasColumnName("fecha_ing");

                entity.Property(e => e.NombreCompleto)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("nombre_completo");

                entity.Property(e => e.NombreCorto)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("nombre_corto");

                entity.Property(e => e.UsuarioIng)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("usuario_ing");

                entity.HasOne(d => d.CodigoTipoClienteNavigation)
                    .WithMany(p => p.Clientes)
                    .HasForeignKey(d => d.CodigoTipoCliente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_VENTAS_CLIENTE_TIPO");
            });

            modelBuilder.Entity<Concepto>(entity =>
            {
                entity.HasKey(e => e.CodigoConcepto)
                    .HasName("PK_SIT_CONCEPTO");

                entity.ToTable("concepto", "db_tesoreria");

                entity.HasIndex(e => e.Nombre, "UQ_SIT_CONCEPTO_NOMBRE")
                    .IsUnique();

                entity.Property(e => e.CodigoConcepto)
                    .ValueGeneratedNever()
                    .HasColumnName("codigo_concepto");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("descripcion");

                entity.Property(e => e.Estado).HasColumnName("estado");

                entity.Property(e => e.FechaIng)
                    .HasColumnType("datetime")
                    .HasColumnName("fecha_ing");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("nombre");

                entity.Property(e => e.OrdenReporteCaja).HasColumnName("orden_reporte_caja");

                entity.Property(e => e.UsuarioIng)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("usuario_ing");
            });

            modelBuilder.Entity<ConfigSueldosIndirecto>(entity =>
            {
                entity.HasKey(e => new { e.Anio, e.Mes })
                    .HasName("PK_SIT_CONFMONTOSUELDOI");

                entity.ToTable("config_sueldos_indirectos", "db_tesoreria");

                entity.Property(e => e.Anio).HasColumnName("anio");

                entity.Property(e => e.Mes).HasColumnName("mes");

                entity.Property(e => e.Estado).HasColumnName("estado");

                entity.Property(e => e.FechaIng)
                    .HasColumnType("datetime")
                    .HasColumnName("fecha_ing");

                entity.Property(e => e.Monto)
                    .HasColumnType("decimal(15, 2)")
                    .HasColumnName("monto");

                entity.Property(e => e.UsuarioIng)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("usuario_ing");
            });

            modelBuilder.Entity<ConfigUsuarioOperacion>(entity =>
            {
                entity.HasKey(e => new { e.IdUsuario, e.CodigoOperacion })
                    .HasName("PK_SIT_CONFUSEROP");

                entity.ToTable("config_usuario_operacion", "db_tesoreria");

                entity.Property(e => e.IdUsuario)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("id_usuario");

                entity.Property(e => e.CodigoOperacion).HasColumnName("codigo_operacion");

                entity.Property(e => e.Estado).HasColumnName("estado");

                entity.Property(e => e.FechaIng)
                    .HasColumnType("datetime")
                    .HasColumnName("fecha_ing");

                entity.Property(e => e.UsuarioIng)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("usuario_ing");

                entity.HasOne(d => d.CodigoOperacionNavigation)
                    .WithMany(p => p.ConfigUsuarioOperacions)
                    .HasForeignKey(d => d.CodigoOperacion)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SIT_CONFUSEROP_OPERACION");

                entity.HasOne(d => d.IdUsuarioNavigation)
                    .WithMany(p => p.ConfigUsuarioOperacions)
                    .HasForeignKey(d => d.IdUsuario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SIT_CONFUSEROP_USUARIO");
            });

            modelBuilder.Entity<ConfigVendedorRutum>(entity =>
            {
                entity.HasKey(e => e.CodigoConfiguracion)
                    .HasName("PK_VENTAS_CVENRUTA");

                entity.ToTable("config_vendedor_ruta", "db_ventas");

                entity.Property(e => e.CodigoConfiguracion)
                    .ValueGeneratedNever()
                    .HasColumnName("codigo_configuracion");

                entity.Property(e => e.CodigoCanalVenta).HasColumnName("codigo_canal_venta");

                entity.Property(e => e.CodigoVendedor)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("codigo_vendedor");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("descripcion");

                entity.Property(e => e.Estado).HasColumnName("estado");

                entity.Property(e => e.FechaAct)
                    .HasColumnType("datetime")
                    .HasColumnName("fecha_act");

                entity.Property(e => e.FechaIng)
                    .HasColumnType("datetime")
                    .HasColumnName("fecha_ing");

                entity.Property(e => e.Ruta).HasColumnName("ruta");

                entity.Property(e => e.UsuarioAct)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("usuario_act");

                entity.Property(e => e.UsuarioIng)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("usuario_ing");

                entity.HasOne(d => d.CodigoCanalVentaNavigation)
                    .WithMany(p => p.ConfigVendedorRuta)
                    .HasForeignKey(d => d.CodigoCanalVenta)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_VENTAS_CVENRUTA_CANAL");

                entity.HasOne(d => d.CodigoVendedorNavigation)
                    .WithMany(p => p.ConfigVendedorRuta)
                    .HasForeignKey(d => d.CodigoVendedor)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_VENTAS_CVENRUTA_VENDEDOR");

                entity.HasOne(d => d.RutaNavigation)
                    .WithMany(p => p.ConfigVendedorRuta)
                    .HasForeignKey(d => d.Ruta)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_VENTAS_CVENRUTA_RUTA");
            });

            modelBuilder.Entity<Contribuyente>(entity =>
            {
                entity.HasKey(e => e.Nit)
                    .HasName("PK_SIT_CONTRIB");

                entity.ToTable("contribuyente", "db_tesoreria");

                entity.Property(e => e.Nit)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("nit");

                entity.Property(e => e.CodigoTipoContribuyente).HasColumnName("codigo_tipo_contribuyente");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("descripcion");

                entity.Property(e => e.Estado).HasColumnName("estado");

                entity.Property(e => e.FechaIng)
                    .HasColumnType("datetime")
                    .HasColumnName("fecha_ing");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(350)
                    .IsUnicode(false)
                    .HasColumnName("nombre");

                entity.Property(e => e.UsuarioIng)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("usuario_ing");

                entity.HasOne(d => d.CodigoTipoContribuyenteNavigation)
                    .WithMany(p => p.Contribuyentes)
                    .HasForeignKey(d => d.CodigoTipoContribuyente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SIT_CONTRIB_TIPO");
            });

            modelBuilder.Entity<CuentaBancarium>(entity =>
            {
                entity.HasKey(e => new { e.CodigoBanco, e.NumeroCuenta })
                    .HasName("PK_ADMON_CUENTABANCARIA");

                entity.ToTable("cuenta_bancaria", "db_admon");

                entity.Property(e => e.CodigoBanco).HasColumnName("codigo_banco");

                entity.Property(e => e.NumeroCuenta)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("numero_cuenta");

                entity.Property(e => e.CodigoEmpresa).HasColumnName("codigo_empresa");

                entity.Property(e => e.CodigoTipoCuenta).HasColumnName("codigo_tipo_cuenta");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("descripcion");

                entity.Property(e => e.Estado).HasColumnName("estado");

                entity.Property(e => e.FechaIng)
                    .HasColumnType("datetime")
                    .HasColumnName("fecha_ing");

                entity.Property(e => e.NombreCuenta)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("nombre_cuenta");

                entity.Property(e => e.Tesoreria).HasColumnName("tesoreria");

                entity.Property(e => e.UsuarioIng)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("usuario_ing");

                entity.HasOne(d => d.CodigoBancoNavigation)
                    .WithMany(p => p.CuentaBancaria)
                    .HasForeignKey(d => d.CodigoBanco)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ADMON_CUENTABANCARIA_BANCO");

                entity.HasOne(d => d.CodigoEmpresaNavigation)
                    .WithMany(p => p.CuentaBancaria)
                    .HasForeignKey(d => d.CodigoEmpresa)
                    .HasConstraintName("FK_ADMON_CUENTABANCARIA_EMPRESA");
            });

            modelBuilder.Entity<CuentaPorCobrar>(entity =>
            {
                entity.HasKey(e => e.CodigoCxc)
                    .HasName("PK_CONTA_CXC");

                entity.ToTable("cuenta_por_cobrar", "db_contabilidad");

                entity.Property(e => e.CodigoCxc)
                    .ValueGeneratedNever()
                    .HasColumnName("codigo_cxc");

                entity.Property(e => e.AnioOperacion).HasColumnName("anio_operacion");

                entity.Property(e => e.CargaInicial).HasColumnName("carga_inicial");

                entity.Property(e => e.CodigoCategoria).HasColumnName("codigo_categoria");

                entity.Property(e => e.CodigoCategoriaEntidad).HasColumnName("codigo_categoria_entidad");

                entity.Property(e => e.CodigoEntidad)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("codigo_entidad");

                entity.Property(e => e.CodigoEstado).HasColumnName("codigo_estado");

                entity.Property(e => e.CodigoEstadoPagoBtb).HasColumnName("codigo_estado_pago_btb");

                entity.Property(e => e.CodigoOperacion).HasColumnName("codigo_operacion");

                entity.Property(e => e.CodigoPago).HasColumnName("codigo_pago");

                entity.Property(e => e.CodigoPlanilla).HasColumnName("codigo_planilla");

                entity.Property(e => e.CodigoReporte).HasColumnName("codigo_reporte");

                entity.Property(e => e.CodigoTipoCxc).HasColumnName("codigo_tipo_cxc");

                entity.Property(e => e.CodigoTransaccion).HasColumnName("codigo_transaccion");

                entity.Property(e => e.CodigoTransaccionPagoBtb).HasColumnName("codigo_transaccion_pago_btb");

                entity.Property(e => e.FechaAct)
                    .HasColumnType("datetime")
                    .HasColumnName("fecha_act");

                entity.Property(e => e.FechaIng)
                    .HasColumnType("datetime")
                    .HasColumnName("fecha_ing");

                entity.Property(e => e.FechaInicioPago)
                    .HasColumnType("date")
                    .HasColumnName("fecha_inicio_pago");

                entity.Property(e => e.FechaPrestamo)
                    .HasColumnType("date")
                    .HasColumnName("fecha_prestamo");

                entity.Property(e => e.Monto)
                    .HasColumnType("decimal(15, 2)")
                    .HasColumnName("monto");

                entity.Property(e => e.NombreEntidad)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("nombre_entidad");

                entity.Property(e => e.Observaciones)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("observaciones");

                entity.Property(e => e.SemanaOperacion).HasColumnName("semana_operacion");

                entity.Property(e => e.UsuarioAct)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("usuario_act");

                entity.Property(e => e.UsuarioIng)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("usuario_ing");

                entity.HasOne(d => d.CodigoCategoriaNavigation)
                    .WithMany(p => p.CuentaPorCobrarCodigoCategoriaNavigations)
                    .HasForeignKey(d => d.CodigoCategoria)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CONTA_CXC_CATEGORIA");

                entity.HasOne(d => d.CodigoCategoriaEntidadNavigation)
                    .WithMany(p => p.CuentaPorCobrarCodigoCategoriaEntidadNavigations)
                    .HasForeignKey(d => d.CodigoCategoriaEntidad)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CONTA_CXC_CATENTIDAD");

                entity.HasOne(d => d.CodigoEstadoNavigation)
                    .WithMany(p => p.CuentaPorCobrars)
                    .HasForeignKey(d => d.CodigoEstado)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CONTA_CXC_ESTADO");

                entity.HasOne(d => d.CodigoOperacionNavigation)
                    .WithMany(p => p.CuentaPorCobrars)
                    .HasForeignKey(d => d.CodigoOperacion)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CONTA_CXC_OPERACION");

                entity.HasOne(d => d.CodigoPagoNavigation)
                    .WithMany(p => p.CuentaPorCobrars)
                    .HasForeignKey(d => d.CodigoPago)
                    .HasConstraintName("FK_CONTA_CXC_PAGOTEMP");

                entity.HasOne(d => d.CodigoReporteNavigation)
                    .WithMany(p => p.CuentaPorCobrars)
                    .HasForeignKey(d => d.CodigoReporte)
                    .HasConstraintName("FK_CONTA_CXC_REPORTECAJA");

                entity.HasOne(d => d.CodigoTipoCxcNavigation)
                    .WithMany(p => p.CuentaPorCobrars)
                    .HasForeignKey(d => d.CodigoTipoCxc)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CONTA_CXC_TIPO");

                entity.HasOne(d => d.CodigoTransaccionPagoBtbNavigation)
                    .WithMany(p => p.CuentaPorCobrars)
                    .HasForeignKey(d => d.CodigoTransaccionPagoBtb)
                    .HasConstraintName("FK_CONTA_CXC_TRANSACPAGOBTB");
            });

            modelBuilder.Entity<CuentaPorCobrarArqueo>(entity =>
            {
                entity.HasKey(e => e.Correlativo)
                    .HasName("PK_CONTA_CXCARQUEO");

                entity.ToTable("cuenta_por_cobrar_arqueo", "db_contabilidad");

                entity.Property(e => e.Correlativo)
                    .ValueGeneratedNever()
                    .HasColumnName("correlativo");

                entity.Property(e => e.AnioOperacion).HasColumnName("anio_operacion");

                entity.Property(e => e.CargaInicial).HasColumnName("carga_inicial");

                entity.Property(e => e.CodigoCategoria).HasColumnName("codigo_categoria");

                entity.Property(e => e.CodigoCategoriaEntidad).HasColumnName("codigo_categoria_entidad");

                entity.Property(e => e.CodigoCxc).HasColumnName("codigo_cxc");

                entity.Property(e => e.CodigoEntidad)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("codigo_entidad");

                entity.Property(e => e.CodigoEstado).HasColumnName("codigo_estado");

                entity.Property(e => e.CodigoOperacion).HasColumnName("codigo_operacion");

                entity.Property(e => e.CodigoPago).HasColumnName("codigo_pago");

                entity.Property(e => e.CodigoPlanilla).HasColumnName("codigo_planilla");

                entity.Property(e => e.CodigoReporte).HasColumnName("codigo_reporte");

                entity.Property(e => e.CodigoTipoCxc).HasColumnName("codigo_tipo_cxc");

                entity.Property(e => e.CodigoTransaccion).HasColumnName("codigo_transaccion");

                entity.Property(e => e.FechaAct)
                    .HasColumnType("datetime")
                    .HasColumnName("fecha_act");

                entity.Property(e => e.FechaIng)
                    .HasColumnType("datetime")
                    .HasColumnName("fecha_ing");

                entity.Property(e => e.FechaInicioPago)
                    .HasColumnType("date")
                    .HasColumnName("fecha_inicio_pago");

                entity.Property(e => e.FechaPrestamo)
                    .HasColumnType("date")
                    .HasColumnName("fecha_prestamo");

                entity.Property(e => e.Monto)
                    .HasColumnType("decimal(15, 2)")
                    .HasColumnName("monto");

                entity.Property(e => e.NombreEntidad)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("nombre_entidad");

                entity.Property(e => e.Observaciones)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("observaciones");

                entity.Property(e => e.SemanaOperacion).HasColumnName("semana_operacion");

                entity.Property(e => e.UsuarioAct)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("usuario_act");

                entity.Property(e => e.UsuarioIng)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("usuario_ing");

                entity.HasOne(d => d.CodigoCategoriaNavigation)
                    .WithMany(p => p.CuentaPorCobrarArqueoCodigoCategoriaNavigations)
                    .HasForeignKey(d => d.CodigoCategoria)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CONTA_CXCARQUEO_CATEGORIA");

                entity.HasOne(d => d.CodigoCategoriaEntidadNavigation)
                    .WithMany(p => p.CuentaPorCobrarArqueoCodigoCategoriaEntidadNavigations)
                    .HasForeignKey(d => d.CodigoCategoriaEntidad)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CONTA_CXCARQUEO_CATENTIDAD");

                entity.HasOne(d => d.CodigoEstadoNavigation)
                    .WithMany(p => p.CuentaPorCobrarArqueos)
                    .HasForeignKey(d => d.CodigoEstado)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CONTA_CXCARQUEO_ESTADO");

                entity.HasOne(d => d.CodigoOperacionNavigation)
                    .WithMany(p => p.CuentaPorCobrarArqueos)
                    .HasForeignKey(d => d.CodigoOperacion)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CONTA_CXCARQUEO_OPERACION");

                entity.HasOne(d => d.CodigoPagoNavigation)
                    .WithMany(p => p.CuentaPorCobrarArqueos)
                    .HasForeignKey(d => d.CodigoPago)
                    .HasConstraintName("FK_CONTA_CXCARQUEO_PAGOTEMP");

                entity.HasOne(d => d.CodigoReporteNavigation)
                    .WithMany(p => p.CuentaPorCobrarArqueos)
                    .HasForeignKey(d => d.CodigoReporte)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CONTA_CXCARQUEO_REPORTECAJA");

                entity.HasOne(d => d.CodigoTipoCxcNavigation)
                    .WithMany(p => p.CuentaPorCobrarArqueos)
                    .HasForeignKey(d => d.CodigoTipoCxc)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CONTA_CXCARQUEO_TIPO");

                entity.HasOne(d => d.Codigo)
                    .WithMany(p => p.CuentaPorCobrarArqueos)
                    .HasForeignKey(d => new { d.CodigoTransaccion, d.CodigoReporte })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CONTA_CXCARQUEO_TRANSACCION");
            });

            modelBuilder.Entity<CxcReporte>(entity =>
            {
                entity.HasKey(e => new { e.CodigoReporte, e.AnioOperacion, e.SemanaOperacion })
                    .HasName("PK_CONTA_CXCREPORTE");

                entity.ToTable("cxc_reporte", "db_contabilidad");

                entity.Property(e => e.CodigoReporte).HasColumnName("codigo_reporte");

                entity.Property(e => e.AnioOperacion).HasColumnName("anio_operacion");

                entity.Property(e => e.SemanaOperacion).HasColumnName("semana_operacion");

                entity.Property(e => e.CodigoEstado).HasColumnName("codigo_estado");

                entity.Property(e => e.FechaAct)
                    .HasColumnType("datetime")
                    .HasColumnName("fecha_act");

                entity.Property(e => e.FechaIng)
                    .HasColumnType("datetime")
                    .HasColumnName("fecha_ing");

                entity.Property(e => e.UsuarioAct)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("usuario_act");

                entity.Property(e => e.UsuarioIng)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("usuario_ing");

                entity.HasOne(d => d.CodigoEstadoNavigation)
                    .WithMany(p => p.CxcReportes)
                    .HasForeignKey(d => d.CodigoEstado)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CONTA_CXCREPORTE_ESTADO");

                entity.HasOne(d => d.CodigoReporteNavigation)
                    .WithMany(p => p.CxcReportes)
                    .HasForeignKey(d => d.CodigoReporte)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CONTA_CXCREPORTE_REPORTECAJA");
            });

            modelBuilder.Entity<CxcReporteDetalle>(entity =>
            {
                entity.HasKey(e => new { e.CodigoReporte, e.AnioOperacion, e.SemanaOperacion, e.CodigoOperacion, e.CodigoEntidad })
                    .HasName("PK_CONTA_CXCREPORTED");

                entity.ToTable("cxc_reporte_detalle", "db_contabilidad");

                entity.Property(e => e.CodigoReporte).HasColumnName("codigo_reporte");

                entity.Property(e => e.AnioOperacion).HasColumnName("anio_operacion");

                entity.Property(e => e.SemanaOperacion).HasColumnName("semana_operacion");

                entity.Property(e => e.CodigoOperacion).HasColumnName("codigo_operacion");

                entity.Property(e => e.CodigoEntidad)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("codigo_entidad");

                entity.Property(e => e.CodigoCategoria).HasColumnName("codigo_categoria");

                entity.Property(e => e.Estado).HasColumnName("estado");

                entity.Property(e => e.FechaIng)
                    .HasColumnType("datetime")
                    .HasColumnName("fecha_ing");

                entity.Property(e => e.MontoDevolucion)
                    .HasColumnType("decimal(15, 2)")
                    .HasColumnName("monto_devolucion");

                entity.Property(e => e.MontoSolicitado)
                    .HasColumnType("decimal(15, 2)")
                    .HasColumnName("monto_solicitado");

                entity.Property(e => e.Observaciones)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("observaciones");

                entity.Property(e => e.SaldoFinal)
                    .HasColumnType("decimal(15, 2)")
                    .HasColumnName("saldo_final");

                entity.Property(e => e.SaldoInicial)
                    .HasColumnType("decimal(15, 2)")
                    .HasColumnName("saldo_inicial");

                entity.Property(e => e.UsuarioIng)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("usuario_ing");

                entity.HasOne(d => d.CodigoCategoriaNavigation)
                    .WithMany(p => p.CxcReporteDetalles)
                    .HasForeignKey(d => d.CodigoCategoria)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CONTA_CXCREPORTED_CATEGORIA");

                entity.HasOne(d => d.CodigoOperacionNavigation)
                    .WithMany(p => p.CxcReporteDetalles)
                    .HasForeignKey(d => d.CodigoOperacion)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CONTA_CXCREPORTED_OPERACION");

                entity.HasOne(d => d.CxcReporte)
                    .WithMany(p => p.CxcReporteDetalles)
                    .HasForeignKey(d => new { d.CodigoReporte, d.AnioOperacion, d.SemanaOperacion })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CONTA_CXCREPORTED_REPORTE");
            });

            modelBuilder.Entity<CxcReporteDetalleArqueo>(entity =>
            {
                entity.HasKey(e => new { e.CodigoReporte, e.AnioOperacion, e.SemanaOperacion, e.CodigoOperacion, e.CodigoEntidad })
                    .HasName("PK_CONTA_CXCREPORTARQUEO");

                entity.ToTable("cxc_reporte_detalle_arqueo", "db_contabilidad");

                entity.Property(e => e.CodigoReporte).HasColumnName("codigo_reporte");

                entity.Property(e => e.AnioOperacion).HasColumnName("anio_operacion");

                entity.Property(e => e.SemanaOperacion).HasColumnName("semana_operacion");

                entity.Property(e => e.CodigoOperacion).HasColumnName("codigo_operacion");

                entity.Property(e => e.CodigoEntidad)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("codigo_entidad");

                entity.Property(e => e.CodigoCategoria).HasColumnName("codigo_categoria");

                entity.Property(e => e.Estado).HasColumnName("estado");

                entity.Property(e => e.FechaIng)
                    .HasColumnType("datetime")
                    .HasColumnName("fecha_ing");

                entity.Property(e => e.MontoDevolucion)
                    .HasColumnType("decimal(15, 2)")
                    .HasColumnName("monto_devolucion");

                entity.Property(e => e.MontoSolicitado)
                    .HasColumnType("decimal(15, 2)")
                    .HasColumnName("monto_solicitado");

                entity.Property(e => e.Observaciones)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("observaciones");

                entity.Property(e => e.SaldoFinal)
                    .HasColumnType("decimal(15, 2)")
                    .HasColumnName("saldo_final");

                entity.Property(e => e.SaldoInicial)
                    .HasColumnType("decimal(15, 2)")
                    .HasColumnName("saldo_inicial");

                entity.Property(e => e.UsuarioIng)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("usuario_ing");

                entity.HasOne(d => d.CodigoCategoriaNavigation)
                    .WithMany(p => p.CxcReporteDetalleArqueos)
                    .HasForeignKey(d => d.CodigoCategoria)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CONTA_CXCREPORTARQUEO_CATEGORIA");

                entity.HasOne(d => d.CodigoOperacionNavigation)
                    .WithMany(p => p.CxcReporteDetalleArqueos)
                    .HasForeignKey(d => d.CodigoOperacion)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CONTA_CXCREPORTARQUEO_OPERACION");

                entity.HasOne(d => d.CxcReporte)
                    .WithMany(p => p.CxcReporteDetalleArqueos)
                    .HasForeignKey(d => new { d.CodigoReporte, d.AnioOperacion, d.SemanaOperacion })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CONTA_CXCREPORTARQUEO_REPORTE");
            });

            modelBuilder.Entity<Departamento>(entity =>
            {
                entity.HasKey(e => e.CodigoDepartamento)
                    .HasName("PK_ADMON_DEPTO");

                entity.ToTable("departamento", "db_admon");

                entity.HasIndex(e => e.Nombre, "UQ_ADMON_DEPTO_NOMBRE")
                    .IsUnique();

                entity.Property(e => e.CodigoDepartamento)
                    .ValueGeneratedNever()
                    .HasColumnName("codigo_departamento");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("descripcion");

                entity.Property(e => e.Estado).HasColumnName("estado");

                entity.Property(e => e.FechaIng)
                    .HasColumnType("datetime")
                    .HasColumnName("fecha_ing");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("nombre");

                entity.Property(e => e.UsuarioIng)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("usuario_ing");
            });

            modelBuilder.Entity<DepositoBtb>(entity =>
            {
                entity.HasKey(e => e.CodigoDepositoBtb)
                    .HasName("PK_CONTA_DEPBTB");

                entity.ToTable("deposito_btb", "db_contabilidad");

                entity.Property(e => e.CodigoDepositoBtb)
                    .ValueGeneratedNever()
                    .HasColumnName("codigo_deposito_btb");

                entity.Property(e => e.AnioOperacion).HasColumnName("anio_operacion");

                entity.Property(e => e.AnioPlanilla).HasColumnName("anio_planilla");

                entity.Property(e => e.CodigoBancoDeposito).HasColumnName("codigo_banco_deposito");

                entity.Property(e => e.CodigoEmpleado)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("codigo_empleado");

                entity.Property(e => e.CodigoEmpresa).HasColumnName("codigo_empresa");

                entity.Property(e => e.CodigoFrecuenciaPago).HasColumnName("codigo_frecuencia_pago");

                entity.Property(e => e.CodigoOperacion).HasColumnName("codigo_operacion");

                entity.Property(e => e.CodigoReporte).HasColumnName("codigo_reporte");

                entity.Property(e => e.CodigoTipoPlanilla).HasColumnName("codigo_tipo_planilla");

                entity.Property(e => e.DiaOperacion).HasColumnName("dia_operacion");

                entity.Property(e => e.Estado).HasColumnName("estado");

                entity.Property(e => e.FechaAct)
                    .HasColumnType("datetime")
                    .HasColumnName("fecha_act");

                entity.Property(e => e.FechaIng)
                    .HasColumnType("datetime")
                    .HasColumnName("fecha_ing");

                entity.Property(e => e.MesPlanilla).HasColumnName("mes_planilla");

                entity.Property(e => e.Monto)
                    .HasColumnType("decimal(15, 2)")
                    .HasColumnName("monto");

                entity.Property(e => e.NumeroBoleta)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("numero_boleta");

                entity.Property(e => e.NumeroCuenta)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("numero_cuenta");

                entity.Property(e => e.Observaciones)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("observaciones");

                entity.Property(e => e.SemanaOperacion).HasColumnName("semana_operacion");

                entity.Property(e => e.UsuarioAct)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("usuario_act");

                entity.Property(e => e.UsuarioIng)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("usuario_ing");

                entity.HasOne(d => d.CodigoFrecuenciaPagoNavigation)
                    .WithMany(p => p.DepositoBtbs)
                    .HasForeignKey(d => d.CodigoFrecuenciaPago)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CONTA_DEPBTB_FRECPAGO");

                entity.HasOne(d => d.CodigoOperacionNavigation)
                    .WithMany(p => p.DepositoBtbs)
                    .HasForeignKey(d => d.CodigoOperacion)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CONTA_DEPBTB_OPERACION");

                entity.HasOne(d => d.CodigoReporteNavigation)
                    .WithMany(p => p.DepositoBtbs)
                    .HasForeignKey(d => d.CodigoReporte)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CONTA_DEPBTB_REPORTECAJA");

                entity.HasOne(d => d.CodigoTipoPlanillaNavigation)
                    .WithMany(p => p.DepositoBtbs)
                    .HasForeignKey(d => d.CodigoTipoPlanilla)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CONTA_DEPBTB_TIPOPLAN");

                entity.HasOne(d => d.CuentaBancarium)
                    .WithMany(p => p.DepositoBtbs)
                    .HasForeignKey(d => new { d.CodigoBancoDeposito, d.NumeroCuenta })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CONTA_DEPBTB_BANCODEP");

                entity.HasOne(d => d.CodigoEmp)
                    .WithMany(p => p.DepositoBtbs)
                    .HasForeignKey(d => new { d.CodigoEmpresa, d.CodigoEmpleado })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CONTA_DEPBTB_EMPLEADO");
            });

            modelBuilder.Entity<DetalleParametro>(entity =>
            {
                entity.HasKey(e => e.CodigoDetalle)
                    .HasName("PK_ADMON_DETPARAM");

                entity.ToTable("detalle_parametro", "db_admon");

                entity.Property(e => e.CodigoDetalle)
                    .ValueGeneratedNever()
                    .HasColumnName("codigo_detalle");

                entity.Property(e => e.CodigoParametro).HasColumnName("codigo_parametro");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("descripcion");

                entity.Property(e => e.Estado).HasColumnName("estado");

                entity.Property(e => e.FechaAct)
                    .HasColumnType("datetime")
                    .HasColumnName("fecha_act");

                entity.Property(e => e.FechaFin)
                    .HasColumnType("date")
                    .HasColumnName("fecha_fin");

                entity.Property(e => e.FechaIng)
                    .HasColumnType("datetime")
                    .HasColumnName("fecha_ing");

                entity.Property(e => e.FechaInicio)
                    .HasColumnType("date")
                    .HasColumnName("fecha_inicio");

                entity.Property(e => e.UsuarioAct)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("usuario_act");

                entity.Property(e => e.UsuarioIng)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("usuario_ing");

                entity.Property(e => e.Valor)
                    .HasColumnType("decimal(15, 2)")
                    .HasColumnName("valor");

                entity.HasOne(d => d.CodigoParametroNavigation)
                    .WithMany(p => p.DetalleParametros)
                    .HasForeignKey(d => d.CodigoParametro)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ADMON_DETPARAM_PARAMETRO");
            });

            modelBuilder.Entity<Empleado>(entity =>
            {
                entity.HasKey(e => new { e.CodigoEmpresa, e.CodigoEmpleado })
                    .HasName("PK_RRHH_EMPLEADO");

                entity.ToTable("empleado", "db_rrhh");

                entity.Property(e => e.CodigoEmpresa).HasColumnName("codigo_empresa");

                entity.Property(e => e.CodigoEmpleado)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("codigo_empleado");

                entity.Property(e => e.Actualizado).HasColumnName("actualizado");

                entity.Property(e => e.BackToBack).HasColumnName("back_to_back");

                entity.Property(e => e.BonoDeLey).HasColumnName("bono_de_ley");

                entity.Property(e => e.BonoDecreto372001)
                    .HasColumnType("decimal(8, 2)")
                    .HasColumnName("bono_decreto_37_2001");

                entity.Property(e => e.CodigoArea).HasColumnName("codigo_area");

                entity.Property(e => e.CodigoEstado).HasColumnName("codigo_estado");

                entity.Property(e => e.CodigoFrecuenciaPago).HasColumnName("codigo_frecuencia_pago");

                entity.Property(e => e.CodigoJornada).HasColumnName("codigo_jornada");

                entity.Property(e => e.CodigoMotivoBaja).HasColumnName("codigo_motivo_baja");

                entity.Property(e => e.CodigoPuesto).HasColumnName("codigo_puesto");

                entity.Property(e => e.CodigoSeccion).HasColumnName("codigo_seccion");

                entity.Property(e => e.CodigoTipoBtb).HasColumnName("codigo_tipo_btb");

                entity.Property(e => e.CodigoTipoCuenta).HasColumnName("codigo_tipo_cuenta");

                entity.Property(e => e.CodigoTipoIdentificacion)
                    .IsRequired()
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("codigo_tipo_identificacion");

                entity.Property(e => e.CodigoUbicacion).HasColumnName("codigo_ubicacion");

                entity.Property(e => e.CorreoElectronico)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("correo_electronico");

                entity.Property(e => e.Cui)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("cui");

                entity.Property(e => e.EmpleadoExterno).HasColumnName("empleado_externo");

                entity.Property(e => e.EnPlanilla)
                    .HasColumnName("en_planilla")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.FechaAct)
                    .HasColumnType("datetime")
                    .HasColumnName("fecha_act");

                entity.Property(e => e.FechaEgreso)
                    .HasColumnType("date")
                    .HasColumnName("fecha_egreso");

                entity.Property(e => e.FechaIng)
                    .HasColumnType("datetime")
                    .HasColumnName("fecha_ing");

                entity.Property(e => e.FechaIngreso)
                    .HasColumnType("date")
                    .HasColumnName("fecha_ingreso");

                entity.Property(e => e.Foto)
                    .IsUnicode(false)
                    .HasColumnName("foto");

                entity.Property(e => e.Igss).HasColumnName("igss");

                entity.Property(e => e.MontoDescuentoPrestamo)
                    .HasColumnType("decimal(15, 2)")
                    .HasColumnName("monto_descuento_prestamo");

                entity.Property(e => e.MontoDevengado)
                    .HasColumnType("decimal(15, 2)")
                    .HasColumnName("monto_devengado");

                entity.Property(e => e.Nit)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("nit");

                entity.Property(e => e.NumeroAfiliacion)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("numero_afiliacion");

                entity.Property(e => e.NumeroCuenta)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("numero_cuenta");

                entity.Property(e => e.Observaciones)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("observaciones");

                entity.Property(e => e.PagoPendiente).HasColumnName("pago_pendiente");

                entity.Property(e => e.RetencionIsr).HasColumnName("retencion_isr");

                entity.Property(e => e.SalarioDiario)
                    .HasColumnType("decimal(15, 2)")
                    .HasColumnName("salario_diario");

                entity.Property(e => e.SaldoPrestamo).HasColumnName("saldo_prestamo");

                entity.Property(e => e.UsuarioAct)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("usuario_act");

                entity.Property(e => e.UsuarioIng)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("usuario_ing");

                entity.HasOne(d => d.CodigoAreaNavigation)
                    .WithMany(p => p.Empleados)
                    .HasForeignKey(d => d.CodigoArea)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RRHH_EMPLEADO_AREA");

                entity.HasOne(d => d.CodigoEmpresaNavigation)
                    .WithMany(p => p.Empleados)
                    .HasForeignKey(d => d.CodigoEmpresa)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RRHH_EMPLEADO_EMPRESA");

                entity.HasOne(d => d.CodigoEstadoNavigation)
                    .WithMany(p => p.Empleados)
                    .HasForeignKey(d => d.CodigoEstado)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RRHH_EMPLEADO_ESTADO");

                entity.HasOne(d => d.CodigoFrecuenciaPagoNavigation)
                    .WithMany(p => p.Empleados)
                    .HasForeignKey(d => d.CodigoFrecuenciaPago)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RRHH_EMPLEADO_FRECPAGO");

                entity.HasOne(d => d.CodigoJornadaNavigation)
                    .WithMany(p => p.Empleados)
                    .HasForeignKey(d => d.CodigoJornada)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RRHH_EMPLEADO_JORNADA");

                entity.HasOne(d => d.CodigoMotivoBajaNavigation)
                    .WithMany(p => p.Empleados)
                    .HasForeignKey(d => d.CodigoMotivoBaja)
                    .HasConstraintName("FK_RRHH_EMPLEADO_MOTIVOBAJ");

                entity.HasOne(d => d.CodigoPuestoNavigation)
                    .WithMany(p => p.Empleados)
                    .HasForeignKey(d => d.CodigoPuesto)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RRHH_EMPLEADO_PUESTO");

                entity.HasOne(d => d.CodigoSeccionNavigation)
                    .WithMany(p => p.Empleados)
                    .HasForeignKey(d => d.CodigoSeccion)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RRHH_EMPLEADO_SECCION");

                entity.HasOne(d => d.CodigoTipoBtbNavigation)
                    .WithMany(p => p.Empleados)
                    .HasForeignKey(d => d.CodigoTipoBtb)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RRHH_EMPLEADO_TIPOBACKTOBACK");

                entity.HasOne(d => d.CodigoTipoCuentaNavigation)
                    .WithMany(p => p.Empleados)
                    .HasForeignKey(d => d.CodigoTipoCuenta)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RRHH_EMPLEADO_TCUENTA");

                entity.HasOne(d => d.CodigoUbicacionNavigation)
                    .WithMany(p => p.Empleados)
                    .HasForeignKey(d => d.CodigoUbicacion)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RRHH_EMPLEADO_UBICACION");

                entity.HasOne(d => d.CuiNavigation)
                    .WithMany(p => p.Empleados)
                    .HasForeignKey(d => d.Cui)
                    .HasConstraintName("FK_RRHH_EMPLEADO_CUI");
            });

            modelBuilder.Entity<EmpleadoHist>(entity =>
            {
                entity.HasKey(e => e.CodigoHistorial)
                    .HasName("PK_RRHH_EMPLEADOH");

                entity.ToTable("empleado_hist", "db_rrhh");

                entity.Property(e => e.CodigoHistorial)
                    .ValueGeneratedNever()
                    .HasColumnName("codigo_historial");

                entity.Property(e => e.BackToBack).HasColumnName("back_to_back");

                entity.Property(e => e.BonoDeLey).HasColumnName("bono_de_ley");

                entity.Property(e => e.CodigoArea).HasColumnName("codigo_area");

                entity.Property(e => e.CodigoEmpleado)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("codigo_empleado");

                entity.Property(e => e.CodigoEmpresa).HasColumnName("codigo_empresa");

                entity.Property(e => e.CodigoEstado).HasColumnName("codigo_estado");

                entity.Property(e => e.CodigoFrecuenciaPago).HasColumnName("codigo_frecuencia_pago");

                entity.Property(e => e.CodigoJornada).HasColumnName("codigo_jornada");

                entity.Property(e => e.CodigoMotivoBaja).HasColumnName("codigo_motivo_baja");

                entity.Property(e => e.CodigoPuesto).HasColumnName("codigo_puesto");

                entity.Property(e => e.CodigoSeccion).HasColumnName("codigo_seccion");

                entity.Property(e => e.CodigoTipoCuenta).HasColumnName("codigo_tipo_cuenta");

                entity.Property(e => e.CodigoTipoIdentificacion)
                    .IsRequired()
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("codigo_tipo_identificacion");

                entity.Property(e => e.CodigoUbicacion).HasColumnName("codigo_ubicacion");

                entity.Property(e => e.CorreoElectronico)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("correo_electronico");

                entity.Property(e => e.Cui)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("cui");

                entity.Property(e => e.EmpleadoExterno).HasColumnName("empleado_externo");

                entity.Property(e => e.FechaAct)
                    .HasColumnType("datetime")
                    .HasColumnName("fecha_act");

                entity.Property(e => e.FechaEgreso)
                    .HasColumnType("date")
                    .HasColumnName("fecha_egreso");

                entity.Property(e => e.FechaIng)
                    .HasColumnType("datetime")
                    .HasColumnName("fecha_ing");

                entity.Property(e => e.FechaIngreso)
                    .HasColumnType("date")
                    .HasColumnName("fecha_ingreso");

                entity.Property(e => e.Igss).HasColumnName("igss");

                entity.Property(e => e.MontoDescuentoPrestamo)
                    .HasColumnType("decimal(15, 2)")
                    .HasColumnName("monto_descuento_prestamo");

                entity.Property(e => e.MontoDevengado)
                    .HasColumnType("decimal(15, 2)")
                    .HasColumnName("monto_devengado");

                entity.Property(e => e.Nit)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("nit");

                entity.Property(e => e.NumeroAfiliacion)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("numero_afiliacion");

                entity.Property(e => e.NumeroCuenta)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("numero_cuenta");

                entity.Property(e => e.Observaciones)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("observaciones");

                entity.Property(e => e.RetencionIsr).HasColumnName("retencion_isr");

                entity.Property(e => e.UsuarioAct)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("usuario_act");

                entity.Property(e => e.UsuarioIng)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("usuario_ing");

                entity.HasOne(d => d.CodigoAreaNavigation)
                    .WithMany(p => p.EmpleadoHists)
                    .HasForeignKey(d => d.CodigoArea)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RRHH_EMPLEADOH_AREA");

                entity.HasOne(d => d.CodigoEstadoNavigation)
                    .WithMany(p => p.EmpleadoHists)
                    .HasForeignKey(d => d.CodigoEstado)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RRHH_EMPLEADOH_ESTADO");

                entity.HasOne(d => d.CodigoFrecuenciaPagoNavigation)
                    .WithMany(p => p.EmpleadoHists)
                    .HasForeignKey(d => d.CodigoFrecuenciaPago)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RRHH_EMPLEADOH_FRECPAGO");

                entity.HasOne(d => d.CodigoJornadaNavigation)
                    .WithMany(p => p.EmpleadoHists)
                    .HasForeignKey(d => d.CodigoJornada)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RRHH_EMPLEADOH_JORNADA");

                entity.HasOne(d => d.CodigoMotivoBajaNavigation)
                    .WithMany(p => p.EmpleadoHists)
                    .HasForeignKey(d => d.CodigoMotivoBaja)
                    .HasConstraintName("FK_RRHH_EMPLEADOH_MOTIVOBAJ");

                entity.HasOne(d => d.CodigoPuestoNavigation)
                    .WithMany(p => p.EmpleadoHists)
                    .HasForeignKey(d => d.CodigoPuesto)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RRHH_EMPLEADOH_PUESTO");

                entity.HasOne(d => d.CodigoSeccionNavigation)
                    .WithMany(p => p.EmpleadoHists)
                    .HasForeignKey(d => d.CodigoSeccion)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RRHH_EMPLEADOH_SECCION");

                entity.HasOne(d => d.CodigoTipoCuentaNavigation)
                    .WithMany(p => p.EmpleadoHists)
                    .HasForeignKey(d => d.CodigoTipoCuenta)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RRHH_EMPLEADOH_TCUENTA");

                entity.HasOne(d => d.CodigoUbicacionNavigation)
                    .WithMany(p => p.EmpleadoHists)
                    .HasForeignKey(d => d.CodigoUbicacion)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RRHH_EMPLEADOH_UBICACION");

                entity.HasOne(d => d.CuiNavigation)
                    .WithMany(p => p.EmpleadoHists)
                    .HasForeignKey(d => d.Cui)
                    .HasConstraintName("FK_RRHH_EMPLEADOH_CUI");

                entity.HasOne(d => d.CodigoEmp)
                    .WithMany(p => p.EmpleadoHists)
                    .HasForeignKey(d => new { d.CodigoEmpresa, d.CodigoEmpleado })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RRHH_EMPLEADOH_EMPLEADO");
            });

            modelBuilder.Entity<Empresa>(entity =>
            {
                entity.HasKey(e => e.CodigoEmpresa)
                    .HasName("PK_ADMON_EMPRESA");

                entity.ToTable("empresa", "db_admon");

                entity.Property(e => e.CodigoEmpresa)
                    .ValueGeneratedNever()
                    .HasColumnName("codigo_empresa");

                entity.Property(e => e.CodigoQsystem)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("codigo_qsystem");

                entity.Property(e => e.CodigoTipoEmpresa).HasColumnName("codigo_tipo_empresa");

                entity.Property(e => e.Direccion)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("direccion");

                entity.Property(e => e.Estado).HasColumnName("estado");

                entity.Property(e => e.FechaIng)
                    .HasColumnType("datetime")
                    .HasColumnName("fecha_ing");

                entity.Property(e => e.Nit)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("nit");

                entity.Property(e => e.NombreComercial)
                    .IsRequired()
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("nombre_comercial");

                entity.Property(e => e.NombreCorto)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("nombre_corto");

                entity.Property(e => e.NombreRazonSocial)
                    .IsRequired()
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("nombre_razon_social");

                entity.Property(e => e.Observaciones)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("observaciones");

                entity.Property(e => e.Tesoreria).HasColumnName("tesoreria");

                entity.Property(e => e.UsuarioIng)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("usuario_ing");

                entity.HasOne(d => d.CodigoTipoEmpresaNavigation)
                    .WithMany(p => p.Empresas)
                    .HasForeignKey(d => d.CodigoTipoEmpresa)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ADMON_EMPRESA_TIPOEMPRESA");
            });

            modelBuilder.Entity<EmpresaConcedeIva>(entity =>
            {
                entity.HasKey(e => e.Nit)
                    .HasName("PK_SIT_EMPCONCEIVA");

                entity.ToTable("empresa_concede_iva", "db_tesoreria");

                entity.Property(e => e.Nit)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("nit");

                entity.Property(e => e.CodigoEntidad).HasColumnName("codigo_entidad");

                entity.Property(e => e.Estado).HasColumnName("estado");

                entity.Property(e => e.FechaIng)
                    .HasColumnType("datetime")
                    .HasColumnName("fecha_ing");

                entity.Property(e => e.Observaciones)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("observaciones");

                entity.Property(e => e.UsuarioIng)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("usuario_ing");

                entity.HasOne(d => d.CodigoEntidadNavigation)
                    .WithMany(p => p.EmpresaConcedeIvas)
                    .HasForeignKey(d => d.CodigoEntidad)
                    .HasConstraintName("FK_SIT_EMPCONCEIVA_ENTIDAD");

                entity.HasOne(d => d.NitNavigation)
                    .WithOne(p => p.EmpresaConcedeIva)
                    .HasForeignKey<EmpresaConcedeIva>(d => d.Nit)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SIT_EMPCONCEIVA_NIT");
            });

            modelBuilder.Entity<Entidad>(entity =>
            {
                entity.HasKey(e => e.CodigoEntidad)
                    .HasName("PK_SIT_ENTIDAD");

                entity.ToTable("entidad", "db_tesoreria");

                entity.Property(e => e.CodigoEntidad)
                    .ValueGeneratedNever()
                    .HasColumnName("codigo_entidad");

                entity.Property(e => e.CodigoCategoriaEntidad).HasColumnName("codigo_categoria_entidad");

                entity.Property(e => e.CodigoOperacion).HasColumnName("codigo_operacion");

                entity.Property(e => e.ConcedeIva).HasColumnName("concede_iva");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("descripcion");

                entity.Property(e => e.Estado).HasColumnName("estado");

                entity.Property(e => e.FechaAct)
                    .HasColumnType("datetime")
                    .HasColumnName("fecha_act");

                entity.Property(e => e.FechaIng)
                    .HasColumnType("datetime")
                    .HasColumnName("fecha_ing");

                entity.Property(e => e.NombreCompleto)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("nombre_completo");

                entity.Property(e => e.UsuarioAct)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("usuario_act");

                entity.Property(e => e.UsuarioIng)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("usuario_ing");

                entity.HasOne(d => d.CodigoCategoriaEntidadNavigation)
                    .WithMany(p => p.Entidads)
                    .HasForeignKey(d => d.CodigoCategoriaEntidad)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SIT_ENTIDAD_CATEGORIA");

                entity.HasOne(d => d.CodigoOperacionNavigation)
                    .WithMany(p => p.Entidads)
                    .HasForeignKey(d => d.CodigoOperacion)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SIT_ENTIDAD_OPERACION");
            });

            modelBuilder.Entity<EntidadCategorium>(entity =>
            {
                entity.HasKey(e => e.CodigoCategoriaEntidad)
                    .HasName("PK_SIT_ENTCAT");

                entity.ToTable("entidad_categoria", "db_tesoreria");

                entity.HasIndex(e => e.Nombre, "UQ_SIT_ENTCAT_NOMBRE")
                    .IsUnique();

                entity.Property(e => e.CodigoCategoriaEntidad)
                    .ValueGeneratedNever()
                    .HasColumnName("codigo_categoria_entidad");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("descripcion");

                entity.Property(e => e.Estado).HasColumnName("estado");

                entity.Property(e => e.ExcluirRegistroEntidad).HasColumnName("excluir_registro_entidad");

                entity.Property(e => e.FechaIng)
                    .HasColumnType("datetime")
                    .HasColumnName("fecha_ing");

                entity.Property(e => e.IncluirConfigOperacion).HasColumnName("incluir_config_operacion");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("nombre");

                entity.Property(e => e.UsuarioIng)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("usuario_ing");
            });

            modelBuilder.Entity<EntidadProveedor>(entity =>
            {
                entity.HasKey(e => e.CodigoProveedor)
                    .HasName("PK_SIT_ENTIDADPROVEEDOR");

                entity.ToTable("entidad_proveedor", "db_tesoreria");

                entity.Property(e => e.CodigoProveedor)
                    .ValueGeneratedNever()
                    .HasColumnName("codigo_proveedor");

                entity.Property(e => e.CodigoEntidad).HasColumnName("codigo_entidad");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("descripcion");

                entity.Property(e => e.Estado).HasColumnName("estado");

                entity.Property(e => e.FechaAct)
                    .HasColumnType("datetime")
                    .HasColumnName("fecha_act");

                entity.Property(e => e.FechaIng)
                    .HasColumnType("datetime")
                    .HasColumnName("fecha_ing");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("nombre");

                entity.Property(e => e.UsuarioAct)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("usuario_act");

                entity.Property(e => e.UsuarioIng)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("usuario_ing");

                entity.HasOne(d => d.CodigoEntidadNavigation)
                    .WithMany(p => p.EntidadProveedors)
                    .HasForeignKey(d => d.CodigoEntidad)
                    .HasConstraintName("FK_SIT_ENTIDADPROVEEDOR_ENTIDAD");
            });

            modelBuilder.Entity<EstadoCxc>(entity =>
            {
                entity.HasKey(e => e.CodigoEstadoCxc)
                    .HasName("PK_CONTA_ESTADOCXC");

                entity.ToTable("estado_cxc", "db_contabilidad");

                entity.HasIndex(e => e.Nombre, "UQ_CONTA_ESTADOCXC_NOMBRE")
                    .IsUnique();

                entity.Property(e => e.CodigoEstadoCxc).HasColumnName("codigo_estado_cxc");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("descripcion");

                entity.Property(e => e.Estado).HasColumnName("estado");

                entity.Property(e => e.FechaIng)
                    .HasColumnType("datetime")
                    .HasColumnName("fecha_ing");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("nombre");

                entity.Property(e => e.UsuarioIng)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("usuario_ing");
            });

            modelBuilder.Entity<EstadoDepuracionEspeciales2>(entity =>
            {
                entity.HasKey(e => e.CodigoEstadoDepuracion)
                    .HasName("PK_SIT_STATUSDEPESP2");

                entity.ToTable("estado_depuracion_especiales2", "db_tesoreria");

                entity.HasIndex(e => e.Nombre, "UQ_SIT_STATUSDEPESP2_NOMBRE")
                    .IsUnique();

                entity.Property(e => e.CodigoEstadoDepuracion).HasColumnName("codigo_estado_depuracion");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("descripcion");

                entity.Property(e => e.Estado).HasColumnName("estado");

                entity.Property(e => e.FechaIng)
                    .HasColumnType("datetime")
                    .HasColumnName("fecha_ing");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nombre");

                entity.Property(e => e.UsuarioIng)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("usuario_ing");
            });

            modelBuilder.Entity<EstadoEmpleado>(entity =>
            {
                entity.HasKey(e => e.CodigoEstadoEmpleado)
                    .HasName("PK_RRHH_ESTADOEMP");

                entity.ToTable("estado_empleado", "db_rrhh");

                entity.HasIndex(e => e.Nombre, "UQ_RRHH_ESTADOEMP_NOMBRE")
                    .IsUnique();

                entity.Property(e => e.CodigoEstadoEmpleado)
                    .ValueGeneratedNever()
                    .HasColumnName("codigo_estado_empleado");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("descripcion");

                entity.Property(e => e.Estado).HasColumnName("estado");

                entity.Property(e => e.FechaIng)
                    .HasColumnType("datetime")
                    .HasColumnName("fecha_ing");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("nombre");

                entity.Property(e => e.UsuarioIng)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("usuario_ing");
            });

            modelBuilder.Entity<EstadoReporteCaja>(entity =>
            {
                entity.HasKey(e => e.CodigoEstadoReporteCaja)
                    .HasName("PK_SIT_ESTADOREPORCAJA");

                entity.ToTable("estado_reporte_caja", "db_tesoreria");

                entity.HasIndex(e => e.Nombre, "UQ_SIT_ESTADOREPORCAJA_NOMBRE")
                    .IsUnique();

                entity.Property(e => e.CodigoEstadoReporteCaja).HasColumnName("codigo_estado_reporte_caja");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("descripcion");

                entity.Property(e => e.Estado).HasColumnName("estado");

                entity.Property(e => e.FechaIng)
                    .HasColumnType("datetime")
                    .HasColumnName("fecha_ing");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("nombre");

                entity.Property(e => e.UsuarioIng)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("usuario_ing");
            });

            modelBuilder.Entity<EstadoReporteCajaChica>(entity =>
            {
                entity.HasKey(e => e.CodigoEstado)
                    .HasName("PK_SIT_ESTADOREPORTCC");

                entity.ToTable("estado_reporte_caja_chica", "db_tesoreria");

                entity.HasIndex(e => e.Nombre, "UQ_SIT_ESTADOREPORTCC_NOMBRE")
                    .IsUnique();

                entity.Property(e => e.CodigoEstado).HasColumnName("codigo_estado");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("descripcion");

                entity.Property(e => e.Estado).HasColumnName("estado");

                entity.Property(e => e.FechaIng)
                    .HasColumnType("datetime")
                    .HasColumnName("fecha_ing");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("nombre");

                entity.Property(e => e.UsuarioIng)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("usuario_ing");
            });

            modelBuilder.Entity<EstadoReporteCxc>(entity =>
            {
                entity.HasKey(e => e.CodigoEstadoReporte)
                    .HasName("PK_CONTA_ESTADOREPORCXC");

                entity.ToTable("estado_reporte_cxc", "db_contabilidad");

                entity.Property(e => e.CodigoEstadoReporte).HasColumnName("codigo_estado_reporte");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("descripcion");

                entity.Property(e => e.Estado).HasColumnName("estado");

                entity.Property(e => e.FechaIng)
                    .HasColumnType("datetime")
                    .HasColumnName("fecha_ing");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nombre");

                entity.Property(e => e.UsuarioIng)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("usuario_ing");
            });

            modelBuilder.Entity<EstadoSolicitudCorreccion>(entity =>
            {
                entity.HasKey(e => e.CodigoEstadoSolicitudCorreccion)
                    .HasName("PK_SIT_ESTADOSOLC");

                entity.ToTable("estado_solicitud_correccion", "db_tesoreria");

                entity.HasIndex(e => e.Nombre, "UQ_SIT_ESTADOSOLC_NOMBRE")
                    .IsUnique();

                entity.Property(e => e.CodigoEstadoSolicitudCorreccion).HasColumnName("codigo_estado_solicitud_correccion");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("descripcion");

                entity.Property(e => e.Estado).HasColumnName("estado");

                entity.Property(e => e.FechaAct)
                    .HasColumnType("datetime")
                    .HasColumnName("fecha_act");

                entity.Property(e => e.FechaIng)
                    .HasColumnType("datetime")
                    .HasColumnName("fecha_ing");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("nombre");

                entity.Property(e => e.UsuarioAct)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("usuario_act");

                entity.Property(e => e.UsuarioIng)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("usuario_ing");
            });

            modelBuilder.Entity<EstadoTransaccion>(entity =>
            {
                entity.HasKey(e => e.CodigoEstadoTransaccion)
                    .HasName("PK_SIT_STATETRANS");

                entity.ToTable("estado_transaccion", "db_tesoreria");

                entity.HasIndex(e => e.Nombre, "UQ_SIT_STATETRANS_NOMBRE")
                    .IsUnique();

                entity.Property(e => e.CodigoEstadoTransaccion)
                    .ValueGeneratedNever()
                    .HasColumnName("codigo_estado_transaccion");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("descripcion");

                entity.Property(e => e.Estado).HasColumnName("estado");

                entity.Property(e => e.FechaIng)
                    .HasColumnType("datetime")
                    .HasColumnName("fecha_ing");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("nombre");

                entity.Property(e => e.UsuarioIng)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("usuario_ing");
            });

            modelBuilder.Entity<EstadoTrasladoCaja>(entity =>
            {
                entity.HasKey(e => e.CodigoEstado)
                    .HasName("PK_SIT_ESTADOTRASCAJA");

                entity.ToTable("estado_traslado_caja", "db_tesoreria");

                entity.HasIndex(e => e.Nombre, "UQ_SIT_ESTADOTRASCAJA_NOMBRE")
                    .IsUnique();

                entity.Property(e => e.CodigoEstado)
                    .ValueGeneratedNever()
                    .HasColumnName("codigo_estado");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("descripcion");

                entity.Property(e => e.Estado).HasColumnName("estado");

                entity.Property(e => e.FechaIng)
                    .HasColumnType("datetime")
                    .HasColumnName("fecha_ing");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("nombre");

                entity.Property(e => e.UsuarioIng)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("usuario_ing");
            });

            modelBuilder.Entity<EstadoTrasladoEspeciales2>(entity =>
            {
                entity.HasKey(e => e.CodigoEstadoTraslado)
                    .HasName("PK_SIT_STATUSTRASESP2");

                entity.ToTable("estado_traslado_especiales2", "db_tesoreria");

                entity.HasIndex(e => e.Nombre, "UQ_SIT_STATUSTRASESP2_NOMBRE")
                    .IsUnique();

                entity.Property(e => e.CodigoEstadoTraslado).HasColumnName("codigo_estado_traslado");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("descripcion");

                entity.Property(e => e.Estado).HasColumnName("estado");

                entity.Property(e => e.FechaIng)
                    .HasColumnType("datetime")
                    .HasColumnName("fecha_ing");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nombre");

                entity.Property(e => e.UsuarioIng)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("usuario_ing");
            });

            modelBuilder.Entity<EstadoTrasladoLiquidacion>(entity =>
            {
                entity.HasKey(e => e.CodigoEstadoTraslado)
                    .HasName("PK_SIT_ESTADOTRASLIQ");

                entity.ToTable("estado_traslado_liquidacion", "db_tesoreria");

                entity.Property(e => e.CodigoEstadoTraslado).HasColumnName("codigo_estado_traslado");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("descripcion");

                entity.Property(e => e.Estado).HasColumnName("estado");

                entity.Property(e => e.FechaIng)
                    .HasColumnType("datetime")
                    .HasColumnName("fecha_ing");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nombre");

                entity.Property(e => e.UsuarioIng)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("usuario_ing");
            });

            modelBuilder.Entity<FormaPago>(entity =>
            {
                entity.HasKey(e => e.CodigoFormaPago)
                    .HasName("PK_SIT_FORMAPAGO");

                entity.ToTable("forma_pago", "db_tesoreria");

                entity.HasIndex(e => e.Nombre, "UQ_SIT_FORMAPAGO_NOMBRE")
                    .IsUnique();

                entity.Property(e => e.CodigoFormaPago)
                    .ValueGeneratedNever()
                    .HasColumnName("codigo_forma_pago");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("descripcion");

                entity.Property(e => e.Estado).HasColumnName("estado");

                entity.Property(e => e.FechaIng)
                    .HasColumnType("datetime")
                    .HasColumnName("fecha_ing");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("nombre");

                entity.Property(e => e.UsuarioIng)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("usuario_ing");
            });

            modelBuilder.Entity<FrecuenciaPago>(entity =>
            {
                entity.HasKey(e => e.CodigoFrecuenciaPago)
                    .HasName("PK_RRHH_FRECUENCIAPAGO");

                entity.ToTable("frecuencia_pago", "db_rrhh");

                entity.HasIndex(e => e.Nombre, "UQ_RRHH_FRECUENCIAPAGO_NOMBRE")
                    .IsUnique();

                entity.Property(e => e.CodigoFrecuenciaPago).HasColumnName("codigo_frecuencia_pago");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("descripcion");

                entity.Property(e => e.Estado).HasColumnName("estado");

                entity.Property(e => e.FechaIng)
                    .HasColumnType("datetime")
                    .HasColumnName("fecha_ing");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("nombre");

                entity.Property(e => e.UsuarioIng)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("usuario_ing");
            });

            modelBuilder.Entity<GrupoFinanciero>(entity =>
            {
                entity.HasKey(e => e.CodigoGrupoFinanciero)
                    .HasName("PK_ADMON_GRUPOF");

                entity.ToTable("grupo_financiero", "db_admon");

                entity.HasIndex(e => e.Nombre, "UQ_ADMON_GRUPOF_NOMBRE")
                    .IsUnique();

                entity.Property(e => e.CodigoGrupoFinanciero)
                    .ValueGeneratedNever()
                    .HasColumnName("codigo_grupo_financiero");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("descripcion");

                entity.Property(e => e.Estado).HasColumnName("estado");

                entity.Property(e => e.FechaIng)
                    .HasColumnType("datetime")
                    .HasColumnName("fecha_ing");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("nombre");

                entity.Property(e => e.UsuarioIng)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("usuario_ing");
            });

            modelBuilder.Entity<Jornadum>(entity =>
            {
                entity.HasKey(e => e.CodigoJornada)
                    .HasName("PK_RRHH_JORNADA");

                entity.ToTable("jornada", "db_rrhh");

                entity.HasIndex(e => e.Nombre, "UQ_RRHH_JORNADA_NOMBRE")
                    .IsUnique();

                entity.Property(e => e.CodigoJornada).HasColumnName("codigo_jornada");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("descripcion");

                entity.Property(e => e.Estado).HasColumnName("estado");

                entity.Property(e => e.FechaIng)
                    .HasColumnType("datetime")
                    .HasColumnName("fecha_ing");

                entity.Property(e => e.HoraFin).HasColumnName("hora_fin");

                entity.Property(e => e.HoraInicio).HasColumnName("hora_inicio");

                entity.Property(e => e.MinutoFin).HasColumnName("minuto_fin");

                entity.Property(e => e.MinutoInicio).HasColumnName("minuto_inicio");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("nombre");

                entity.Property(e => e.UsuarioIng)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("usuario_ing");
            });

            modelBuilder.Entity<MotivoBaja>(entity =>
            {
                entity.HasKey(e => e.CodigoMotivoBaja)
                    .HasName("PK_RRHH_MOTIVOBAJ");

                entity.ToTable("motivo_baja", "db_rrhh");

                entity.HasIndex(e => e.Nombre, "UQ_RRHH_MOTIVOBAJ_NOMBRE")
                    .IsUnique();

                entity.Property(e => e.CodigoMotivoBaja)
                    .ValueGeneratedNever()
                    .HasColumnName("codigo_motivo_baja");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("descripcion");

                entity.Property(e => e.Estado).HasColumnName("estado");

                entity.Property(e => e.FechaIng)
                    .HasColumnType("datetime")
                    .HasColumnName("fecha_ing");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("nombre");

                entity.Property(e => e.UsuarioIng)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("usuario_ing");
            });

            modelBuilder.Entity<MotivoExclusion>(entity =>
            {
                entity.HasKey(e => e.CodigoMotivoExclusion)
                    .HasName("PK_SIT_MOTEXCLUSION");

                entity.ToTable("motivo_exclusion", "db_tesoreria");

                entity.HasIndex(e => e.Nombre, "UQ_SIT_MOTEXCLUSION_NOMBRE")
                    .IsUnique();

                entity.Property(e => e.CodigoMotivoExclusion).HasColumnName("codigo_motivo_exclusion");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("descripcion");

                entity.Property(e => e.Estado).HasColumnName("estado");

                entity.Property(e => e.FechaIng)
                    .HasColumnType("datetime")
                    .HasColumnName("fecha_ing");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("nombre");

                entity.Property(e => e.UsuarioIng)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("usuario_ing");
            });

            modelBuilder.Entity<MotivoSuspension>(entity =>
            {
                entity.HasKey(e => e.CodigoMotivoSuspension)
                    .HasName("PK_RRHH_MOTIVOSUSP");

                entity.ToTable("motivo_suspension", "db_rrhh");

                entity.HasIndex(e => e.Nombre, "UQ_RRHH_MOTIVOSUSP_NOMBRE")
                    .IsUnique();

                entity.Property(e => e.CodigoMotivoSuspension)
                    .ValueGeneratedNever()
                    .HasColumnName("codigo_motivo_suspension");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("descripcion");

                entity.Property(e => e.Estado).HasColumnName("estado");

                entity.Property(e => e.FechaIng)
                    .HasColumnType("datetime")
                    .HasColumnName("fecha_ing");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("nombre");

                entity.Property(e => e.UsuarioIng)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("usuario_ing");
            });

            modelBuilder.Entity<Municipio>(entity =>
            {
                entity.HasKey(e => new { e.CodigoDepartamento, e.CodigoMunicipio })
                    .HasName("PK_ADMON_MUNI");

                entity.ToTable("municipio", "db_admon");

                entity.HasIndex(e => e.Nombre, "UQ_ADMON_MUNI_NOMBRE")
                    .IsUnique();

                entity.Property(e => e.CodigoDepartamento).HasColumnName("codigo_departamento");

                entity.Property(e => e.CodigoMunicipio).HasColumnName("codigo_municipio");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("descripcion");

                entity.Property(e => e.Estado).HasColumnName("estado");

                entity.Property(e => e.FechaIng)
                    .HasColumnType("datetime")
                    .HasColumnName("fecha_ing");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("nombre");

                entity.Property(e => e.UsuarioIng)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("usuario_ing");

                entity.HasOne(d => d.CodigoDepartamentoNavigation)
                    .WithMany(p => p.Municipios)
                    .HasForeignKey(d => d.CodigoDepartamento)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ADMON_MUNI_DEPTO");
            });

            modelBuilder.Entity<Operacion>(entity =>
            {
                entity.HasKey(e => e.CodigoOperacion)
                    .HasName("PK_SIT_OPERACION");

                entity.ToTable("operacion", "db_tesoreria");

                entity.Property(e => e.CodigoOperacion)
                    .ValueGeneratedNever()
                    .HasColumnName("codigo_operacion");

                entity.Property(e => e.AplicaCajaChica).HasColumnName("aplica_caja_chica");

                entity.Property(e => e.CodigoCategoriaOperacion).HasColumnName("codigo_categoria_operacion");

                entity.Property(e => e.CodigoConcepto).HasColumnName("codigo_concepto");

                entity.Property(e => e.CodigoOperacionPadre).HasColumnName("codigo_operacion_padre");

                entity.Property(e => e.CodigoTipoOperacion).HasColumnName("codigo_tipo_operacion");

                entity.Property(e => e.ConfigEntidadGenerica).HasColumnName("config_entidad_generica");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("descripcion");

                entity.Property(e => e.Estado).HasColumnName("estado");

                entity.Property(e => e.FechaIng)
                    .HasColumnType("datetime")
                    .HasColumnName("fecha_ing");

                entity.Property(e => e.Grupo01).HasColumnName("grupo_01");

                entity.Property(e => e.Grupo02).HasColumnName("grupo_02");

                entity.Property(e => e.Grupo03).HasColumnName("grupo_03");

                entity.Property(e => e.HabilitarParaCaja).HasColumnName("habilitar_para_caja");

                entity.Property(e => e.NombreOperacion)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("nombre_operacion");

                entity.Property(e => e.NombreReporteCaja)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("nombre_reporte_caja");

                entity.Property(e => e.UsuarioIng)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("usuario_ing");

                entity.HasOne(d => d.CodigoCategoriaOperacionNavigation)
                    .WithMany(p => p.Operacions)
                    .HasForeignKey(d => d.CodigoCategoriaOperacion)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SIT_OPERACION_CATEGORIA");

                entity.HasOne(d => d.CodigoTipoOperacionNavigation)
                    .WithMany(p => p.Operacions)
                    .HasForeignKey(d => d.CodigoTipoOperacion)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SIT_OPERACION_TIPO");
            });

            modelBuilder.Entity<OtrosIngreso>(entity =>
            {
                entity.HasKey(e => e.CodigoOtroIngreso)
                    .HasName("PK_SIT_OTROSINGRESOS");

                entity.ToTable("otros_ingresos", "db_tesoreria");

                entity.HasIndex(e => e.Nombre, "UQ_SIT_OTROSINGRESOS_NOMBRE")
                    .IsUnique();

                entity.Property(e => e.CodigoOtroIngreso)
                    .ValueGeneratedNever()
                    .HasColumnName("codigo_otro_ingreso");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("descripcion");

                entity.Property(e => e.Estado).HasColumnName("estado");

                entity.Property(e => e.FechaIng)
                    .HasColumnType("datetime")
                    .HasColumnName("fecha_ing");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("nombre");

                entity.Property(e => e.UsuarioIng)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("usuario_ing");
            });

            modelBuilder.Entity<PagosYDescuento>(entity =>
            {
                entity.HasKey(e => e.CodigoPago)
                    .HasName("PK_CONTA_PAGOYDES");

                entity.ToTable("pagos_y_descuentos", "db_contabilidad");

                entity.Property(e => e.CodigoPago)
                    .ValueGeneratedNever()
                    .HasColumnName("codigo_pago");

                entity.Property(e => e.Anio).HasColumnName("anio");

                entity.Property(e => e.CodigoEmpleado)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("codigo_empleado");

                entity.Property(e => e.CodigoEmpresa).HasColumnName("codigo_empresa");

                entity.Property(e => e.CodigoEstado).HasColumnName("codigo_estado");

                entity.Property(e => e.CodigoFrecuenciaPago).HasColumnName("codigo_frecuencia_pago");

                entity.Property(e => e.CodigoOperacion).HasColumnName("codigo_operacion");

                entity.Property(e => e.CodigoQuincena).HasColumnName("codigo_quincena");

                entity.Property(e => e.CodigoTipoPlanilla).HasColumnName("codigo_tipo_planilla");

                entity.Property(e => e.FechaAct)
                    .HasColumnType("datetime")
                    .HasColumnName("fecha_act");

                entity.Property(e => e.FechaIng)
                    .HasColumnType("datetime")
                    .HasColumnName("fecha_ing");

                entity.Property(e => e.Mes).HasColumnName("mes");

                entity.Property(e => e.Monto)
                    .HasColumnType("decimal(15, 2)")
                    .HasColumnName("monto");

                entity.Property(e => e.MontoCalculado)
                    .HasColumnType("decimal(15, 2)")
                    .HasColumnName("monto_calculado");

                entity.Property(e => e.MontoDescuento)
                    .HasColumnType("decimal(15, 2)")
                    .HasColumnName("monto_descuento");

                entity.Property(e => e.MontoPlanillaExcel)
                    .HasColumnType("decimal(15, 2)")
                    .HasColumnName("monto_planilla_excel");

                entity.Property(e => e.NumeroSemana).HasColumnName("numero_semana");

                entity.Property(e => e.UsuarioAct)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("usuario_act");

                entity.Property(e => e.UsuarioIng)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("usuario_ing");

                entity.HasOne(d => d.CodigoFrecuenciaPagoNavigation)
                    .WithMany(p => p.PagosYDescuentos)
                    .HasForeignKey(d => d.CodigoFrecuenciaPago)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CONTA_PAGOYDES_FRECPAGO");

                entity.HasOne(d => d.CodigoOperacionNavigation)
                    .WithMany(p => p.PagosYDescuentos)
                    .HasForeignKey(d => d.CodigoOperacion)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CONTA_PAGOYDES_OPERACION");

                entity.HasOne(d => d.CodigoTipoPlanillaNavigation)
                    .WithMany(p => p.PagosYDescuentos)
                    .HasForeignKey(d => d.CodigoTipoPlanilla)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CONTA_PAGOYDES_TIPOPLAN");
            });

            modelBuilder.Entity<Parametro>(entity =>
            {
                entity.HasKey(e => e.CodigoParametro)
                    .HasName("PK_ADMON_PARAMETRO");

                entity.ToTable("parametro", "db_admon");

                entity.Property(e => e.CodigoParametro)
                    .ValueGeneratedNever()
                    .HasColumnName("codigo_parametro");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("descripcion");

                entity.Property(e => e.Estado).HasColumnName("estado");

                entity.Property(e => e.FechaIng)
                    .HasColumnType("datetime")
                    .HasColumnName("fecha_ing");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("nombre");

                entity.Property(e => e.UsuarioIng)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("usuario_ing");
            });

            modelBuilder.Entity<ParametroImpresion>(entity =>
            {
                entity.HasKey(e => e.CodigoConfiguracion)
                    .HasName("PK_ADMON_PARAMETERPRINTER");

                entity.ToTable("parametro_impresion", "db_admon");

                entity.Property(e => e.CodigoConfiguracion)
                    .ValueGeneratedNever()
                    .HasColumnName("codigo_configuracion");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("descripcion");

                entity.Property(e => e.Estado).HasColumnName("estado");

                entity.Property(e => e.FechaIng)
                    .HasColumnType("datetime")
                    .HasColumnName("fecha_ing");

                entity.Property(e => e.Ip)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("ip");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nombre");

                entity.Property(e => e.NombreImpresora)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nombre_impresora");

                entity.Property(e => e.NumeroCopias).HasColumnName("numero_copias");

                entity.Property(e => e.Puerto).HasColumnName("puerto");

                entity.Property(e => e.UsuarioIng)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("usuario_ing");
            });

            modelBuilder.Entity<Persona>(entity =>
            {
                entity.HasKey(e => e.Cui)
                    .HasName("PK_RRHH_PERSONA");

                entity.ToTable("persona", "db_rrhh");

                entity.Property(e => e.Cui)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("cui");

                entity.Property(e => e.ApellidoCasada)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("apellido_casada");

                entity.Property(e => e.CodigoArea).HasColumnName("codigo_area");

                entity.Property(e => e.CodigoDepartamentoResidencia).HasColumnName("codigo_departamento_residencia");

                entity.Property(e => e.CodigoEstado).HasColumnName("codigo_estado");

                entity.Property(e => e.CodigoGenero)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("codigo_genero");

                entity.Property(e => e.CodigoMunicipioResidencia).HasColumnName("codigo_municipio_residencia");

                entity.Property(e => e.CorreoElectronico)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("correo_electronico");

                entity.Property(e => e.DireccionResidencia)
                    .IsRequired()
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("direccion_residencia");

                entity.Property(e => e.FechaAct)
                    .HasColumnType("datetime")
                    .HasColumnName("fecha_act");

                entity.Property(e => e.FechaIng)
                    .HasColumnType("datetime")
                    .HasColumnName("fecha_ing");

                entity.Property(e => e.FechaNacimiento)
                    .HasColumnType("date")
                    .HasColumnName("fecha_nacimiento");

                entity.Property(e => e.Foto)
                    .IsUnicode(false)
                    .HasColumnName("foto");

                entity.Property(e => e.NoIncluidoEnPlanilla).HasColumnName("no_incluido_en_planilla");

                entity.Property(e => e.NombreCompleto)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("nombre_completo");

                entity.Property(e => e.PrimerApellido)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("primer_apellido");

                entity.Property(e => e.PrimerNombre)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("primer_nombre");

                entity.Property(e => e.SegundoApellido)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("segundo_apellido");

                entity.Property(e => e.SegundoNombre)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("segundo_nombre");

                entity.Property(e => e.TercerNombre)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("tercer_nombre");

                entity.Property(e => e.UsuarioAct)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("usuario_act");

                entity.Property(e => e.UsuarioIng)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("usuario_ing");

                entity.Property(e => e.Zona).HasColumnName("zona");

                entity.HasOne(d => d.CodigoAreaNavigation)
                    .WithMany(p => p.Personas)
                    .HasForeignKey(d => d.CodigoArea)
                    .HasConstraintName("FK_RRHH_PERSONA_AREA");

                entity.HasOne(d => d.Codigo)
                    .WithMany(p => p.Personas)
                    .HasForeignKey(d => new { d.CodigoDepartamentoResidencia, d.CodigoMunicipioResidencia })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RRHH_PERSONA_MUNIRES");
            });

            modelBuilder.Entity<PersonaHist>(entity =>
            {
                entity.HasKey(e => e.CodigoHistorial)
                    .HasName("PK_RRHH_PERSONAHIST");

                entity.ToTable("persona_hist", "db_rrhh");

                entity.Property(e => e.CodigoHistorial)
                    .ValueGeneratedNever()
                    .HasColumnName("codigo_historial");

                entity.Property(e => e.ApellidoCasada)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("apellido_casada");

                entity.Property(e => e.CodigoArea).HasColumnName("codigo_area");

                entity.Property(e => e.CodigoDepartamentoResidencia).HasColumnName("codigo_departamento_residencia");

                entity.Property(e => e.CodigoEstado).HasColumnName("codigo_estado");

                entity.Property(e => e.CodigoGenero)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("codigo_genero");

                entity.Property(e => e.CodigoMunicipioResidencia).HasColumnName("codigo_municipio_residencia");

                entity.Property(e => e.CorreoElectronico)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("correo_electronico");

                entity.Property(e => e.Cui)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("cui");

                entity.Property(e => e.DireccionResidencia)
                    .IsRequired()
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("direccion_residencia");

                entity.Property(e => e.FechaAct)
                    .HasColumnType("datetime")
                    .HasColumnName("fecha_act");

                entity.Property(e => e.FechaIng)
                    .HasColumnType("datetime")
                    .HasColumnName("fecha_ing");

                entity.Property(e => e.FechaNacimiento)
                    .HasColumnType("date")
                    .HasColumnName("fecha_nacimiento");

                entity.Property(e => e.NoIncluidoEnPlanilla).HasColumnName("no_incluido_en_planilla");

                entity.Property(e => e.NombreCompleto)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("nombre_completo");

                entity.Property(e => e.PrimerApellido)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("primer_apellido");

                entity.Property(e => e.PrimerNombre)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("primer_nombre");

                entity.Property(e => e.SegundoApellido)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("segundo_apellido");

                entity.Property(e => e.SegundoNombre)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("segundo_nombre");

                entity.Property(e => e.TercerNombre)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("tercer_nombre");

                entity.Property(e => e.UsuarioAct)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("usuario_act");

                entity.Property(e => e.UsuarioIng)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("usuario_ing");

                entity.Property(e => e.Zona).HasColumnName("zona");

                entity.HasOne(d => d.CodigoAreaNavigation)
                    .WithMany(p => p.PersonaHists)
                    .HasForeignKey(d => d.CodigoArea)
                    .HasConstraintName("FK_RRHH_PERSONAHIST_AREA");

                entity.HasOne(d => d.Codigo)
                    .WithMany(p => p.PersonaHists)
                    .HasForeignKey(d => new { d.CodigoDepartamentoResidencia, d.CodigoMunicipioResidencia })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RRHH_PERSONAHIST_MUNIRES");
            });

            modelBuilder.Entity<PersonaNotificacion>(entity =>
            {
                entity.HasKey(e => new { e.Cui, e.CodigoTipoNotificacion })
                    .HasName("PK_ADMON_PERSONANOTIFICA");

                entity.ToTable("persona_notificacion", "db_admon");

                entity.Property(e => e.Cui)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("cui");

                entity.Property(e => e.CodigoTipoNotificacion).HasColumnName("codigo_tipo_notificacion");

                entity.Property(e => e.Estado).HasColumnName("estado");

                entity.Property(e => e.FechaIng)
                    .HasColumnType("datetime")
                    .HasColumnName("fecha_ing");

                entity.Property(e => e.UsuarioIng)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("usuario_ing");

                entity.HasOne(d => d.CuiNavigation)
                    .WithMany(p => p.PersonaNotificacions)
                    .HasForeignKey(d => d.Cui)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ADMON_PERSONANOTIFICA_CUI");
            });

            modelBuilder.Entity<Planilla20221001Minimo>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Planilla20221001_Minimo", "db_rrhh");

                entity.Property(e => e.AfiliacionIgss)
                    .HasMaxLength(150)
                    .HasColumnName("AFILIACION_IGSS");

                entity.Property(e => e.Area)
                    .HasMaxLength(150)
                    .HasColumnName("AREA");

                entity.Property(e => e.AreaSinTilde)
                    .HasMaxLength(150)
                    .HasColumnName("AREA_SIN_TILDE");

                entity.Property(e => e.CodArea).HasColumnName("COD_AREA");

                entity.Property(e => e.CodEmpresa)
                    .HasMaxLength(50)
                    .HasColumnName("COD_EMPRESA");

                entity.Property(e => e.CodEstado).HasColumnName("COD_ESTADO");

                entity.Property(e => e.CodFrecuenciaPago).HasColumnName("COD_FRECUENCIA_PAGO");

                entity.Property(e => e.CodGenero)
                    .HasMaxLength(2)
                    .HasColumnName("COD_GENERO");

                entity.Property(e => e.CodHorario).HasColumnName("COD_HORARIO");

                entity.Property(e => e.CodPuesto).HasColumnName("COD_PUESTO");

                entity.Property(e => e.CodSeccion).HasColumnName("COD_SECCION");

                entity.Property(e => e.CodTipoCuenta).HasColumnName("COD_TIPO_CUENTA");

                entity.Property(e => e.CodigoEmpleado)
                    .HasMaxLength(50)
                    .HasColumnName("CODIGO_EMPLEADO");

                entity.Property(e => e.Cui)
                    .HasMaxLength(50)
                    .HasColumnName("CUI");

                entity.Property(e => e.DescuentoIngresosTarde)
                    .HasMaxLength(50)
                    .HasColumnName("DESCUENTO_INGRESOS_TARDE");

                entity.Property(e => e.DescuentoSeptimodiaPorAusencias)
                    .HasMaxLength(50)
                    .HasColumnName("DESCUENTO_SEPTIMODIA_POR_AUSENCIAS");

                entity.Property(e => e.DocumentoAusencias)
                    .HasMaxLength(50)
                    .HasColumnName("DOCUMENTO_AUSENCIAS");

                entity.Property(e => e.Edad).HasColumnName("EDAD");

                entity.Property(e => e.Empresa)
                    .HasMaxLength(150)
                    .HasColumnName("EMPRESA");

                entity.Property(e => e.EmpresaSinTilde)
                    .HasMaxLength(150)
                    .HasColumnName("EMPRESA_SIN_TILDE");

                entity.Property(e => e.Estado)
                    .HasMaxLength(50)
                    .HasColumnName("ESTADO");

                entity.Property(e => e.FechaEgreso)
                    .HasMaxLength(50)
                    .HasColumnName("FECHA_EGRESO");

                entity.Property(e => e.FechaIngreso)
                    .HasMaxLength(50)
                    .HasColumnName("FECHA_INGRESO");

                entity.Property(e => e.FechaNacimiento)
                    .HasMaxLength(50)
                    .HasColumnName("FECHA_NACIMIENTO");

                entity.Property(e => e.FrecuenciaPago)
                    .HasMaxLength(50)
                    .HasColumnName("FRECUENCIA_PAGO");

                entity.Property(e => e.Genero)
                    .HasMaxLength(50)
                    .HasColumnName("GENERO");

                entity.Property(e => e.Horario)
                    .HasMaxLength(50)
                    .HasColumnName("HORARIO");

                entity.Property(e => e.HorasDoblesSabados)
                    .HasMaxLength(50)
                    .HasColumnName("HORAS_DOBLES_SABADOS");

                entity.Property(e => e.Nit)
                    .HasMaxLength(50)
                    .HasColumnName("NIT");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(150)
                    .HasColumnName("NOMBRE");

                entity.Property(e => e.NombreSinTilde)
                    .HasMaxLength(150)
                    .HasColumnName("NOMBRE_SIN_TILDE");

                entity.Property(e => e.NumeroCuenta)
                    .HasMaxLength(50)
                    .HasColumnName("NUMERO_CUENTA");

                entity.Property(e => e.Puesto)
                    .HasMaxLength(150)
                    .HasColumnName("PUESTO");

                entity.Property(e => e.PuestoSinTilde)
                    .HasMaxLength(150)
                    .HasColumnName("PUESTO_SIN_TILDE");

                entity.Property(e => e.Row)
                    .HasMaxLength(50)
                    .HasColumnName("ROW");

                entity.Property(e => e.Seccion)
                    .HasMaxLength(150)
                    .HasColumnName("SECCION");

                entity.Property(e => e.SeccionSinTilde)
                    .HasMaxLength(150)
                    .HasColumnName("SECCION_SIN_TILDE");

                entity.Property(e => e.TipoCuenta)
                    .HasMaxLength(50)
                    .HasColumnName("TIPO_CUENTA");
            });

            modelBuilder.Entity<PlanillaOctubre2022>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("PlanillaOctubre2022", "db_rrhh");

                entity.Property(e => e.Afiliacion)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("AFILIACION");

                entity.Property(e => e.Area)
                    .HasMaxLength(150)
                    .HasColumnName("AREA");

                entity.Property(e => e.AreaSinTilde)
                    .HasMaxLength(150)
                    .HasColumnName("AREA_SIN_TILDE");

                entity.Property(e => e.CodArea).HasColumnName("COD_AREA");

                entity.Property(e => e.CodEmpresa).HasColumnName("COD_EMPRESA");

                entity.Property(e => e.CodEstatus)
                    .HasMaxLength(1)
                    .HasColumnName("COD_ESTATUS");

                entity.Property(e => e.CodFrecuenciaPago)
                    .HasMaxLength(1)
                    .HasColumnName("COD_FRECUENCIA_PAGO");

                entity.Property(e => e.CodGenero)
                    .HasMaxLength(1)
                    .HasColumnName("COD_GENERO");

                entity.Property(e => e.CodHorario)
                    .HasMaxLength(1)
                    .HasColumnName("COD_HORARIO");

                entity.Property(e => e.CodPuesto)
                    .HasMaxLength(1)
                    .HasColumnName("COD_PUESTO");

                entity.Property(e => e.CodSeccion).HasColumnName("COD_SECCION");

                entity.Property(e => e.CodTipoCuenta)
                    .HasMaxLength(1)
                    .HasColumnName("COD_TIPO_CUENTA");

                entity.Property(e => e.Codigo)
                    .HasMaxLength(50)
                    .HasColumnName("CODIGO");

                entity.Property(e => e.Correlativo).HasColumnName("CORRELATIVO");

                entity.Property(e => e.CuentaBancaria)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CUENTA_BANCARIA");

                entity.Property(e => e.Cui)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CUI");

                entity.Property(e => e.Empresa)
                    .HasMaxLength(150)
                    .HasColumnName("EMPRESA");

                entity.Property(e => e.EmpresaSinTilde)
                    .HasMaxLength(150)
                    .HasColumnName("EMPRESA_SIN_TILDE");

                entity.Property(e => e.Estatus)
                    .HasMaxLength(50)
                    .HasColumnName("ESTATUS");

                entity.Property(e => e.FechaEgreso)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("FECHA_EGRESO");

                entity.Property(e => e.FechaIngreso)
                    .HasMaxLength(30)
                    .HasColumnName("FECHA_INGRESO");

                entity.Property(e => e.FechaNacimiento)
                    .HasMaxLength(50)
                    .HasColumnName("FECHA_NACIMIENTO");

                entity.Property(e => e.FrecuenciaPago)
                    .HasMaxLength(150)
                    .HasColumnName("FRECUENCIA_PAGO");

                entity.Property(e => e.Genero)
                    .HasMaxLength(50)
                    .HasColumnName("GENERO");

                entity.Property(e => e.Horario)
                    .HasMaxLength(50)
                    .HasColumnName("HORARIO");

                entity.Property(e => e.Nit)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("NIT");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(150)
                    .HasColumnName("NOMBRE");

                entity.Property(e => e.NombreSinTilde)
                    .HasMaxLength(150)
                    .HasColumnName("NOMBRE_SIN_TILDE");

                entity.Property(e => e.Puesto)
                    .HasMaxLength(150)
                    .HasColumnName("PUESTO");

                entity.Property(e => e.PuestoSinTilde)
                    .HasMaxLength(150)
                    .HasColumnName("PUESTO_SIN_TILDE");

                entity.Property(e => e.Seccion)
                    .HasMaxLength(150)
                    .HasColumnName("SECCION");

                entity.Property(e => e.SeccionSinTilde)
                    .HasMaxLength(150)
                    .HasColumnName("SECCION_SIN_TILDE");

                entity.Property(e => e.TipoCuenta)
                    .HasMaxLength(50)
                    .HasColumnName("TIPO_CUENTA");
            });

            modelBuilder.Entity<ProgramacionQuincenal>(entity =>
            {
                entity.HasKey(e => e.CodigoProgramacion)
                    .HasName("PK_ADMON_PROGQUINCENAL");

                entity.ToTable("programacion_quincenal", "db_admon");

                entity.Property(e => e.CodigoProgramacion)
                    .ValueGeneratedNever()
                    .HasColumnName("codigo_programacion");

                entity.Property(e => e.Anio).HasColumnName("anio");

                entity.Property(e => e.CodigoQuincena).HasColumnName("codigo_quincena");

                entity.Property(e => e.Estado).HasColumnName("estado");

                entity.Property(e => e.FechaFin)
                    .HasColumnType("date")
                    .HasColumnName("fecha_fin");

                entity.Property(e => e.FechaIng)
                    .HasColumnType("datetime")
                    .HasColumnName("fecha_ing");

                entity.Property(e => e.FechaInicio)
                    .HasColumnType("date")
                    .HasColumnName("fecha_inicio");

                entity.Property(e => e.NumeroMes).HasColumnName("numero_mes");

                entity.Property(e => e.NumeroQuincena).HasColumnName("numero_quincena");

                entity.Property(e => e.UsuarioIng)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("usuario_ing");
            });

            modelBuilder.Entity<ProgramacionSemanal>(entity =>
            {
                entity.HasKey(e => e.CodigoProgramacion)
                    .HasName("PK_ADMON_PROGSEMANAL");

                entity.ToTable("programacion_semanal", "db_admon");

                entity.Property(e => e.CodigoProgramacion)
                    .ValueGeneratedNever()
                    .HasColumnName("codigo_programacion");

                entity.Property(e => e.Anio).HasColumnName("anio");

                entity.Property(e => e.Estado).HasColumnName("estado");

                entity.Property(e => e.Fecha)
                    .HasColumnType("date")
                    .HasColumnName("fecha");

                entity.Property(e => e.FechaIng)
                    .HasColumnType("datetime")
                    .HasColumnName("fecha_ing");

                entity.Property(e => e.NumeroDia).HasColumnName("numero_dia");

                entity.Property(e => e.NumeroSemana).HasColumnName("numero_semana");

                entity.Property(e => e.UsuarioIng)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("usuario_ing");
            });

            modelBuilder.Entity<Puesto>(entity =>
            {
                entity.HasKey(e => e.CodigoPuesto)
                    .HasName("PK_RRHH_PUESTO");

                entity.ToTable("puesto", "db_rrhh");

                entity.HasIndex(e => e.Nombre, "UQ_RRHH_PUESTO_NOMBRE")
                    .IsUnique();

                entity.Property(e => e.CodigoPuesto)
                    .ValueGeneratedNever()
                    .HasColumnName("codigo_puesto");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("descripcion");

                entity.Property(e => e.Estado).HasColumnName("estado");

                entity.Property(e => e.FechaIng)
                    .HasColumnType("datetime")
                    .HasColumnName("fecha_ing");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("nombre");

                entity.Property(e => e.UsuarioIng)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("usuario_ing");
            });

            modelBuilder.Entity<ReporteCaja>(entity =>
            {
                entity.HasKey(e => e.CodigoReporte)
                    .HasName("PK_SIT_REPORTECAJA");

                entity.ToTable("reporte_caja", "db_tesoreria");

                entity.Property(e => e.CodigoReporte)
                    .ValueGeneratedNever()
                    .HasColumnName("codigo_reporte");

                entity.Property(e => e.Anio).HasColumnName("anio");

                entity.Property(e => e.Arqueo).HasColumnName("arqueo");

                entity.Property(e => e.CodigoEstado).HasColumnName("codigo_estado");

                entity.Property(e => e.FechaAct)
                    .HasColumnType("datetime")
                    .HasColumnName("fecha_act");

                entity.Property(e => e.FechaIng)
                    .HasColumnType("datetime")
                    .HasColumnName("fecha_ing");

                entity.Property(e => e.NumeroSemana).HasColumnName("numero_semana");

                entity.Property(e => e.Observaciones)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("observaciones");

                entity.Property(e => e.UsuarioAct)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("usuario_act");

                entity.Property(e => e.UsuarioIng)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("usuario_ing");

                entity.HasOne(d => d.CodigoEstadoNavigation)
                    .WithMany(p => p.ReporteCajas)
                    .HasForeignKey(d => d.CodigoEstado)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SIT_REPORTECAJA_ESTADO");
            });

            modelBuilder.Entity<ReporteCajaChica>(entity =>
            {
                entity.HasKey(e => e.CodigoReporte)
                    .HasName("PK_SIT_REPORTCAJAC");

                entity.ToTable("reporte_caja_chica", "db_tesoreria");

                entity.Property(e => e.CodigoReporte)
                    .ValueGeneratedNever()
                    .HasColumnName("codigo_reporte");

                entity.Property(e => e.AnioOperacion).HasColumnName("anio_operacion");

                entity.Property(e => e.Arqueo).HasColumnName("arqueo");

                entity.Property(e => e.CodigoCajaChica).HasColumnName("codigo_caja_chica");

                entity.Property(e => e.CodigoEstado).HasColumnName("codigo_estado");

                entity.Property(e => e.FechaAct)
                    .HasColumnType("datetime")
                    .HasColumnName("fecha_act");

                entity.Property(e => e.FechaGeneracion)
                    .HasColumnType("datetime")
                    .HasColumnName("fecha_generacion");

                entity.Property(e => e.FechaIng)
                    .HasColumnType("datetime")
                    .HasColumnName("fecha_ing");

                entity.Property(e => e.FechaRecepcionReembolso)
                    .HasColumnType("datetime")
                    .HasColumnName("fecha_recepcion_reembolso");

                entity.Property(e => e.MontoAsignado)
                    .HasColumnType("decimal(15, 2)")
                    .HasColumnName("monto_asignado");

                entity.Property(e => e.MontoReembolso)
                    .HasColumnType("decimal(15, 2)")
                    .HasColumnName("monto_reembolso");

                entity.Property(e => e.MontoReembolsoCalculado)
                    .HasColumnType("decimal(15, 2)")
                    .HasColumnName("monto_reembolso_calculado");

                entity.Property(e => e.MontoSaldoInicial)
                    .HasColumnType("decimal(15, 2)")
                    .HasColumnName("monto_saldo_inicial");

                entity.Property(e => e.Observaciones)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("observaciones");

                entity.Property(e => e.ObservacionesRecepcionReembolso)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("observaciones_recepcion_reembolso");

                entity.Property(e => e.ReembolsoRecibido).HasColumnName("reembolso_recibido");

                entity.Property(e => e.SemanaOperacion).HasColumnName("semana_operacion");

                entity.Property(e => e.UsuarioAct)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("usuario_act");

                entity.Property(e => e.UsuarioIng)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("usuario_ing");

                entity.Property(e => e.UsuarioRecepcionReembolso)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("usuario_recepcion_reembolso");

                entity.HasOne(d => d.CodigoCajaChicaNavigation)
                    .WithMany(p => p.ReporteCajaChicas)
                    .HasForeignKey(d => d.CodigoCajaChica)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SIT_REPORTCAJAC_CAJACHICA");

                entity.HasOne(d => d.CodigoEstadoNavigation)
                    .WithMany(p => p.ReporteCajaChicas)
                    .HasForeignKey(d => d.CodigoEstado)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SIT_REPORTCAJAC_ESTADO");
            });

            modelBuilder.Entity<ReporteCajaDetalle>(entity =>
            {
                entity.HasKey(e => e.CodigoDetalleReporte)
                    .HasName("PK_SIT_REPORTECAJAD");

                entity.ToTable("reporte_caja_detalle", "db_tesoreria");

                entity.Property(e => e.CodigoDetalleReporte)
                    .ValueGeneratedNever()
                    .HasColumnName("codigo_detalle_reporte");

                entity.Property(e => e.CodigoCategoriaEntidad).HasColumnName("codigo_categoria_entidad");

                entity.Property(e => e.CodigoConcepto).HasColumnName("codigo_concepto");

                entity.Property(e => e.CodigoEntidad)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("codigo_entidad");

                entity.Property(e => e.CodigoOperacion).HasColumnName("codigo_operacion");

                entity.Property(e => e.CodigoReporte).HasColumnName("codigo_reporte");

                entity.Property(e => e.CodigoTipoOperacion).HasColumnName("codigo_tipo_operacion");

                entity.Property(e => e.CodigoTransaccion).HasColumnName("codigo_transaccion");

                entity.Property(e => e.Estado).HasColumnName("estado");

                entity.Property(e => e.FechaAct)
                    .HasColumnType("datetime")
                    .HasColumnName("fecha_act");

                entity.Property(e => e.FechaIng)
                    .HasColumnType("datetime")
                    .HasColumnName("fecha_ing");

                entity.Property(e => e.MontoDevoluciones)
                    .HasColumnType("decimal(15, 2)")
                    .HasColumnName("monto_devoluciones");

                entity.Property(e => e.MontoDomingo)
                    .HasColumnType("decimal(15, 2)")
                    .HasColumnName("monto_domingo");

                entity.Property(e => e.MontoJueves)
                    .HasColumnType("decimal(15, 2)")
                    .HasColumnName("monto_jueves");

                entity.Property(e => e.MontoLunes)
                    .HasColumnType("decimal(15, 2)")
                    .HasColumnName("monto_lunes");

                entity.Property(e => e.MontoMartes)
                    .HasColumnType("decimal(15, 2)")
                    .HasColumnName("monto_martes");

                entity.Property(e => e.MontoMiercoles)
                    .HasColumnType("decimal(15, 2)")
                    .HasColumnName("monto_miercoles");

                entity.Property(e => e.MontoSabado)
                    .HasColumnType("decimal(15, 2)")
                    .HasColumnName("monto_sabado");

                entity.Property(e => e.MontoViernes)
                    .HasColumnType("decimal(15, 2)")
                    .HasColumnName("monto_viernes");

                entity.Property(e => e.NombreEntidad)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("nombre_entidad");

                entity.Property(e => e.NombreEntidadCompleto)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("nombre_entidad_completo");

                entity.Property(e => e.SaldoAnterior)
                    .HasColumnType("decimal(15, 2)")
                    .HasColumnName("saldo_anterior");

                entity.Property(e => e.UsuarioAct)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("usuario_act");

                entity.Property(e => e.UsuarioIng)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("usuario_ing");

                entity.HasOne(d => d.CodigoCategoriaEntidadNavigation)
                    .WithMany(p => p.ReporteCajaDetalles)
                    .HasForeignKey(d => d.CodigoCategoriaEntidad)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SIT_REPORTECAJAD_CATEND");

                entity.HasOne(d => d.CodigoConceptoNavigation)
                    .WithMany(p => p.ReporteCajaDetalles)
                    .HasForeignKey(d => d.CodigoConcepto)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SIT_REPORTECAJAD_CONCEPTO");

                entity.HasOne(d => d.CodigoOperacionNavigation)
                    .WithMany(p => p.ReporteCajaDetalles)
                    .HasForeignKey(d => d.CodigoOperacion)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SIT_REPORTECAJAD_OPCAJA");

                entity.HasOne(d => d.CodigoReporteNavigation)
                    .WithMany(p => p.ReporteCajaDetalles)
                    .HasForeignKey(d => d.CodigoReporte)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SIT_REPORTECAJAD_REPORTE");

                entity.HasOne(d => d.CodigoTransaccionNavigation)
                    .WithMany(p => p.ReporteCajaDetalles)
                    .HasForeignKey(d => d.CodigoTransaccion)
                    .HasConstraintName("FK_SIT_REPORTECAJAD_TRANSAC");
            });

            modelBuilder.Entity<Rol>(entity =>
            {
                entity.HasKey(e => e.CodigoRol)
                    .HasName("PK_ADMON_ROL");

                entity.ToTable("rol", "db_admon");

                entity.HasIndex(e => e.Nombre, "UQ_ADMON_ROL_NOMBRE")
                    .IsUnique();

                entity.Property(e => e.CodigoRol)
                    .ValueGeneratedNever()
                    .HasColumnName("codigo_rol");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("descripcion");

                entity.Property(e => e.Estado).HasColumnName("estado");

                entity.Property(e => e.FechaIng)
                    .HasColumnType("datetime")
                    .HasColumnName("fecha_ing");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("nombre");

                entity.Property(e => e.UsuarioIng)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("usuario_ing");
            });

            modelBuilder.Entity<RolSitemap>(entity =>
            {
                entity.HasKey(e => new { e.CodigoRol, e.CodigoSitemap })
                    .HasName("PK_ADMON_ROLESITE");

                entity.ToTable("rol_sitemap", "db_admon");

                entity.Property(e => e.CodigoRol).HasColumnName("codigo_rol");

                entity.Property(e => e.CodigoSitemap).HasColumnName("codigo_sitemap");

                entity.Property(e => e.Estado).HasColumnName("estado");

                entity.Property(e => e.FechaIng)
                    .HasColumnType("datetime")
                    .HasColumnName("fecha_ing");

                entity.Property(e => e.UsuarioIng)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("usuario_ing");

                entity.HasOne(d => d.CodigoRolNavigation)
                    .WithMany(p => p.RolSitemaps)
                    .HasForeignKey(d => d.CodigoRol)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ADMON_ROLESITE_ROL");

                entity.HasOne(d => d.CodigoSitemapNavigation)
                    .WithMany(p => p.RolSitemaps)
                    .HasForeignKey(d => d.CodigoSitemap)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ADMON_ROLESITE_SITE");
            });

            modelBuilder.Entity<Rutum>(entity =>
            {
                entity.HasKey(e => e.Ruta)
                    .HasName("PK_VENTAS_RUTA");

                entity.ToTable("ruta", "db_ventas");

                entity.Property(e => e.Ruta)
                    .ValueGeneratedNever()
                    .HasColumnName("ruta");

                entity.Property(e => e.CodigoCanalVenta).HasColumnName("codigo_canal_venta");

                entity.Property(e => e.CodigoTipoRuta).HasColumnName("codigo_tipo_ruta");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("descripcion");

                entity.Property(e => e.Estado).HasColumnName("estado");

                entity.Property(e => e.FechaAct)
                    .HasColumnType("datetime")
                    .HasColumnName("fecha_act");

                entity.Property(e => e.FechaIng)
                    .HasColumnType("datetime")
                    .HasColumnName("fecha_ing");

                entity.Property(e => e.MigracionCompleta).HasColumnName("migracion_completa");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("nombre");

                entity.Property(e => e.NombreCorto)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("nombre_corto");

                entity.Property(e => e.UsuarioAct)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("usuario_act");

                entity.Property(e => e.UsuarioIng)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("usuario_ing");

                entity.HasOne(d => d.CodigoCanalVentaNavigation)
                    .WithMany(p => p.Ruta)
                    .HasForeignKey(d => d.CodigoCanalVenta)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_VENTAS_RUTA_CANAL");

                entity.HasOne(d => d.CodigoTipoRutaNavigation)
                    .WithMany(p => p.Ruta)
                    .HasForeignKey(d => d.CodigoTipoRuta)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_VENTAS_RUTA_TIPORUTA");
            });

            modelBuilder.Entity<SaldosIniciale>(entity =>
            {
                entity.HasKey(e => e.CodigoSaldoInicial)
                    .HasName("PK_CONTA_SALDOS");

                entity.ToTable("saldos_iniciales", "db_contabilidad");

                entity.Property(e => e.CodigoSaldoInicial)
                    .ValueGeneratedNever()
                    .HasColumnName("codigo_saldo_inicial");

                entity.Property(e => e.AnioOperacion).HasColumnName("anio_operacion");

                entity.Property(e => e.CodigoCategoriaEntidad).HasColumnName("codigo_categoria_entidad");

                entity.Property(e => e.CodigoEntidad)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("codigo_entidad");

                entity.Property(e => e.CodigoEstado).HasColumnName("codigo_estado");

                entity.Property(e => e.CodigoOperacion).HasColumnName("codigo_operacion");

                entity.Property(e => e.CodigoReporte).HasColumnName("codigo_reporte");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("descripcion");

                entity.Property(e => e.FechaAct)
                    .HasColumnType("datetime")
                    .HasColumnName("fecha_act");

                entity.Property(e => e.FechaIng)
                    .HasColumnType("datetime")
                    .HasColumnName("fecha_ing");

                entity.Property(e => e.Monto)
                    .HasColumnType("decimal(15, 2)")
                    .HasColumnName("monto");

                entity.Property(e => e.SemanaOperacion).HasColumnName("semana_operacion");

                entity.Property(e => e.UsuarioAct)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("usuario_act");

                entity.Property(e => e.UsuarioIng)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("usuario_ing");

                entity.HasOne(d => d.CodigoCategoriaEntidadNavigation)
                    .WithMany(p => p.SaldosIniciales)
                    .HasForeignKey(d => d.CodigoCategoriaEntidad)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CONTA_SALDOS_CATEGORIAENTIDAD");

                entity.HasOne(d => d.CodigoOperacionNavigation)
                    .WithMany(p => p.SaldosIniciales)
                    .HasForeignKey(d => d.CodigoOperacion)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CONTA_SALDOS_OPERACION");

                entity.HasOne(d => d.CodigoReporteNavigation)
                    .WithMany(p => p.SaldosIniciales)
                    .HasForeignKey(d => d.CodigoReporte)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CONTA_SALDOS_REPORTE");
            });

            modelBuilder.Entity<Seccion>(entity =>
            {
                entity.HasKey(e => e.CodigoSeccion)
                    .HasName("PK_RRHH_SECCION");

                entity.ToTable("seccion", "db_rrhh");

                entity.HasIndex(e => e.Nombre, "UQ_RRHH_SECCION_NOMBRE")
                    .IsUnique();

                entity.Property(e => e.CodigoSeccion)
                    .ValueGeneratedNever()
                    .HasColumnName("codigo_seccion");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("descripcion");

                entity.Property(e => e.Estado).HasColumnName("estado");

                entity.Property(e => e.FechaIng)
                    .HasColumnType("datetime")
                    .HasColumnName("fecha_ing");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("nombre");

                entity.Property(e => e.UsuarioIng)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("usuario_ing");
            });

            modelBuilder.Entity<SecuenciaDetalle>(entity =>
            {
                entity.HasKey(e => e.CodigoSecuenciaDet)
                    .HasName("PK_ADMON_SEQDET");

                entity.ToTable("secuencia_detalle", "db_admon");

                entity.Property(e => e.CodigoSecuenciaDet)
                    .ValueGeneratedNever()
                    .HasColumnName("codigo_secuencia_det");

                entity.Property(e => e.Anio).HasColumnName("anio");

                entity.Property(e => e.CodigoSecuencia).HasColumnName("codigo_secuencia");

                entity.Property(e => e.Incremento).HasColumnName("incremento");

                entity.Property(e => e.SigValor).HasColumnName("sig_valor");

                entity.HasOne(d => d.CodigoSecuenciaNavigation)
                    .WithMany(p => p.SecuenciaDetalles)
                    .HasForeignKey(d => d.CodigoSecuencia)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ADMON_SEQDET_SEQ");
            });

            modelBuilder.Entity<Secuencium>(entity =>
            {
                entity.HasKey(e => e.CodigoSecuencia)
                    .HasName("PK_ADMON_SEQ");

                entity.ToTable("secuencia", "db_admon");

                entity.Property(e => e.CodigoSecuencia)
                    .ValueGeneratedNever()
                    .HasColumnName("codigo_secuencia");

                entity.Property(e => e.CodigoSistema).HasColumnName("codigo_sistema");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("descripcion");

                entity.Property(e => e.Estado).HasColumnName("estado");

                entity.Property(e => e.FechaIng)
                    .HasColumnType("datetime")
                    .HasColumnName("fecha_ing");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nombre");

                entity.Property(e => e.UsuarioIng)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("usuario_ing");

                entity.HasOne(d => d.CodigoSistemaNavigation)
                    .WithMany(p => p.Secuencia)
                    .HasForeignKey(d => d.CodigoSistema)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ADMON_SEQ_SISTEMA");
            });

            modelBuilder.Entity<Sistema>(entity =>
            {
                entity.HasKey(e => e.CodigoSistema)
                    .HasName("PK_ADMON_SISTEMA");

                entity.ToTable("sistema", "db_admon");

                entity.HasIndex(e => e.Nombre, "UQ_ADMON_SISTEMA_NOMBRE")
                    .IsUnique();

                entity.HasIndex(e => e.NombreCorto, "UQ_ADMON_SISTEMA_NOMBREC")
                    .IsUnique();

                entity.Property(e => e.CodigoSistema)
                    .ValueGeneratedNever()
                    .HasColumnName("codigo_sistema");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("descripcion");

                entity.Property(e => e.Estado).HasColumnName("estado");

                entity.Property(e => e.FechaIng)
                    .HasColumnType("datetime")
                    .HasColumnName("fecha_ing");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("nombre");

                entity.Property(e => e.NombreCorto)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("nombre_corto");

                entity.Property(e => e.UsuarioIng)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("usuario_ing");
            });

            modelBuilder.Entity<Sitemap>(entity =>
            {
                entity.HasKey(e => e.CodigoSitemap)
                    .HasName("PK_ADMON_SITEMAP");

                entity.ToTable("sitemap", "db_admon");

                entity.Property(e => e.CodigoSitemap)
                    .ValueGeneratedNever()
                    .HasColumnName("codigo_sitemap");

                entity.Property(e => e.CodigoSistema).HasColumnName("codigo_sistema");

                entity.Property(e => e.CodigoSitemapPadre).HasColumnName("codigo_sitemap_padre");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("descripcion");

                entity.Property(e => e.Estado).HasColumnName("estado");

                entity.Property(e => e.FechaAct)
                    .HasColumnType("datetime")
                    .HasColumnName("fecha_act");

                entity.Property(e => e.FechaIng)
                    .HasColumnType("datetime")
                    .HasColumnName("fecha_ing");

                entity.Property(e => e.Nivel).HasColumnName("nivel");

                entity.Property(e => e.NombreAction)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nombre_action");

                entity.Property(e => e.NombreController)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nombre_controller");

                entity.Property(e => e.Titulo)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("titulo");

                entity.Property(e => e.UsuarioAct)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("usuario_act");

                entity.Property(e => e.UsuarioIng)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("usuario_ing");

                entity.HasOne(d => d.CodigoSistemaNavigation)
                    .WithMany(p => p.Sitemaps)
                    .HasForeignKey(d => d.CodigoSistema)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ADMON_SITEMAP_SISTEMA");
            });

            modelBuilder.Entity<SolicitudCorreccion>(entity =>
            {
                entity.HasKey(e => e.CodigoTransaccion)
                    .HasName("PK_SIT_TSOLCORREC");

                entity.ToTable("solicitud_correccion", "db_tesoreria");

                entity.Property(e => e.CodigoTransaccion)
                    .ValueGeneratedNever()
                    .HasColumnName("codigo_transaccion");

                entity.Property(e => e.CodigoTipoCorreccion).HasColumnName("codigo_tipo_correccion");

                entity.Property(e => e.CodigoTransaccionCorrecta).HasColumnName("codigo_transaccion_correcta");

                entity.Property(e => e.Estado).HasColumnName("estado");

                entity.Property(e => e.FechaAct)
                    .HasColumnType("datetime")
                    .HasColumnName("fecha_act");

                entity.Property(e => e.FechaAprobacion)
                    .HasColumnType("datetime")
                    .HasColumnName("fecha_aprobacion");

                entity.Property(e => e.FechaIng)
                    .HasColumnType("datetime")
                    .HasColumnName("fecha_ing");

                entity.Property(e => e.ObservacionesAprobacion)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("observaciones_aprobacion");

                entity.Property(e => e.ObservacionesSolicitud)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("observaciones_solicitud");

                entity.Property(e => e.Resultado).HasColumnName("resultado");

                entity.Property(e => e.UsuarioAct)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("usuario_act");

                entity.Property(e => e.UsuarioAprobacion)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("usuario_aprobacion");

                entity.Property(e => e.UsuarioIng)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("usuario_ing");

                entity.HasOne(d => d.CodigoTransaccionNavigation)
                    .WithOne(p => p.SolicitudCorreccionCodigoTransaccionNavigation)
                    .HasForeignKey<SolicitudCorreccion>(d => d.CodigoTransaccion)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SIT_TSOLCORREC_TRANS");

                entity.HasOne(d => d.CodigoTransaccionCorrectaNavigation)
                    .WithMany(p => p.SolicitudCorreccionCodigoTransaccionCorrectaNavigations)
                    .HasForeignKey(d => d.CodigoTransaccionCorrecta)
                    .HasConstraintName("FK_SIT_TSOLCORREC_TRANSC");
            });

            modelBuilder.Entity<SolicitudCorreccionCajaChica>(entity =>
            {
                entity.HasKey(e => e.CodigoTransaccion)
                    .HasName("PK_SIT_TSOLCORCHACHICA");

                entity.ToTable("solicitud_correccion_caja_chica", "db_tesoreria");

                entity.Property(e => e.CodigoTransaccion)
                    .ValueGeneratedNever()
                    .HasColumnName("codigo_transaccion");

                entity.Property(e => e.CodigoTipoCorreccion).HasColumnName("codigo_tipo_correccion");

                entity.Property(e => e.CodigoTransaccionCorrecta).HasColumnName("codigo_transaccion_correcta");

                entity.Property(e => e.Estado).HasColumnName("estado");

                entity.Property(e => e.FechaAct)
                    .HasColumnType("datetime")
                    .HasColumnName("fecha_act");

                entity.Property(e => e.FechaAprobacion)
                    .HasColumnType("datetime")
                    .HasColumnName("fecha_aprobacion");

                entity.Property(e => e.FechaIng)
                    .HasColumnType("datetime")
                    .HasColumnName("fecha_ing");

                entity.Property(e => e.ObservacionesAprobacion)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("observaciones_aprobacion");

                entity.Property(e => e.ObservacionesSolicitud)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("observaciones_solicitud");

                entity.Property(e => e.Resultado).HasColumnName("resultado");

                entity.Property(e => e.UsuarioAct)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("usuario_act");

                entity.Property(e => e.UsuarioAprobacion)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("usuario_aprobacion");

                entity.Property(e => e.UsuarioIng)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("usuario_ing");

                entity.HasOne(d => d.CodigoTransaccionNavigation)
                    .WithOne(p => p.SolicitudCorreccionCajaChicaCodigoTransaccionNavigation)
                    .HasForeignKey<SolicitudCorreccionCajaChica>(d => d.CodigoTransaccion)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SIT_TSOLCORCHACHICA_TRANS");

                entity.HasOne(d => d.CodigoTransaccionCorrectaNavigation)
                    .WithMany(p => p.SolicitudCorreccionCajaChicaCodigoTransaccionCorrectaNavigations)
                    .HasForeignKey(d => d.CodigoTransaccionCorrecta)
                    .HasConstraintName("FK_SIT_TSOLCORCHACHICA_TRANSC");
            });

            modelBuilder.Entity<Suspension>(entity =>
            {
                entity.HasKey(e => e.CodigoSuspension)
                    .HasName("PK_RRHH_SUSPENSION");

                entity.ToTable("suspension", "db_rrhh");

                entity.Property(e => e.CodigoSuspension)
                    .ValueGeneratedNever()
                    .HasColumnName("codigo_suspension");

                entity.Property(e => e.CodigoEmpleado)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("codigo_empleado");

                entity.Property(e => e.CodigoEmpresa).HasColumnName("codigo_empresa");

                entity.Property(e => e.CodigoMotivoSuspension).HasColumnName("codigo_motivo_suspension");

                entity.Property(e => e.Estado).HasColumnName("estado");

                entity.Property(e => e.FechaAct)
                    .HasColumnType("datetime")
                    .HasColumnName("fecha_act");

                entity.Property(e => e.FechaAlta)
                    .HasColumnType("date")
                    .HasColumnName("fecha_alta");

                entity.Property(e => e.FechaFinSuspension)
                    .HasColumnType("date")
                    .HasColumnName("fecha_fin_suspension");

                entity.Property(e => e.FechaIng)
                    .HasColumnType("datetime")
                    .HasColumnName("fecha_ing");

                entity.Property(e => e.FechaInicioSuspension)
                    .HasColumnType("date")
                    .HasColumnName("fecha_inicio_suspension");

                entity.Property(e => e.Observaciones)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("observaciones");

                entity.Property(e => e.UsuarioAct)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("usuario_act");

                entity.Property(e => e.UsuarioIng)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("usuario_ing");

                entity.HasOne(d => d.CodigoMotivoSuspensionNavigation)
                    .WithMany(p => p.Suspensions)
                    .HasForeignKey(d => d.CodigoMotivoSuspension)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RRHH_SUSPENSION_MOTIVO");

                entity.HasOne(d => d.CodigoEmp)
                    .WithMany(p => p.Suspensions)
                    .HasForeignKey(d => new { d.CodigoEmpresa, d.CodigoEmpleado })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RRHH_SUSPENSION_EMPLEADO");
            });

            modelBuilder.Entity<TipoBtb>(entity =>
            {
                entity.HasKey(e => e.CodigoTipoBtb)
                    .HasName("PK_RRHH_TIPOBTB");

                entity.ToTable("tipo_btb", "db_rrhh");

                entity.HasIndex(e => e.Nombre, "UQ_RRHH_TIPOBTB_NOMBRE")
                    .IsUnique();

                entity.Property(e => e.CodigoTipoBtb).HasColumnName("codigo_tipo_btb");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("descripcion");

                entity.Property(e => e.Estado).HasColumnName("estado");

                entity.Property(e => e.FechaIng)
                    .HasColumnType("datetime")
                    .HasColumnName("fecha_ing");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("nombre");

                entity.Property(e => e.Tesoreria).HasColumnName("tesoreria");

                entity.Property(e => e.TextoComprobante)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("texto_comprobante");

                entity.Property(e => e.UsuarioIng)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("usuario_ing");
            });

            modelBuilder.Entity<TipoCliente>(entity =>
            {
                entity.HasKey(e => e.CodigoTipoCliente)
                    .HasName("PK_VENTAS_TIPOCLIENT");

                entity.ToTable("tipo_cliente", "db_ventas");

                entity.HasIndex(e => e.Nombre, "UQ_VENTAS_TIPOCLIENT_NOMBRE")
                    .IsUnique();

                entity.Property(e => e.CodigoTipoCliente)
                    .ValueGeneratedNever()
                    .HasColumnName("codigo_tipo_cliente");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("descripcion");

                entity.Property(e => e.Estado).HasColumnName("estado");

                entity.Property(e => e.FechaIng)
                    .HasColumnType("datetime")
                    .HasColumnName("fecha_ing");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("nombre");

                entity.Property(e => e.UsuarioIng)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("usuario_ing");
            });

            modelBuilder.Entity<TipoContribuyente>(entity =>
            {
                entity.HasKey(e => e.CodigoTipoContribuyente)
                    .HasName("PK_SIT_TIPOCONT");

                entity.ToTable("tipo_contribuyente", "db_tesoreria");

                entity.HasIndex(e => e.Nombre, "UQ_SIT_TIPOCONT_NOMBRE")
                    .IsUnique();

                entity.Property(e => e.CodigoTipoContribuyente)
                    .ValueGeneratedNever()
                    .HasColumnName("codigo_tipo_contribuyente");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("descripcion");

                entity.Property(e => e.Estado).HasColumnName("estado");

                entity.Property(e => e.FechaIng)
                    .HasColumnType("datetime")
                    .HasColumnName("fecha_ing");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("nombre");

                entity.Property(e => e.UsuarioIng)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("usuario_ing");
            });

            modelBuilder.Entity<TipoCuentum>(entity =>
            {
                entity.HasKey(e => e.CodigoTipoCuenta)
                    .HasName("PK_RRHH_TIPOCUENTA");

                entity.ToTable("tipo_cuenta", "db_rrhh");

                entity.HasIndex(e => e.Nombre, "UQ_RRHH_TIPOCUENTA_NOMBRE")
                    .IsUnique();

                entity.Property(e => e.CodigoTipoCuenta)
                    .ValueGeneratedNever()
                    .HasColumnName("codigo_tipo_cuenta");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("descripcion");

                entity.Property(e => e.Estado).HasColumnName("estado");

                entity.Property(e => e.FechaIng)
                    .HasColumnType("datetime")
                    .HasColumnName("fecha_ing");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("nombre");

                entity.Property(e => e.UsuarioIng)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("usuario_ing");
            });

            modelBuilder.Entity<TipoCxc>(entity =>
            {
                entity.HasKey(e => e.CodigoTipoCxc)
                    .HasName("PK_CONTA_TIPOCXC");

                entity.ToTable("tipo_cxc", "db_contabilidad");

                entity.HasIndex(e => e.Nombre, "UQ_CONTA_TIPOCXC_NOMBRE")
                    .IsUnique();

                entity.Property(e => e.CodigoTipoCxc).HasColumnName("codigo_tipo_cxc");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("descripcion");

                entity.Property(e => e.Estado).HasColumnName("estado");

                entity.Property(e => e.FechaIng)
                    .HasColumnType("datetime")
                    .HasColumnName("fecha_ing");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("nombre");

                entity.Property(e => e.UsuarioIng)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("usuario_ing");
            });

            modelBuilder.Entity<TipoDocumento>(entity =>
            {
                entity.HasKey(e => e.CodigoTipoDocumento)
                    .HasName("PK_SIT_TIPODOC");

                entity.ToTable("tipo_documento", "db_tesoreria");

                entity.HasIndex(e => e.Nombre, "UQ_SIT_TIPODOC_NOMBRE")
                    .IsUnique();

                entity.Property(e => e.CodigoTipoDocumento).HasColumnName("codigo_tipo_documento");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("descripcion");

                entity.Property(e => e.Estado).HasColumnName("estado");

                entity.Property(e => e.FechaIng)
                    .HasColumnType("datetime")
                    .HasColumnName("fecha_ing");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("nombre");

                entity.Property(e => e.UsuarioIng)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("usuario_ing");
            });

            modelBuilder.Entity<TipoEmpresa>(entity =>
            {
                entity.HasKey(e => e.CodigoTipoEmpresa)
                    .HasName("PK_ADMON_TIPOEMPRESA");

                entity.ToTable("tipo_empresa", "db_admon");

                entity.HasIndex(e => e.Nombre, "UQ_ADMON_TIPOEMPRESA_NOMBRE")
                    .IsUnique();

                entity.Property(e => e.CodigoTipoEmpresa).HasColumnName("codigo_tipo_empresa");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("descripcion");

                entity.Property(e => e.Estado).HasColumnName("estado");

                entity.Property(e => e.FechaIng)
                    .HasColumnType("datetime")
                    .HasColumnName("fecha_ing");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("nombre");

                entity.Property(e => e.UsuarioIng)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("usuario_ing");
            });

            modelBuilder.Entity<TipoNotificacion>(entity =>
            {
                entity.HasKey(e => e.CodigoTipoNotificacion)
                    .HasName("PK_ADMON_TIPONOTIFICACION");

                entity.ToTable("tipo_notificacion", "db_admon");

                entity.Property(e => e.CodigoTipoNotificacion)
                    .ValueGeneratedNever()
                    .HasColumnName("codigo_tipo_notificacion");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("descripcion");

                entity.Property(e => e.Estado).HasColumnName("estado");

                entity.Property(e => e.FechaAct)
                    .HasColumnType("datetime")
                    .HasColumnName("fecha_act");

                entity.Property(e => e.FechaIng)
                    .HasColumnType("datetime")
                    .HasColumnName("fecha_ing");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("nombre");

                entity.Property(e => e.UsuarioAct)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("usuario_act");

                entity.Property(e => e.UsuarioIng)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("usuario_ing");
            });

            modelBuilder.Entity<TipoOperacion>(entity =>
            {
                entity.HasKey(e => e.CodigoTipoOperacion)
                    .HasName("PK_SIT_TIPOOP");

                entity.ToTable("tipo_operacion", "db_tesoreria");

                entity.Property(e => e.CodigoTipoOperacion)
                    .ValueGeneratedNever()
                    .HasColumnName("codigo_tipo_operacion");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("descripcion");

                entity.Property(e => e.Estado).HasColumnName("estado");

                entity.Property(e => e.FechaIng)
                    .HasColumnType("datetime")
                    .HasColumnName("fecha_ing");

                entity.Property(e => e.Id)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("id");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("nombre");

                entity.Property(e => e.Signo).HasColumnName("signo");

                entity.Property(e => e.UsuarioIng)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("usuario_ing");
            });

            modelBuilder.Entity<TipoPago>(entity =>
            {
                entity.HasKey(e => e.CodigoTipoPago)
                    .HasName("PK_SIT_TIPOPAGO");

                entity.ToTable("tipo_pago", "db_tesoreria");

                entity.HasIndex(e => e.Nombre, "UQ_SIT_TIPOPAGO_NOMBRE")
                    .IsUnique();

                entity.Property(e => e.CodigoTipoPago).HasColumnName("codigo_tipo_pago");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("descripcion");

                entity.Property(e => e.Estado).HasColumnName("estado");

                entity.Property(e => e.FechaIng)
                    .HasColumnType("datetime")
                    .HasColumnName("fecha_ing");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("nombre");

                entity.Property(e => e.UsuarioIng)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("usuario_ing");
            });

            modelBuilder.Entity<TipoPlanilla>(entity =>
            {
                entity.HasKey(e => e.CodigoTipoPlanilla)
                    .HasName("PK_CONTA_TPLANILLA");

                entity.ToTable("tipo_planilla", "db_contabilidad");

                entity.HasIndex(e => e.Nombre, "UQ_CONTA_TPLANILLA_NOMBRE")
                    .IsUnique();

                entity.Property(e => e.CodigoTipoPlanilla)
                    .ValueGeneratedNever()
                    .HasColumnName("codigo_tipo_planilla");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("descripcion");

                entity.Property(e => e.Estado).HasColumnName("estado");

                entity.Property(e => e.FechaIng)
                    .HasColumnType("datetime")
                    .HasColumnName("fecha_ing");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("nombre");

                entity.Property(e => e.UsuarioIng)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("usuario_ing");
            });

            modelBuilder.Entity<TipoReporte>(entity =>
            {
                entity.HasKey(e => e.CodigoTipoReporte)
                    .HasName("PK_ADMON_TIPOREPORTE");

                entity.ToTable("tipo_reporte", "db_admon");

                entity.Property(e => e.CodigoTipoReporte)
                    .ValueGeneratedNever()
                    .HasColumnName("codigo_tipo_reporte");

                entity.Property(e => e.CodigoCategoria).HasColumnName("codigo_categoria");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("descripcion");

                entity.Property(e => e.Estado).HasColumnName("estado");

                entity.Property(e => e.Excel).HasColumnName("excel");

                entity.Property(e => e.FechaAct)
                    .HasColumnType("datetime")
                    .HasColumnName("fecha_act");

                entity.Property(e => e.FechaIng)
                    .HasColumnType("datetime")
                    .HasColumnName("fecha_ing");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(75)
                    .IsUnicode(false)
                    .HasColumnName("nombre");

                entity.Property(e => e.NombreAccion)
                    .IsRequired()
                    .HasMaxLength(75)
                    .IsUnicode(false)
                    .HasColumnName("nombre_accion");

                entity.Property(e => e.NombreControlador)
                    .IsRequired()
                    .HasMaxLength(75)
                    .IsUnicode(false)
                    .HasColumnName("nombre_controlador");

                entity.Property(e => e.Pdf).HasColumnName("pdf");

                entity.Property(e => e.UsuarioAct)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("usuario_act");

                entity.Property(e => e.UsuarioIng)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("usuario_ing");

                entity.Property(e => e.Web).HasColumnName("web");

                entity.HasOne(d => d.CodigoCategoriaNavigation)
                    .WithMany(p => p.TipoReportes)
                    .HasForeignKey(d => d.CodigoCategoria)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ADMON_TIPOREPORTE_CATEGORIA");
            });

            modelBuilder.Entity<TipoReporte1>(entity =>
            {
                entity.HasKey(e => e.CodigoTipoReporte)
                    .HasName("PK_CONTA_TIPOREPORTE");

                entity.ToTable("tipo_reporte", "db_contabilidad");

                entity.Property(e => e.CodigoTipoReporte)
                    .ValueGeneratedNever()
                    .HasColumnName("codigo_tipo_reporte");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("descripcion");

                entity.Property(e => e.Estado).HasColumnName("estado");

                entity.Property(e => e.Excel).HasColumnName("excel");

                entity.Property(e => e.FechaIng)
                    .HasColumnType("datetime")
                    .HasColumnName("fecha_ing");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(75)
                    .IsUnicode(false)
                    .HasColumnName("nombre");

                entity.Property(e => e.NombreAccion)
                    .IsRequired()
                    .HasMaxLength(75)
                    .IsUnicode(false)
                    .HasColumnName("nombre_accion");

                entity.Property(e => e.NombreControlador)
                    .IsRequired()
                    .HasMaxLength(75)
                    .IsUnicode(false)
                    .HasColumnName("nombre_controlador");

                entity.Property(e => e.Pdf).HasColumnName("pdf");

                entity.Property(e => e.UsuarioIng)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("usuario_ing");

                entity.Property(e => e.Web).HasColumnName("web");
            });

            modelBuilder.Entity<TipoRutum>(entity =>
            {
                entity.HasKey(e => e.CodigoTipoRuta)
                    .HasName("PK_VENTAS_TIPORUTA");

                entity.ToTable("tipo_ruta", "db_ventas");

                entity.Property(e => e.CodigoTipoRuta).HasColumnName("codigo_tipo_ruta");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("descripcion");

                entity.Property(e => e.Estado).HasColumnName("estado");

                entity.Property(e => e.FechaIng)
                    .HasColumnType("datetime")
                    .HasColumnName("fecha_ing");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("nombre");

                entity.Property(e => e.UsuarioIng)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("usuario_ing");
            });

            modelBuilder.Entity<Transaccion>(entity =>
            {
                entity.HasKey(e => e.CodigoTransaccion)
                    .HasName("PK_SIT_TRANSACCION");

                entity.ToTable("transaccion", "db_tesoreria");

                entity.Property(e => e.CodigoTransaccion)
                    .ValueGeneratedNever()
                    .HasColumnName("codigo_transaccion");

                entity.Property(e => e.AnioComision).HasColumnName("anio_comision");

                entity.Property(e => e.AnioOperacion).HasColumnName("anio_operacion");

                entity.Property(e => e.AnioPlanilla).HasColumnName("anio_planilla");

                entity.Property(e => e.AnioSueldoIndirecto).HasColumnName("anio_sueldo_indirecto");

                entity.Property(e => e.Cheque).HasColumnName("cheque");

                entity.Property(e => e.CodigoArea).HasColumnName("codigo_area");

                entity.Property(e => e.CodigoBancoDeposito).HasColumnName("codigo_banco_deposito");

                entity.Property(e => e.CodigoBoletaComision).HasColumnName("codigo_boleta_comision");

                entity.Property(e => e.CodigoBonoExtra).HasColumnName("codigo_bono_extra");

                entity.Property(e => e.CodigoCanalVenta).HasColumnName("codigo_canal_venta");

                entity.Property(e => e.CodigoCategoriaEntidad).HasColumnName("codigo_categoria_entidad");

                entity.Property(e => e.CodigoCxc).HasColumnName("codigo_cxc");

                entity.Property(e => e.CodigoCxcBtb).HasColumnName("codigo_cxc_btb");

                entity.Property(e => e.CodigoEmpresa).HasColumnName("codigo_empresa");

                entity.Property(e => e.CodigoEntidad)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("codigo_entidad");

                entity.Property(e => e.CodigoEstado).HasColumnName("codigo_estado");

                entity.Property(e => e.CodigoEstadoSolicitudCorreccion).HasColumnName("codigo_estado_solicitud_correccion");

                entity.Property(e => e.CodigoFrecuenciaPago).HasColumnName("codigo_frecuencia_pago");

                entity.Property(e => e.CodigoOperacion).HasColumnName("codigo_operacion");

                entity.Property(e => e.CodigoOperacionCaja).HasColumnName("codigo_operacion_caja");

                entity.Property(e => e.CodigoOtroIngreso).HasColumnName("codigo_otro_ingreso");

                entity.Property(e => e.CodigoPagoPlanilla).HasColumnName("codigo_pago_planilla");

                entity.Property(e => e.CodigoPlanilla).HasColumnName("codigo_planilla");

                entity.Property(e => e.CodigoProveedor).HasColumnName("codigo_proveedor");

                entity.Property(e => e.CodigoQuincenaPlanilla).HasColumnName("codigo_quincena_planilla");

                entity.Property(e => e.CodigoReporte).HasColumnName("codigo_reporte");

                entity.Property(e => e.CodigoSeguridad)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("codigo_seguridad");

                entity.Property(e => e.CodigoTipoCxc).HasColumnName("codigo_tipo_cxc");

                entity.Property(e => e.CodigoTipoDocDeposito).HasColumnName("codigo_tipo_doc_deposito");

                entity.Property(e => e.CodigoTipoDocumento).HasColumnName("codigo_tipo_documento");

                entity.Property(e => e.CodigoTipoOperacion).HasColumnName("codigo_tipo_operacion");

                entity.Property(e => e.CodigoTipoPago).HasColumnName("codigo_tipo_pago");

                entity.Property(e => e.CodigoTipoSueldoIndirecto).HasColumnName("codigo_tipo_sueldo_indirecto");

                entity.Property(e => e.CodigoTipoTransaccion)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("codigo_tipo_transaccion");

                entity.Property(e => e.CodigoTipoTraslado)
                    .HasColumnName("codigo_tipo_traslado")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.CodigoTransaccionAnt).HasColumnName("codigo_transaccion_ant");

                entity.Property(e => e.CodigoVendedor)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("codigo_vendedor");

                entity.Property(e => e.ComplementoConta).HasColumnName("complemento_conta");

                entity.Property(e => e.ConcederIva).HasColumnName("conceder_iva");

                entity.Property(e => e.Correccion).HasColumnName("correccion");

                entity.Property(e => e.Deposito).HasColumnName("deposito");

                entity.Property(e => e.DiaOperacion).HasColumnName("dia_operacion");

                entity.Property(e => e.Efectivo).HasColumnName("efectivo");

                entity.Property(e => e.FechaAct)
                    .HasColumnType("datetime")
                    .HasColumnName("fecha_act");

                entity.Property(e => e.FechaAnulacion)
                    .HasColumnType("datetime")
                    .HasColumnName("fecha_anulacion");

                entity.Property(e => e.FechaConfirmacion)
                    .HasColumnType("datetime")
                    .HasColumnName("fecha_confirmacion");

                entity.Property(e => e.FechaDocumento)
                    .HasColumnType("date")
                    .HasColumnName("fecha_documento");

                entity.Property(e => e.FechaIng)
                    .HasColumnType("datetime")
                    .HasColumnName("fecha_ing");

                entity.Property(e => e.FechaOperacion)
                    .HasColumnType("datetime")
                    .HasColumnName("fecha_operacion");

                entity.Property(e => e.FechaRecibo)
                    .HasColumnType("datetime")
                    .HasColumnName("fecha_recibo");

                entity.Property(e => e.FechaRevision)
                    .HasColumnType("datetime")
                    .HasColumnName("fecha_revision");

                entity.Property(e => e.IncluirParaCambioSemana).HasColumnName("incluir_para_cambio_semana");

                entity.Property(e => e.Liquidacion).HasColumnName("liquidacion");

                entity.Property(e => e.MesPlanilla).HasColumnName("mes_planilla");

                entity.Property(e => e.MesSueldoIndirecto).HasColumnName("mes_sueldo_indirecto");

                entity.Property(e => e.Monto)
                    .HasColumnType("decimal(15, 2)")
                    .HasColumnName("monto");

                entity.Property(e => e.MontoCheques)
                    .HasColumnType("decimal(15, 2)")
                    .HasColumnName("monto_cheques");

                entity.Property(e => e.MontoEfectivo)
                    .HasColumnType("decimal(15, 2)")
                    .HasColumnName("monto_efectivo");

                entity.Property(e => e.MontoSaldoActualCxc)
                    .HasColumnType("decimal(15, 2)")
                    .HasColumnName("monto_saldo_actual_cxc");

                entity.Property(e => e.MontoSaldoAnteriorCxc)
                    .HasColumnType("decimal(15, 2)")
                    .HasColumnName("monto_saldo_anterior_cxc");

                entity.Property(e => e.MotivoAnulacion)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("motivo_anulacion");

                entity.Property(e => e.NitEmpresaConcedeIva)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("nit_empresa_concede_iva");

                entity.Property(e => e.NitProveedor)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("nit_proveedor");

                entity.Property(e => e.NombreProveedor)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nombre_proveedor");

                entity.Property(e => e.NumeroBoleta)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("numero_boleta");

                entity.Property(e => e.NumeroCuenta)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("numero_cuenta");

                entity.Property(e => e.NumeroDocumento).HasColumnName("numero_documento");

                entity.Property(e => e.NumeroRecibo).HasColumnName("numero_recibo");

                entity.Property(e => e.NumeroReciboReferencia).HasColumnName("numero_recibo_referencia");

                entity.Property(e => e.NumeroVoucher)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("numero_voucher");

                entity.Property(e => e.Observaciones)
                    .HasMaxLength(300)
                    .HasColumnName("observaciones");

                entity.Property(e => e.ObservacionesRevision)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("observaciones_revision");

                entity.Property(e => e.ResultadoRevision).HasColumnName("resultado_revision");

                entity.Property(e => e.Revisado).HasColumnName("revisado");

                entity.Property(e => e.Ruta).HasColumnName("ruta");

                entity.Property(e => e.SemanaComision).HasColumnName("semana_comision");

                entity.Property(e => e.SemanaOperacion).HasColumnName("semana_operacion");

                entity.Property(e => e.SemanaPlanilla).HasColumnName("semana_planilla");

                entity.Property(e => e.SerieFactura)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("serie_factura");

                entity.Property(e => e.TipoEspeciales1).HasColumnName("tipo_especiales_1");

                entity.Property(e => e.UsuarioAct)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("usuario_act");

                entity.Property(e => e.UsuarioAnulacion)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("usuario_anulacion");

                entity.Property(e => e.UsuarioIng)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("usuario_ing");

                entity.Property(e => e.UsuarioRevision)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("usuario_revision");

                entity.HasOne(d => d.CodigoAreaNavigation)
                    .WithMany(p => p.Transaccions)
                    .HasForeignKey(d => d.CodigoArea)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SIT_TRANSACCION_AREA");

                entity.HasOne(d => d.CodigoBancoDepositoNavigation)
                    .WithMany(p => p.Transaccions)
                    .HasForeignKey(d => d.CodigoBancoDeposito)
                    .HasConstraintName("FK_SIT_TRANSACCION_BANCODEPOSITO");

                entity.HasOne(d => d.CodigoBonoExtraNavigation)
                    .WithMany(p => p.Transaccions)
                    .HasForeignKey(d => d.CodigoBonoExtra)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SIT_TRANSACCION_BONOEXTRA");

                entity.HasOne(d => d.CodigoCanalVentaNavigation)
                    .WithMany(p => p.Transaccions)
                    .HasForeignKey(d => d.CodigoCanalVenta)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SIT_TRANSACCION_CANALVENTA");

                entity.HasOne(d => d.CodigoCategoriaEntidadNavigation)
                    .WithMany(p => p.Transaccions)
                    .HasForeignKey(d => d.CodigoCategoriaEntidad)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SIT_TRANSACCION_CATENTIDAD");

                entity.HasOne(d => d.CodigoCxcNavigation)
                    .WithMany(p => p.TransaccionCodigoCxcNavigations)
                    .HasForeignKey(d => d.CodigoCxc)
                    .HasConstraintName("FK_SIT_TRANSACCION_CXC");

                entity.HasOne(d => d.CodigoCxcBtbNavigation)
                    .WithMany(p => p.TransaccionCodigoCxcBtbNavigations)
                    .HasForeignKey(d => d.CodigoCxcBtb)
                    .HasConstraintName("FK_SIT_TRANSACCION_CXCBTB");

                entity.HasOne(d => d.CodigoEmpresaNavigation)
                    .WithMany(p => p.Transaccions)
                    .HasForeignKey(d => d.CodigoEmpresa)
                    .HasConstraintName("FK_SIT_TRANSACCION_EMPRESA");

                entity.HasOne(d => d.CodigoEstadoNavigation)
                    .WithMany(p => p.Transaccions)
                    .HasForeignKey(d => d.CodigoEstado)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SIT_TRANSACCION_ESTADO");

                entity.HasOne(d => d.CodigoEstadoSolicitudCorreccionNavigation)
                    .WithMany(p => p.Transaccions)
                    .HasForeignKey(d => d.CodigoEstadoSolicitudCorreccion)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SIT_TRANSACCION_ESTADOSOLCORRECCION");

                entity.HasOne(d => d.CodigoFrecuenciaPagoNavigation)
                    .WithMany(p => p.Transaccions)
                    .HasForeignKey(d => d.CodigoFrecuenciaPago)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SIT_TRANSACCION_FRECUENCIAPAGO");

                entity.HasOne(d => d.CodigoOperacionNavigation)
                    .WithMany(p => p.TransaccionCodigoOperacionNavigations)
                    .HasForeignKey(d => d.CodigoOperacion)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SIT_TRANSACCION_OPCONTA");

                entity.HasOne(d => d.CodigoOperacionCajaNavigation)
                    .WithMany(p => p.TransaccionCodigoOperacionCajaNavigations)
                    .HasForeignKey(d => d.CodigoOperacionCaja)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SIT_TRANSACCION_OPCAJA");

                entity.HasOne(d => d.CodigoOtroIngresoNavigation)
                    .WithMany(p => p.Transaccions)
                    .HasForeignKey(d => d.CodigoOtroIngreso)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SIT_TRANSACCION_OTROINGRESO");

                entity.HasOne(d => d.CodigoReporteNavigation)
                    .WithMany(p => p.Transaccions)
                    .HasForeignKey(d => d.CodigoReporte)
                    .HasConstraintName("FK_SIT_TRANSACCION_REPORTE");

                entity.HasOne(d => d.CodigoTipoCxcNavigation)
                    .WithMany(p => p.Transaccions)
                    .HasForeignKey(d => d.CodigoTipoCxc)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SIT_TRANSACCION_TIPOCXC");

                entity.HasOne(d => d.CodigoTipoDocumentoNavigation)
                    .WithMany(p => p.Transaccions)
                    .HasForeignKey(d => d.CodigoTipoDocumento)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SIT_TRANSACCION_TIPODOC");

                entity.HasOne(d => d.CodigoTipoPagoNavigation)
                    .WithMany(p => p.Transaccions)
                    .HasForeignKey(d => d.CodigoTipoPago)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SIT_TRANSACCION_TIPOPAGO");

                entity.HasOne(d => d.CodigoTipoSueldoIndirectoNavigation)
                    .WithMany(p => p.Transaccions)
                    .HasForeignKey(d => d.CodigoTipoSueldoIndirecto)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SIT_TRANSACCION_TIPOSUELDOINDIRECTO");

                entity.HasOne(d => d.CodigoVendedorNavigation)
                    .WithMany(p => p.Transaccions)
                    .HasForeignKey(d => d.CodigoVendedor)
                    .HasConstraintName("FK_SIT_TRANSACCION_VENDEDOR");

                entity.HasOne(d => d.NitEmpresaConcedeIvaNavigation)
                    .WithMany(p => p.TransaccionNitEmpresaConcedeIvaNavigations)
                    .HasForeignKey(d => d.NitEmpresaConcedeIva)
                    .HasConstraintName("FK_SIT_TRANSACCION_CONSUMIDOR");

                entity.HasOne(d => d.NitProveedorNavigation)
                    .WithMany(p => p.TransaccionNitProveedorNavigations)
                    .HasForeignKey(d => d.NitProveedor)
                    .HasConstraintName("FK_SIT_TRANSACCION_PROVEEDOR");
            });

            modelBuilder.Entity<TransaccionArqueo>(entity =>
            {
                entity.HasKey(e => new { e.CodigoTransaccion, e.CodigoReporte })
                    .HasName("PK_SIT_TARQUEO");

                entity.ToTable("transaccion_arqueo", "db_tesoreria");

                entity.Property(e => e.CodigoTransaccion).HasColumnName("codigo_transaccion");

                entity.Property(e => e.CodigoReporte).HasColumnName("codigo_reporte");

                entity.Property(e => e.AnioComision).HasColumnName("anio_comision");

                entity.Property(e => e.AnioOperacion).HasColumnName("anio_operacion");

                entity.Property(e => e.AnioPlanilla).HasColumnName("anio_planilla");

                entity.Property(e => e.AnioSueldoIndirecto).HasColumnName("anio_sueldo_indirecto");

                entity.Property(e => e.Cheque).HasColumnName("cheque");

                entity.Property(e => e.CodigoArea).HasColumnName("codigo_area");

                entity.Property(e => e.CodigoBancoDeposito).HasColumnName("codigo_banco_deposito");

                entity.Property(e => e.CodigoBoletaComision).HasColumnName("codigo_boleta_comision");

                entity.Property(e => e.CodigoBonoExtra).HasColumnName("codigo_bono_extra");

                entity.Property(e => e.CodigoCategoriaEntidad).HasColumnName("codigo_categoria_entidad");

                entity.Property(e => e.CodigoCxc).HasColumnName("codigo_cxc");

                entity.Property(e => e.CodigoEmpresa).HasColumnName("codigo_empresa");

                entity.Property(e => e.CodigoEntidad)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("codigo_entidad");

                entity.Property(e => e.CodigoEstado).HasColumnName("codigo_estado");

                entity.Property(e => e.CodigoEstadoSolicitudCorreccion).HasColumnName("codigo_estado_solicitud_correccion");

                entity.Property(e => e.CodigoFrecuenciaPago).HasColumnName("codigo_frecuencia_pago");

                entity.Property(e => e.CodigoOperacion).HasColumnName("codigo_operacion");

                entity.Property(e => e.CodigoOperacionCaja).HasColumnName("codigo_operacion_caja");

                entity.Property(e => e.CodigoPagoPlanilla).HasColumnName("codigo_pago_planilla");

                entity.Property(e => e.CodigoPlanilla).HasColumnName("codigo_planilla");

                entity.Property(e => e.CodigoQuincenaPlanilla).HasColumnName("codigo_quincena_planilla");

                entity.Property(e => e.CodigoSeguridad)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("codigo_seguridad");

                entity.Property(e => e.CodigoTipoCxc).HasColumnName("codigo_tipo_cxc");

                entity.Property(e => e.CodigoTipoDocDeposito).HasColumnName("codigo_tipo_doc_deposito");

                entity.Property(e => e.CodigoTipoDocumento).HasColumnName("codigo_tipo_documento");

                entity.Property(e => e.CodigoTipoOperacion).HasColumnName("codigo_tipo_operacion");

                entity.Property(e => e.CodigoTipoPago).HasColumnName("codigo_tipo_pago");

                entity.Property(e => e.CodigoTipoTransaccion)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("codigo_tipo_transaccion");

                entity.Property(e => e.CodigoTransaccionAnt).HasColumnName("codigo_transaccion_ant");

                entity.Property(e => e.CodigoVendedor)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("codigo_vendedor");

                entity.Property(e => e.ComplementoConta).HasColumnName("complemento_conta");

                entity.Property(e => e.ConcederIva).HasColumnName("conceder_iva");

                entity.Property(e => e.Correccion).HasColumnName("correccion");

                entity.Property(e => e.Deposito).HasColumnName("deposito");

                entity.Property(e => e.DiaOperacion).HasColumnName("dia_operacion");

                entity.Property(e => e.Efectivo).HasColumnName("efectivo");

                entity.Property(e => e.FechaAct)
                    .HasColumnType("datetime")
                    .HasColumnName("fecha_act");

                entity.Property(e => e.FechaAnulacion)
                    .HasColumnType("datetime")
                    .HasColumnName("fecha_anulacion");

                entity.Property(e => e.FechaConfirmacion)
                    .HasColumnType("datetime")
                    .HasColumnName("fecha_confirmacion");

                entity.Property(e => e.FechaDocumento)
                    .HasColumnType("date")
                    .HasColumnName("fecha_documento");

                entity.Property(e => e.FechaIng)
                    .HasColumnType("datetime")
                    .HasColumnName("fecha_ing");

                entity.Property(e => e.FechaOperacion)
                    .HasColumnType("datetime")
                    .HasColumnName("fecha_operacion");

                entity.Property(e => e.FechaRecibo)
                    .HasColumnType("datetime")
                    .HasColumnName("fecha_recibo");

                entity.Property(e => e.FechaRevision)
                    .HasColumnType("datetime")
                    .HasColumnName("fecha_revision");

                entity.Property(e => e.Liquidacion).HasColumnName("liquidacion");

                entity.Property(e => e.MesPlanilla).HasColumnName("mes_planilla");

                entity.Property(e => e.MesSueldoIndirecto).HasColumnName("mes_sueldo_indirecto");

                entity.Property(e => e.Monto)
                    .HasColumnType("decimal(15, 2)")
                    .HasColumnName("monto");

                entity.Property(e => e.MontoCheques)
                    .HasColumnType("decimal(15, 2)")
                    .HasColumnName("monto_cheques");

                entity.Property(e => e.MontoEfectivo)
                    .HasColumnType("decimal(15, 2)")
                    .HasColumnName("monto_efectivo");

                entity.Property(e => e.MotivoAnulacion)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("motivo_anulacion");

                entity.Property(e => e.NitEmpresaConcedeIva)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("nit_empresa_concede_iva");

                entity.Property(e => e.NitProveedor)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("nit_proveedor");

                entity.Property(e => e.NombreProveedor)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nombre_proveedor");

                entity.Property(e => e.NumeroBoleta)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("numero_boleta");

                entity.Property(e => e.NumeroCuenta)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("numero_cuenta");

                entity.Property(e => e.NumeroDocumento).HasColumnName("numero_documento");

                entity.Property(e => e.NumeroRecibo).HasColumnName("numero_recibo");

                entity.Property(e => e.NumeroVoucher)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("numero_voucher");

                entity.Property(e => e.Observaciones)
                    .HasMaxLength(300)
                    .HasColumnName("observaciones");

                entity.Property(e => e.ObservacionesRevision)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("observaciones_revision");

                entity.Property(e => e.ResultadoRevision).HasColumnName("resultado_revision");

                entity.Property(e => e.Revisado).HasColumnName("revisado");

                entity.Property(e => e.Ruta).HasColumnName("ruta");

                entity.Property(e => e.SemanaComision).HasColumnName("semana_comision");

                entity.Property(e => e.SemanaOperacion).HasColumnName("semana_operacion");

                entity.Property(e => e.SemanaPlanilla).HasColumnName("semana_planilla");

                entity.Property(e => e.SerieFactura)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("serie_factura");

                entity.Property(e => e.TipoEspeciales1).HasColumnName("tipo_especiales_1");

                entity.Property(e => e.UsuarioAct)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("usuario_act");

                entity.Property(e => e.UsuarioAnulacion)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("usuario_anulacion");

                entity.Property(e => e.UsuarioIng)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("usuario_ing");

                entity.Property(e => e.UsuarioRevision)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("usuario_revision");

                entity.HasOne(d => d.CodigoAreaNavigation)
                    .WithMany(p => p.TransaccionArqueos)
                    .HasForeignKey(d => d.CodigoArea)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SIT_TARQUEO_AREA");

                entity.HasOne(d => d.CodigoBancoDepositoNavigation)
                    .WithMany(p => p.TransaccionArqueos)
                    .HasForeignKey(d => d.CodigoBancoDeposito)
                    .HasConstraintName("FK_SIT_TARQUEO_BANCODEPOSITO");

                entity.HasOne(d => d.CodigoBonoExtraNavigation)
                    .WithMany(p => p.TransaccionArqueos)
                    .HasForeignKey(d => d.CodigoBonoExtra)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SIT_TARQUEO_BONOEXTRA");

                entity.HasOne(d => d.CodigoCategoriaEntidadNavigation)
                    .WithMany(p => p.TransaccionArqueos)
                    .HasForeignKey(d => d.CodigoCategoriaEntidad)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SIT_TARQUEO_CATENTIDAD");

                entity.HasOne(d => d.CodigoCxcNavigation)
                    .WithMany(p => p.TransaccionArqueos)
                    .HasForeignKey(d => d.CodigoCxc)
                    .HasConstraintName("FK_SIT_TARQUEO_CXC");

                entity.HasOne(d => d.CodigoEmpresaNavigation)
                    .WithMany(p => p.TransaccionArqueos)
                    .HasForeignKey(d => d.CodigoEmpresa)
                    .HasConstraintName("FK_SIT_TARQUEO_EMPRESA");

                entity.HasOne(d => d.CodigoEstadoNavigation)
                    .WithMany(p => p.TransaccionArqueos)
                    .HasForeignKey(d => d.CodigoEstado)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SIT_TARQUEO_ESTADO");

                entity.HasOne(d => d.CodigoEstadoSolicitudCorreccionNavigation)
                    .WithMany(p => p.TransaccionArqueos)
                    .HasForeignKey(d => d.CodigoEstadoSolicitudCorreccion)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SIT_TARQUEO_ESTADOSOLCORRECCION");

                entity.HasOne(d => d.CodigoFrecuenciaPagoNavigation)
                    .WithMany(p => p.TransaccionArqueos)
                    .HasForeignKey(d => d.CodigoFrecuenciaPago)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SIT_TARQUEO_FRECUENCIAPAGO");

                entity.HasOne(d => d.CodigoOperacionNavigation)
                    .WithMany(p => p.TransaccionArqueoCodigoOperacionNavigations)
                    .HasForeignKey(d => d.CodigoOperacion)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SIT_TARQUEO_OPCONTA");

                entity.HasOne(d => d.CodigoOperacionCajaNavigation)
                    .WithMany(p => p.TransaccionArqueoCodigoOperacionCajaNavigations)
                    .HasForeignKey(d => d.CodigoOperacionCaja)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SIT_TARQUEO_OPCAJA");

                entity.HasOne(d => d.CodigoReporteNavigation)
                    .WithMany(p => p.TransaccionArqueos)
                    .HasForeignKey(d => d.CodigoReporte)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SIT_TARQUEO_REPORTE");

                entity.HasOne(d => d.CodigoTipoCxcNavigation)
                    .WithMany(p => p.TransaccionArqueos)
                    .HasForeignKey(d => d.CodigoTipoCxc)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SIT_TARQUEO_TIPOCXC");

                entity.HasOne(d => d.CodigoTipoDocumentoNavigation)
                    .WithMany(p => p.TransaccionArqueos)
                    .HasForeignKey(d => d.CodigoTipoDocumento)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SIT_TARQUEO_TIPODOC");

                entity.HasOne(d => d.CodigoTipoPagoNavigation)
                    .WithMany(p => p.TransaccionArqueos)
                    .HasForeignKey(d => d.CodigoTipoPago)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SIT_TARQUEO_TIPOPAGO");

                entity.HasOne(d => d.CodigoVendedorNavigation)
                    .WithMany(p => p.TransaccionArqueos)
                    .HasForeignKey(d => d.CodigoVendedor)
                    .HasConstraintName("FK_SIT_TARQUEO_VENDEDOR");

                entity.HasOne(d => d.NitEmpresaConcedeIvaNavigation)
                    .WithMany(p => p.TransaccionArqueoNitEmpresaConcedeIvaNavigations)
                    .HasForeignKey(d => d.NitEmpresaConcedeIva)
                    .HasConstraintName("FK_SIT_TARQUEO_CONSUMIDOR");

                entity.HasOne(d => d.NitProveedorNavigation)
                    .WithMany(p => p.TransaccionArqueoNitProveedorNavigations)
                    .HasForeignKey(d => d.NitProveedor)
                    .HasConstraintName("FK_SIT_TARQUEO_PROVEEDOR");
            });

            modelBuilder.Entity<TransaccionCajaChica>(entity =>
            {
                entity.HasKey(e => e.CodigoTransaccion)
                    .HasName("PK_SIT_TRANCAJACHICA");

                entity.ToTable("transaccion_caja_chica", "db_tesoreria");

                entity.Property(e => e.CodigoTransaccion)
                    .ValueGeneratedNever()
                    .HasColumnName("codigo_transaccion");

                entity.Property(e => e.AnioOperacion).HasColumnName("anio_operacion");

                entity.Property(e => e.CodigoCajaChica).HasColumnName("codigo_caja_chica");

                entity.Property(e => e.CodigoEstado).HasColumnName("codigo_estado");

                entity.Property(e => e.CodigoEstadoRecepcion).HasColumnName("codigo_estado_recepcion");

                entity.Property(e => e.CodigoEstadoSolicitudCorreccion).HasColumnName("codigo_estado_solicitud_correccion");

                entity.Property(e => e.CodigoMotivoExclusion).HasColumnName("codigo_motivo_exclusion");

                entity.Property(e => e.CodigoOperacion).HasColumnName("codigo_operacion");

                entity.Property(e => e.CodigoReporte).HasColumnName("codigo_reporte");

                entity.Property(e => e.CodigoSeguridad)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("codigo_seguridad");

                entity.Property(e => e.CodigoTipoDocumento).HasColumnName("codigo_tipo_documento");

                entity.Property(e => e.CodigoTipoTransaccion)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("codigo_tipo_transaccion");

                entity.Property(e => e.CodigoTransaccionAnt).HasColumnName("codigo_transaccion_ant");

                entity.Property(e => e.Correccion).HasColumnName("correccion");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("descripcion");

                entity.Property(e => e.DiaOperacion).HasColumnName("dia_operacion");

                entity.Property(e => e.ExcluirFactura).HasColumnName("excluir_factura");

                entity.Property(e => e.FechaAct)
                    .HasColumnType("datetime")
                    .HasColumnName("fecha_act");

                entity.Property(e => e.FechaAnulacion)
                    .HasColumnType("datetime")
                    .HasColumnName("fecha_anulacion");

                entity.Property(e => e.FechaDocumento)
                    .HasColumnType("date")
                    .HasColumnName("fecha_documento");

                entity.Property(e => e.FechaIng)
                    .HasColumnType("datetime")
                    .HasColumnName("fecha_ing");

                entity.Property(e => e.FechaOperacion)
                    .HasColumnType("datetime")
                    .HasColumnName("fecha_operacion");

                entity.Property(e => e.FechaRevision)
                    .HasColumnType("datetime")
                    .HasColumnName("fecha_revision");

                entity.Property(e => e.Monto)
                    .HasColumnType("decimal(15, 2)")
                    .HasColumnName("monto");

                entity.Property(e => e.NitProveedor)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("nit_proveedor");

                entity.Property(e => e.NumeroDocumento).HasColumnName("numero_documento");

                entity.Property(e => e.Observaciones)
                    .HasMaxLength(300)
                    .HasColumnName("observaciones");

                entity.Property(e => e.ObservacionesAnulacion)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("observaciones_anulacion");

                entity.Property(e => e.ObservacionesExclusion)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("observaciones_exclusion");

                entity.Property(e => e.ObservacionesRecepcion)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("observaciones_recepcion");

                entity.Property(e => e.SemanaOperacion).HasColumnName("semana_operacion");

                entity.Property(e => e.SerieFactura)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("serie_factura");

                entity.Property(e => e.UsuarioAct)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("usuario_act");

                entity.Property(e => e.UsuarioAnulacion)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("usuario_anulacion");

                entity.Property(e => e.UsuarioIng)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("usuario_ing");

                entity.Property(e => e.UsuarioRevision)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("usuario_revision");

                entity.HasOne(d => d.CodigoEstadoSolicitudCorreccionNavigation)
                    .WithMany(p => p.TransaccionCajaChicas)
                    .HasForeignKey(d => d.CodigoEstadoSolicitudCorreccion)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SIT_TRANCAJACHICA_STATESOLC");

                entity.HasOne(d => d.CodigoMotivoExclusionNavigation)
                    .WithMany(p => p.TransaccionCajaChicas)
                    .HasForeignKey(d => d.CodigoMotivoExclusion)
                    .HasConstraintName("FK_SIT_TRANCAJACHICA_MOTEXCLUSION");

                entity.HasOne(d => d.CodigoOperacionNavigation)
                    .WithMany(p => p.TransaccionCajaChicas)
                    .HasForeignKey(d => d.CodigoOperacion)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SIT_TRANCAJACHICA_OPCONTA");

                entity.HasOne(d => d.CodigoReporteNavigation)
                    .WithMany(p => p.TransaccionCajaChicas)
                    .HasForeignKey(d => d.CodigoReporte)
                    .HasConstraintName("FK_SIT_TRANCAJACHICA_REPORTE");

                entity.HasOne(d => d.NitProveedorNavigation)
                    .WithMany(p => p.TransaccionCajaChicas)
                    .HasForeignKey(d => d.NitProveedor)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SIT_TRANCAJACHICA_PROVEEDOR");
            });

            modelBuilder.Entity<TransaccionCajaChicaCheque>(entity =>
            {
                entity.HasKey(e => e.CodigoTransaccion)
                    .HasName("PK_SIT_TRANCAJACCHEQUE");

                entity.ToTable("transaccion_caja_chica_cheque", "db_tesoreria");

                entity.Property(e => e.CodigoTransaccion)
                    .ValueGeneratedNever()
                    .HasColumnName("codigo_transaccion");

                entity.Property(e => e.CodigoBanco).HasColumnName("codigo_banco");

                entity.Property(e => e.Estado).HasColumnName("estado");

                entity.Property(e => e.FechaAct)
                    .HasColumnType("datetime")
                    .HasColumnName("fecha_act");

                entity.Property(e => e.FechaCheque)
                    .HasColumnType("date")
                    .HasColumnName("fecha_cheque");

                entity.Property(e => e.FechaIng)
                    .HasColumnType("datetime")
                    .HasColumnName("fecha_ing");

                entity.Property(e => e.Monto)
                    .HasColumnType("decimal(15, 2)")
                    .HasColumnName("monto");

                entity.Property(e => e.NumeroCheque)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("numero_cheque");

                entity.Property(e => e.UsuarioAct)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("usuario_act");

                entity.Property(e => e.UsuarioIng)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("usuario_ing");

                entity.HasOne(d => d.CodigoBancoNavigation)
                    .WithMany(p => p.TransaccionCajaChicaCheques)
                    .HasForeignKey(d => d.CodigoBanco)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SIT_TRANCAJACCHEQUE_BANCO");
            });

            modelBuilder.Entity<TrasladoDetalleEspeciales2>(entity =>
            {
                entity.HasKey(e => new { e.Serie, e.Pedido, e.Empresa })
                    .HasName("PK_SIT_TRASDETESP2");

                entity.ToTable("traslado_detalle_especiales2", "db_tesoreria");

                entity.Property(e => e.Serie)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("serie");

                entity.Property(e => e.Pedido).HasColumnName("pedido");

                entity.Property(e => e.Empresa)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("empresa");

                entity.Property(e => e.CodigoCliente)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("codigo_cliente");

                entity.Property(e => e.CodigoEntidad)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("codigo_entidad");

                entity.Property(e => e.CodigoEstadoDepuracion).HasColumnName("codigo_estado_depuracion");

                entity.Property(e => e.CodigoTraslado).HasColumnName("codigo_traslado");

                entity.Property(e => e.Estado).HasColumnName("estado");

                entity.Property(e => e.FechaAct)
                    .HasColumnType("datetime")
                    .HasColumnName("fecha_act");

                entity.Property(e => e.FechaGrabado)
                    .HasColumnType("datetime")
                    .HasColumnName("fecha_grabado");

                entity.Property(e => e.FechaIng)
                    .HasColumnType("datetime")
                    .HasColumnName("fecha_ing");

                entity.Property(e => e.Modificacion).HasColumnName("modificacion");

                entity.Property(e => e.Monto)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("monto");

                entity.Property(e => e.NombreCliente)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("nombre_cliente");

                entity.Property(e => e.NombreEntidad)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("nombre_entidad");

                entity.Property(e => e.UsuarioAct)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("usuario_act");

                entity.Property(e => e.UsuarioIng)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("usuario_ing");

                entity.HasOne(d => d.CodigoEstadoDepuracionNavigation)
                    .WithMany(p => p.TrasladoDetalleEspeciales2s)
                    .HasForeignKey(d => d.CodigoEstadoDepuracion)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SIT_TRASDETESP2_ESTADODEBUG");

                entity.HasOne(d => d.CodigoTrasladoNavigation)
                    .WithMany(p => p.TrasladoDetalleEspeciales2s)
                    .HasForeignKey(d => d.CodigoTraslado)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SIT_TRASDETESP2_TRASLADO");
            });

            modelBuilder.Entity<TrasladoEspeciales2>(entity =>
            {
                entity.HasKey(e => e.CodigoTraslado)
                    .HasName("PK_SIT_TRASESP2");

                entity.ToTable("traslado_especiales2", "db_tesoreria");

                entity.Property(e => e.CodigoTraslado)
                    .ValueGeneratedNever()
                    .HasColumnName("codigo_traslado");

                entity.Property(e => e.CodigoEstado).HasColumnName("codigo_estado");

                entity.Property(e => e.FechaAct)
                    .HasColumnType("datetime")
                    .HasColumnName("fecha_act");

                entity.Property(e => e.FechaIng)
                    .HasColumnType("datetime")
                    .HasColumnName("fecha_ing");

                entity.Property(e => e.FechaOperacion)
                    .HasColumnType("datetime")
                    .HasColumnName("fecha_operacion");

                entity.Property(e => e.FechaRecepcion)
                    .HasColumnType("datetime")
                    .HasColumnName("fecha_recepcion");

                entity.Property(e => e.ObservacionesRecepcion)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("observaciones_recepcion");

                entity.Property(e => e.UsuarioAct)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("usuario_act");

                entity.Property(e => e.UsuarioIng)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("usuario_ing");

                entity.Property(e => e.UsuarioRecepcion)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("usuario_recepcion");

                entity.HasOne(d => d.CodigoEstadoNavigation)
                    .WithMany(p => p.TrasladoEspeciales2s)
                    .HasForeignKey(d => d.CodigoEstado)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SIT_TRASESP2_ESTADO");
            });

            modelBuilder.Entity<TrasladoLiquidacion>(entity =>
            {
                entity.HasKey(e => e.CodigoTraslado)
                    .HasName("PK_SIT_TRASLIQ");

                entity.ToTable("traslado_liquidacion", "db_tesoreria");

                entity.Property(e => e.CodigoTraslado)
                    .ValueGeneratedNever()
                    .HasColumnName("codigo_traslado");

                entity.Property(e => e.AnioOperacion).HasColumnName("anio_operacion");

                entity.Property(e => e.CodigoEstado).HasColumnName("codigo_estado");

                entity.Property(e => e.FechaAct)
                    .HasColumnType("datetime")
                    .HasColumnName("fecha_act");

                entity.Property(e => e.FechaGeneracion)
                    .HasColumnType("datetime")
                    .HasColumnName("fecha_generacion");

                entity.Property(e => e.FechaIng)
                    .HasColumnType("datetime")
                    .HasColumnName("fecha_ing");

                entity.Property(e => e.FechaTraslado)
                    .HasColumnType("datetime")
                    .HasColumnName("fecha_traslado");

                entity.Property(e => e.Observaciones)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("observaciones");

                entity.Property(e => e.SemanaOperacion).HasColumnName("semana_operacion");

                entity.Property(e => e.UsuarioAct)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("usuario_act");

                entity.Property(e => e.UsuarioGeneracion)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("usuario_generacion");

                entity.Property(e => e.UsuarioIng)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("usuario_ing");

                entity.Property(e => e.UsuarioTraslado)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("usuario_traslado");

                entity.HasOne(d => d.CodigoEstadoNavigation)
                    .WithMany(p => p.TrasladoLiquidacions)
                    .HasForeignKey(d => d.CodigoEstado)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SIT_TRASLIQ_ESTADO");
            });

            modelBuilder.Entity<TrasladoLiquidacionDetalle>(entity =>
            {
                entity.HasKey(e => e.CodigoTransaccion)
                    .HasName("PK_SIT_TRASLIQDET");

                entity.ToTable("traslado_liquidacion_detalle", "db_tesoreria");

                entity.Property(e => e.CodigoTransaccion)
                    .ValueGeneratedNever()
                    .HasColumnName("codigo_transaccion");

                entity.Property(e => e.CodigoCanalVenta).HasColumnName("codigo_canal_venta");

                entity.Property(e => e.CodigoEmpresa).HasColumnName("codigo_empresa");

                entity.Property(e => e.CodigoTipoTraslado).HasColumnName("codigo_tipo_traslado");

                entity.Property(e => e.CodigoTransaccionAnt).HasColumnName("codigo_transaccion_ant");

                entity.Property(e => e.CodigoTraslado).HasColumnName("codigo_traslado");

                entity.Property(e => e.CodigoVendedor)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("codigo_vendedor");

                entity.Property(e => e.DiaOperacion).HasColumnName("dia_operacion");

                entity.Property(e => e.Estado).HasColumnName("estado");

                entity.Property(e => e.FechaAct)
                    .HasColumnType("datetime")
                    .HasColumnName("fecha_act");

                entity.Property(e => e.FechaIng)
                    .HasColumnType("datetime")
                    .HasColumnName("fecha_ing");

                entity.Property(e => e.FechaOperacion)
                    .HasColumnType("date")
                    .HasColumnName("fecha_operacion");

                entity.Property(e => e.Monto)
                    .HasColumnType("decimal(15, 2)")
                    .HasColumnName("monto");

                entity.Property(e => e.Ruta).HasColumnName("ruta");

                entity.Property(e => e.UsuarioAct)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("usuario_act");

                entity.Property(e => e.UsuarioIng)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("usuario_ing");

                entity.HasOne(d => d.CodigoCanalVentaNavigation)
                    .WithMany(p => p.TrasladoLiquidacionDetalles)
                    .HasForeignKey(d => d.CodigoCanalVenta)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SIT_TRASLIQDET_CANALVENTA");

                entity.HasOne(d => d.CodigoEmpresaNavigation)
                    .WithMany(p => p.TrasladoLiquidacionDetalles)
                    .HasForeignKey(d => d.CodigoEmpresa)
                    .HasConstraintName("FK_SIT_TRASLIQDET_EMPRESA");

                entity.HasOne(d => d.CodigoTransaccionNavigation)
                    .WithOne(p => p.TrasladoLiquidacionDetalleCodigoTransaccionNavigation)
                    .HasForeignKey<TrasladoLiquidacionDetalle>(d => d.CodigoTransaccion)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SIT_TRASLIQDET_TRANS");

                entity.HasOne(d => d.CodigoTransaccionAntNavigation)
                    .WithMany(p => p.TrasladoLiquidacionDetalleCodigoTransaccionAntNavigations)
                    .HasForeignKey(d => d.CodigoTransaccionAnt)
                    .HasConstraintName("FK_SIT_TRASLIQDET_TRANSANT");

                entity.HasOne(d => d.CodigoTrasladoNavigation)
                    .WithMany(p => p.TrasladoLiquidacionDetalles)
                    .HasForeignKey(d => d.CodigoTraslado)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SIT_TRASLIQDET_TRASLADO");

                entity.HasOne(d => d.CodigoVendedorNavigation)
                    .WithMany(p => p.TrasladoLiquidacionDetalles)
                    .HasForeignKey(d => d.CodigoVendedor)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SIT_TRASLIQDET_VENDEDOR");

                entity.HasOne(d => d.RutaNavigation)
                    .WithMany(p => p.TrasladoLiquidacionDetalles)
                    .HasForeignKey(d => d.Ruta)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SIT_TRASLIQDET_RUTA");
            });

            modelBuilder.Entity<TrasladoVentasContado>(entity =>
            {
                entity.HasKey(e => e.CodigoTraslado)
                    .HasName("PK_SIT_TRASVENTACONTADO");

                entity.ToTable("traslado_ventas_contado", "db_tesoreria");

                entity.Property(e => e.CodigoTraslado)
                    .ValueGeneratedNever()
                    .HasColumnName("codigo_traslado");

                entity.Property(e => e.AnioOperacion).HasColumnName("anio_operacion");

                entity.Property(e => e.CodigoEstado).HasColumnName("codigo_estado");

                entity.Property(e => e.DiaOperacion).HasColumnName("dia_operacion");

                entity.Property(e => e.FechaAct)
                    .HasColumnType("datetime")
                    .HasColumnName("fecha_act");

                entity.Property(e => e.FechaIng)
                    .HasColumnType("datetime")
                    .HasColumnName("fecha_ing");

                entity.Property(e => e.FechaOperacion)
                    .HasColumnType("datetime")
                    .HasColumnName("fecha_operacion");

                entity.Property(e => e.FechaRecepcion)
                    .HasColumnType("datetime")
                    .HasColumnName("fecha_recepcion");

                entity.Property(e => e.Monto)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("monto");

                entity.Property(e => e.MontoCheques)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("monto_cheques");

                entity.Property(e => e.MontoEfectivo)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("monto_efectivo");

                entity.Property(e => e.MontoTransferencia)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("monto_transferencia");

                entity.Property(e => e.ObservacionesGeneracion)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("observaciones_generacion");

                entity.Property(e => e.ObservacionesRecepcion)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("observaciones_recepcion");

                entity.Property(e => e.SemanaOperacion).HasColumnName("semana_operacion");

                entity.Property(e => e.UsuarioAct)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("usuario_act");

                entity.Property(e => e.UsuarioIng)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("usuario_ing");

                entity.Property(e => e.UsuarioRecepcion)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("usuario_recepcion");

                entity.HasOne(d => d.CodigoEstadoNavigation)
                    .WithMany(p => p.TrasladoVentasContados)
                    .HasForeignKey(d => d.CodigoEstado)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SIT_TRASVENTACONTADO_ESTADO");
            });

            modelBuilder.Entity<Ubicacion>(entity =>
            {
                entity.HasKey(e => e.CodigoUbicacion)
                    .HasName("PK_RRHH_UBICACION");

                entity.ToTable("ubicacion", "db_rrhh");

                entity.HasIndex(e => e.Nombre, "UQ_RRHH_UBICACION_NOMBRE")
                    .IsUnique();

                entity.Property(e => e.CodigoUbicacion)
                    .ValueGeneratedNever()
                    .HasColumnName("codigo_ubicacion");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("descripcion");

                entity.Property(e => e.Estado).HasColumnName("estado");

                entity.Property(e => e.FechaIng)
                    .HasColumnType("datetime")
                    .HasColumnName("fecha_ing");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("nombre");

                entity.Property(e => e.UsuarioIng)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("usuario_ing");
            });

            modelBuilder.Entity<Usuario>(entity =>
            {
                entity.HasKey(e => e.IdUsuario)
                    .HasName("PK_ADMON_USUARIO");

                entity.ToTable("usuario", "db_admon");

                entity.Property(e => e.IdUsuario)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("id_usuario");

                entity.Property(e => e.Contrasenia)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("contrasenia");

                entity.Property(e => e.Cui)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("cui");

                entity.Property(e => e.Estado).HasColumnName("estado");

                entity.Property(e => e.FechaIng)
                    .HasColumnType("datetime")
                    .HasColumnName("fecha_ing");

                entity.Property(e => e.NombreUsuario)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nombre_usuario");

                entity.Property(e => e.SemanaAExcluir).HasColumnName("semana_a_excluir");

                entity.Property(e => e.SetSemanaAnt).HasColumnName("set_semana_ant");

                entity.Property(e => e.SuperAdmin).HasColumnName("super_admin");

                entity.Property(e => e.UsuarioIng)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("usuario_ing");

                entity.HasOne(d => d.CuiNavigation)
                    .WithMany(p => p.Usuarios)
                    .HasForeignKey(d => d.Cui)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ADMON_USUARIO_CUI");
            });

            modelBuilder.Entity<UsuarioCajaChica>(entity =>
            {
                entity.HasKey(e => new { e.IdUsuario, e.CodigoCajaChica })
                    .HasName("PK_ADMON_USRCCHICA");

                entity.ToTable("usuario_caja_chica", "db_admon");

                entity.Property(e => e.IdUsuario)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("id_usuario");

                entity.Property(e => e.CodigoCajaChica).HasColumnName("codigo_caja_chica");

                entity.Property(e => e.Estado).HasColumnName("estado");

                entity.Property(e => e.FechaIng)
                    .HasColumnType("datetime")
                    .HasColumnName("fecha_ing");

                entity.Property(e => e.UsuarioIng)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("usuario_ing");

                entity.HasOne(d => d.CodigoCajaChicaNavigation)
                    .WithMany(p => p.UsuarioCajaChicas)
                    .HasForeignKey(d => d.CodigoCajaChica)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ADMON_USRCCHICA_CAJACHICA");

                entity.HasOne(d => d.IdUsuarioNavigation)
                    .WithMany(p => p.UsuarioCajaChicas)
                    .HasForeignKey(d => d.IdUsuario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ADMON_USRCCHICA_USER");
            });

            modelBuilder.Entity<UsuarioEmpresa>(entity =>
            {
                entity.HasKey(e => new { e.CodigoEmpresa, e.IdUsuario })
                    .HasName("PK_ADMON_USEREMP");

                entity.ToTable("usuario_empresa", "db_admon");

                entity.Property(e => e.CodigoEmpresa).HasColumnName("codigo_empresa");

                entity.Property(e => e.IdUsuario)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("id_usuario");

                entity.Property(e => e.Estado).HasColumnName("estado");

                entity.Property(e => e.FechaIng)
                    .HasColumnType("datetime")
                    .HasColumnName("fecha_ing");

                entity.Property(e => e.UsuarioIng)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("usuario_ing");

                entity.HasOne(d => d.CodigoEmpresaNavigation)
                    .WithMany(p => p.UsuarioEmpresas)
                    .HasForeignKey(d => d.CodigoEmpresa)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ADMON_USEREMP_EMPRESA");

                entity.HasOne(d => d.IdUsuarioNavigation)
                    .WithMany(p => p.UsuarioEmpresas)
                    .HasForeignKey(d => d.IdUsuario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ADMON_USEREMP_USUARIO");
            });

            modelBuilder.Entity<UsuarioRol>(entity =>
            {
                entity.HasKey(e => new { e.IdUsuario, e.CodigoRol })
                    .HasName("PK_ADMON_USUARIOROL");

                entity.ToTable("usuario_rol", "db_admon");

                entity.Property(e => e.IdUsuario)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("id_usuario");

                entity.Property(e => e.CodigoRol).HasColumnName("codigo_rol");

                entity.Property(e => e.Estado).HasColumnName("estado");

                entity.Property(e => e.FechaIng)
                    .HasColumnType("datetime")
                    .HasColumnName("fecha_ing");

                entity.Property(e => e.UsuarioIng)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("usuario_ing");

                entity.HasOne(d => d.CodigoRolNavigation)
                    .WithMany(p => p.UsuarioRols)
                    .HasForeignKey(d => d.CodigoRol)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ADMON_USUARIOROL_ROL");

                entity.HasOne(d => d.IdUsuarioNavigation)
                    .WithMany(p => p.UsuarioRols)
                    .HasForeignKey(d => d.IdUsuario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ADMON_USUARIOROL_USUARIO");
            });

            modelBuilder.Entity<UsuarioTipoReporte>(entity =>
            {
                entity.HasKey(e => new { e.CodigoTipoReporte, e.IdUsuario })
                    .HasName("PK_ADMON_TIPOREPORTUSER");

                entity.ToTable("usuario_tipo_reporte", "db_admon");

                entity.Property(e => e.CodigoTipoReporte).HasColumnName("codigo_tipo_reporte");

                entity.Property(e => e.IdUsuario)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("id_usuario");

                entity.Property(e => e.Estado).HasColumnName("estado");

                entity.Property(e => e.FechaIng)
                    .HasColumnType("datetime")
                    .HasColumnName("fecha_ing");

                entity.Property(e => e.UsuarioIng)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("usuario_ing");

                entity.HasOne(d => d.CodigoTipoReporteNavigation)
                    .WithMany(p => p.UsuarioTipoReportes)
                    .HasForeignKey(d => d.CodigoTipoReporte)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ADMON_TIPOREPORTUSER_TIPOREPORT");

                entity.HasOne(d => d.IdUsuarioNavigation)
                    .WithMany(p => p.UsuarioTipoReportes)
                    .HasForeignKey(d => d.IdUsuario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ADMON_TIPOREPORTUSER_USER");
            });

            modelBuilder.Entity<Vendedor>(entity =>
            {
                entity.HasKey(e => e.CodigoVendedor)
                    .HasName("PK_VENTAS_VENDOR");

                entity.ToTable("vendedor", "db_ventas");

                entity.Property(e => e.CodigoVendedor)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("codigo_vendedor");

                entity.Property(e => e.CodigoEmpleado)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("codigo_empleado");

                entity.Property(e => e.CodigoEmpresa).HasColumnName("codigo_empresa");

                entity.Property(e => e.Cui)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("cui");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("descripcion");

                entity.Property(e => e.Estado).HasColumnName("estado");

                entity.Property(e => e.FechaIng)
                    .HasColumnType("datetime")
                    .HasColumnName("fecha_ing");

                entity.Property(e => e.NombreCompleto)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("nombre_completo");

                entity.Property(e => e.UsuarioIng)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("usuario_ing");

                entity.HasOne(d => d.CuiNavigation)
                    .WithMany(p => p.Vendedors)
                    .HasForeignKey(d => d.Cui)
                    .HasConstraintName("FK_VENTAS_VENDOR_PERSONA");

                entity.HasOne(d => d.CodigoEmp)
                    .WithMany(p => p.Vendedors)
                    .HasForeignKey(d => new { d.CodigoEmpresa, d.CodigoEmpleado })
                    .HasConstraintName("FK_VENTAS_VENDOR_EMPLEADO");
            });

            modelBuilder.HasSequence("SQ_CLIENTE", "db_ventas").StartsAt(390);

            modelBuilder.HasSequence("SQ_CODIGO_DEPOSITO_BTB", "db_contabilidad").StartsAt(70);

            modelBuilder.HasSequence("SQ_CODIGO_HIST_EMPLEADO", "db_rrhh").StartsAt(128);

            modelBuilder.HasSequence("SQ_CODIGO_HIST_PERSONA", "db_rrhh").StartsAt(9);

            modelBuilder.HasSequence("SQ_CODIGO_SUSPENSION", "db_rrhh").StartsAt(3);

            modelBuilder.HasSequence("SQ_CONFIG_VENDEDOR_RUTA", "db_ventas");

            modelBuilder.HasSequence("SQ_CUENTA_POR_COBRAR", "db_contabilidad").StartsAt(683);

            modelBuilder.HasSequence("SQ_CUI_GENERICO", "db_rrhh").StartsAt(4);

            modelBuilder.HasSequence("SQ_CXC_CORRELATIVO", "db_contabilidad").StartsAt(54);

            modelBuilder.HasSequence("SQ_DET_REPORTE_CAJA", "db_tesoreria").StartsAt(23451);

            modelBuilder.HasSequence("SQ_DET_SECUENCIA", "db_admon");

            modelBuilder.HasSequence("SQ_ENTIDAD", "db_tesoreria").StartsAt(5016);

            modelBuilder.HasSequence("SQ_PAGO_BTB", "db_contabilidad").StartsAt(6);

            modelBuilder.HasSequence("SQ_PAGO_DESCUENTO", "db_contabilidad").StartsAt(82);

            modelBuilder.HasSequence("SQ_PROG_QUINCENAL", "db_admon").StartsAt(49);

            modelBuilder.HasSequence("SQ_PROG_SEMANAL", "db_admon").StartsAt(731);

            modelBuilder.HasSequence("SQ_RECIBO_EGRESO", "db_tesoreria");

            modelBuilder.HasSequence("SQ_RECIBO_INGRESO", "db_tesoreria");

            modelBuilder.HasSequence("SQ_REPORTE_CAJA", "db_tesoreria").StartsAt(156);

            modelBuilder.HasSequence("SQ_REPORTE_CAJA_CHICA", "db_tesoreria").StartsAt(98);

            modelBuilder.HasSequence("SQ_SALDO_INICIAL", "db_contabilidad").StartsAt(6);

            modelBuilder.HasSequence("SQ_SITEMAP", "db_admon").StartsAt(90);

            modelBuilder.HasSequence("SQ_TIPO_REPORTE", "db_admon").StartsAt(10);

            modelBuilder.HasSequence("SQ_TRANSACCION", "db_tesoreria");

            modelBuilder.HasSequence("SQ_TRASLADO_VENTA_CONTADO", "db_tesoreria");

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
