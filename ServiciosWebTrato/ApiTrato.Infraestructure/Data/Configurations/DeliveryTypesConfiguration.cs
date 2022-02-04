using ApiTrato.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ApiTrato.Infraestructure.Data.Configurations
{
    public class DeliveryTypesConfiguration : IEntityTypeConfiguration<DeliveryTypes>
    {
        public void Configure(EntityTypeBuilder<DeliveryTypes> builder)
        {
            builder.HasKey(e => e.DeliveryTypeId)
                    .HasName("PK__TIPOS_DE__350E32BF90F1777A");

            builder.ToTable("TIPOS_DE_ENTREGA");

            builder.Property(e => e.DeliveryTypeId).HasColumnName("ID_TIPO_ENTREGA");

            builder.Property(e => e.StateId).HasColumnName("ID_ESTADO");

            builder.Property(e => e.DeliveryTypeName)
                .IsRequired()
                .HasColumnName("NOMBRE_TIPO_ENTREGA")
                .HasMaxLength(30)
                .IsUnicode(false);

            builder.HasOne(d => d.States)
                .WithMany(p => p.DeliveryTypes)
                .HasForeignKey(d => d.StateId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__TIPOS_DE___ID_ES__6B24EA82");
        }
    }
}
