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
                            GenderId = 1,
                            Gsm = "5541172005",
                            IsBlocked = false,
                            IsSuperVisor = true,
                            LastName = "Susuz",
                            PasswordHash = new byte[] { 106, 7, 4, 40, 14, 106, 76, 13, 10, 74, 9, 235, 176, 182, 181, 101, 36, 237, 120, 4, 20, 68, 4, 153, 237, 154, 1, 91, 4, 4, 153, 177, 194, 7, 221, 67, 66, 105, 80, 50, 223, 221, 167, 211, 75, 238, 15, 13, 205, 110, 14, 148, 99, 236, 241, 216, 190, 191, 164, 84, 19, 23, 5, 151 },
                            PasswordSalt = new byte[] { 96, 87, 101, 83, 135, 232, 141, 13, 111, 192, 56, 249, 125, 79, 14, 148, 231, 146, 96, 222, 38, 187, 169, 72, 71, 211, 247, 146, 211, 18, 2, 25, 174, 27, 67, 247, 35, 247, 43, 29, 187, 225, 115, 98, 71, 42, 10, 185, 87, 55, 164, 30, 99, 136, 245, 111, 219, 15, 58, 99, 235, 160, 13, 39, 78, 202, 164, 184, 72, 40, 211, 40, 32, 175, 23, 182, 61, 100, 226, 218, 159, 11, 159, 81, 161, 68, 197, 248, 253, 131, 22, 143, 156, 249, 222, 53, 230, 93, 169, 145, 153, 81, 222, 185, 59, 189, 49, 91, 228, 136, 26, 35, 27, 217, 149, 91, 55, 199, 223, 37, 145, 28, 169, 96, 40, 131, 210, 179 },
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
