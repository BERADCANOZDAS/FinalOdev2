using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFApp
{
    internal class OkulDbContext:DbContext
    {
        public DbSet<Ogrenci> Ogrenciler { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(@"Data Source = localhost;Initial Catalog = OkulDbSube1EF;Integrated Security = true;TrustServerCertificate=true");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Ogrenci>().Property(o=>o.Soyad).HasColumnType("varchar").HasMaxLength(30).IsRequired();
            modelBuilder.Entity<Ogrenci>().Property(o=>o.Numara).HasColumnType("varchar").HasMaxLength(10).IsRequired();
        }

    }
}
//DbContext classı : EF içerisinde veritabanı işlemlerini yapmak için kullanılan class. Örn. CRUD işlemleri.Her projeninin ayrı bir DbContext
//classı olmalıdır . Her projenin Db'si kendisine özgüdür.

// DbSet : Db'deki tabloları bellekte temsil eder.Generic yapılardır.Dolayısıyla hangi entity tipinde oluşturulursa o tipteki alanları
//içerir.Db için sorguları çalıştırmak için kullanılır. Entity'ler bu yapı içerisinde tutulur. Örn. Öğrenci tipi için,OgrenciId,Ad,Soyad,Numara

//Migration işlemleri : EF code First tekniğinde , kod ile yapılan işlemlerin DB'ye aktarılması için gerekli olan classlardır.Bu classlar her kod 
//değişimde oluşturulmalıdır. Migration classı oluşturmak için add-migration komutu kullanılır.