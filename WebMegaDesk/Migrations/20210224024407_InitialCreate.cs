using Microsoft.EntityFrameworkCore.Migrations;

namespace WebMegaDesk.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Quote",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerFirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CustomerLastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeskWidth = table.Column<double>(type: "float", nullable: false),
                    DeskDepth = table.Column<double>(type: "float", nullable: false),
                    DeskDrawerNumber = table.Column<int>(type: "int", nullable: false),
                    DesktopMaterial = table.Column<int>(type: "int", nullable: false),
                    RushSpeed = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Quote", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Quote");
        }
    }
}
