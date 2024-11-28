using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using LitList.Models;
using System.ComponentModel.DataAnnotations;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.AspNetCore.Mvc.Rendering;

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

        [BindProperty]
        [Required]
        public int BookIDToAdd {get; set;}
        public SelectList BooksDropDown {get; set;} = default!;
        public IActionResult OnPostRemoveBook (int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var user = _context.Users.Include(u => u.UserBooks!).ThenInclude(ub => ub.Book).FirstOrDefault(m => m.UserID == id);

            if (user == null)
            {
                return NotFound();
            }
            else
            {
                User = user;
            }
            BooksDropDown = new SelectList(_context.Books.ToList().OrderBy(b => b.Title), "BookID", "Title");

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

                BooksDropDown = new SelectList(_context.Books.ToList().OrderBy(b => b.Title), "BookID", "Title");

                return Page();
            }

            return NotFound();
        }

        public IActionResult OnPostAddBook(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var user = _context.Users.Include(u => u.UserBooks!).ThenInclude(ub => ub.Book).FirstOrDefault(m => m.UserID == id);

            if (user == null)
            {
                return NotFound();
            }
            else
            {
                User = user;
            }

            BooksDropDown = new SelectList(_context.Books.ToList().OrderBy(b => b.Title), "BookID", "Title");

            if (!ModelState.IsValid)
            {
                return Page();
            }

            if(!_context.UserBooks.Any(ub => ub.BookID == BookIDToAdd && ub.UserID == id))
            {
                UserBook bookToAdd = new UserBook {UserID = id.Value, BookID = BookIDToAdd};
                _context.Add(bookToAdd);
                _context.SaveChanges();
            }

            return Page();
        }
    }
}
