using Microsoft.EntityFrameworkCore.Migrations;

namespace Project.Migrations
{
    public partial class updateKlassen : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cpu");

            migrationBuilder.DropTable(
                name: "Gpu");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Bestelling",
                table: "Bestelling");

            migrationBuilder.RenameTable(
                name: "Bestelling",
                newName: "Bestellingen");

            migrationBuilder.AddColumn<string>(
                name: "Cpu",
                table: "Computer",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Gpu",
                table: "Computer",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "BetaalmethodeId",
                table: "Bestellingen",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "StatusId",
                table: "Bestellingen",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Bestellingen",
                table: "Bestellingen",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Betaalmethode",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naam = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Afbeelding = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Betaalmethode", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Status",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naam = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Status", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Bestellingen_AccountId",
                table: "Bestellingen",
                column: "AccountId");

            migrationBuilder.CreateIndex(
                name: "IX_Bestellingen_BetaalmethodeId",
                table: "Bestellingen",
                column: "BetaalmethodeId");

            migrationBuilder.CreateIndex(
                name: "IX_Bestellingen_StatusId",
                table: "Bestellingen",
                column: "StatusId");

            migrationBuilder.AddForeignKey(
                name: "FK_Bestellingen_Account_AccountId",
                table: "Bestellingen",
                column: "AccountId",
                principalTable: "Account",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Bestellingen_Betaalmethode_BetaalmethodeId",
                table: "Bestellingen",
                column: "BetaalmethodeId",
                principalTable: "Betaalmethode",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Bestellingen_Status_StatusId",
                table: "Bestellingen",
                column: "StatusId",
                principalTable: "Status",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bestellingen_Account_AccountId",
                table: "Bestellingen");

            migrationBuilder.DropForeignKey(
                name: "FK_Bestellingen_Betaalmethode_BetaalmethodeId",
                table: "Bestellingen");

            migrationBuilder.DropForeignKey(
                name: "FK_Bestellingen_Status_StatusId",
                table: "Bestellingen");

            migrationBuilder.DropTable(
                name: "Betaalmethode");

            migrationBuilder.DropTable(
                name: "Status");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Bestellingen",
                table: "Bestellingen");

            migrationBuilder.DropIndex(
                name: "IX_Bestellingen_AccountId",
                table: "Bestellingen");

            migrationBuilder.DropIndex(
                name: "IX_Bestellingen_BetaalmethodeId",
                table: "Bestellingen");

            migrationBuilder.DropIndex(
                name: "IX_Bestellingen_StatusId",
                table: "Bestellingen");

            migrationBuilder.DropColumn(
                name: "Cpu",
                table: "Computer");

            migrationBuilder.DropColumn(
                name: "Gpu",
                table: "Computer");

            migrationBuilder.DropColumn(
                name: "BetaalmethodeId",
                table: "Bestellingen");

            migrationBuilder.DropColumn(
                name: "StatusId",
                table: "Bestellingen");

            migrationBuilder.RenameTable(
                name: "Bestellingen",
                newName: "Bestelling");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Bestelling",
                table: "Bestelling",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Cpu",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naam = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Socket = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cpu", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Gpu",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AantalDisplaypoorten = table.Column<int>(type: "int", nullable: false),
                    Naam = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Gpu", x => x.Id);
                });
        }
    }
}
