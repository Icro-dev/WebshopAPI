using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebshopAPI.Migrations
{
    public partial class Migration1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AvailableSince = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Property1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Property2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Property3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Property4 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Property5 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Property6 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Property7 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Property8 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Property9 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Property10 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Property11 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Property12 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Property13 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Property14 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Property15 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Property16 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Property17 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Property18 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Property19 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Property20 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Property21 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Property22 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Property23 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Property24 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Property25 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<double>(type: "float", nullable: true),
                    IsAvailable = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
