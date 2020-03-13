﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using transpositionAPI.Context;

namespace transpositionAPI.Migrations
{
    [DbContext(typeof(DBContexto))]
    [Migration("20200313162533_inicial_t")]
    partial class inicial_t
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("transpositionAPI.Models.Acordes", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AcordesComaticas")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("acordesComaticasMayores")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("acordesComaticasMenores")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("acordesSeptimaMayor")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("acordesSeptimaMenor")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("acordes");
                });

            modelBuilder.Entity("transpositionAPI.Models.Notas", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("acordesComaticos")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("acordesComaticosMayores")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("acordesComaticosMenores")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("acordesSeptimaMayor")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("acordesSeptimaMenor")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("notas");
                });
#pragma warning restore 612, 618
        }
    }
}
