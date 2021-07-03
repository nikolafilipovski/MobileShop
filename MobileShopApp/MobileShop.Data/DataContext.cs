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
        public DbSet<Order> Orders { get; set; }

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
                    Price = "60000 ден.",
                    PhotoURL = "galaxys215g-336174.jpg",
                    ManufacturerID = 1,
                    ManufacturerName = "Samsung"
                },
                new Phone
                {
                    PhoneID = 2,
                    Model = "Samsung Note 20",
                    Display = "Dinamic Amoled 6.8 inches",
                    Battery = "4000 mAh Littium",
                    Memory = "512GB, 8GB RAM",
                    Price = "64000 ден.",
                    PhotoURL = "galaxynote20-398247.jpg",
                    ManufacturerID = 1,
                    ManufacturerName = "Samsung"
                },
                new Phone
                {
                    PhoneID = 3,
                    Model = "Samsung A01 Core",
                    Display = "Dinamic Amoled 5.0 inches",
                    Battery = "4000 mAh Littium",
                    Memory = "128GB, 4GB RAM",
                    Price = "5000 ден.",
                    PhotoURL = "galaxya01core-211128.jpg",
                    ManufacturerID = 1,
                    ManufacturerName = "Samsung"
                },
                new Phone
                {
                    PhoneID = 4,
                    Model = "IPhone 12 Pro",
                    Display = "OLED 6.1 inches",
                    Battery = "3000 mAh Littium",
                    Memory = "128GB, 8GB RAM",
                    Price = "70000 ден.",
                    PhotoURL = "iphone12pro-117264.jpg",
                    ManufacturerID = 2,
                    ManufacturerName = "Apple"
                },
                new Phone
                {
                    PhoneID = 5,
                    Model = "IPhone 12 Pro Max",
                    Display = "OLED 6.3 inches",
                    Battery = "3500 mAh Littium",
                    Memory = "128GB, 8GB RAM",
                    Price = "72000 ден.",
                    PhotoURL = "iphone12promax-914433.jpg",
                    ManufacturerID = 2,
                    ManufacturerName = "Apple"
                },
                new Phone
                {
                    PhoneID = 6,
                    Model = "IPhone 12 Mini",
                    Display = "OLED 5.4 inches",
                    Battery = "2500 mAh Littium",
                    Memory = "128GB, 8GB RAM",
                    Price = "45000 ден.",
                    PhotoURL = "iphone12mini-238343.jpg",
                    ManufacturerID = 2,
                    ManufacturerName = "Apple"
                },
                new Phone
                {
                    PhoneID = 7,
                    Model = "Asus ROG",
                    Display = "Dinamic Amoled 5.0 inches",
                    Battery = "5000 mAh Littium",
                    Memory = "1TB, 16GB RAM",
                    Price = "48000 ден.",
                    PhotoURL = "rogphone5-960857.jpg",
                    ManufacturerID = 3,
                    ManufacturerName = "Asus"
                }
                );

            #endregion

            #region Manufacturer

            modelBuilder.Entity<Manufacturer>().HasData(
                new Manufacturer
                {
                    ManufactuterID = 1,
                    Name = "Samsung",
                    Country = "South Korea",
                    LogoURL = "Logo-Samsung.png"
                },
                new Manufacturer
                {
                    ManufactuterID = 2,
                    Name = "Apple",
                    Country = "USA",
                    LogoURL = "apple.png"
                },
                new Manufacturer
                {
                    ManufactuterID = 3,
                    Name = "Asus",
                    Country = "Taiwan",
                    LogoURL = "Asus-Logo.png"
                }
                );

            #endregion

            #region Admin

            const string ADMIN_ID = "b4280b6a-0613-4cbd-a9e6-f1701e926e71";
            const string ROLE_ID = ADMIN_ID;
            const string password = "admin123";

            modelBuilder.Entity<IdentityRole>().HasData(
                new IdentityRole
                {
                    Id = ROLE_ID,
                    Name = "admin",
                    NormalizedName = "ADMIN"
                },
                new IdentityRole
                {
                    Id = "b4280b6a-0613-4cbd-a9e6-f1701e926e72",
                    Name = "guest",
                    NormalizedName = "GUEST"
                }
            );

            var hasher = new PasswordHasher<IdentityUser>();

            modelBuilder.Entity<IdentityUser>().HasData(new IdentityUser
            {
                Id = ADMIN_ID,
                UserName = "admin@mobile.com",
                NormalizedUserName = "ADMIN@MOBILE.COM",
                Email = "admin@mobile.com",
                NormalizedEmail = "ADMIN@MOBILE.COM",
                EmailConfirmed = true,
                PasswordHash = hasher.HashPassword(null, password),
                SecurityStamp = string.Empty,
                ConcurrencyStamp = "c8554266-b401-4519-9aeb-a9283053fc58"
            });

            modelBuilder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
            {
                RoleId = ROLE_ID,
                UserId = ADMIN_ID
            });

            #endregion

            base.OnModelCreating(modelBuilder);
        }

    }
}
