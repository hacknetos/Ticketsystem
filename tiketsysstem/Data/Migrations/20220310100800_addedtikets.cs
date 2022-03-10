using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace tiketsysstem.Data.Migrations
{
    public partial class addedtikets : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Tikets",
                columns: table => new
                {
                    productid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    productname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Discription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    finish = table.Column<bool>(type: "bit", nullable: false),
                    Note = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    userid = table.Column<int>(type: "int", nullable: false),
                    MyProperty = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tikets", x => x.productid);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tikets");
        }
    }
}
