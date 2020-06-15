using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DeadwoodAPI.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Survey",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    enviroGroup = table.Column<bool>(nullable: false),
                    performedSurveyBefore = table.Column<bool>(nullable: false),
                    woodlandName = table.Column<string>(nullable: true),
                    latitude = table.Column<string>(nullable: true),
                    longitude = table.Column<string>(nullable: true),
                    gridRef = table.Column<string>(nullable: true),
                    woodlandSize = table.Column<double>(nullable: false),
                    deadwoodStandingOrLying = table.Column<string>(nullable: true),
                    deadwoodDiameter = table.Column<double>(nullable: false),
                    deadwoodLenght = table.Column<double>(nullable: false),
                    deadwoodSpecies = table.Column<string>(nullable: true),
                    holesInDeadwood = table.Column<string>(nullable: true),
                    floraOnDeadwood = table.Column<string>(nullable: true),
                    faunaOnDeadwood = table.Column<string>(nullable: true),
                    pencilDepth = table.Column<double>(nullable: false),
                    deadwoodSoftness = table.Column<string>(nullable: true),
                    faunaInDeadwood = table.Column<string>(nullable: true),
                    deadwoodColour = table.Column<string>(nullable: true),
                    stateOfDecay = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Survey", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Survey");
        }
    }
}
