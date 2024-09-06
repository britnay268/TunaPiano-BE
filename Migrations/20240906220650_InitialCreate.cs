using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace TunaPiano_BE.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Artists",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Age = table.Column<int>(type: "integer", nullable: false),
                    Bio = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Artists", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Genres",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Description = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genres", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Songs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Title = table.Column<string>(type: "text", nullable: false),
                    ArtistId = table.Column<int>(type: "integer", nullable: false),
                    Album = table.Column<string>(type: "text", nullable: false),
                    Length = table.Column<double>(type: "double precision", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Songs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Songs_Artists_ArtistId",
                        column: x => x.ArtistId,
                        principalTable: "Artists",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GenreSong",
                columns: table => new
                {
                    GenresId = table.Column<int>(type: "integer", nullable: false),
                    SongsId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GenreSong", x => new { x.GenresId, x.SongsId });
                    table.ForeignKey(
                        name: "FK_GenreSong_Genres_GenresId",
                        column: x => x.GenresId,
                        principalTable: "Genres",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GenreSong_Songs_SongsId",
                        column: x => x.SongsId,
                        principalTable: "Songs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Artists",
                columns: new[] { "Id", "Age", "Bio", "Name" },
                values: new object[,]
                {
                    { 1, 32, "Nigerian singer and songwriter known for his fusion of Afrobeat and other genres", "Burna Boy" },
                    { 2, 27, "Nigerian singer and songwriter known for her soulful voice and introspective lyrics", "Tems" },
                    { 3, 55, "French DJ and record producer known for EDM hits", "David Guetta" },
                    { 4, 27, "Dutch DJ and record producer known for his EDM tracks", "Martin Garrix" },
                    { 5, 40, "Legendary jazz trumpeter and composer", "Miles Davis" },
                    { 6, 42, "Saxophonist known for his innovative jazz playing", "John Coltrane" },
                    { 7, 55, "Grammy-winning gospel singer and producer", "Kirk Franklin" },
                    { 8, 40, "Gospel singer known for her powerful vocals", "Tasha Cobbs Leonard" }
                });

            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "Id", "Description" },
                values: new object[,]
                {
                    { 1, "Afrobeat" },
                    { 2, "EDM" },
                    { 3, "Jazz" },
                    { 4, "Gospel" }
                });

            migrationBuilder.InsertData(
                table: "Songs",
                columns: new[] { "Id", "Album", "ArtistId", "Length", "Title" },
                values: new object[,]
                {
                    { 1, "Love, Damini", 1, 240.5, "Last Last" },
                    { 2, "If Orange Was the Color of Sky", 2, 210.19999999999999, "Free Mind" },
                    { 3, "Nothing But the Beat", 3, 270.80000000000001, "Play Hard" },
                    { 4, "Animals", 4, 255.30000000000001, "Animals" },
                    { 5, "Kind of Blue", 5, 300.0, "So What" },
                    { 6, "Giant Steps", 6, 285.69999999999999, "Giant Steps" },
                    { 7, "The Rebirth", 7, 220.09999999999999, "Stomp" },
                    { 8, "Grace", 8, 235.59999999999999, "Break Every Chain" },
                    { 9, "Twice as Tall", 1, 260.89999999999998, "Ye" },
                    { 10, "If Orange Was the Color of Sky", 2, 200.40000000000001, "Vibez" },
                    { 11, "Nothing But the Beat", 3, 290.19999999999999, "Titanium" },
                    { 12, "Animals", 4, 275.5, "In My Mind" },
                    { 13, "Kind of Blue", 5, 310.69999999999999, "So What" },
                    { 14, "Giant Steps", 6, 295.10000000000002, "Giant Steps" },
                    { 15, "The Rebirth", 7, 215.80000000000001, "Stomp" },
                    { 16, "Grace", 8, 230.30000000000001, "Break Every Chain" },
                    { 17, "Twice as Tall", 1, 250.59999999999999, "On The Low" },
                    { 18, "If Orange Was the Color of Sky", 2, 190.09999999999999, "For Now" },
                    { 19, "Nothing But the Beat", 3, 280.39999999999998, "When Love Takes Over" },
                    { 20, "Animals", 4, 265.69999999999999, "Animals" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_GenreSong_SongsId",
                table: "GenreSong",
                column: "SongsId");

            migrationBuilder.CreateIndex(
                name: "IX_Songs_ArtistId",
                table: "Songs",
                column: "ArtistId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GenreSong");

            migrationBuilder.DropTable(
                name: "Genres");

            migrationBuilder.DropTable(
                name: "Songs");

            migrationBuilder.DropTable(
                name: "Artists");
        }
    }
}
