using AspNetCoreSecondProject.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace AspNetCoreSecondProject.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            Author author = new Author
            {
                Name = "Eylem",
                BookCount = 50,
                Nickname = "Ariel Prenses",
                Surname = "BAKCA"
            };
            List<Author> authors = new List<Author>
            {
                new(){Name = "Melih Ömer",Surname = "KAMAR",Nickname="kamar",BookCount=123},
                new(){Name = "Mustafa",Surname = "BAYÇÖL",Nickname="baycol",BookCount=12},
                new(){Name = "EfeCan",Surname = "CÖRÜT",Nickname="corut",BookCount=125},
                new(){Name = "Berkant",Surname = "YILMAZ",Nickname="yilmaz",BookCount=1234},
                new(){Name = "Eylem",Surname = "BAKCA",Nickname="Ariel Prenses",BookCount=55},
            };
            
            AuthorInfoAndListVM model = new()
            {
                 Author = author,
                 Authors = authors
            };
            return View(model);
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
}
