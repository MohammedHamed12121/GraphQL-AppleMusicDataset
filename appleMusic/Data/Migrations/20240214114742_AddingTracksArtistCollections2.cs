using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace appleMusic.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddingTracksArtistCollections2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "TrackId",
                table: "Tracks",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "CollectionId",
                table: "Collections",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "ArtistId",
                table: "Artists",
                newName: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Tracks",
                newName: "TrackId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Collections",
                newName: "CollectionId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Artists",
                newName: "ArtistId");
        }
    }
}
