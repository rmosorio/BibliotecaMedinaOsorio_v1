using Microsoft.EntityFrameworkCore.Migrations;

namespace BibliotecaMedinaOsorio_v1.Migrations
{
    public partial class obrigatoriedadeperfilnofunc : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Funcionario_Perfil_PerfilId",
                table: "Funcionario");

            migrationBuilder.AlterColumn<int>(
                name: "PerfilId",
                table: "Funcionario",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Funcionario_Perfil_PerfilId",
                table: "Funcionario",
                column: "PerfilId",
                principalTable: "Perfil",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Funcionario_Perfil_PerfilId",
                table: "Funcionario");

            migrationBuilder.AlterColumn<int>(
                name: "PerfilId",
                table: "Funcionario",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Funcionario_Perfil_PerfilId",
                table: "Funcionario",
                column: "PerfilId",
                principalTable: "Perfil",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
