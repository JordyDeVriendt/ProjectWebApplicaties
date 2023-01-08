using Microsoft.EntityFrameworkCore.Migrations;

namespace Project.Migrations
{
    public partial class bestellingtesting : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropPrimaryKey(
                name: "PK_Bestellingen",
                table: "Bestellingen");

            migrationBuilder.RenameTable(
                name: "Bestellingen",
                newName: "Bestelling");

            migrationBuilder.RenameIndex(
                name: "IX_Bestellingen_StatusId",
                table: "Bestelling",
                newName: "IX_Bestelling_StatusId");

            migrationBuilder.RenameIndex(
                name: "IX_Bestellingen_BetaalmethodeId",
                table: "Bestelling",
                newName: "IX_Bestelling_BetaalmethodeId");

            migrationBuilder.RenameIndex(
                name: "IX_Bestellingen_AccountId",
                table: "Bestelling",
                newName: "IX_Bestelling_AccountId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Bestelling",
                table: "Bestelling",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Bestelling_Account_AccountId",
                table: "Bestelling",
                column: "AccountId",
                principalTable: "Account",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Bestelling_Betaalmethode_BetaalmethodeId",
                table: "Bestelling",
                column: "BetaalmethodeId",
                principalTable: "Betaalmethode",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Bestelling_Status_StatusId",
                table: "Bestelling",
                column: "StatusId",
                principalTable: "Status",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bestelling_Account_AccountId",
                table: "Bestelling");

            migrationBuilder.DropForeignKey(
                name: "FK_Bestelling_Betaalmethode_BetaalmethodeId",
                table: "Bestelling");

            migrationBuilder.DropForeignKey(
                name: "FK_Bestelling_Status_StatusId",
                table: "Bestelling");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Bestelling",
                table: "Bestelling");

            migrationBuilder.RenameTable(
                name: "Bestelling",
                newName: "Bestellingen");

            migrationBuilder.RenameIndex(
                name: "IX_Bestelling_StatusId",
                table: "Bestellingen",
                newName: "IX_Bestellingen_StatusId");

            migrationBuilder.RenameIndex(
                name: "IX_Bestelling_BetaalmethodeId",
                table: "Bestellingen",
                newName: "IX_Bestellingen_BetaalmethodeId");

            migrationBuilder.RenameIndex(
                name: "IX_Bestelling_AccountId",
                table: "Bestellingen",
                newName: "IX_Bestellingen_AccountId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Bestellingen",
                table: "Bestellingen",
                column: "Id");

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
    }
}
