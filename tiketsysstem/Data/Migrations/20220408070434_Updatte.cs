using Microsoft.EntityFrameworkCore.Migrations;

namespace tiketsysstem.Data.Migrations
{
    public partial class Updatte : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<string>(
                name: "userid",
                table: "Tikets",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "4cf78e03-ae3e-42fc-9e32-29291a45206c", "84ee2b80-db47-451a-8c88-19fde928f2d4", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "23a195a7-233c-4327-9645-5ab69cc6c8f7", "1b5209eb-16f6-4d64-b3ee-984802ccb0ba", "Supporter", "SUPPOTTER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "8cf1a1c5-9427-4997-830e-5a07f23a9f21", "bd026107-9741-49c2-a0ef-f5314b5bf43d", "Admin", "ADMIN" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "23a195a7-233c-4327-9645-5ab69cc6c8f7");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4cf78e03-ae3e-42fc-9e32-29291a45206c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8cf1a1c5-9427-4997-830e-5a07f23a9f21");

            migrationBuilder.AlterColumn<int>(
                name: "userid",
                table: "Tikets",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

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
    }
}
