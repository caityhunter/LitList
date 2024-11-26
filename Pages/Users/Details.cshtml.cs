using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using LitList.Models;

namespace LitList.Pages_Users
{
    public class DetailsModel : PageModel
    {
        private readonly LitList.Models.AppDbContext _context;

        public DetailsModel(LitList.Models.AppDbContext context)
        {
            _context = context;
        }

        public User User { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var user = await _context.Users.Include(u => u.UserBooks!).ThenInclude(ub => ub.Book).FirstOrDefaultAsync(m => m.UserID == id);

            if (user is not null)
            {
                User = user;

                return Page();
            }

            return NotFound();
        }
    }
}
