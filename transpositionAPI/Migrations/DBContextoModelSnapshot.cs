﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using transpositionAPI.Context;

namespace transpositionAPI.Migrations
{
    [DbContext(typeof(DBContexto))]
    partial class DBContextoModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
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

                    b.Property<string>("AcordesCromaticas")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("acordesCromaticasMayores")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("acordesCromaticasMenores")
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

                    b.Property<string>("acordesCromaticos")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("acordesCromaticosMayores")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("acordesCromaticosMenores")
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
