using Microsoft.EntityFrameworkCore.Migrations;

namespace Clinica_Médica.Migrations
{
    public partial class correcaoMedico2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CodEspecialidade",
                table: "TBMedico");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CodEspecialidade",
                table: "TBMedico",
                type: "int",
                nullable: true);
        }
    }
}
