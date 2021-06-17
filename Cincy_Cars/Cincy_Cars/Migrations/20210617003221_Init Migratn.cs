using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Cincy_Cars.Migrations
{
    public partial class InitMigratn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Downtown",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 200, nullable: false),
                    Organization = table.Column<string>(maxLength: 200, nullable: false),
                    DateTime = table.Column<DateTime>(nullable: false),
                    Link = table.Column<string>(maxLength: 500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Downtown", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "East",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 200, nullable: false),
                    Organization = table.Column<string>(maxLength: 200, nullable: false),
                    DateTime = table.Column<DateTime>(nullable: false),
                    Link = table.Column<string>(maxLength: 500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_East", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "North",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 200, nullable: false),
                    Organization = table.Column<string>(maxLength: 200, nullable: false),
                    DateTime = table.Column<DateTime>(nullable: false),
                    Link = table.Column<string>(maxLength: 500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_North", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "South",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 200, nullable: false),
                    Organization = table.Column<string>(maxLength: 200, nullable: false),
                    DateTime = table.Column<DateTime>(nullable: false),
                    Link = table.Column<string>(maxLength: 500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_South", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "West",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 200, nullable: false),
                    Organization = table.Column<string>(maxLength: 200, nullable: false),
                    DateTime = table.Column<DateTime>(nullable: false),
                    Link = table.Column<string>(maxLength: 500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_West", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Downtown");

            migrationBuilder.DropTable(
                name: "East");

            migrationBuilder.DropTable(
                name: "North");

            migrationBuilder.DropTable(
                name: "South");

            migrationBuilder.DropTable(
                name: "West");
        }
    }
}
