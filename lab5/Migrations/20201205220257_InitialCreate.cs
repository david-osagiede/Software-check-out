using Microsoft.EntityFrameworkCore.Migrations;

namespace lab5.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migration builder that creates the table using the software info
            migrationBuilder.CreateTable(
                name: "Software",
                columns: table => new
                {
                    softwareID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    make = table.Column<string>(nullable: true),
                    model = table.Column<string>(nullable: true),
                    year = table.Column<int>(nullable: false),
                    price = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Software", x => x.softwareID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Software");
        }
    }
}
