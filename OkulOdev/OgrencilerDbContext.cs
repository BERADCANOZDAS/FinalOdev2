using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace OkulOdev
{
    internal class OgrencilerDbContext: DbContext
    {
        public DbSet<Ogrenciler> Ogrenci { get; set; }
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(@"Data Source = localhost;Initial Catalog = OkulOdev;Integrated Security = true;TrustServerCertificate=true");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Ogrenciler>()
        .HasKey(o => o.OgrenciId);
            modelBuilder.Entity<Ogrenciler>().Property(o => o.Ad).HasColumnType("varchar").HasMaxLength(20).IsRequired();
            modelBuilder.Entity<Ogrenciler>().Property(o => o.Soyad).HasColumnType("varchar").HasMaxLength(30).IsRequired();
            modelBuilder.Entity<Ogrenciler>().Property(o => o.Numara).HasColumnType("varchar").HasMaxLength(20).IsRequired();
        }

    }
}

