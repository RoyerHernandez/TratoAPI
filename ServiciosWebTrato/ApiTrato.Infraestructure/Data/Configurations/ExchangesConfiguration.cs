using ApiTrato.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ApiTrato.Infraestructure.Data.Configurations
{
    public class ExchangesConfiguration : IEntityTypeConfiguration<Exchanges>
    {
        public void Configure(EntityTypeBuilder<Exchanges> builder)
        {
            builder.HasKey(e => e.ExchangeId)
                   .HasName("PK__INTERCAM__2F81ABEEE8AB77A5");

            builder.ToTable("INTERCAMBIOS");

            builder.Property(e => e.ExchangeId).HasColumnName("ID_INTERCAMBIO");

            builder.Property(e => e.High).HasColumnName("ALTO");

            builder.Property(e => e.width).HasColumnName("ANCHO");

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

            builder.HasOne(d => d.Categories)
                .WithMany(p => p.Exchanges)
                .HasForeignKey(d => d.CategoryId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__INTERCAMB__ID_CA__06CD04F7");

            builder.HasOne(d => d.Cities)
                .WithMany(p => p.Exchanges)
                .HasForeignKey(d => d.CityId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__INTERCAMB__ID_CI__08B54D69");

            builder.HasOne(d => d.States)
                .WithMany(p => p.Exchanges)
                .HasForeignKey(d => d.StateId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__INTERCAMB__ID_ES__07C12930");

            builder.HasOne(d => d.DeliveriesTypes)
                .WithMany(p => p.Excanges)
                .HasForeignKey(d => d.DeliveryTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__INTERCAMB__ID_TI__09A971A2");
        }
    }
}
