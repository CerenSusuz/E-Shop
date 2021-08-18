﻿// <auto-generated />
using System;
using EShop.DataAccess.Contexts.EF;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EShop.DataAccess.Migrations
{
    [DbContext(typeof(EShopContext))]
    [Migration("20210818200659_codeRefactoring")]
    partial class codeRefactoring
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
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

                    b.Property<DateTime>("UpdatedAt")
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
                            PasswordHash = new byte[] { 81, 131, 242, 10, 202, 100, 29, 103, 144, 69, 69, 158, 166, 1, 42, 133, 128, 4, 164, 199, 17, 76, 185, 255, 0, 18, 73, 209, 117, 142, 172, 207, 200, 21, 61, 79, 37, 12, 213, 26, 107, 152, 230, 39, 184, 47, 164, 175, 199, 9, 22, 223, 70, 252, 118, 208, 148, 91, 36, 232, 109, 35, 248, 100 },
                            PasswordSalt = new byte[] { 198, 12, 19, 100, 225, 78, 79, 40, 122, 218, 104, 203, 92, 63, 3, 50, 133, 25, 104, 88, 13, 21, 82, 145, 196, 15, 1, 148, 123, 10, 225, 175, 21, 76, 217, 28, 124, 119, 48, 36, 2, 223, 201, 103, 10, 4, 11, 204, 49, 36, 4, 224, 116, 215, 82, 117, 78, 54, 122, 73, 15, 207, 215, 167, 221, 244, 117, 245, 82, 221, 117, 167, 106, 166, 209, 143, 0, 191, 203, 170, 35, 173, 198, 77, 223, 144, 105, 69, 180, 223, 1, 186, 7, 84, 51, 169, 82, 193, 71, 220, 5, 230, 89, 200, 175, 58, 72, 184, 111, 112, 187, 208, 160, 150, 145, 14, 186, 216, 206, 46, 76, 122, 34, 254, 75, 76, 241, 124 },
                            UpdatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
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

                    b.Property<DateTime>("UpdatedAt")
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
                            IsBlocked = false,
                            UpdatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 2,
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Erkek",
                            IsBlocked = false,
                            UpdatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
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

                    b.Property<DateTime>("UpdatedAt")
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
                            IsBlocked = false,
                            UpdatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 2,
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Son kullanıcı",
                            IsBlocked = false,
                            UpdatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
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
