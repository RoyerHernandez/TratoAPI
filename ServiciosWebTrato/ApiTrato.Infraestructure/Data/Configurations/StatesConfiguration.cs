using ApiTrato.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApiTrato.Infraestructure.Data.Configurations
{
    public class StatesConfiguration : IEntityTypeConfiguration<States>
    {
        public void Configure(EntityTypeBuilder<States> builder)
        {
            builder.HasKey(e => e.StateId)
                   .HasName("PK__ESTADOS__241E2E01FD4E17AA");

            builder.ToTable("ESTADOS");

            builder.Property(e => e.StateId)
                .HasColumnName("ID_ESTADO")
                .ValueGeneratedNever();

            builder.Property(e => e.StateName)
                .IsRequired()
                .HasColumnName("NOMBRE_ESTADO")
                .HasMaxLength(30)
                .IsUnicode(false);
        }
    }
}
