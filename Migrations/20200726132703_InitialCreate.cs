using Microsoft.EntityFrameworkCore.Migrations;

namespace Garage.Migrations
{
    public partial class InitialCreate : Migration
    {
        // Method to create the database (Will be called with "Update-Database" command)
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Auto",
                columns: table => new
                {
                    AutoId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AutoKenteken = table.Column<string>(nullable: true),
                    AutoMerk = table.Column<string>(nullable: true),
                    AutoType = table.Column<string>(nullable: true),
                    EigenaarNaam = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    // Sets the primary key of the table
                    table.PrimaryKey("PK_Auto", x => x.AutoId);
                });
        }

        // Method reverts the schema changes made by the Up migration.
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Auto");
        }
    }
}
