using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace appleMusic.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddingTracksArtistCollections : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Artists",
                columns: table => new
                {
                    ArtistId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ArtistName = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Artists", x => x.ArtistId);
                });

            migrationBuilder.CreateTable(
                name: "Collections",
                columns: table => new
                {
                    CollectionId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CollectionName = table.Column<string>(type: "TEXT", nullable: true),
                    CollectionCensoredName = table.Column<string>(type: "TEXT", nullable: true),
                    CollectionPrice = table.Column<decimal>(type: "TEXT", nullable: true),
                    ContentAdvisoryRating = table.Column<string>(type: "TEXT", nullable: true),
                    ReleaseDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    TrackCount = table.Column<int>(type: "INTEGER", nullable: false),
                    PrimaryGenreName = table.Column<string>(type: "TEXT", nullable: true),
                    ArtistId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Collections", x => x.CollectionId);
                    table.ForeignKey(
                        name: "FK_Collections_Artists_ArtistId",
                        column: x => x.ArtistId,
                        principalTable: "Artists",
                        principalColumn: "ArtistId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Tracks",
                columns: table => new
                {
                    TrackId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CollectionId = table.Column<int>(type: "INTEGER", nullable: false),
                    ArtistId = table.Column<int>(type: "INTEGER", nullable: false),
                    TrackName = table.Column<string>(type: "TEXT", nullable: true),
                    TrackCensoredName = table.Column<string>(type: "TEXT", nullable: true),
                    TrackPrice = table.Column<decimal>(type: "TEXT", nullable: true),
                    TrackNumber = table.Column<int>(type: "INTEGER", nullable: false),
                    DiscNumber = table.Column<int>(type: "INTEGER", nullable: false),
                    Kind = table.Column<string>(type: "TEXT", nullable: true),
                    TrackTimeMillis = table.Column<int>(type: "INTEGER", nullable: false),
                    IsStreamable = table.Column<bool>(type: "INTEGER", nullable: true),
                    TrackExplicitness = table.Column<string>(type: "TEXT", nullable: true),
                    PreviewUrl = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tracks", x => x.TrackId);
                    table.ForeignKey(
                        name: "FK_Tracks_Artists_ArtistId",
                        column: x => x.ArtistId,
                        principalTable: "Artists",
                        principalColumn: "ArtistId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Tracks_Collections_CollectionId",
                        column: x => x.CollectionId,
                        principalTable: "Collections",
                        principalColumn: "CollectionId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Collections_ArtistId",
                table: "Collections",
                column: "ArtistId");

            migrationBuilder.CreateIndex(
                name: "IX_Tracks_ArtistId",
                table: "Tracks",
                column: "ArtistId");

            migrationBuilder.CreateIndex(
                name: "IX_Tracks_CollectionId",
                table: "Tracks",
                column: "CollectionId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tracks");

            migrationBuilder.DropTable(
                name: "Collections");

            migrationBuilder.DropTable(
                name: "Artists");
        }
    }
}
