using Microsoft.AspNetCore.Mvc;
using RequestApi.Client;
using RequestApi.Models;
using System.Diagnostics;

namespace RequestApi.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IServiceClient _client;

        public HomeController(ILogger<HomeController> logger, IServiceClient client)
        {
            _logger = logger;
            _client = client;
        }

        public async Task<IActionResult> Index()
        {
            var model = await _client.GetAllUser();
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