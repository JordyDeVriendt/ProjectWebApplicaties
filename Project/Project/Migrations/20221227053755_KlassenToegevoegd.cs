using Microsoft.EntityFrameworkCore.Migrations;

namespace Project.Migrations
{
    public partial class KlassenToegevoegd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "OperatingSystem",
                table: "Computer",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Behuizing",
                table: "Computer",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "CpuCooler",
                table: "Computer",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Moederbord",
                table: "Computer",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Opslag",
                table: "Computer",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Ram",
                table: "Computer",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Behuizing",
                table: "Computer");

            migrationBuilder.DropColumn(
                name: "CpuCooler",
                table: "Computer");

            migrationBuilder.DropColumn(
                name: "Moederbord",
                table: "Computer");

            migrationBuilder.DropColumn(
                name: "Opslag",
                table: "Computer");

            migrationBuilder.DropColumn(
                name: "Ram",
                table: "Computer");

            migrationBuilder.AlterColumn<string>(
                name: "OperatingSystem",
                table: "Computer",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }
    }
}
