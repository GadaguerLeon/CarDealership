using Microsoft.EntityFrameworkCore.Migrations;

namespace WebAPI.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cars",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VIN = table.Column<string>(type: "nvarchar(20)", nullable: false),
                    Make = table.Column<string>(type: "nvarchar(20)", nullable: false),
                    Model = table.Column<string>(type: "nvarchar(20)", nullable: false),
                    Color = table.Column<string>(type: "nvarchar(20)", nullable: false),
                    Year = table.Column<int>(type: "int", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(10)", nullable: false),
                    Mileage = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cars", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cars");
        }
    }
}
