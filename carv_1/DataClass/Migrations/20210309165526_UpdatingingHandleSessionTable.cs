using Microsoft.EntityFrameworkCore.Migrations;

namespace DataClass.Migrations
{
    public partial class UpdatingingHandleSessionTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Token",
                table: "HandleSessions",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Token",
                table: "HandleSessions");
        }
    }
}
