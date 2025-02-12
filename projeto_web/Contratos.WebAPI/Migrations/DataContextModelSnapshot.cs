﻿// <auto-generated />
using Contratos.WebAPI.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Contratos.WebAPI.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.3");

            modelBuilder.Entity("Contratos.WebAPI.Model.DocumentoContratualModelo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("DataFimVigencia")
                        .HasColumnType("TEXT");

                    b.Property<string>("DataInicioVigencia")
                        .HasColumnType("TEXT");

                    b.Property<string>("LinkRedmine")
                        .HasColumnType("TEXT");

                    b.Property<string>("ObjetoAcordo")
                        .HasColumnType("TEXT");

                    b.Property<string>("ProcessoTCE")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("DocumentosContratuais");
                });
#pragma warning restore 612, 618
        }
    }
}
