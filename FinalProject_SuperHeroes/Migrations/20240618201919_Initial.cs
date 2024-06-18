using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FinalProject_SuperHeroes.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SuperHeroes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SuperName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SuperPower = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Strength = table.Column<int>(type: "int", nullable: false),
                    IsTeam = table.Column<bool>(type: "bit", nullable: false),
                    VillainName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SuperHeroes", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SuperHeroes");
        }
    }
}
