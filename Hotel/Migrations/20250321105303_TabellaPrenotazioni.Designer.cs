﻿// <auto-generated />
using System;
using Hotel.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Hotel.Migrations
{
    [DbContext(typeof(HotelDbContext))]
    [Migration("20250321105303_TabellaPrenotazioni")]
    partial class TabellaPrenotazioni
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Hotel.Models.ApplicationRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Hotel.Models.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<DateOnly?>("BirthDate")
                        .IsRequired()
                        .HasColumnType("date");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

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
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("Hotel.Models.ApplicationUserRole", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Hotel.Models.Camera", b =>
                {
                    b.Property<Guid>("CameraId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("NumeroCamera")
                        .HasColumnType("int");

                    b.Property<decimal>("PrezzoPerNotte")
                        .HasColumnType("decimal(18, 2)");

                    b.Property<string>("Tipo")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("CameraId");

                    b.ToTable("Camere");

                    b.HasData(
                        new
                        {
                            CameraId = new Guid("f47ac10b-58cc-4372-a567-0e02b2c3d479"),
                            NumeroCamera = 101,
                            PrezzoPerNotte = 50m,
                            Tipo = "Singola"
                        },
                        new
                        {
                            CameraId = new Guid("aab8a3c0-ded7-4d8f-a27d-e2a0d47f2b5b"),
                            NumeroCamera = 102,
                            PrezzoPerNotte = 80m,
                            Tipo = "Doppia"
                        },
                        new
                        {
                            CameraId = new Guid("cc961b45-e0b1-4e49-a091-1d056c3d93e2"),
                            NumeroCamera = 103,
                            PrezzoPerNotte = 120m,
                            Tipo = "Familiare"
                        },
                        new
                        {
                            CameraId = new Guid("e7f3c58b-9f4c-44d3-b285-d61c2c4b3f42"),
                            NumeroCamera = 104,
                            PrezzoPerNotte = 50m,
                            Tipo = "Singola"
                        },
                        new
                        {
                            CameraId = new Guid("d42c35f1-3e33-44c9-a62b-9bd8e07a5f84"),
                            NumeroCamera = 105,
                            PrezzoPerNotte = 80m,
                            Tipo = "Doppia"
                        },
                        new
                        {
                            CameraId = new Guid("34ac5b72-62cd-4b8d-b3c4-71d3132a7f79"),
                            NumeroCamera = 106,
                            PrezzoPerNotte = 120m,
                            Tipo = "Familiare"
                        },
                        new
                        {
                            CameraId = new Guid("a75f1b56-3cbb-4e8a-a95d-6c3495d1c1b1"),
                            NumeroCamera = 107,
                            PrezzoPerNotte = 50m,
                            Tipo = "Singola"
                        },
                        new
                        {
                            CameraId = new Guid("b8d5f8b3-908d-41c5-987d-3f869b6e9a48"),
                            NumeroCamera = 108,
                            PrezzoPerNotte = 80m,
                            Tipo = "Doppia"
                        },
                        new
                        {
                            CameraId = new Guid("e1d2c3b4-a567-4f89-bcdf-9a6e8b3c2f91"),
                            NumeroCamera = 109,
                            PrezzoPerNotte = 120m,
                            Tipo = "Familiare"
                        },
                        new
                        {
                            CameraId = new Guid("c4a5b6d7-e8f9-4012-abcd-567e8f91c2b3"),
                            NumeroCamera = 110,
                            PrezzoPerNotte = 50m,
                            Tipo = "Singola"
                        },
                        new
                        {
                            CameraId = new Guid("f9e8d7c6-b5a4-3d2c-1e0f-6789abcfde12"),
                            NumeroCamera = 111,
                            PrezzoPerNotte = 80m,
                            Tipo = "Doppia"
                        },
                        new
                        {
                            CameraId = new Guid("1e2d3c4b-5a67-8f90-bcdf-3456e7f8912a"),
                            NumeroCamera = 112,
                            PrezzoPerNotte = 120m,
                            Tipo = "Familiare"
                        },
                        new
                        {
                            CameraId = new Guid("9a8b7c6d-5e4f-3a2b-1c0d-6789fabcde12"),
                            NumeroCamera = 113,
                            PrezzoPerNotte = 50m,
                            Tipo = "Singola"
                        },
                        new
                        {
                            CameraId = new Guid("abcdef12-3456-7890-9a8b-7c6d5e4f3a2b"),
                            NumeroCamera = 114,
                            PrezzoPerNotte = 80m,
                            Tipo = "Doppia"
                        },
                        new
                        {
                            CameraId = new Guid("01234567-89ab-cdef-0123-456789abcdef"),
                            NumeroCamera = 115,
                            PrezzoPerNotte = 120m,
                            Tipo = "Familiare"
                        },
                        new
                        {
                            CameraId = new Guid("12345678-9abc-def0-1234-56789abcdef0"),
                            NumeroCamera = 116,
                            PrezzoPerNotte = 50m,
                            Tipo = "Singola"
                        },
                        new
                        {
                            CameraId = new Guid("23456789-abcd-ef01-2345-6789abcdef01"),
                            NumeroCamera = 117,
                            PrezzoPerNotte = 80m,
                            Tipo = "Doppia"
                        },
                        new
                        {
                            CameraId = new Guid("3456789a-bcde-f012-3456-789abcdef012"),
                            NumeroCamera = 118,
                            PrezzoPerNotte = 120m,
                            Tipo = "Familiare"
                        },
                        new
                        {
                            CameraId = new Guid("456789ab-cdef-0123-4567-89abcdef0123"),
                            NumeroCamera = 119,
                            PrezzoPerNotte = 50m,
                            Tipo = "Singola"
                        });
                });

            modelBuilder.Entity("Hotel.Models.Cliente", b =>
                {
                    b.Property<Guid>("ClienteId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Cognome")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Telefono")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("ClienteId");

                    b.ToTable("Cliente");

                    b.HasData(
                        new
                        {
                            ClienteId = new Guid("bdde9f60-ef14-4a7d-a78a-d3a77e7b0a9c"),
                            Cognome = "Barberis",
                            Email = "rachele.barberis@email.com",
                            Nome = "Rachele",
                            Telefono = "1234567890"
                        },
                        new
                        {
                            ClienteId = new Guid("c4dd7b3f-4fdc-493e-b59b-93df439e627d"),
                            Cognome = "Bianchi",
                            Email = "luca.bianchi@email.com",
                            Nome = "Luca",
                            Telefono = "0987654321"
                        },
                        new
                        {
                            ClienteId = new Guid("b7e90b60-bcc5-45b6-bbc6-e1d10fa1a2b6"),
                            Cognome = "Verdi",
                            Email = "anna.verdi@email.com",
                            Nome = "Anna",
                            Telefono = "1122334455"
                        },
                        new
                        {
                            ClienteId = new Guid("d3f2eeae-1b50-47eb-a2e1-5e713b6637a7"),
                            Cognome = "Neri",
                            Email = "giulia.neri@email.com",
                            Nome = "Giulia",
                            Telefono = "5566778899"
                        });
                });

            modelBuilder.Entity("Hotel.Models.Prenotazione", b =>
                {
                    b.Property<Guid>("PrenotazioneId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CameraId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ClienteId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("DataFine")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataInizio")
                        .HasColumnType("datetime2");

                    b.Property<string>("Stato")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("PrenotazioneId");

                    b.HasIndex("CameraId");

                    b.HasIndex("ClienteId");

                    b.ToTable("Prenotazioni");

                    b.HasData(
                        new
                        {
                            PrenotazioneId = new Guid("5e8d6a1b-3c2f-4b79-a012-9d8e7f6c5b4a"),
                            CameraId = new Guid("cc961b45-e0b1-4e49-a091-1d056c3d93e2"),
                            ClienteId = new Guid("bdde9f60-ef14-4a7d-a78a-d3a77e7b0a9c"),
                            DataFine = new DateTime(2025, 3, 24, 10, 53, 2, 832, DateTimeKind.Utc).AddTicks(1358),
                            DataInizio = new DateTime(2025, 3, 21, 10, 53, 2, 832, DateTimeKind.Utc).AddTicks(1356),
                            Stato = "Confermata"
                        },
                        new
                        {
                            PrenotazioneId = new Guid("f1a2b3c4-d5e6-7f89-0123-456789abcdef"),
                            CameraId = new Guid("f47ac10b-58cc-4372-a567-0e02b2c3d479"),
                            ClienteId = new Guid("c4dd7b3f-4fdc-493e-b59b-93df439e627d"),
                            DataFine = new DateTime(2025, 3, 28, 10, 53, 2, 832, DateTimeKind.Utc).AddTicks(1368),
                            DataInizio = new DateTime(2025, 3, 26, 10, 53, 2, 832, DateTimeKind.Utc).AddTicks(1368),
                            Stato = "In Attesa"
                        },
                        new
                        {
                            PrenotazioneId = new Guid("9c8d7e6f-5a4b-3c2d-1e0f-6789abcdef12"),
                            CameraId = new Guid("e7f3c58b-9f4c-44d3-b285-d61c2c4b3f42"),
                            ClienteId = new Guid("b7e90b60-bcc5-45b6-bbc6-e1d10fa1a2b6"),
                            DataFine = new DateTime(2025, 4, 2, 10, 53, 2, 832, DateTimeKind.Utc).AddTicks(1373),
                            DataInizio = new DateTime(2025, 3, 31, 10, 53, 2, 832, DateTimeKind.Utc).AddTicks(1373),
                            Stato = "Confermata"
                        },
                        new
                        {
                            PrenotazioneId = new Guid("abcdef12-3456-7890-9a8b-7c6d5e4f3a2b"),
                            CameraId = new Guid("d42c35f1-3e33-44c9-a62b-9bd8e07a5f84"),
                            ClienteId = new Guid("d3f2eeae-1b50-47eb-a2e1-5e713b6637a7"),
                            DataFine = new DateTime(2025, 4, 8, 10, 53, 2, 832, DateTimeKind.Utc).AddTicks(1376),
                            DataInizio = new DateTime(2025, 4, 5, 10, 53, 2, 832, DateTimeKind.Utc).AddTicks(1376),
                            Stato = "Annullata"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("Hotel.Models.ApplicationUserRole", b =>
                {
                    b.HasOne("Hotel.Models.ApplicationRole", "Role")
                        .WithMany("ApplicationUserRole")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Hotel.Models.ApplicationUser", "User")
                        .WithMany("ApplicationUserRole")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Hotel.Models.Prenotazione", b =>
                {
                    b.HasOne("Hotel.Models.Camera", "Camera")
                        .WithMany("Prenotazioni")
                        .HasForeignKey("CameraId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Hotel.Models.Cliente", "Cliente")
                        .WithMany("Prenotazioni")
                        .HasForeignKey("ClienteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Camera");

                    b.Navigation("Cliente");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Hotel.Models.ApplicationRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Hotel.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Hotel.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Hotel.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Hotel.Models.ApplicationRole", b =>
                {
                    b.Navigation("ApplicationUserRole");
                });

            modelBuilder.Entity("Hotel.Models.ApplicationUser", b =>
                {
                    b.Navigation("ApplicationUserRole");
                });

            modelBuilder.Entity("Hotel.Models.Camera", b =>
                {
                    b.Navigation("Prenotazioni");
                });

            modelBuilder.Entity("Hotel.Models.Cliente", b =>
                {
                    b.Navigation("Prenotazioni");
                });
#pragma warning restore 612, 618
        }
    }
}
