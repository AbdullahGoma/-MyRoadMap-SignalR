using ChatApp.Data;
using ChatApp.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace ChatApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        public readonly ApplicationDbContext context;
        public readonly UserManager<AppUser> userManager;

        public HomeController(ILogger<HomeController> logger, ApplicationDbContext _context, UserManager<AppUser> _userManager)
        {
            _logger = logger;
            context = _context;
            userManager = _userManager;
        }

        public async Task<IActionResult> Index()
        {
            var currentUser = await userManager.GetUserAsync(User);
            ViewBag.CurrentUserName = currentUser.UserName;
            var messages = await context.Messages.ToListAsync();
            return View();
        }


        public async Task<IActionResult> Create(Message message)
        {
            if(ModelState.IsValid)
            {
                message.UserName = User.Identity.Name;
                var sender = await userManager.GetUserAsync(User);
                message.UserID = sender.Id;
                await context.Messages.AddAsync(message);
                await context.SaveChangesAsync();
                return Ok();
            }
            return Error();
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