using ApiTrato.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApiTrato.Infraestructure.Data.Configurations
{
    public class CitiesConfiguration : IEntityTypeConfiguration<Cities>
    {
        public void Configure(EntityTypeBuilder<Cities> builder)
        {
            builder.HasKey(e => e.CityId)
                    .HasName("PK__CIUDADES__6D2D1B23E48C9947");

            builder.ToTable("CIUDADES");

            builder.Property(e => e.CityId).HasColumnName("ID_CIUDAD");

            builder.Property(e => e.DepartmentId).HasColumnName("ID_DEPARTAMENTO");

            builder.Property(e => e.CountryId).HasColumnName("ID_PAIS");

            builder.Property(e => e.CityName)
                .IsRequired()
                .HasColumnName("NOMBRE_CIUDAD")
                .HasMaxLength(50)
                .IsUnicode(false);

            builder.HasOne(d => d.Departments)
                .WithMany(p => p.Cities)
                .HasForeignKey(d => d.DepartmentId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__CIUDADES__ID_DEP__787EE5A0");

            builder.HasOne(d => d.Countries)
                .WithMany(p => p.Cities)
                .HasForeignKey(d => d.CountryId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__CIUDADES__ID_PAI__797309D9");
        }
    }
}
