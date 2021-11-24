using Final_project.Data;
using Final_project.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Final_project.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        private readonly AuthDbContext _authContext;
        private readonly BoardGamesContext _context;
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger , BoardGamesContext context , AuthDbContext authContext)
        {
            _logger = logger;
            _context = context;
            _authContext = authContext;
        }

        public async Task<IActionResult> IndexAsync()
        { 
            return View(await _context.BoardGames.ToListAsync());
        }

        public IActionResult Privacy()
        {
            return View();
        }
    }
}
