using CsvHelper.Configuration.Attributes;

namespace appleMusic.Models
{
    public class Artist
    {
        [Name("artistId")]
        public int Id { get; set; }
        [Name("artistName")]
        public string? ArtistName { get; set; }
        // [Name("collectionId")]
        // public int CollectionId { get; set; }
        public List<Collection>? Collections { get; set; }
    }

}