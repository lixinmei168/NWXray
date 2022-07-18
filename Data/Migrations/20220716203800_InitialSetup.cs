using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NWXray.Data.Migrations
{
    public partial class InitialSetup : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Case",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClientFirstname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ClientLastname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ClientEmail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ClientPhone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ClientAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ClientInquiry = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClientRequestDatetime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DealerRespond = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DealerRespondDatetime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DealerUserName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Case", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Case");
        }
    }
}
