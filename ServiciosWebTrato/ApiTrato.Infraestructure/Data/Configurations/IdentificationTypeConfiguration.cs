using ApiTrato.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ApiTrato.Infraestructure.Data.Configurations
{
    public class IdentificationTypeConfiguration : IEntityTypeConfiguration<IdentificationType>
    {
        public void Configure(EntityTypeBuilder<IdentificationType> builder)
        {
            builder.HasKey(e => e.IdentificationTypeId)
                    .HasName("PK__TIPOS_ID__4B87E3378E64658E");

            builder.ToTable("TIPOS_IDENTIFICACION");

            builder.Property(e => e.IdentificationTypeId).HasColumnName("ID_TIPO_IDENTIFICACION");

            builder.Property(e => e.Description)
                .IsRequired()
                .HasColumnName("DESCRIPCION")
                .HasMaxLength(45)
                .IsUnicode(false);

            builder.Property(e => e.IdentificationTypeName)
                .IsRequired()
                .HasColumnName("TIPO_IDENTIFICACION")
                .HasMaxLength(45)
                .IsUnicode(false);
        }
    }
}
