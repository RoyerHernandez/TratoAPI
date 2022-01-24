using System;
using ApiTrato.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace ApiTrato.Infraestructure.Data
{
    public partial class TRATO_DATABASEContext : DbContext
    {
        public TRATO_DATABASEContext()
        {
        }

        public TRATO_DATABASEContext(DbContextOptions<TRATO_DATABASEContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Categories> Categorias { get; set; }
        public virtual DbSet<Ciudades> Ciudades { get; set; }
        public virtual DbSet<Departamentos> Departamentos { get; set; }
        public virtual DbSet<Estados> Estados { get; set; }
        public virtual DbSet<Intercambios> Intercambios { get; set; }
        public virtual DbSet<Localidad> Localidad { get; set; }
        public virtual DbSet<Pais> Pais { get; set; }
        public virtual DbSet<Subastas> Subastas { get; set; }
        public virtual DbSet<TiposDeEntrega> TiposDeEntrega { get; set; }
        public virtual DbSet<TiposIdentificacion> TiposIdentificacion { get; set; }
        public virtual DbSet<Usuarios> Usuarios { get; set; }

//        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//        {
//            if (!optionsBuilder.IsConfigured)
//            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
//            }
//        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Categories>(entity =>
            {
                entity.HasKey(e => e.CategoryId)
                    .HasName("PK__CATEGORI__4BD51FA54F258162");

                entity.ToTable("CATEGORIAS");

                entity.Property(e => e.CategoryId)
                    .HasColumnName("ID_CATEGORIA")
                    .ValueGeneratedNever();

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("DESCRIPCION")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.Image)
                    .IsRequired()
                    .HasColumnName("IMAGEN")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CategoryName)
                    .IsRequired()
                    .HasColumnName("NOMBRE_CATEGORIA")
                    .HasMaxLength(45)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Ciudades>(entity =>
            {
                entity.HasKey(e => e.IdCiudad)
                    .HasName("PK__CIUDADES__6D2D1B23E48C9947");

                entity.ToTable("CIUDADES");

                entity.Property(e => e.IdCiudad).HasColumnName("ID_CIUDAD");

                entity.Property(e => e.IdDepartamento).HasColumnName("ID_DEPARTAMENTO");

                entity.Property(e => e.IdPais).HasColumnName("ID_PAIS");

                entity.Property(e => e.NombreCiudad)
                    .IsRequired()
                    .HasColumnName("NOMBRE_CIUDAD")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdDepartamentoNavigation)
                    .WithMany(p => p.Ciudades)
                    .HasForeignKey(d => d.IdDepartamento)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__CIUDADES__ID_DEP__787EE5A0");

                entity.HasOne(d => d.IdPaisNavigation)
                    .WithMany(p => p.Ciudades)
                    .HasForeignKey(d => d.IdPais)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__CIUDADES__ID_PAI__797309D9");
            });

            modelBuilder.Entity<Departamentos>(entity =>
            {
                entity.HasKey(e => e.IdDepartamento)
                    .HasName("PK__DEPARTAM__52E77BE08231DC37");

                entity.ToTable("DEPARTAMENTOS");

                entity.Property(e => e.IdDepartamento)
                    .HasColumnName("ID_DEPARTAMENTO")
                    .ValueGeneratedNever();

                entity.Property(e => e.IdPais).HasColumnName("ID_PAIS");

                entity.Property(e => e.NombreDepartamento)
                    .IsRequired()
                    .HasColumnName("NOMBRE_DEPARTAMENTO")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdPaisNavigation)
                    .WithMany(p => p.Departamentos)
                    .HasForeignKey(d => d.IdPais)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__DEPARTAME__ID_PA__75A278F5");
            });

            modelBuilder.Entity<Estados>(entity =>
            {
                entity.HasKey(e => e.IdEstado)
                    .HasName("PK__ESTADOS__241E2E01FD4E17AA");

                entity.ToTable("ESTADOS");

                entity.Property(e => e.IdEstado)
                    .HasColumnName("ID_ESTADO")
                    .ValueGeneratedNever();

                entity.Property(e => e.NombreEstado)
                    .IsRequired()
                    .HasColumnName("NOMBRE_ESTADO")
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Intercambios>(entity =>
            {
                entity.HasKey(e => e.IdIntercambio)
                    .HasName("PK__INTERCAM__2F81ABEEE8AB77A5");

                entity.ToTable("INTERCAMBIOS");

                entity.Property(e => e.IdIntercambio).HasColumnName("ID_INTERCAMBIO");

                entity.Property(e => e.Alto).HasColumnName("ALTO");

                entity.Property(e => e.Ancho).HasColumnName("ANCHO");

                entity.Property(e => e.IdCategoria).HasColumnName("ID_CATEGORIA");

                entity.Property(e => e.IdCiudad).HasColumnName("ID_CIUDAD");

                entity.Property(e => e.IdEstado).HasColumnName("ID_ESTADO");

                entity.Property(e => e.IdLocalidad).HasColumnName("ID_LOCALIDAD");

                entity.Property(e => e.IdTipoEntrega).HasColumnName("ID_TIPO_ENTREGA");

                entity.Property(e => e.Imagenes)
                    .HasColumnName("IMAGENES")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Largo).HasColumnName("LARGO");

                entity.Property(e => e.Marca)
                    .IsRequired()
                    .HasColumnName("MARCA")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Peso).HasColumnName("PESO");

                entity.Property(e => e.Producto)
                    .IsRequired()
                    .HasColumnName("PRODUCTO")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdCategoriaNavigation)
                    .WithMany(p => p.Exchanges)
                    .HasForeignKey(d => d.IdCategoria)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__INTERCAMB__ID_CA__06CD04F7");

                entity.HasOne(d => d.IdCiudadNavigation)
                    .WithMany(p => p.Intercambios)
                    .HasForeignKey(d => d.IdCiudad)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__INTERCAMB__ID_CI__08B54D69");

                entity.HasOne(d => d.IdEstadoNavigation)
                    .WithMany(p => p.Intercambios)
                    .HasForeignKey(d => d.IdEstado)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__INTERCAMB__ID_ES__07C12930");

                entity.HasOne(d => d.IdTipoEntregaNavigation)
                    .WithMany(p => p.Intercambios)
                    .HasForeignKey(d => d.IdTipoEntrega)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__INTERCAMB__ID_TI__09A971A2");
            });

            modelBuilder.Entity<Localidad>(entity =>
            {
                entity.HasKey(e => e.IdLocalidad)
                    .HasName("PK__LOCALIDA__469BEBBD132EBB35");

                entity.ToTable("LOCALIDAD");

                entity.Property(e => e.IdLocalidad)
                    .HasColumnName("ID_LOCALIDAD")
                    .ValueGeneratedNever();

                entity.Property(e => e.IdCiudad).HasColumnName("ID_CIUDAD");

                entity.Property(e => e.IdDepartamento).HasColumnName("ID_DEPARTAMENTO");

                entity.Property(e => e.IdPais).HasColumnName("ID_PAIS");

                entity.Property(e => e.NombreLocalidad)
                    .IsRequired()
                    .HasColumnName("NOMBRE_LOCALIDAD")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdCiudadNavigation)
                    .WithMany(p => p.Localidad)
                    .HasForeignKey(d => d.IdCiudad)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__LOCALIDAD__ID_CI__7C4F7684");

                entity.HasOne(d => d.IdDepartamentoNavigation)
                    .WithMany(p => p.Localidad)
                    .HasForeignKey(d => d.IdDepartamento)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__LOCALIDAD__ID_DE__7D439ABD");

                entity.HasOne(d => d.IdPaisNavigation)
                    .WithMany(p => p.Localidad)
                    .HasForeignKey(d => d.IdPais)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__LOCALIDAD__ID_PA__7E37BEF6");
            });

            modelBuilder.Entity<Pais>(entity =>
            {
                entity.HasKey(e => e.IdPais)
                    .HasName("PK__PAIS__B68D33A1FF612604");

                entity.ToTable("PAIS");

                entity.Property(e => e.IdPais).HasColumnName("ID_PAIS");

                entity.Property(e => e.NombrePais)
                    .IsRequired()
                    .HasColumnName("NOMBRE_PAIS")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Subastas>(entity =>
            {
                entity.HasKey(e => e.IdSubasta)
                    .HasName("PK__SUBASTAS__05C0A4EFE3EAC42F");

                entity.ToTable("SUBASTAS");

                entity.Property(e => e.IdSubasta).HasColumnName("ID_SUBASTA");

                entity.Property(e => e.Alto).HasColumnName("ALTO");

                entity.Property(e => e.Ancho).HasColumnName("ANCHO");

                entity.Property(e => e.IdCategoria).HasColumnName("ID_CATEGORIA");

                entity.Property(e => e.IdCiudad).HasColumnName("ID_CIUDAD");

                entity.Property(e => e.IdEstado).HasColumnName("ID_ESTADO");

                entity.Property(e => e.IdLocalidad).HasColumnName("ID_LOCALIDAD");

                entity.Property(e => e.IdTipoEntrega).HasColumnName("ID_TIPO_ENTREGA");

                entity.Property(e => e.Imagenes)
                    .HasColumnName("IMAGENES")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Largo).HasColumnName("LARGO");

                entity.Property(e => e.Marca)
                    .IsRequired()
                    .HasColumnName("MARCA")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Peso).HasColumnName("PESO");

                entity.Property(e => e.Producto)
                    .IsRequired()
                    .HasColumnName("PRODUCTO")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ValorDeInicio)
                    .HasColumnName("VALOR_DE_INICIO")
                    .HasColumnType("decimal(2, 0)");

                entity.Property(e => e.ValorDePuja)
                    .HasColumnName("VALOR_DE_PUJA")
                    .HasColumnType("decimal(2, 0)");

                entity.HasOne(d => d.IdCategoriaNavigation)
                    .WithMany(p => p.Auctions)
                    .HasForeignKey(d => d.IdCategoria)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__SUBASTAS__ID_CAT__01142BA1");

                entity.HasOne(d => d.IdCiudadNavigation)
                    .WithMany(p => p.Subastas)
                    .HasForeignKey(d => d.IdCiudad)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__SUBASTAS__ID_CIU__02FC7413");

                entity.HasOne(d => d.IdEstadoNavigation)
                    .WithMany(p => p.Subastas)
                    .HasForeignKey(d => d.IdEstado)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__SUBASTAS__ID_EST__02084FDA");

                entity.HasOne(d => d.IdTipoEntregaNavigation)
                    .WithMany(p => p.Subastas)
                    .HasForeignKey(d => d.IdTipoEntrega)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__SUBASTAS__ID_TIP__03F0984C");
            });

            modelBuilder.Entity<TiposDeEntrega>(entity =>
            {
                entity.HasKey(e => e.IdTipoEntrega)
                    .HasName("PK__TIPOS_DE__350E32BF90F1777A");

                entity.ToTable("TIPOS_DE_ENTREGA");

                entity.Property(e => e.IdTipoEntrega).HasColumnName("ID_TIPO_ENTREGA");

                entity.Property(e => e.IdEstado).HasColumnName("ID_ESTADO");

                entity.Property(e => e.NombreTipoEntrega)
                    .IsRequired()
                    .HasColumnName("NOMBRE_TIPO_ENTREGA")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdEstadoNavigation)
                    .WithMany(p => p.TiposDeEntrega)
                    .HasForeignKey(d => d.IdEstado)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__TIPOS_DE___ID_ES__6B24EA82");
            });

            modelBuilder.Entity<TiposIdentificacion>(entity =>
            {
                entity.HasKey(e => e.IdTipoIdentificacion)
                    .HasName("PK__TIPOS_ID__4B87E3378E64658E");

                entity.ToTable("TIPOS_IDENTIFICACION");

                entity.Property(e => e.IdTipoIdentificacion).HasColumnName("ID_TIPO_IDENTIFICACION");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasColumnName("DESCRIPCION")
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.TipoIdentificacion)
                    .IsRequired()
                    .HasColumnName("TIPO_IDENTIFICACION")
                    .HasMaxLength(45)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Usuarios>(entity =>
            {
                entity.ToTable("USUARIOS");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Apellido)
                    .IsRequired()
                    .HasColumnName("APELLIDO")
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.Contrasena)
                    .IsRequired()
                    .HasColumnName("CONTRASENA")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CorreoElectronico)
                    .HasColumnName("CORREO_ELECTRONICO")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Direccion)
                    .IsRequired()
                    .HasColumnName("DIRECCION")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.IdEstado).HasColumnName("ID_ESTADO");

                entity.Property(e => e.IdTipoIdentifiacion).HasColumnName("ID_TIPO_IDENTIFIACION");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("NOMBRE")
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.NumeroContacto)
                    .HasColumnName("NUMERO_CONTACTO")
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.NumeroIdentificacion)
                    .IsRequired()
                    .HasColumnName("NUMERO_IDENTIFICACION")
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdEstadoNavigation)
                    .WithMany(p => p.Usuarios)
                    .HasForeignKey(d => d.IdEstado)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__USUARIOS__ID_EST__6E01572D");

                entity.HasOne(d => d.IdTipoIdentifiacionNavigation)
                    .WithMany(p => p.Usuarios)
                    .HasForeignKey(d => d.IdTipoIdentifiacion)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__USUARIOS__ID_TIP__6EF57B66");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
