using System;
using ApiTrato.Core.Entities;
using ApiTrato.Infraestructure.Data.Configurations;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace ApiTrato.Infraestructure.Data
{
    public partial class TRATO_DATABASEContext : DbContext
    {
        public TRATO_DATABASEContext()
        {
        }

        public TRATO_DATABASEContext(DbContextOptions<TRATO_DATABASEContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Categories> Categories { get; set; }
        public virtual DbSet<Cities> Cities { get; set; }
        public virtual DbSet<Departments> Departments { get; set; }
        public virtual DbSet<States> States { get; set; }
        public virtual DbSet<Exchanges> Exchanges { get; set; }
        public virtual DbSet<Locations> Locations { get; set; }
        public virtual DbSet<Country> Countries { get; set; }
        public virtual DbSet<Auctions> Auctions { get; set; }
        public virtual DbSet<DeliveryTypes> DeliveryTypes { get; set; }
        public virtual DbSet<IdentificationType> IdentificationTypes { get; set; }
        public virtual DbSet<Users> Users { get; set; }

//        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//        {
//            if (!optionsBuilder.IsConfigured)
//            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
//            }
//        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CategoriesConfiguration());

            modelBuilder.ApplyConfiguration(new CitiesConfiguration());

            modelBuilder.ApplyConfiguration(new DepartmentsConfiguration());

            modelBuilder.ApplyConfiguration(new StatesConfiguration());

            modelBuilder.ApplyConfiguration(new ExchangesConfiguration());

            modelBuilder.ApplyConfiguration(new LocationsConfiguration());

            modelBuilder.ApplyConfiguration(new CountryConfiguration());

            modelBuilder.ApplyConfiguration(new AuctionsConfiguration());

            modelBuilder.ApplyConfiguration(new DeliveryTypesConfiguration());

            modelBuilder.ApplyConfiguration(new IdentificationTypeConfiguration());

            modelBuilder.ApplyConfiguration(new UsersConfiguration());

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
