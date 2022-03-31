using Microsoft.EntityFrameworkCore.Migrations;

namespace Labb4.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Persons",
                columns: table => new
                {
                    PersonID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    firstName = table.Column<string>(nullable: true),
                    lastName = table.Column<string>(nullable: true),
                    phoneNr = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Persons", x => x.PersonID);
                });

            migrationBuilder.CreateTable(
                name: "Interests",
                columns: table => new
                {
                    interestID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    interestName = table.Column<string>(nullable: true),
                    details = table.Column<string>(nullable: true),
                    PersonID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Interests", x => x.interestID);
                    table.ForeignKey(
                        name: "FK_Interests_Persons_PersonID",
                        column: x => x.PersonID,
                        principalTable: "Persons",
                        principalColumn: "PersonID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "websites",
                columns: table => new
                {
                    WebpageID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Webpage = table.Column<string>(nullable: true),
                    interestsinterestID = table.Column<int>(nullable: true),
                    InterestID = table.Column<int>(nullable: false),
                    PersonID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_websites", x => x.WebpageID);
                    table.ForeignKey(
                        name: "FK_websites_Persons_PersonID",
                        column: x => x.PersonID,
                        principalTable: "Persons",
                        principalColumn: "PersonID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_websites_Interests_interestsinterestID",
                        column: x => x.interestsinterestID,
                        principalTable: "Interests",
                        principalColumn: "interestID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Persons",
                columns: new[] { "PersonID", "firstName", "lastName", "phoneNr" },
                values: new object[] { 1, "Ludwig", "Oleby", "0736004656" });

            migrationBuilder.InsertData(
                table: "Persons",
                columns: new[] { "PersonID", "firstName", "lastName", "phoneNr" },
                values: new object[] { 2, "Sara", "Sarasson", "0736004657" });

            migrationBuilder.InsertData(
                table: "Persons",
                columns: new[] { "PersonID", "firstName", "lastName", "phoneNr" },
                values: new object[] { 3, "Sam", "Samson", "0736004658" });

            migrationBuilder.InsertData(
                table: "Interests",
                columns: new[] { "interestID", "PersonID", "details", "interestName" },
                values: new object[,]
                {
                    { 1, 1, "The fine art of making console applications", "C#" },
                    { 4, 1, "Getting matched with bad teammates and loose games", "Overwatch" },
                    { 2, 2, "Identifying and managing problems in a relationship", "SQL" },
                    { 3, 3, "Eliminates various bugs", "Exterminator" }
                });

            migrationBuilder.InsertData(
                table: "websites",
                columns: new[] { "WebpageID", "InterestID", "PersonID", "Webpage", "interestsinterestID" },
                values: new object[,]
                {
                    { 2, 2, 1, "www.playoverwatch.com", null },
                    { 3, 3, 2, "www.sql.se", null },
                    { 4, 4, 3, "www.bugs.com", null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Interests_PersonID",
                table: "Interests",
                column: "PersonID");

            migrationBuilder.CreateIndex(
                name: "IX_websites_PersonID",
                table: "websites",
                column: "PersonID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_websites_interestsinterestID",
                table: "websites",
                column: "interestsinterestID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "websites");

            migrationBuilder.DropTable(
                name: "Interests");

            migrationBuilder.DropTable(
                name: "Persons");
        }
    }
}
