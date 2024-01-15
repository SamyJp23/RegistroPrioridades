﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Prioridad.DAL;

#nullable disable

namespace Prioridad.Migrations
{
    [DbContext(typeof(PrioridadContext))]
    [Migration("20240115054836_Inicial")]
    partial class Inicial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.1");

            modelBuilder.Entity("Prioridad.Models.Prioridades", b =>
                {
                    b.Property<int>("IdPrioridades")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Descripcion")
                        .HasColumnType("TEXT");

                    b.Property<int>("DiasCompromiso")
                        .HasColumnType("INTEGER");

                    b.HasKey("IdPrioridades");

                    b.ToTable("Prioridades");
                });
#pragma warning restore 612, 618
        }
    }
}