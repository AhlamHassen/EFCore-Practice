using Microsoft.EntityFrameworkCore.Migrations;

namespace EFCore_WebApi.Migrations
{
    public partial class AlterEmployeesData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Email", "Name" },
                values: new object[] { "alu@gmai.com", "alu" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Email", "Name" },
                values: new object[] { "amiiy@gmai.com", "amiiy" });
        }
    }
}
