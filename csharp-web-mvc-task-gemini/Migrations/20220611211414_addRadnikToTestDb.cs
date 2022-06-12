using Microsoft.EntityFrameworkCore.Migrations;

namespace csharp_web_mvc_task_gemini.Migrations
{
    public partial class addRadnikToTestDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Radnici",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ime = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Prezime = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Adresa = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NetoPlata = table.Column<float>(type: "real", nullable: false),
                    BrutoPlata = table.Column<float>(type: "real", nullable: false),
                    PIO = table.Column<float>(type: "real", nullable: false),
                    Zdravstveno = table.Column<float>(type: "real", nullable: false),
                    Nezaposlenost = table.Column<float>(type: "real", nullable: false),
                    PIOPoslodavac = table.Column<float>(type: "real", nullable: false),
                    ZdravstvenoPoslodavac = table.Column<float>(type: "real", nullable: false),
                    NezaposlenostPoslodavac = table.Column<float>(type: "real", nullable: false),
                    UkupniTroskovi = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Radnici", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Radnici");
        }
    }
}
