using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SNDI.Areas.Identity.Data;
using SNDI.Data;
using SNDI.Models;
using System.Diagnostics;

namespace SNDI.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        private readonly SNDIContext _context;
        private readonly ILogger<HomeController> _logger;
        private readonly UserManager<SNDIUser> _userManager;
        public HomeController(SNDIContext context,ILogger<HomeController> logger, UserManager<SNDIUser> userManager)
        {
            _logger = logger;
            this._userManager = userManager;
            _context = context;
        }

       
        public IActionResult Index()
        {
            ViewData["UserID"]=_userManager.GetUserId(this.User);
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult DataComplet()
        {
            var enregistrements = _context.Enregistrer
                .Include(e => e.Document) // Charge l'objet Document associé
                .Include(e => e.Filiation) // Charge l'objet Filiation associé
                .ToList();

            return View(enregistrements);
        }




        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}