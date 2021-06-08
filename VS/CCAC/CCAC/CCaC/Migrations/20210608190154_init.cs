using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CCaC.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Downtown",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    Organization = table.Column<string>(maxLength: 50, nullable: false),
                    Date = table.Column<string>(maxLength: 40, nullable: false),
                    Time = table.Column<string>(maxLength: 40, nullable: false),
                    Link = table.Column<string>(maxLength: 255, nullable: true)
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
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    Organization = table.Column<string>(maxLength: 50, nullable: false),
                    Date = table.Column<string>(maxLength: 40, nullable: false),
                    Time = table.Column<string>(maxLength: 40, nullable: false),
                    Link = table.Column<string>(maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_East", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "North2",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    Organization = table.Column<string>(maxLength: 50, nullable: false),
                    Date = table.Column<DateTime>(maxLength: 40, nullable: false),
                    Link = table.Column<string>(maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_North2", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "South",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    Organization = table.Column<string>(maxLength: 50, nullable: false),
                    Date = table.Column<string>(maxLength: 40, nullable: false),
                    Time = table.Column<string>(maxLength: 40, nullable: false),
                    Link = table.Column<string>(maxLength: 255, nullable: true)
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
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    Organization = table.Column<string>(maxLength: 50, nullable: false),
                    Date = table.Column<string>(maxLength: 40, nullable: false),
                    Time = table.Column<string>(maxLength: 40, nullable: false),
                    Link = table.Column<string>(maxLength: 255, nullable: true)
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
                name: "North2");

            migrationBuilder.DropTable(
                name: "South");

            migrationBuilder.DropTable(
                name: "West");
        }
    }
}
