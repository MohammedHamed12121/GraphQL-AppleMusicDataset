using CsvHelper.Configuration.Attributes;

namespace appleMusic.Models
{
    public class Track
    {
        [Name("trackId")]
        public int Id { get; set; }
        [Name("collectionId")]
        public int CollectionId { get; set; }
        public Collection? Collection { get; set; }
        [Name("artistId")]
        public int ArtistId { get; set; }
        public Artist? Artist { get; set; }
        [Name("trackName")]
        public string? TrackName { get; set; }
        [Name("trackCensoredName")]
        public string? TrackCensoredName { get; set; }
        [Name("trackPrice")]
        public decimal? TrackPrice { get; set; }
        [Name("trackNumber")]
        public int TrackNumber { get; set; }
        [Name("discNumber")]
        public int DiscNumber { get; set; }
        [Name("kind")]
        public string? Kind { get; set; }
        [Name("trackTimeMillis")]
        public int TrackTimeMillis { get; set; }
        [Name("isStreamable")]
        public bool? IsStreamable { get; set; }
        [Name("trackExplicitness")]
        public string? TrackExplicitness { get; set; }
        [Name("previewUrl")]
        public string? PreviewUrl { get; set; }
    }


}