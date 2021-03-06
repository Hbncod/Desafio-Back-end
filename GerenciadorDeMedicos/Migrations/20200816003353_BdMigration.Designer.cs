﻿// <auto-generated />
using System;
using GerenciadorDeMedicos.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace GerenciadorDeMedicos.Migrations
{
    [DbContext(typeof(MedicosContext))]
    [Migration("20200816003353_BdMigration")]
    partial class BdMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("GerenciadorDeMedicos.Domains.Especialidade", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Titulo")
                        .IsRequired()
                        .HasColumnType("VARCHAR (30)");

                    b.HasKey("Id");

                    b.HasIndex("Id")
                        .IsUnique();

                    b.ToTable("Especialidade");
                });

            modelBuilder.Entity("GerenciadorDeMedicos.Domains.Medico", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Cpf")
                        .HasColumnType("nvarchar(11)")
                        .HasMaxLength(11);

                    b.Property<string>("Crm")
                        .IsRequired()
                        .HasColumnType("nvarchar(12)")
                        .HasMaxLength(12);

                    b.Property<int?>("Especialidade1Id")
                        .HasColumnType("int");

                    b.Property<int?>("Especialidade2Id")
                        .HasColumnType("int");

                    b.Property<int>("Fk_Especialidade1")
                        .HasColumnType("int");

                    b.Property<int>("Fk_Especialidade2")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("VARCHAR (255)")
                        .HasMaxLength(255);

                    b.HasKey("Id");

                    b.HasIndex("Especialidade1Id");

                    b.HasIndex("Especialidade2Id");

                    b.HasIndex("Id")
                        .IsUnique();

                    b.ToTable("Medico");
                });

            modelBuilder.Entity("GerenciadorDeMedicos.Domains.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("VARCHAR(150)")
                        .HasMaxLength(150);

                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasColumnType("VARCHAR (30)")
                        .HasMaxLength(30);

                    b.HasKey("Id");

                    b.HasIndex("Id")
                        .IsUnique();

                    b.ToTable("Usuario");
                });

            modelBuilder.Entity("GerenciadorDeMedicos.Domains.Medico", b =>
                {
                    b.HasOne("GerenciadorDeMedicos.Domains.Especialidade", "Especialidade1")
                        .WithMany("Medicos")
                        .HasForeignKey("Especialidade1Id");

                    b.HasOne("GerenciadorDeMedicos.Domains.Especialidade", "Especialidade2")
                        .WithMany("Medicoss")
                        .HasForeignKey("Especialidade2Id");
                });
#pragma warning restore 612, 618
        }
    }
}
