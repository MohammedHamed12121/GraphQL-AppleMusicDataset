using CsvHelper.Configuration.Attributes;

namespace appleMusic.Models
{
    public class Collection
    {
        [Name("collectionId")]
        public int Id { get; set; }
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
        [Name("artistId")]
        public int ArtistId { get; set; }
        public Artist? Artist { get; set; }
    }


}