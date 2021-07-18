using Microsoft.EntityFrameworkCore.Migrations;

namespace Clinica_Médica.Migrations
{
    public partial class AlteracaoTabelaAgenda : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TBAgenda_TBMedico_MedicoResponsavelID",
                table: "TBAgenda");

            migrationBuilder.DropForeignKey(
                name: "FK_TBAgenda_TBPaciente_PacienteConsultaID",
                table: "TBAgenda");

            migrationBuilder.DropIndex(
                name: "IX_TBAgenda_MedicoResponsavelID",
                table: "TBAgenda");

            migrationBuilder.DropIndex(
                name: "IX_TBAgenda_PacienteConsultaID",
                table: "TBAgenda");

            migrationBuilder.DropColumn(
                name: "MedicoResponsavelID",
                table: "TBAgenda");

            migrationBuilder.DropColumn(
                name: "PacienteConsultaID",
                table: "TBAgenda");

            migrationBuilder.RenameColumn(
                name: "CodPaciente",
                table: "TBAgenda",
                newName: "PacienteId");

            migrationBuilder.RenameColumn(
                name: "CodMedico",
                table: "TBAgenda",
                newName: "MedicoId");

            migrationBuilder.CreateIndex(
                name: "IX_TBAgenda_MedicoId",
                table: "TBAgenda",
                column: "MedicoId");

            migrationBuilder.CreateIndex(
                name: "IX_TBAgenda_PacienteId",
                table: "TBAgenda",
                column: "PacienteId");

            migrationBuilder.AddForeignKey(
                name: "FK_TBAgenda_TBMedico_MedicoId",
                table: "TBAgenda",
                column: "MedicoId",
                principalTable: "TBMedico",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TBAgenda_TBPaciente_PacienteId",
                table: "TBAgenda",
                column: "PacienteId",
                principalTable: "TBPaciente",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TBAgenda_TBMedico_MedicoId",
                table: "TBAgenda");

            migrationBuilder.DropForeignKey(
                name: "FK_TBAgenda_TBPaciente_PacienteId",
                table: "TBAgenda");

            migrationBuilder.DropIndex(
                name: "IX_TBAgenda_MedicoId",
                table: "TBAgenda");

            migrationBuilder.DropIndex(
                name: "IX_TBAgenda_PacienteId",
                table: "TBAgenda");

            migrationBuilder.RenameColumn(
                name: "PacienteId",
                table: "TBAgenda",
                newName: "CodPaciente");

            migrationBuilder.RenameColumn(
                name: "MedicoId",
                table: "TBAgenda",
                newName: "CodMedico");

            migrationBuilder.AddColumn<int>(
                name: "MedicoResponsavelID",
                table: "TBAgenda",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PacienteConsultaID",
                table: "TBAgenda",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_TBAgenda_MedicoResponsavelID",
                table: "TBAgenda",
                column: "MedicoResponsavelID");

            migrationBuilder.CreateIndex(
                name: "IX_TBAgenda_PacienteConsultaID",
                table: "TBAgenda",
                column: "PacienteConsultaID");

            migrationBuilder.AddForeignKey(
                name: "FK_TBAgenda_TBMedico_MedicoResponsavelID",
                table: "TBAgenda",
                column: "MedicoResponsavelID",
                principalTable: "TBMedico",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TBAgenda_TBPaciente_PacienteConsultaID",
                table: "TBAgenda",
                column: "PacienteConsultaID",
                principalTable: "TBPaciente",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
