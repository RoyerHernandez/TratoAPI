using ApiTrato.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApiTrato.Infraestructure.Data.Configurations
{
    public class DepartmentsConfiguration : IEntityTypeConfiguration<Departments>
    {
        public void Configure(EntityTypeBuilder<Departments> builder)
        {
            builder.HasKey(e => e.DepartmentId)
                    .HasName("PK__DEPARTAM__52E77BE08231DC37");

            builder.ToTable("DEPARTAMENTOS");

            builder.Property(e => e.DepartmentId)
                .HasColumnName("ID_DEPARTAMENTO")
                .ValueGeneratedNever();

            builder.Property(e => e.CountryId).HasColumnName("ID_PAIS");

            builder.Property(e => e.DepartmentName)
                .IsRequired()
                .HasColumnName("NOMBRE_DEPARTAMENTO")
                .HasMaxLength(50)
                .IsUnicode(false);

            builder.HasOne(d => d.Countries)
                .WithMany(p => p.Departments)
                .HasForeignKey(d => d.CountryId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__DEPARTAME__ID_PA__75A278F5");
        }
    }
}
