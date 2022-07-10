using Microsoft.EntityFrameworkCore.Migrations;

namespace Social_Network.Infrastructure.Persistence.Migrations
{
    public partial class UpdatedEntityFriend : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Friends_Users_Friend_Id",
                table: "Friends");

            migrationBuilder.DropForeignKey(
                name: "FK_Friends_Users_UserId",
                table: "Friends");

            migrationBuilder.DropIndex(
                name: "IX_Friends_Friend_Id",
                table: "Friends");

            migrationBuilder.DropIndex(
                name: "IX_Friends_UserId",
                table: "Friends");

            migrationBuilder.DropColumn(
                name: "Friend_Id",
                table: "Friends");

            migrationBuilder.CreateIndex(
                name: "IX_Friends_IdFriend",
                table: "Friends",
                column: "IdFriend");

            migrationBuilder.AddForeignKey(
                name: "FK_Friends_Users_IdFriend",
                table: "Friends",
                column: "IdFriend",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Friends_Users_IdFriend",
                table: "Friends");

            migrationBuilder.DropIndex(
                name: "IX_Friends_IdFriend",
                table: "Friends");

            migrationBuilder.AddColumn<int>(
                name: "Friend_Id",
                table: "Friends",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Friends_Friend_Id",
                table: "Friends",
                column: "Friend_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Friends_UserId",
                table: "Friends",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Friends_Users_Friend_Id",
                table: "Friends",
                column: "Friend_Id",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Friends_Users_UserId",
                table: "Friends",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id");
        }
    }
}
