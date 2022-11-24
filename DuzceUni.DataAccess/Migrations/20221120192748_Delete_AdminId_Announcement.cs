using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DuzceUni.DataAccess.Migrations
{
    public partial class Delete_AdminId_Announcement : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AdminId",
                table: "Announcements");

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "AdminId",
                keyValue: 1,
                column: "SecretKey",
                value: "abdf5e66cc2b424c9784292f9774941620Kas2022222748");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AdminId",
                table: "Announcements",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "AdminId",
                keyValue: 1,
                column: "SecretKey",
                value: "376c677277a64d33b1ff7c98d3bc11db20Kas2022022026");
        }
    }
}
