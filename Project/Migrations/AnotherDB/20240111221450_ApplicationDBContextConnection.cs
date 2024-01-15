using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Project.Migrations.AnotherDB
{
    /// <inheritdoc />
    public partial class ApplicationDBContextConnection : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clubs",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(30)", nullable: false),
                    city = table.Column<string>(type: "nvarchar(30)", nullable: false),
                    street = table.Column<string>(type: "nvarchar(30)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clubs", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Opinions",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    text = table.Column<string>(type: "nvarchar(500)", nullable: false),
                    rateNumber = table.Column<int>(type: "int", nullable: false),
                    clubID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Opinions", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Passes",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(30)", nullable: false),
                    price = table.Column<int>(type: "int", nullable: false),
                    numberOfEntries = table.Column<int>(type: "int", nullable: false),
                    numberOfAvailableClubs = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Passes", x => x.ID);
                });

            migrationBuilder.InsertData(
                table: "Clubs",
                columns: new[] { "ID", "city", "name", "street" },
                values: new object[,]
                {
                    { 1, "Kraków", "Crossfit Box", "Długa 12" },
                    { 2, "Kraków", "Hells gym", "Krótka 65C" },
                    { 3, "Warszawa", "Poland Mountain", "Pokątna 12" },
                    { 4, "Sosnowiec", "Rainbow Park", "Sezamkowa 2137" }
                });

            migrationBuilder.InsertData(
                table: "Opinions",
                columns: new[] { "ID", "clubID", "rateNumber", "text" },
                values: new object[,]
                {
                    { 1, 1, 5, "The gym's extensive and modern equipment receives a top rating for providing a well-rounded fitness experience, suitable for all levels." },
                    { 2, 1, 4, "The energetic atmosphere and motivational decor contribute positively to the workout environment, though there is always room for enhancement." },
                    { 3, 2, 5, "The staff's friendliness and expertise in guiding members through workouts earn a high rating, ensuring a safe and effective exercise routine." },
                    { 4, 2, 4, "The gym's commitment to cleanliness is commendable, but there might be occasional improvements needed to maintain a consistently spotless environment." },
                    { 5, 3, 5, "Offering diverse fitness classes and programs for all interests and skill levels earns top marks for keeping workouts engaging and challenging." },
                    { 6, 3, 5, "The gym's extended hours receive high praise for accommodating a variety of schedules, ensuring members can conveniently fit in their workouts." },
                    { 7, 4, 4, "The gym's efforts to build a sense of community among members are appreciated, though there is some room for additional engagement and connection opportunities." },
                    { 8, 4, 5, "Considering the facilities, services, and overall experience, the gym offers excellent value for money, justifying the membership fees with its high-quality offerings." }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Clubs");

            migrationBuilder.DropTable(
                name: "Opinions");

            migrationBuilder.DropTable(
                name: "Passes");
        }
    }
}
