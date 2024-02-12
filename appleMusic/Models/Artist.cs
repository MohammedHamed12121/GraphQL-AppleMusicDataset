using CsvHelper.Configuration.Attributes;

namespace appleMusic.Models
{
    public class Artist
    {
        [Name("artistId")]
        public int ArtistId { get; set; }
        [Name("artistName")]
        public string? ArtistName { get; set; }
    }

    public class Collection
    {
        [Name("collectionId")]
        public int CollectionId { get; set; }
        [Name("collectionName")]
        public string? CollectionName { get; set; }
        [Name("collectionCensoredName")]
        public string? CollectionCensoredName { get; set; }
        [Name("collectionPrice")]
        public decimal? CollectionPrice { get; set; }
        [Name("contentAdvisoryRating")]
        public string? ContentAdvisoryRating { get; set; }
        [Name("releaseDate")]
        public DateTime ReleaseDate { get; set; }
        [Name("trackCount")]
        public int TrackCount { get; set; }
        [Name("primaryGenreName")]
        public string? PrimaryGenreName { get; set; }
    }

    public class Track
    {
        [Name("trackId")]
        public int TrackId { get; set; }
        [Name("collectionId")]
        public int CollectionId { get; set; }
        [Name("artistId")]
        public int ArtistId { get; set; }
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