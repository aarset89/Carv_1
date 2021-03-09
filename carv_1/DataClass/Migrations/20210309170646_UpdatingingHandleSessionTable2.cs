using Microsoft.EntityFrameworkCore.Migrations;

namespace DataClass.Migrations
{
    public partial class UpdatingingHandleSessionTable2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_HandleSessions_Users_userId",
                table: "HandleSessions");

            migrationBuilder.DropIndex(
                name: "IX_HandleSessions_userId",
                table: "HandleSessions");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_HandleSessions_userId",
                table: "HandleSessions",
                column: "userId");

            migrationBuilder.AddForeignKey(
                name: "FK_HandleSessions_Users_userId",
                table: "HandleSessions",
                column: "userId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
