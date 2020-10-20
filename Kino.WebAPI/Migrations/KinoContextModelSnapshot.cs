﻿// <auto-generated />
using System;
using Kino.WebAPI.EF;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Kino.WebAPI.Migrations
{
    [DbContext(typeof(KinoContext))]
    partial class KinoContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.11-servicing-32099")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Kino.WebAPI.Database.Filmovi", b =>
                {
                    b.Property<int>("FilmID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Glumci");

                    b.Property<string>("GodinaIzdavanja");

                    b.Property<string>("Naziv");

                    b.Property<string>("Opis");

                    b.Property<string>("Reziser");

                    b.Property<byte[]>("Slika");

                    b.Property<int>("Trajanje");

                    b.Property<string>("VideoUrl");

                    b.Property<int>("ZanrID");

                    b.HasKey("FilmID");

                    b.HasIndex("ZanrID");

                    b.ToTable("Filmovi");
                });

            modelBuilder.Entity("Kino.WebAPI.Database.Komentari", b =>
                {
                    b.Property<int>("KomentarID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("FilmID");

                    b.Property<int>("KupacID");

                    b.Property<string>("Sadrzaj");

                    b.Property<DateTime>("VrijemeKreiranja");

                    b.HasKey("KomentarID");

                    b.HasIndex("FilmID");

                    b.HasIndex("KupacID");

                    b.ToTable("Komentari");
                });

            modelBuilder.Entity("Kino.WebAPI.Database.Korisnici", b =>
                {
                    b.Property<int>("KorisnikID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email");

                    b.Property<string>("Ime");

                    b.Property<bool?>("IsActive");

                    b.Property<string>("KorisnickoIme");

                    b.Property<string>("LozinkaHash");

                    b.Property<string>("LozinkaSalt");

                    b.Property<string>("Prezime");

                    b.Property<string>("Telefon");

                    b.HasKey("KorisnikID");

                    b.ToTable("Korisnici");
                });

            modelBuilder.Entity("Kino.WebAPI.Database.KorisniciUloge", b =>
                {
                    b.Property<int>("KorisnikUlogaID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DatumIzmjene");

                    b.Property<int>("KorisnikID");

                    b.Property<int>("UlogaID");

                    b.HasKey("KorisnikUlogaID");

                    b.HasIndex("KorisnikID");

                    b.HasIndex("UlogaID");

                    b.ToTable("KorisniciUloge");
                });

            modelBuilder.Entity("Kino.WebAPI.Database.Kupci", b =>
                {
                    b.Property<int>("KupacID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BrojTokena");

                    b.Property<string>("Email");

                    b.Property<string>("Ime");

                    b.Property<bool>("IsActive");

                    b.Property<string>("KorisnickoIme");

                    b.Property<string>("LozinkaHash");

                    b.Property<string>("LozinkaSalt");

                    b.Property<string>("Prezime");

                    b.Property<string>("Telefon");

                    b.HasKey("KupacID");

                    b.ToTable("Kupci");
                });

            modelBuilder.Entity("Kino.WebAPI.Database.Ocjene", b =>
                {
                    b.Property<int>("OcjenaID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("FilmID");

                    b.Property<int>("KupacID");

                    b.Property<int>("Ocjena");

                    b.HasKey("OcjenaID");

                    b.HasIndex("FilmID");

                    b.HasIndex("KupacID");

                    b.ToTable("Ocjene");
                });

            modelBuilder.Entity("Kino.WebAPI.Database.Projekcije", b =>
                {
                    b.Property<int>("ProjekcijaID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("Cijena");

                    b.Property<DateTime>("Datum");

                    b.Property<int>("FilmID");

                    b.Property<int>("KorisnikID");

                    b.Property<int>("SalaID");

                    b.HasKey("ProjekcijaID");

                    b.HasIndex("FilmID");

                    b.HasIndex("KorisnikID");

                    b.HasIndex("SalaID");

                    b.ToTable("Projekcije");
                });

            modelBuilder.Entity("Kino.WebAPI.Database.Sale", b =>
                {
                    b.Property<int>("SalaID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BrojKolona");

                    b.Property<string>("BrojRedova");

                    b.Property<string>("Naziv");

                    b.HasKey("SalaID");

                    b.ToTable("Sale");
                });

            modelBuilder.Entity("Kino.WebAPI.Database.Sjedista", b =>
                {
                    b.Property<int>("SjedisteID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("OznakaKolone");

                    b.Property<int>("OznakaReda");

                    b.Property<int>("SalaID");

                    b.HasKey("SjedisteID");

                    b.HasIndex("SalaID");

                    b.ToTable("Sjedista");
                });

            modelBuilder.Entity("Kino.WebAPI.Database.Ulaznice", b =>
                {
                    b.Property<int>("UlaznicaID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<byte[]>("BarCodeIMG");

                    b.Property<decimal>("CijenaSaPopustom");

                    b.Property<DateTime>("Datum");

                    b.Property<int?>("KupacID");

                    b.Property<int>("Popust");

                    b.Property<int>("ProjekcijaID");

                    b.Property<int>("SjedisteID");

                    b.HasKey("UlaznicaID");

                    b.HasIndex("KupacID");

                    b.HasIndex("ProjekcijaID");

                    b.HasIndex("SjedisteID");

                    b.ToTable("Ulaznice");
                });

            modelBuilder.Entity("Kino.WebAPI.Database.Uloge", b =>
                {
                    b.Property<int>("UlogaId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Naziv");

                    b.HasKey("UlogaId");

                    b.ToTable("Uloge");
                });

            modelBuilder.Entity("Kino.WebAPI.Database.Zanrovi", b =>
                {
                    b.Property<int>("ZanrID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Naziv");

                    b.HasKey("ZanrID");

                    b.ToTable("Zanrovi");
                });

            modelBuilder.Entity("Kino.WebAPI.Database.Filmovi", b =>
                {
                    b.HasOne("Kino.WebAPI.Database.Zanrovi", "Zanr")
                        .WithMany()
                        .HasForeignKey("ZanrID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Kino.WebAPI.Database.Komentari", b =>
                {
                    b.HasOne("Kino.WebAPI.Database.Filmovi", "Filmovi")
                        .WithMany()
                        .HasForeignKey("FilmID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Kino.WebAPI.Database.Kupci", "Kupac")
                        .WithMany()
                        .HasForeignKey("KupacID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Kino.WebAPI.Database.KorisniciUloge", b =>
                {
                    b.HasOne("Kino.WebAPI.Database.Korisnici", "Korisnik")
                        .WithMany("KorisniciUloge")
                        .HasForeignKey("KorisnikID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Kino.WebAPI.Database.Uloge", "Uloga")
                        .WithMany("KorisniciUloge")
                        .HasForeignKey("UlogaID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Kino.WebAPI.Database.Ocjene", b =>
                {
                    b.HasOne("Kino.WebAPI.Database.Filmovi", "Filmovi")
                        .WithMany()
                        .HasForeignKey("FilmID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Kino.WebAPI.Database.Kupci", "Kupac")
                        .WithMany()
                        .HasForeignKey("KupacID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Kino.WebAPI.Database.Projekcije", b =>
                {
                    b.HasOne("Kino.WebAPI.Database.Filmovi", "Film")
                        .WithMany()
                        .HasForeignKey("FilmID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Kino.WebAPI.Database.Korisnici", "Korisnik")
                        .WithMany()
                        .HasForeignKey("KorisnikID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Kino.WebAPI.Database.Sale", "Sala")
                        .WithMany()
                        .HasForeignKey("SalaID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Kino.WebAPI.Database.Sjedista", b =>
                {
                    b.HasOne("Kino.WebAPI.Database.Sale", "Sala")
                        .WithMany()
                        .HasForeignKey("SalaID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Kino.WebAPI.Database.Ulaznice", b =>
                {
                    b.HasOne("Kino.WebAPI.Database.Kupci", "Kupac")
                        .WithMany()
                        .HasForeignKey("KupacID");

                    b.HasOne("Kino.WebAPI.Database.Projekcije", "Projekcija")
                        .WithMany()
                        .HasForeignKey("ProjekcijaID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Kino.WebAPI.Database.Sjedista", "Sjediste")
                        .WithMany()
                        .HasForeignKey("SjedisteID")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
