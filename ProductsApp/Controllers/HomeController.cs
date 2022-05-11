using Microsoft.AspNetCore.Mvc;
using ProductsApp.Data;
using ProductsApp.Models;
using System.Diagnostics;

namespace ProductsApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        //private readonly WProductsDBContext _context;

        //public HomeController(WProductsDBContext context)
        //{
        //    _context = context;
        //}

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
           // _context = context;
        }

        //public HomeController(ILogger<HomeController> logger, WProductsDBContext context)
        //{
        //    _logger = logger;
        //    // _context = context;
        //}

        public IActionResult Index()
        {
            return View();
        }
        //public IActionResult Index()
        //{

        //    //WProductsDBContext wp = new WProductsDBContext();
        //    var top = _context.Product.ToList();

        //    ViewData["higherthan150"] = top;
        //    return View();
        //}


        //public IEnumerable<Product> GetProducts()
        //{
        //    return _context.Product.ToList();
        //}

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