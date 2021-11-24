using System.Collections.Generic;
using System.Threading.Tasks;
using Final_project.Areas.Identity.Data;
using Final_project.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace Final_project.Areas.Identity.Pages.Account.Manage
{
    public class PersonalDataModel : PageModel
    {
        private readonly BoardGamesContext _context;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly ILogger<PersonalDataModel> _logger;
        public PersonalDataModel(
            UserManager<ApplicationUser> userManager,
            ILogger<PersonalDataModel> logger, BoardGamesContext context)
        {
            _userManager = userManager;
            _logger = logger;
            _context = context;
        }
        public List<Rental> UserRentals { get; set; }
        public async Task<IActionResult> OnGet()
        {
            var user = await _userManager.GetUserAsync(User);
            UserRentals = new List<Rental>();
            foreach (BoardGame games in _context.BoardGames)
            {
                foreach (Rental rent in _context.Rentals)
                {
                    if (games.BoardGameId == rent.BoardGameId && user.Id == rent.UserId)
                    {
                        if (rent.BoardGames == null)
                        {
                            rent.BoardGames = new List<BoardGame>();
                        }
                        rent.BoardGames.Add(games);
                        UserRentals.Add(rent);
                    }

                }

            }
            if (user == null)
            {
                return NotFound($"Unable to load user with ID '{_userManager.GetUserId(User)}'.");
            }

            return Page();
        }
    }
}