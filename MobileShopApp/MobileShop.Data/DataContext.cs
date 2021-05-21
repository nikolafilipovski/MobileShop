using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MobileShop.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MobileShop.Data
{
    public class DataContext : IdentityDbContext<IdentityUser>
    {
        public DataContext(DbContextOptions options) : base(options) { }

        public DbSet<Phone> Phones { get; set; }
        public DbSet<Manufacturer> Manufacturers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region PhoneData

            modelBuilder.Entity<Phone>().HasData(
                new Phone
                {
                    PhoneID = 1,
                    Model = "Samsung S21",
                    Display = "Dinamic Amoled 6.2 inches",
                    Battery = "4000 mAh Littium",
                    Memory = "256GB, 8GB RAM",
                    Price = "60000 ден."
                },
                new Phone
                {
                    PhoneID = 2,
                    Model = "Samsung Note 20",
                    Display = "Dinamic Amoled 6.8 inches",
                    Battery = "4000 mAh Littium",
                    Memory = "512GB, 8GB RAM",
                    Price = "64000 ден."
                },
                new Phone
                {
                    PhoneID = 3,
                    Model = "Samsung A01 Core",
                    Display = "Dinamic Amoled 5.0 inches",
                    Battery = "4000 mAh Littium",
                    Memory = "128GB, 4GB RAM",
                    Price = "5000 ден."
                },
                new Phone
                {
                    PhoneID = 4,
                    Model = "IPhone 12 Pro",
                    Display = "OLED 6.1 inches",
                    Battery = "3000 mAh Littium",
                    Memory = "128GB, 8GB RAM",
                    Price = "70000 ден."
                },
                new Phone
                {
                    PhoneID = 5,
                    Model = "IPhone 12 Pro Max",
                    Display = "OLED 6.3 inches",
                    Battery = "3500 mAh Littium",
                    Memory = "128GB, 8GB RAM",
                    Price = "72000 ден."
                },
                new Phone
                {
                    PhoneID = 6,
                    Model = "IPhone 12 Mini",
                    Display = "OLED 5.4 inches",
                    Battery = "2500 mAh Littium",
                    Memory = "128GB, 8GB RAM",
                    Price = "45000 ден."
                },
                new Phone
                {
                    PhoneID = 7,
                    Model = "Asus ROG",
                    Display = "Dinamic Amoled 5.0 inches",
                    Battery = "5000 mAh Littium",
                    Memory = "1TB, 16GB RAM",
                    Price = "48000 ден."
                }
                );

            #endregion

            #region Manufacturer

            modelBuilder.Entity<Manufacturer>().HasData(
                new Manufacturer
                {
                    ManufactuterID = 8,
                    Name = "Samsung",
                    Country = "South Korea"
                },
                new Manufacturer
                {
                    ManufactuterID = 9,
                    Name = "Apple",
                    Country = "USA"
                },
                new Manufacturer
                {
                    ManufactuterID = 10,
                    Name = "Asus",
                    Country = "Taiwan"
                }
                );

            #endregion

            base.OnModelCreating(modelBuilder);
        }

    }
}
