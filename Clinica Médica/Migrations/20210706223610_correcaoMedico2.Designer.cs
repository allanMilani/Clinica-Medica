﻿// <auto-generated />
using System;
using Clinica_Médica.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Clinica_Médica.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20210706223610_correcaoMedico2")]
    partial class correcaoMedico2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.7")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Clinica_Médica.Model.Agenda", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Anotacoes")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("CodMedico")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<int?>("CodPaciente")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<DateTime>("DataHoraConsulta")
                        .HasColumnType("datetime2");

                    b.Property<TimeSpan>("HoraFim")
                        .HasColumnType("time");

                    b.Property<TimeSpan>("HoraInicio")
                        .HasColumnType("time");

                    b.Property<int?>("MedicoResponsavelID")
                        .HasColumnType("int");

                    b.Property<int?>("PacienteConsultaID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("MedicoResponsavelID");

                    b.HasIndex("PacienteConsultaID");

                    b.ToTable("TBAgenda");
                });

            modelBuilder.Entity("Clinica_Médica.Model.Especialidade", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("NomeEspecialidade")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("ID");

                    b.ToTable("TBEspecialidade");
                });

            modelBuilder.Entity("Clinica_Médica.Model.Medico", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CRM")
                        .IsRequired()
                        .HasMaxLength(12)
                        .HasColumnType("nvarchar(12)");

                    b.Property<int?>("EspecialidadeMedicoID")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<TimeSpan>("TempoMedio")
                        .HasColumnType("time");

                    b.HasKey("ID");

                    b.HasIndex("EspecialidadeMedicoID");

                    b.ToTable("TBMedico");
                });

            modelBuilder.Entity("Clinica_Médica.Model.Paciente", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DataNascimento")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("Profissao")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("Telefone")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("ID");

                    b.ToTable("TBPaciente");
                });

            modelBuilder.Entity("Clinica_Médica.Model.Agenda", b =>
                {
                    b.HasOne("Clinica_Médica.Model.Medico", "MedicoResponsavel")
                        .WithMany()
                        .HasForeignKey("MedicoResponsavelID");

                    b.HasOne("Clinica_Médica.Model.Paciente", "PacienteConsulta")
                        .WithMany()
                        .HasForeignKey("PacienteConsultaID");

                    b.Navigation("MedicoResponsavel");

                    b.Navigation("PacienteConsulta");
                });

            modelBuilder.Entity("Clinica_Médica.Model.Medico", b =>
                {
                    b.HasOne("Clinica_Médica.Model.Especialidade", "EspecialidadeMedico")
                        .WithMany()
                        .HasForeignKey("EspecialidadeMedicoID");

                    b.Navigation("EspecialidadeMedico");
                });
#pragma warning restore 612, 618
        }
    }
}
