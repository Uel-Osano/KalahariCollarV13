using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KalahariCollarV13.Migrations
{
    /// <inheritdoc />
    public partial class PetsCRUDV32 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "OwnerId",
                table: "Pet",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateIndex(
                name: "IX_Pet_OwnerId",
                table: "Pet",
                column: "OwnerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Pet_AspNetUsers_OwnerId",
                table: "Pet",
                column: "OwnerId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pet_AspNetUsers_OwnerId",
                table: "Pet");

            migrationBuilder.DropIndex(
                name: "IX_Pet_OwnerId",
                table: "Pet");

            migrationBuilder.AlterColumn<string>(
                name: "OwnerId",
                table: "Pet",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");
        }
    }
}
