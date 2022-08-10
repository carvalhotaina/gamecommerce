﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApplication1.Data;

namespace WebApplication1.Migrations
{
    [DbContext(typeof(AppDbcontext))]
    [Migration("20220810190006_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.6")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WebApplication1.Models.Desenvolvedor_game", b =>
                {
                    b.Property<int>("DesenvolvedorId")
                        .HasColumnType("int");

                    b.Property<int>("gameId")
                        .HasColumnType("int");

                    b.HasKey("DesenvolvedorId", "gameId");

                    b.HasIndex("gameId");

                    b.ToTable("desenvolvedores_games");
                });

            modelBuilder.Entity("WebApplication1.Models.Game", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("GameCat")
                        .HasColumnType("int");

                    b.Property<int?>("PlataformasId")
                        .HasColumnType("int");

                    b.Property<int>("Plataformasid")
                        .HasColumnType("int");

                    b.Property<string>("bio")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("empressaId")
                        .HasColumnType("int");

                    b.Property<int>("empressaid")
                        .HasColumnType("int");

                    b.Property<string>("foto")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nome")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("preço")
                        .HasColumnType("float");

                    b.HasKey("id");

                    b.HasIndex("PlataformasId");

                    b.HasIndex("empressaId");

                    b.ToTable("Games");
                });

            modelBuilder.Entity("WebApplication1.Models.Plataformas", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("bio")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("foto")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nome")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("Plataformas");
                });

            modelBuilder.Entity("WebApplication1.Models.desenvolvedor", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("bio")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("foto")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nome")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("desenvolvedors");
                });

            modelBuilder.Entity("WebApplication1.Models.empressa", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("bio")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("foto")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nome")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("empressas");
                });

            modelBuilder.Entity("WebApplication1.Models.Desenvolvedor_game", b =>
                {
                    b.HasOne("WebApplication1.Models.desenvolvedor", "desenvolvedor")
                        .WithMany("Desenvolvedores_games")
                        .HasForeignKey("DesenvolvedorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebApplication1.Models.Game", "Game")
                        .WithMany("Desenvolvedores_games")
                        .HasForeignKey("gameId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("desenvolvedor");

                    b.Navigation("Game");
                });

            modelBuilder.Entity("WebApplication1.Models.Game", b =>
                {
                    b.HasOne("WebApplication1.Models.Plataformas", "Plataformas")
                        .WithMany("Games")
                        .HasForeignKey("PlataformasId");

                    b.HasOne("WebApplication1.Models.empressa", "empressa")
                        .WithMany("Games")
                        .HasForeignKey("empressaId");

                    b.Navigation("empressa");

                    b.Navigation("Plataformas");
                });

            modelBuilder.Entity("WebApplication1.Models.Game", b =>
                {
                    b.Navigation("Desenvolvedores_games");
                });

            modelBuilder.Entity("WebApplication1.Models.Plataformas", b =>
                {
                    b.Navigation("Games");
                });

            modelBuilder.Entity("WebApplication1.Models.desenvolvedor", b =>
                {
                    b.Navigation("Desenvolvedores_games");
                });

            modelBuilder.Entity("WebApplication1.Models.empressa", b =>
                {
                    b.Navigation("Games");
                });
#pragma warning restore 612, 618
        }
    }
}
