﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProConvenios.API.Data;

namespace ProConvenios.API.Data.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20210307224541_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.3");

            modelBuilder.Entity("ProConvenios.API.Models.Convenio", b =>
                {
                    b.Property<int>("ConvenioId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("DtFim")
                        .HasColumnType("TEXT");

                    b.Property<string>("DtInicio")
                        .HasColumnType("TEXT");

                    b.Property<string>("LinkRedmine")
                        .HasColumnType("TEXT");

                    b.Property<string>("ObjetoAcordo")
                        .HasColumnType("TEXT");

                    b.Property<string>("ProcessoTCE")
                        .HasColumnType("TEXT");

                    b.HasKey("ConvenioId");

                    b.ToTable("Convenios");
                });
#pragma warning restore 612, 618
        }
    }
}
