using Microsoft.EntityFrameworkCore.Migrations;

namespace Clinica_Médica.Migrations
{
    public partial class atualizacaoTabelaMedico : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TBMedico_TBEspecialidade_EspecialidadeMedicoID",
                table: "TBMedico");

            migrationBuilder.RenameColumn(
                name: "EspecialidadeMedicoID",
                table: "TBMedico",
                newName: "EspecialidadeId");

            migrationBuilder.RenameIndex(
                name: "IX_TBMedico_EspecialidadeMedicoID",
                table: "TBMedico",
                newName: "IX_TBMedico_EspecialidadeId");

            migrationBuilder.AddForeignKey(
                name: "FK_TBMedico_TBEspecialidade_EspecialidadeId",
                table: "TBMedico",
                column: "EspecialidadeId",
                principalTable: "TBEspecialidade",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TBMedico_TBEspecialidade_EspecialidadeId",
                table: "TBMedico");

            migrationBuilder.RenameColumn(
                name: "EspecialidadeId",
                table: "TBMedico",
                newName: "EspecialidadeMedicoID");

            migrationBuilder.RenameIndex(
                name: "IX_TBMedico_EspecialidadeId",
                table: "TBMedico",
                newName: "IX_TBMedico_EspecialidadeMedicoID");

            migrationBuilder.AddForeignKey(
                name: "FK_TBMedico_TBEspecialidade_EspecialidadeMedicoID",
                table: "TBMedico",
                column: "EspecialidadeMedicoID",
                principalTable: "TBEspecialidade",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
