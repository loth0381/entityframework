﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using projectef;

#nullable disable

namespace projectef.Migrations
{
    [DbContext(typeof(TareasContext))]
    [Migration("20231007205614_InitialData")]
    partial class InitialData
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("projectef.Models.Categoria", b =>
                {
                    b.Property<Guid>("CategoriaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<int>("Peso")
                        .HasColumnType("int");

                    b.HasKey("CategoriaId");

                    b.ToTable("Categoria", (string)null);

                    b.HasData(
                        new
                        {
                            CategoriaId = new Guid("3f96cc4c-a2ae-4862-a47d-0dc15d150502"),
                            Nombre = "Actividades pedientes",
                            Peso = 20
                        },
                        new
                        {
                            CategoriaId = new Guid("3f96cc4c-a2ae-4862-a47d-0dc15d150594"),
                            Nombre = "Actividades personales",
                            Peso = 50
                        });
                });

            modelBuilder.Entity("projectef.Models.Tarea", b =>
                {
                    b.Property<Guid>("TareaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CategoriaId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("CategoriaId1")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("FechaCreacion")
                        .HasColumnType("datetime2");

                    b.Property<string>("Titulo")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<int>("prioridadTarea")
                        .HasColumnType("int");

                    b.HasKey("TareaId");

                    b.HasIndex("CategoriaId");

                    b.HasIndex("CategoriaId1");

                    b.ToTable("Tarea", (string)null);

                    b.HasData(
                        new
                        {
                            TareaId = new Guid("3f96cc4c-a2ae-4862-a47d-0dc15d150510"),
                            CategoriaId = new Guid("3f96cc4c-a2ae-4862-a47d-0dc15d150502"),
                            FechaCreacion = new DateTime(2023, 10, 7, 15, 56, 14, 790, DateTimeKind.Local).AddTicks(2950),
                            Titulo = "Pago de servicios publico",
                            prioridadTarea = 1
                        },
                        new
                        {
                            TareaId = new Guid("3f96cc4c-a2ae-4862-a47d-0dc15d150511"),
                            CategoriaId = new Guid("3f96cc4c-a2ae-4862-a47d-0dc15d150594"),
                            FechaCreacion = new DateTime(2023, 10, 7, 15, 56, 14, 790, DateTimeKind.Local).AddTicks(2962),
                            Titulo = "Terminar pelicula netflix",
                            prioridadTarea = 0
                        });
                });

            modelBuilder.Entity("projectef.Models.Tarea", b =>
                {
                    b.HasOne("projectef.Models.Categoria", "Categoria")
                        .WithMany()
                        .HasForeignKey("CategoriaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("projectef.Models.Categoria", null)
                        .WithMany("Tareas")
                        .HasForeignKey("CategoriaId1");

                    b.Navigation("Categoria");
                });

            modelBuilder.Entity("projectef.Models.Categoria", b =>
                {
                    b.Navigation("Tareas");
                });
#pragma warning restore 612, 618
        }
    }
}