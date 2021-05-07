using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CCaC.Migrations
{
    public partial class IntialMigration : Migration
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
                name: "East_1",
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
                    table.PrimaryKey("PK_East_1", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "North",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    Organization = table.Column<string>(maxLength: 50, nullable: false),
                    Date = table.Column<DateTime>(maxLength: 40, nullable: false),
                    Time = table.Column<TimeSpan>(maxLength: 40, nullable: false),
                    Link = table.Column<string>(maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_North", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "South_1",
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
                    table.PrimaryKey("PK_South_1", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "West_1",
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
                    table.PrimaryKey("PK_West_1", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Downtown");

            migrationBuilder.DropTable(
                name: "East_1");

            migrationBuilder.DropTable(
                name: "North");

            migrationBuilder.DropTable(
                name: "South_1");

            migrationBuilder.DropTable(
                name: "West_1");
        }
    }
}
