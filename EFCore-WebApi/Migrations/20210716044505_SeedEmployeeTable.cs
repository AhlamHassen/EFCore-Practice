using Microsoft.EntityFrameworkCore.Migrations;

namespace EFCore_WebApi.Migrations
{
    public partial class SeedEmployeeTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "Email", "Name" },
                values: new object[] { 1, "ahlam@gmail.com", "Ahlam" });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "Email", "Name" },
                values: new object[] { 2, "amiiy@gmai.com", "amiiy" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
