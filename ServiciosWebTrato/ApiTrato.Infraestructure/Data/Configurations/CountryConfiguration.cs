using ApiTrato.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ApiTrato.Infraestructure.Data.Configurations
{
    public class CountryConfiguration : IEntityTypeConfiguration<Country>
    {
        public void Configure(EntityTypeBuilder<Country> builder)
        {
            builder.HasKey(e => e.CountryId)
                    .HasName("PK__PAIS__B68D33A1FF612604");

            builder.ToTable("PAIS");

            builder.Property(e => e.CountryId).HasColumnName("ID_PAIS");

            builder.Property(e => e.CountryName)
                .IsRequired()
                .HasColumnName("NOMBRE_PAIS")
                .HasMaxLength(50)
                .IsUnicode(false);
        }
    }
}
