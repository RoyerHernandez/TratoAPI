using ApiTrato.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ApiTrato.Infraestructure.Data.Configurations
{
    public class CategoriesConfiguration : IEntityTypeConfiguration<Categories>
    {
        public void Configure(EntityTypeBuilder<Categories> builder)
        {
            builder.ToTable("CATEGORIAS");
            builder.HasKey(e => e.CategoryId)
                .HasName("PK__CATEGORI__4BD51FA54F258162");

            builder.ToTable("CATEGORIAS");

            builder.Property(e => e.CategoryId)
                .HasColumnName("ID_CATEGORIA")
                .ValueGeneratedNever();

            builder.Property(e => e.Description)
                .IsRequired()
                .HasColumnName("DESCRIPCION")
                .HasMaxLength(1000)
                .IsUnicode(false);

            builder.Property(e => e.Image)
                .IsRequired()
                .HasColumnName("IMAGEN")
                .HasMaxLength(20)
                .IsUnicode(false);

            builder.Property(e => e.CategoryName)
                .IsRequired()
                .HasColumnName("NOMBRE_CATEGORIA")
                .HasMaxLength(45)
                .IsUnicode(false);
        }
    }
}
