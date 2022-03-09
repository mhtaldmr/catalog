using Microsoft.EntityFrameworkCore.Migrations;

namespace Vega.Migrations
{
    public partial class seedsForFeatures2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Features (Name) VALUES ('Feature2') ");
            migrationBuilder.Sql("INSERT INTO Features (Name) VALUES ('Feature3') ");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Features Where (Name) IN ('Feature2','Feature3' ");

        }
    }
}
