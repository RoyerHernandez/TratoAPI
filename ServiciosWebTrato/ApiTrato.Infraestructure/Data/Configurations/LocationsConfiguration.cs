using ApiTrato.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApiTrato.Infraestructure.Data.Configurations
{
    public class LocationsConfiguration : IEntityTypeConfiguration<Locations>
    {
        public void Configure(EntityTypeBuilder<Locations> builder)
        {
            builder.HasKey(e => e.LocationId)
                    .HasName("PK__LOCALIDA__469BEBBD132EBB35");

            builder.ToTable("LOCALIDAD");

            builder.Property(e => e.LocationId)
                .HasColumnName("ID_LOCALIDAD")
                .ValueGeneratedNever();

            builder.Property(e => e.CityId).HasColumnName("ID_CIUDAD");

            builder.Property(e => e.DepartmentId).HasColumnName("ID_DEPARTAMENTO");

            builder.Property(e => e.CountryId).HasColumnName("ID_PAIS");

            builder.Property(e => e.LocationName)
                .IsRequired()
                .HasColumnName("NOMBRE_LOCALIDAD")
                .HasMaxLength(50)
                .IsUnicode(false);

            builder.HasOne(d => d.Cities)
                .WithMany(p => p.Locations)
                .HasForeignKey(d => d.CityId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__LOCALIDAD__ID_CI__7C4F7684");

            builder.HasOne(d => d.Departments)
                .WithMany(p => p.Locations)
                .HasForeignKey(d => d.DepartmentId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__LOCALIDAD__ID_DE__7D439ABD");

            builder.HasOne(d => d.Countries)
                .WithMany(p => p.Locations)
                .HasForeignKey(d => d.CountryId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__LOCALIDAD__ID_PA__7E37BEF6");
        }
    }
}
