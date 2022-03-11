using Microsoft.EntityFrameworkCore.Migrations;

namespace tiketsysstem.Data.Migrations
{
    public partial class SeedRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "96705f68-26be-4e9f-bb8e-404f1034ef48", "904358a1-dfdd-4a46-91e9-b52e562474a7", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "73ce0848-e7ac-437b-8f95-3d7df501fd3c", "9943908d-2239-4edf-b172-306df12860a9", "Supporter", "SUPPOTTER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "a7effaad-11aa-414d-b678-99d86bf1962b", "940cc598-c97e-4596-8b43-17142775c3f1", "Admin", "ADMIN" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "73ce0848-e7ac-437b-8f95-3d7df501fd3c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "96705f68-26be-4e9f-bb8e-404f1034ef48");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a7effaad-11aa-414d-b678-99d86bf1962b");
        }
    }
}
