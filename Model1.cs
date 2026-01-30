using PharmacyDB.Models;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace LongChauPharmacy
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Medic> Medics { get; set; }
        public virtual DbSet<SaleDetail> SaleDetails { get; set; }
        public virtual DbSet<Sale> Sales { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<InfoMedic> InfoMedics { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>()
                .Property(e => e.Phone)
                .IsUnicode(false);

            modelBuilder.Entity<Medic>()
                .Property(e => e.mid)
                .IsUnicode(false);

            modelBuilder.Entity<Medic>()
                .Property(e => e.mnumber)
                .IsUnicode(false);

            modelBuilder.Entity<SaleDetail>()
                .Property(e => e.mid)
                .IsUnicode(false);

            modelBuilder.Entity<SaleDetail>()
                .Property(e => e.Total)
                .HasPrecision(29, 2);

            modelBuilder.Entity<Sale>()
                .HasMany(e => e.SaleDetails)
                .WithRequired(e => e.Sale)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<User>()
                .Property(e => e.mobile)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .HasMany(e => e.Sales)
                .WithRequired(e => e.User)
                .WillCascadeOnDelete(false);
        }
    }
}
