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

        [BindProperty]
        public User User { get; set; } = default!;

        [BindProperty]
        public int BookIDToDelete {get; set;}

        public IActionResult OnPostRemoveBook (int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var user = _context.Users.Include(u => u.UserBooks).ThenInclude(ub => ub.Book).FirstOrDefault(m => m.UserID == id);

            if (user == null)
            {
                return NotFound();
            }
            else
            {
                User = user;
            }
            // BookDropDown = new SelectList(_context.Books.ToList(), "BookID", "Title");

            var bookToRemove = _context.UserBooks.Find(BookIDToDelete, id);

            if (bookToRemove != null)
            {
                _context.Remove(bookToRemove);
                _context.SaveChanges();
            }

            return RedirectToPage(new {id = id});

        }


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
