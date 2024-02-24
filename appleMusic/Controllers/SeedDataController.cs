using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using appleMusic.Data;
using appleMusic.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace appleMusic.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SeedDataController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        private CsvReader _csvReader;
        private string filePath = "apple_music_dataset.csv";
        public List<Artist> artists { get; set; }
        List<Collection> collections { get; set; }
        List<Track> tracks { get; set; }

        public SeedDataController(CsvReader csvReader, ApplicationDbContext context)
        {
            _csvReader = csvReader;
            artists = _csvReader.Read<Artist>(filePath);
            collections = _csvReader.Read<Collection>(filePath);
            tracks = _csvReader.Read<Track>(filePath);
            _context = context;
        }
        // [HttpGet("/")]
        // public IActionResult Index()
        // {
        //     foreach (var a in artists)
        //     {
        //         var newArtist = new Artist
        //         {
        //             Id = a.Id,
        //             ArtistName = a.ArtistName
        //         };
        //         if (_context.Artists.Where(a => a.Id == newArtist.Id).AsNoTracking().FirstOrDefault() == null)
        //         {
        //             _context.Artists.Add(newArtist);
        //             _context.SaveChanges();
        //         }
        //     }
        //     return Ok("track added");
        // }

        // [HttpGet("/")]
        // public IActionResult Index()
        // {
        //     foreach(var c in collections)
        //     {
        //         var newcol = new Collection{
        //             Id                          = c.Id,
        //             CollectionName              = c.CollectionName,
        //             CollectionCensoredName      = c.CollectionCensoredName,
        //             CollectionPrice             = c.CollectionPrice,
        //             ContentAdvisoryRating       = c.ContentAdvisoryRating,
        //             ReleaseDate                 = c.ReleaseDate,
        //             TrackCount                  = c.TrackCount,
        //             PrimaryGenreName            = c.PrimaryGenreName,
        //             ArtistId                    =c.ArtistId
        //         };
        //         if( _context.Collections.Where(a => a.Id == newcol.Id).AsNoTracking().FirstOrDefault() == null)
        //         {
        //             _context.Collections.Add(newcol);
        //             _context.SaveChanges();
        //         }
        //     }
        //     return Ok("col added");
        // }

        // [HttpGet("/")]
        // public IActionResult Index()
        // {
        //     foreach(var t in tracks)
        //     {
        //         var newtrack = new Track{
        //             Id                          = t.Id,
        //             CollectionId                = t.CollectionId,
        //             ArtistId                    = t.ArtistId,
        //             TrackName                   = t.TrackName,
        //             TrackCensoredName           = t.TrackCensoredName,
        //             TrackPrice                  = t.TrackPrice,
        //             TrackNumber                 = t.TrackNumber,
        //             DiscNumber                  = t.DiscNumber,
        //             Kind                        = t.Kind,
        //             TrackTimeMillis             = t.TrackTimeMillis,
        //             TrackExplicitness           = t.TrackExplicitness,
        //             PreviewUrl                  = t.PreviewUrl
        //         };
        //         if( _context.Tracks.Where(a => a.Id == newtrack.Id).AsNoTracking().FirstOrDefault() == null)
        //         {
        //             _context.Tracks.Add(newtrack);
        //             _context.SaveChanges();
        //         }
        //     }
        //     return Ok("track added");
        // }

    }
}