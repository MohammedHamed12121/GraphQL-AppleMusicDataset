using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using appleMusic.Models;
using appleMusic.Interfaces;

namespace appleMusic.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly IGenericRepository<Track> _trackRepo;


    public HomeController(ILogger<HomeController> logger, IGenericRepository<Track> trackRepo)
    {
        _logger = logger;
        _trackRepo = trackRepo;
    }

    public async Task<IActionResult> Index()
    {
        var tracks = await _trackRepo.GetAllWithIncludeAsync(t => t.Artist);
        return View(tracks);
    }

    

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
