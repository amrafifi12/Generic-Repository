using Generic_Repository.Models;
using Generic_Repository.Repository;
using GR.Data.Models;
using Microsoft.AspNetCore.Mvc;

using System.Diagnostics;

namespace GR.Data.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IRepository<Book> BookRepo;
        private readonly IRepository<Author> AuthorRepo;


        public HomeController(ILogger<HomeController> logger, IRepository<Author> authorRepo,IRepository<Book> bookrepo)
        {
            _logger = logger;
            BookRepo=bookrepo;
        }

        public IActionResult Index()
        {
            var book = BookRepo.Get(1);
            return View(book);
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