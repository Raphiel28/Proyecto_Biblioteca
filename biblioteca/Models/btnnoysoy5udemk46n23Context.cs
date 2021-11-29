using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace biblioteca.Models
{
    public partial class btnnoysoy5udemk46n23Context : DbContext
    {
        public btnnoysoy5udemk46n23Context()
        {
        }

        public btnnoysoy5udemk46n23Context(DbContextOptions<btnnoysoy5udemk46n23Context> options)
            : base(options)
        {
        }

        public virtual DbSet<Facturas> Facturas { get; set; }
        public virtual DbSet<Libros> Libros { get; set; }
        public virtual DbSet<Usuarios> Usuarios { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseMySql("server=btnnoysoy5udemk46n23-mysql.services.clever-cloud.com;uid=usgtyi2sy9beap5a;pwd=1BUX84T81RSjN7mwD0jE;database=btnnoysoy5udemk46n23", x => x.ServerVersion("8.0.22-mysql"));
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Facturas>(entity =>
            {
                entity.HasKey(e => e.IdFactura)
                    .HasName("PRIMARY");

                entity.HasIndex(e => e.IdLibro)
                    .HasName("ID_Libro");

                entity.Property(e => e.IdFactura).HasColumnName("ID_Factura");

                entity.Property(e => e.ApellidoCliente)
                    .IsRequired()
                    .HasColumnName("Apellido_Cliente")
                    .HasColumnType("varchar(40)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.FechaRenta)
                    .HasColumnName("Fecha_Renta")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaRetorno)
                    .HasColumnName("Fecha_Retorno")
                    .HasColumnType("datetime");

                entity.Property(e => e.IdLibro).HasColumnName("ID_Libro");

                entity.Property(e => e.NombreCliente)
                    .IsRequired()
                    .HasColumnName("Nombre_Cliente")
                    .HasColumnType("varchar(40)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.TelefonoCliente)
                    .IsRequired()
                    .HasColumnName("Telefono_Cliente")
                    .HasColumnType("varchar(11)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.HasOne(d => d.IdLibroNavigation)
                    .WithMany(p => p.Facturas)
                    .HasForeignKey(d => d.IdLibro)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Facturas_ibfk_1");
            });

            modelBuilder.Entity<Libros>(entity =>
            {
                entity.HasKey(e => e.IdLibro)
                    .HasName("PRIMARY");

                entity.Property(e => e.IdLibro).HasColumnName("ID_Libro");

                entity.Property(e => e.CopiasDisponibles).HasColumnName("Copias_Disponibles");

                entity.Property(e => e.EditorialLibro)
                    .IsRequired()
                    .HasColumnName("Editorial_Libro")
                    .HasColumnType("varchar(40)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.GeneroLibro)
                    .IsRequired()
                    .HasColumnName("Genero_Libro")
                    .HasColumnType("varchar(40)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.NombreLibro)
                    .IsRequired()
                    .HasColumnName("Nombre_Libro")
                    .HasColumnType("varchar(40)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<Usuarios>(entity =>
            {
                entity.HasKey(e => e.IdUsuario)
                    .HasName("PRIMARY");

                entity.Property(e => e.IdUsuario).HasColumnName("ID_Usuario");

                entity.Property(e => e.Admin)
                    .HasColumnName("ADMIN")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.ApellidoUsuario)
                    .IsRequired()
                    .HasColumnName("Apellido_Usuario")
                    .HasColumnType("varchar(40)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Contrasena)
                    .IsRequired()
                    .HasColumnType("varchar(25)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CorreoUsuario)
                    .IsRequired()
                    .HasColumnName("Correo_Usuario")
                    .HasColumnType("varchar(40)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.NombreUsuario)
                    .IsRequired()
                    .HasColumnName("Nombre_Usuario")
                    .HasColumnType("varchar(40)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.TelefonoUsuario)
                    .IsRequired()
                    .HasColumnName("Telefono_Usuario")
                    .HasColumnType("varchar(11)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
