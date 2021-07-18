using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Clinica_Médica.Migrations
{
    public partial class MigracaoInicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TBEspecialidade",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomeEspecialidade = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TBEspecialidade", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "TBPaciente",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    DataNascimento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Telefone = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Profissao = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TBPaciente", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "TBMedico",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CRM = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: false),
                    Nome = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    TempoMedio = table.Column<TimeSpan>(type: "time", nullable: false),
                    CodEspecialidade = table.Column<int>(type: "int", nullable: false),
                    EspecialidadeMedicoID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TBMedico", x => x.ID);
                    table.ForeignKey(
                        name: "FK_TBMedico_TBEspecialidade_EspecialidadeMedicoID",
                        column: x => x.EspecialidadeMedicoID,
                        principalTable: "TBEspecialidade",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TBAgenda",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CodMedico = table.Column<int>(type: "int", nullable: false),
                    MedicoResponsavelID = table.Column<int>(type: "int", nullable: true),
                    CodPaciente = table.Column<int>(type: "int", nullable: false),
                    PacienteConsultaID = table.Column<int>(type: "int", nullable: true),
                    DataHoraConsulta = table.Column<DateTime>(type: "datetime2", nullable: false),
                    HoraInicio = table.Column<TimeSpan>(type: "time", nullable: false),
                    HoraFim = table.Column<TimeSpan>(type: "time", nullable: false),
                    Anotacoes = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TBAgenda", x => x.ID);
                    table.ForeignKey(
                        name: "FK_TBAgenda_TBMedico_MedicoResponsavelID",
                        column: x => x.MedicoResponsavelID,
                        principalTable: "TBMedico",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TBAgenda_TBPaciente_PacienteConsultaID",
                        column: x => x.PacienteConsultaID,
                        principalTable: "TBPaciente",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TBAgenda_MedicoResponsavelID",
                table: "TBAgenda",
                column: "MedicoResponsavelID");

            migrationBuilder.CreateIndex(
                name: "IX_TBAgenda_PacienteConsultaID",
                table: "TBAgenda",
                column: "PacienteConsultaID");

            migrationBuilder.CreateIndex(
                name: "IX_TBMedico_EspecialidadeMedicoID",
                table: "TBMedico",
                column: "EspecialidadeMedicoID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TBAgenda");

            migrationBuilder.DropTable(
                name: "TBMedico");

            migrationBuilder.DropTable(
                name: "TBPaciente");

            migrationBuilder.DropTable(
                name: "TBEspecialidade");
        }
    }
}
