using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using appleMusic.Interfaces;
using appleMusic.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace appleMusic.Controllers
{
    public class TrackController : Controller
    {
        private readonly ILogger<TrackController> _logger;
        private readonly IGenericRepository<Track> _trackRepo;

        public TrackController(ILogger<TrackController> logger, IGenericRepository<Track> trackRepo)
        {
            _logger = logger;
            _trackRepo = trackRepo;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Details(int id)
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}