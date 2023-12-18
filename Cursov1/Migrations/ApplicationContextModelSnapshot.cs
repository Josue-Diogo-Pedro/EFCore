﻿// <auto-generated />
using Cursov1.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Cursov1.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    partial class ApplicationContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseCollation("SQL_Latin1_General_CP1_CI_AI")
                .HasAnnotation("ProductVersion", "6.0.20")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.HasSequence<int>("MinhaSequencia", "sequencias")
                .StartsAt(100L);

            modelBuilder.Entity("Cursov1.Domain.Departamento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValueSql("NEXT VALUE FOR sequencias.MinhaSequencia");

                    b.Property<bool>("Ativo")
                        .HasColumnType("bit");

                    b.Property<string>("Descricao")
                        .HasColumnType("nvarchar(450)")
                        .UseCollation("SQL_Latin1_General_CP1_CS_AS");

                    b.Property<bool>("Excluido")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("Descricao", "Ativo")
                        .IsUnique()
                        .HasDatabaseName("idx_meu_indice_composto")
                        .HasFilter("Descricao IS NOT NULL");

                    SqlServerIndexBuilderExtensions.HasFillFactor(b.HasIndex("Descricao", "Ativo"), 80);

                    b.ToTable("Departamentos", (string)null);
                });

            modelBuilder.Entity("Cursov1.Domain.Estado", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Estados", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Nome = "Sao Paulo"
                        },
                        new
                        {
                            Id = 2,
                            Nome = "Sergipe"
                        });
                });

            modelBuilder.Entity("Cursov1.Domain.Funcionario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("CPF")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DepartamentoId")
                        .HasColumnType("int");

                    b.Property<bool>("Excluido")
                        .HasColumnType("bit");

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("DepartamentoId");

                    b.ToTable("Funcionarios", (string)null);
                });

            modelBuilder.Entity("Cursov1.Domain.Funcionario", b =>
                {
                    b.HasOne("Cursov1.Domain.Departamento", "Departamento")
                        .WithMany("Funcionarios")
                        .HasForeignKey("DepartamentoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Departamento");
                });

            modelBuilder.Entity("Cursov1.Domain.Departamento", b =>
                {
                    b.Navigation("Funcionarios");
                });
#pragma warning restore 612, 618
        }
    }
}