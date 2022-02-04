using ApiTrato.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApiTrato.Infraestructure.Data.Configurations
{
    public class UsersConfiguration : IEntityTypeConfiguration<Users>
    {
        public void Configure(EntityTypeBuilder<Users> builder)
        {
            builder.ToTable("USUARIOS");

            builder.Property(e => e.UserId).HasColumnName("ID");

            builder.Property(e => e.LastName)
                .IsRequired()
                .HasColumnName("APELLIDO")
                .HasMaxLength(45)
                .IsUnicode(false);

            builder.Property(e => e.Password)
                .IsRequired()
                .HasColumnName("CONTRASENA")
                .HasMaxLength(100)
                .IsUnicode(false);

            builder.Property(e => e.EMail)
                .HasColumnName("CORREO_ELECTRONICO")
                .HasMaxLength(150)
                .IsUnicode(false);

            builder.Property(e => e.Address)
                .IsRequired()
                .HasColumnName("DIRECCION")
                .HasMaxLength(150)
                .IsUnicode(false);

            builder.Property(e => e.StateId).HasColumnName("ID_ESTADO");

            builder.Property(e => e.IdentificationTypeId).HasColumnName("ID_TIPO_IDENTIFIACION");

            builder.Property(e => e.Name)
                .IsRequired()
                .HasColumnName("NOMBRE")
                .HasMaxLength(45)
                .IsUnicode(false);

            builder.Property(e => e.ContactNumber)
                .HasColumnName("NUMERO_CONTACTO")
                .HasMaxLength(13)
                .IsUnicode(false);

            builder.Property(e => e.IdentificationNumber)
                .IsRequired()
                .HasColumnName("NUMERO_IDENTIFICACION")
                .HasMaxLength(13)
                .IsUnicode(false);

            builder.HasOne(d => d.States)
                .WithMany(p => p.Users)
                .HasForeignKey(d => d.StateId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__USUARIOS__ID_EST__6E01572D");

            builder.HasOne(d => d.IdentificationType)
                .WithMany(p => p.Users)
                .HasForeignKey(d => d.IdentificationTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__USUARIOS__ID_TIP__6EF57B66");
        }
    }
}
