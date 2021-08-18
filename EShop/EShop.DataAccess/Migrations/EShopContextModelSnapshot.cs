﻿// <auto-generated />
using System;
using EShop.DataAccess.Contexts.EF;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EShop.DataAccess.Migrations
{
    [DbContext(typeof(EShopContext))]
    partial class EShopContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.9")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EShop.DataAccess.Entities.Account", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("GetDate()");

                    b.Property<string>("CreatedUser")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(61)
                        .HasColumnType("nvarchar(61)")
                        .HasDefaultValueSql("space(0)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(75)
                        .HasColumnType("nvarchar(75)")
                        .HasDefaultValueSql("space(0)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)")
                        .HasDefaultValueSql("space(0)");

                    b.Property<int?>("GenderId")
                        .HasColumnType("int");

                    b.Property<string>("Gsm")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)")
                        .HasDefaultValueSql("space(0)");

                    b.Property<bool>("IsBlocked")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(false);

                    b.Property<bool>("IsSuperVisor")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(false);

                    b.Property<string>("LastName")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)")
                        .HasDefaultValueSql("space(0)");

                    b.Property<byte[]>("PasswordHash")
                        .HasColumnType("varbinary(max)");

                    b.Property<byte[]>("PasswordSalt")
                        .HasColumnType("varbinary(max)");

                    b.Property<DateTime?>("UpdatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("GetDate()");

                    b.Property<string>("UpdatedUser")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(61)
                        .HasColumnType("nvarchar(61)")
                        .HasDefaultValueSql("space(0)");

                    b.Property<int>("UserGroupId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.HasIndex("GenderId");

                    b.HasIndex("Gsm");

                    b.HasIndex("UserGroupId");

                    b.HasIndex("FirstName", "LastName");

                    b.ToTable("Accounts");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatedUser = "Migration",
                            Email = "ceren199704@hotmail.com",
                            FirstName = "Ceren",
                            Gsm = "5541172005",
                            IsBlocked = false,
                            IsSuperVisor = true,
                            LastName = "Susuz",
                            PasswordHash = new byte[] { 81, 232, 157, 69, 93, 95, 194, 20, 98, 237, 226, 102, 141, 63, 141, 36, 79, 252, 191, 8, 124, 160, 49, 192, 87, 44, 27, 237, 205, 15, 243, 23, 7, 51, 9, 101, 214, 153, 207, 137, 243, 246, 254, 218, 74, 69, 170, 132, 28, 31, 133, 9, 52, 39, 46, 74, 168, 114, 214, 105, 198, 79, 122, 141 },
                            PasswordSalt = new byte[] { 112, 115, 68, 231, 55, 225, 143, 84, 207, 250, 210, 168, 1, 149, 217, 82, 59, 224, 101, 130, 218, 227, 47, 179, 198, 135, 128, 39, 252, 191, 150, 50, 187, 110, 209, 221, 88, 160, 32, 192, 53, 5, 167, 179, 10, 153, 144, 180, 135, 132, 213, 46, 25, 67, 143, 249, 132, 182, 27, 2, 167, 199, 230, 93, 140, 170, 124, 249, 31, 87, 255, 6, 87, 207, 132, 30, 21, 197, 6, 178, 165, 195, 240, 81, 138, 66, 65, 19, 16, 70, 61, 249, 7, 75, 112, 47, 121, 29, 188, 39, 54, 125, 164, 196, 133, 206, 51, 62, 66, 130, 53, 196, 79, 135, 74, 242, 202, 191, 164, 144, 231, 128, 47, 130, 15, 101, 15, 232 },
                            UserGroupId = 1
                        });
                });

            modelBuilder.Entity("EShop.DataAccess.Entities.Gender", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("GetDate()");

                    b.Property<string>("CreatedUser")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(61)
                        .HasColumnType("nvarchar(61)")
                        .HasDefaultValueSql("space(0)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasDefaultValueSql("space(0)");

                    b.Property<bool>("IsBlocked")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(false);

                    b.Property<DateTime?>("UpdatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("GetDate()");

                    b.Property<string>("UpdatedUser")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(61)
                        .HasColumnType("nvarchar(61)")
                        .HasDefaultValueSql("space(0)");

                    b.HasKey("Id");

                    b.HasIndex("Description");

                    b.ToTable("Genders");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Kadın",
                            IsBlocked = false
                        },
                        new
                        {
                            Id = 2,
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Erkek",
                            IsBlocked = false
                        });
                });

            modelBuilder.Entity("EShop.DataAccess.Entities.UserGroup", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("GetDate()");

                    b.Property<string>("CreatedUser")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(61)
                        .HasColumnType("nvarchar(61)")
                        .HasDefaultValueSql("space(0)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasDefaultValueSql("space(0)");

                    b.Property<bool>("IsBlocked")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(false);

                    b.Property<DateTime?>("UpdatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("GetDate()");

                    b.Property<string>("UpdatedUser")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(61)
                        .HasColumnType("nvarchar(61)")
                        .HasDefaultValueSql("space(0)");

                    b.HasKey("Id");

                    b.HasIndex("Description");

                    b.ToTable("UserGroups");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Personel",
                            IsBlocked = false
                        },
                        new
                        {
                            Id = 2,
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Son kullanıcı",
                            IsBlocked = false
                        });
                });

            modelBuilder.Entity("EShop.DataAccess.Entities.Account", b =>
                {
                    b.HasOne("EShop.DataAccess.Entities.Gender", "Gender")
                        .WithMany()
                        .HasForeignKey("GenderId");

                    b.HasOne("EShop.DataAccess.Entities.UserGroup", "UserGroup")
                        .WithMany()
                        .HasForeignKey("UserGroupId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Gender");

                    b.Navigation("UserGroup");
                });
#pragma warning restore 612, 618
        }
    }
}