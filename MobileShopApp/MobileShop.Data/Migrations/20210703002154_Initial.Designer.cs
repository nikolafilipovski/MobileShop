// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MobileShop.Data;

namespace MobileShop.Data.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20210703002154_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.15")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");

                    b.HasData(
                        new
                        {
                            Id = "b4280b6a-0613-4cbd-a9e6-f1701e926e71",
                            ConcurrencyStamp = "a68e7146-43b0-4e85-a2ef-d90d2f61efbe",
                            Name = "admin",
                            NormalizedName = "ADMIN"
                        },
                        new
                        {
                            Id = "b4280b6a-0613-4cbd-a9e6-f1701e926e72",
                            ConcurrencyStamp = "a3a9d5d4-5ca4-447c-883b-429e44eb9c16",
                            Name = "guest",
                            NormalizedName = "GUEST"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");

                    b.HasData(
                        new
                        {
                            Id = "b4280b6a-0613-4cbd-a9e6-f1701e926e71",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "c8554266-b401-4519-9aeb-a9283053fc58",
                            Email = "admin@mobile.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "ADMIN@MOBILE.COM",
                            NormalizedUserName = "ADMIN@MOBILE.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEPcNcK+qgDZmTXoOMuFUVRHx8geQeiSXFt2pUpUAeadTojOQ9+J9f7eDD9VNjbcpcQ==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "",
                            TwoFactorEnabled = false,
                            UserName = "admin@mobile.com"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");

                    b.HasData(
                        new
                        {
                            UserId = "b4280b6a-0613-4cbd-a9e6-f1701e926e71",
                            RoleId = "b4280b6a-0613-4cbd-a9e6-f1701e926e71"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("MobileShop.Entities.Manufacturer", b =>
                {
                    b.Property<int>("ManufactuterID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Country")
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.Property<string>("LogoURL")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.HasKey("ManufactuterID");

                    b.ToTable("Manufacturers");

                    b.HasData(
                        new
                        {
                            ManufactuterID = 1,
                            Country = "South Korea",
                            LogoURL = "Logo-Samsung.png",
                            Name = "Samsung"
                        },
                        new
                        {
                            ManufactuterID = 2,
                            Country = "USA",
                            LogoURL = "apple.png",
                            Name = "Apple"
                        },
                        new
                        {
                            ManufactuterID = 3,
                            Country = "Taiwan",
                            LogoURL = "Asus-Logo.png",
                            Name = "Asus"
                        });
                });

            modelBuilder.Entity("MobileShop.Entities.Order", b =>
                {
                    b.Property<int>("OrderID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.Property<string>("FullName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PhoneID")
                        .HasColumnType("int");

                    b.HasKey("OrderID");

                    b.HasIndex("PhoneID");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("MobileShop.Entities.Phone", b =>
                {
                    b.Property<int>("PhoneID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Battery")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("Display")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<int>("ManufacturerID")
                        .HasColumnType("int");

                    b.Property<string>("ManufacturerName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Memory")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("Model")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("PhotoURL")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Price")
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.HasKey("PhoneID");

                    b.HasIndex("ManufacturerID");

                    b.ToTable("Phones");

                    b.HasData(
                        new
                        {
                            PhoneID = 1,
                            Battery = "4000 mAh Littium",
                            Display = "Dinamic Amoled 6.2 inches",
                            ManufacturerID = 1,
                            ManufacturerName = "Samsung",
                            Memory = "256GB, 8GB RAM",
                            Model = "Samsung S21",
                            PhotoURL = "galaxys215g-336174.jpg",
                            Price = "60000 ден."
                        },
                        new
                        {
                            PhoneID = 2,
                            Battery = "4000 mAh Littium",
                            Display = "Dinamic Amoled 6.8 inches",
                            ManufacturerID = 1,
                            ManufacturerName = "Samsung",
                            Memory = "512GB, 8GB RAM",
                            Model = "Samsung Note 20",
                            PhotoURL = "galaxynote20-398247.jpg",
                            Price = "64000 ден."
                        },
                        new
                        {
                            PhoneID = 3,
                            Battery = "4000 mAh Littium",
                            Display = "Dinamic Amoled 5.0 inches",
                            ManufacturerID = 1,
                            ManufacturerName = "Samsung",
                            Memory = "128GB, 4GB RAM",
                            Model = "Samsung A01 Core",
                            PhotoURL = "galaxya01core-211128.jpg",
                            Price = "5000 ден."
                        },
                        new
                        {
                            PhoneID = 4,
                            Battery = "3000 mAh Littium",
                            Display = "OLED 6.1 inches",
                            ManufacturerID = 2,
                            ManufacturerName = "Apple",
                            Memory = "128GB, 8GB RAM",
                            Model = "IPhone 12 Pro",
                            PhotoURL = "iphone12pro-117264.jpg",
                            Price = "70000 ден."
                        },
                        new
                        {
                            PhoneID = 5,
                            Battery = "3500 mAh Littium",
                            Display = "OLED 6.3 inches",
                            ManufacturerID = 2,
                            ManufacturerName = "Apple",
                            Memory = "128GB, 8GB RAM",
                            Model = "IPhone 12 Pro Max",
                            PhotoURL = "iphone12promax-914433.jpg",
                            Price = "72000 ден."
                        },
                        new
                        {
                            PhoneID = 6,
                            Battery = "2500 mAh Littium",
                            Display = "OLED 5.4 inches",
                            ManufacturerID = 2,
                            ManufacturerName = "Apple",
                            Memory = "128GB, 8GB RAM",
                            Model = "IPhone 12 Mini",
                            PhotoURL = "iphone12mini-238343.jpg",
                            Price = "45000 ден."
                        },
                        new
                        {
                            PhoneID = 7,
                            Battery = "5000 mAh Littium",
                            Display = "Dinamic Amoled 5.0 inches",
                            ManufacturerID = 3,
                            ManufacturerName = "Asus",
                            Memory = "1TB, 16GB RAM",
                            Model = "Asus ROG",
                            PhotoURL = "rogphone5-960857.jpg",
                            Price = "48000 ден."
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MobileShop.Entities.Order", b =>
                {
                    b.HasOne("MobileShop.Entities.Phone", "Phone")
                        .WithMany()
                        .HasForeignKey("PhoneID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MobileShop.Entities.Phone", b =>
                {
                    b.HasOne("MobileShop.Entities.Manufacturer", "Manufacturer")
                        .WithMany("Phones")
                        .HasForeignKey("ManufacturerID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
