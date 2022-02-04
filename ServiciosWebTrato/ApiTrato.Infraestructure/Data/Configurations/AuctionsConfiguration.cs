using ApiTrato.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ApiTrato.Infraestructure.Data.Configurations
{
    public class AuctionsConfiguration : IEntityTypeConfiguration<Auctions>
    {
        public void Configure(EntityTypeBuilder<Auctions> builder)
        {
            builder.HasKey(e => e.AuctionsId)
                    .HasName("PK__SUBASTAS__05C0A4EFE3EAC42F");

            builder.ToTable("SUBASTAS");

            builder.Property(e => e.AuctionsId).HasColumnName("ID_SUBASTA");

            builder.Property(e => e.High).HasColumnName("ALTO");

            builder.Property(e => e.Width).HasColumnName("ANCHO");

            builder.Property(e => e.CategoryId).HasColumnName("ID_CATEGORIA");

            builder.Property(e => e.CityId).HasColumnName("ID_CIUDAD");

            builder.Property(e => e.StateId).HasColumnName("ID_ESTADO");

            builder.Property(e => e.LocationId).HasColumnName("ID_LOCALIDAD");

            builder.Property(e => e.DeliveryTypeId).HasColumnName("ID_TIPO_ENTREGA");

            builder.Property(e => e.Image)
                .HasColumnName("IMAGENES")
                .HasMaxLength(150)
                .IsUnicode(false);

            builder.Property(e => e.Long).HasColumnName("LARGO");

            builder.Property(e => e.Mark)
                .IsRequired()
                .HasColumnName("MARCA")
                .HasMaxLength(100)
                .IsUnicode(false);

            builder.Property(e => e.Weight).HasColumnName("PESO");

            builder.Property(e => e.Product)
                .IsRequired()
                .HasColumnName("PRODUCTO")
                .HasMaxLength(100)
                .IsUnicode(false);

            builder.Property(e => e.StartValue)
                .HasColumnName("VALOR_DE_INICIO")
                .HasColumnType("decimal(2, 0)");

            builder.Property(e => e.BidValue)
                .HasColumnName("VALOR_DE_PUJA")
                .HasColumnType("decimal(2, 0)");

            builder.HasOne(d => d.Categories)
                .WithMany(p => p.Auctions)
                .HasForeignKey(d => d.CategoryId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__SUBASTAS__ID_CAT__01142BA1");

            builder.HasOne(d => d.Cities)
                .WithMany(p => p.Auctions)
                .HasForeignKey(d => d.CityId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__SUBASTAS__ID_CIU__02FC7413");

            builder.HasOne(d => d.States)
                .WithMany(p => p.Auctions)
                .HasForeignKey(d => d.AuctionsId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__SUBASTAS__ID_EST__02084FDA");

            builder.HasOne(d => d.DeliveriesTypes)
                .WithMany(p => p.Auctions)
                .HasForeignKey(d => d.DeliveryTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__SUBASTAS__ID_TIP__03F0984C");
        }
    }
}
