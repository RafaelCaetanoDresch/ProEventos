﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using ProEventos.API.Data;

#nullable disable

namespace ProEventos.API.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20240319180100_Init")]
    partial class Init
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("ProEventos.API.Models.Evento", b =>
                {
                    b.Property<int>("EventoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("EventoId"));

                    b.Property<string>("DataEvento")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("ImageURL")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Local")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Lote")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("QtdPessoas")
                        .HasColumnType("integer");

                    b.Property<string>("Tema")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("EventoId");

                    b.ToTable("Eventos");
                });
#pragma warning restore 612, 618
        }
    }
}