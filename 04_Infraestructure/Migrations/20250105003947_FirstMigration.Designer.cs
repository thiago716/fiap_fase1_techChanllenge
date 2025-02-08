﻿// <auto-generated />
using System;
using Infraestructure.Configuration;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Infraestructure.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20250105003947_FirstMigration")]
    partial class FirstMigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Core.Entity.Contact", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedOn")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("DATETIME2")
                        .HasDefaultValue(new DateTime(2025, 1, 5, 0, 39, 47, 181, DateTimeKind.Utc).AddTicks(5519));

                    b.Property<int>("DddId")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("Id");

                    b.HasIndex("DddId");

                    b.ToTable("Contact", (string)null);
                });

            modelBuilder.Entity("Core.Entity.DirectDistanceDialing", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedOn")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("DATETIME2")
                        .HasDefaultValue(new DateTime(2025, 1, 5, 0, 39, 47, 181, DateTimeKind.Utc).AddTicks(7590));

                    b.Property<string>("Region")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("DirectDistanceDialing", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 11,
                            CreatedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Region = "São Paulo"
                        },
                        new
                        {
                            Id = 12,
                            CreatedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Region = "São Paulo"
                        },
                        new
                        {
                            Id = 13,
                            CreatedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Region = "São Paulo"
                        },
                        new
                        {
                            Id = 14,
                            CreatedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Region = "São Paulo"
                        },
                        new
                        {
                            Id = 15,
                            CreatedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Region = "São Paulo"
                        },
                        new
                        {
                            Id = 16,
                            CreatedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Region = "São Paulo"
                        },
                        new
                        {
                            Id = 17,
                            CreatedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Region = "São Paulo"
                        },
                        new
                        {
                            Id = 18,
                            CreatedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Region = "São Paulo"
                        },
                        new
                        {
                            Id = 19,
                            CreatedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Region = "São Paulo"
                        },
                        new
                        {
                            Id = 21,
                            CreatedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Region = "Rio de Janeiro"
                        },
                        new
                        {
                            Id = 22,
                            CreatedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Region = "Rio de Janeiro"
                        },
                        new
                        {
                            Id = 24,
                            CreatedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Region = "Rio de Janeiro"
                        },
                        new
                        {
                            Id = 27,
                            CreatedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Region = "Espírito Santo"
                        },
                        new
                        {
                            Id = 28,
                            CreatedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Region = "Espírito Santo"
                        },
                        new
                        {
                            Id = 31,
                            CreatedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Region = "Minas Gerais"
                        },
                        new
                        {
                            Id = 32,
                            CreatedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Region = "Minas Gerais"
                        },
                        new
                        {
                            Id = 33,
                            CreatedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Region = "Minas Gerais"
                        },
                        new
                        {
                            Id = 34,
                            CreatedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Region = "Minas Gerais"
                        },
                        new
                        {
                            Id = 35,
                            CreatedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Region = "Minas Gerais"
                        },
                        new
                        {
                            Id = 37,
                            CreatedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Region = "Minas Gerais"
                        },
                        new
                        {
                            Id = 38,
                            CreatedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Region = "Minas Gerais"
                        },
                        new
                        {
                            Id = 41,
                            CreatedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Region = "Paraná"
                        },
                        new
                        {
                            Id = 42,
                            CreatedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Region = "Paraná"
                        },
                        new
                        {
                            Id = 43,
                            CreatedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Region = "Paraná"
                        },
                        new
                        {
                            Id = 44,
                            CreatedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Region = "Paraná"
                        },
                        new
                        {
                            Id = 45,
                            CreatedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Region = "Paraná"
                        },
                        new
                        {
                            Id = 46,
                            CreatedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Region = "Paraná"
                        },
                        new
                        {
                            Id = 47,
                            CreatedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Region = "Santa Catarina"
                        },
                        new
                        {
                            Id = 48,
                            CreatedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Region = "Santa Catarina"
                        },
                        new
                        {
                            Id = 49,
                            CreatedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Region = "Santa Catarina"
                        },
                        new
                        {
                            Id = 51,
                            CreatedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Region = "Rio Grande do Sul"
                        },
                        new
                        {
                            Id = 53,
                            CreatedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Region = "Rio Grande do Sul"
                        },
                        new
                        {
                            Id = 54,
                            CreatedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Region = "Rio Grande do Sul"
                        },
                        new
                        {
                            Id = 55,
                            CreatedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Region = "Rio Grande do Sul"
                        },
                        new
                        {
                            Id = 61,
                            CreatedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Region = "Distrito Federal"
                        },
                        new
                        {
                            Id = 62,
                            CreatedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Region = "Goiás"
                        },
                        new
                        {
                            Id = 64,
                            CreatedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Region = "Goiás"
                        },
                        new
                        {
                            Id = 65,
                            CreatedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Region = "Mato Grosso"
                        },
                        new
                        {
                            Id = 66,
                            CreatedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Region = "Mato Grosso"
                        },
                        new
                        {
                            Id = 67,
                            CreatedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Region = "Mato Grosso do Sul"
                        },
                        new
                        {
                            Id = 82,
                            CreatedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Region = "Alagoas"
                        },
                        new
                        {
                            Id = 71,
                            CreatedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Region = "Bahia"
                        },
                        new
                        {
                            Id = 73,
                            CreatedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Region = "Bahia"
                        },
                        new
                        {
                            Id = 74,
                            CreatedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Region = "Bahia"
                        },
                        new
                        {
                            Id = 75,
                            CreatedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Region = "Bahia"
                        },
                        new
                        {
                            Id = 77,
                            CreatedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Region = "Bahia"
                        },
                        new
                        {
                            Id = 85,
                            CreatedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Region = "Ceará"
                        },
                        new
                        {
                            Id = 88,
                            CreatedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Region = "Ceará"
                        },
                        new
                        {
                            Id = 98,
                            CreatedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Region = "Maranhão"
                        },
                        new
                        {
                            Id = 99,
                            CreatedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Region = "Maranhão"
                        },
                        new
                        {
                            Id = 83,
                            CreatedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Region = "Paraíba"
                        },
                        new
                        {
                            Id = 81,
                            CreatedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Region = "Pernambuco"
                        },
                        new
                        {
                            Id = 87,
                            CreatedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Region = "Pernambuco"
                        },
                        new
                        {
                            Id = 86,
                            CreatedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Region = "Piauí"
                        },
                        new
                        {
                            Id = 89,
                            CreatedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Region = "Piauí"
                        },
                        new
                        {
                            Id = 84,
                            CreatedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Region = "Rio Grande do Norte"
                        },
                        new
                        {
                            Id = 79,
                            CreatedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Region = "Sergipe"
                        });
                });

            modelBuilder.Entity("Core.Entity.Contact", b =>
                {
                    b.HasOne("Core.Entity.DirectDistanceDialing", "Ddd")
                        .WithMany("Contacts")
                        .HasForeignKey("DddId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_Contact_DirectDistanceDialing");

                    b.Navigation("Ddd");
                });

            modelBuilder.Entity("Core.Entity.DirectDistanceDialing", b =>
                {
                    b.Navigation("Contacts");
                });
#pragma warning restore 612, 618
        }
    }
}
