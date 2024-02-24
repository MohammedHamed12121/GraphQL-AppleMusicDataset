using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using appleMusic.Interfaces;
using appleMusic.Models;
using HotChocolate;

namespace appleMusic.Queries
{
    public class Query
    {
        public async Task<IEnumerable<Track>> GetTracks([Service]IGenericRepository<Track> tracksService)
        {
            return await tracksService.GetAllAsync();
        }       
    }
}