using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Yggdrasil.Migrations
{
    public partial class Migration2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Profesors",
                columns: table => new
                {
                    IdProfesor = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameProfesor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EnrollDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Profesors", x => x.IdProfesor);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Profesors");
        }
    }
}
