﻿// <auto-generated />
using System;
using EFcore.WebAPI.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EFcore.WebAPI.Migrations
{
    [DbContext(typeof(HeroiContext))]
    [Migration("20210105171044_HeroisBatalhas_Identidade")]
    partial class HeroisBatalhas_Identidade
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("EFcore.WebAPI.Models.Arma", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("HeroiId");

                    b.Property<string>("Nome");

                    b.HasKey("Id");

                    b.HasIndex("HeroiId");

                    b.ToTable("Armas");
                });

            modelBuilder.Entity("EFcore.WebAPI.Models.Batalha", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Descricao");

                    b.Property<DateTime>("DtFim");

                    b.Property<DateTime>("DtInicio");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Batalhas");
                });

            modelBuilder.Entity("EFcore.WebAPI.Models.Heroi", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Nome");

                    b.HasKey("Id");

                    b.ToTable("Herois");
                });

            modelBuilder.Entity("EFcore.WebAPI.Models.HeroiBatalha", b =>
                {
                    b.Property<int>("BatalhaId");

                    b.Property<int>("HeroiId");

                    b.HasKey("BatalhaId", "HeroiId");

                    b.HasIndex("HeroiId");

                    b.ToTable("HeroisBatalhas");
                });

            modelBuilder.Entity("EFcore.WebAPI.Models.IdentidadeSecreta", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("HeroiId");

                    b.Property<string>("NomeReal");

                    b.HasKey("Id");

                    b.HasIndex("HeroiId")
                        .IsUnique();

                    b.ToTable("IdentidadesSecretas");
                });

            modelBuilder.Entity("EFcore.WebAPI.Models.Arma", b =>
                {
                    b.HasOne("EFcore.WebAPI.Models.Heroi", "Heroi")
                        .WithMany("Armas")
                        .HasForeignKey("HeroiId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("EFcore.WebAPI.Models.HeroiBatalha", b =>
                {
                    b.HasOne("EFcore.WebAPI.Models.Batalha", "Batalha")
                        .WithMany("HeroisBatalhas")
                        .HasForeignKey("BatalhaId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("EFcore.WebAPI.Models.Heroi", "Heroi")
                        .WithMany("HeroisBatalhas")
                        .HasForeignKey("HeroiId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("EFcore.WebAPI.Models.IdentidadeSecreta", b =>
                {
                    b.HasOne("EFcore.WebAPI.Models.Heroi", "Heroi")
                        .WithOne("Identidade")
                        .HasForeignKey("EFcore.WebAPI.Models.IdentidadeSecreta", "HeroiId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}