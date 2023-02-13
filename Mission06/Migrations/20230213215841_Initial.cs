using Microsoft.EntityFrameworkCore.Migrations;

namespace Mission06.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "responses",
                columns: table => new
                {
                    ApplicationID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    title = table.Column<string>(nullable: false),
                    category = table.Column<string>(nullable: false),
                    year = table.Column<int>(nullable: false),
                    rating = table.Column<string>(nullable: false),
                    director = table.Column<string>(nullable: false),
                    edit = table.Column<bool>(nullable: false),
                    lent = table.Column<string>(nullable: true),
                    notes = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_responses", x => x.ApplicationID);
                });

            migrationBuilder.InsertData(
                table: "responses",
                columns: new[] { "ApplicationID", "category", "director", "edit", "lent", "notes", "rating", "title", "year" },
                values: new object[] { 1, "Action/Adventure", "Pete Docter", false, "Prof Hilton", "Section 3 is the Best!", "PG", "UP", 2009 });

            migrationBuilder.InsertData(
                table: "responses",
                columns: new[] { "ApplicationID", "category", "director", "edit", "lent", "notes", "rating", "title", "year" },
                values: new object[] { 2, "Horrer/Suspense", "John Krasinski", false, null, null, "PG-13", "A Quiet Place", 2018 });

            migrationBuilder.InsertData(
                table: "responses",
                columns: new[] { "ApplicationID", "category", "director", "edit", "lent", "notes", "rating", "title", "year" },
                values: new object[] { 3, "Comedy", "Daniel Kwan", true, null, null, "R", "Everything Everywhere All at Once", 2022 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "responses");
        }
    }
}
