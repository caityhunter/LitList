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
    public class IndexModel : PageModel
    {
        private readonly LitList.Models.AppDbContext _context;

        [BindProperty(SupportsGet = true)]
        public int PageNum {get; set;} = 1;
        public int PageSize {get; set;} = 5;
        public int TotalPages {get; set;}

        public IndexModel(LitList.Models.AppDbContext context)
        {
            _context = context;
        }

        public IList<User> User { get;set; } = default!;

        public async Task OnGetAsync()
        {
            TotalPages = (int)Math.Ceiling(_context.Users.Count() / (double)PageSize);

            User = await _context.Users.Include(u => u.UserBooks!).ThenInclude(ub => ub.Book)
                .Skip((PageNum-1)*PageSize).Take(PageSize).ToListAsync();
        }
    }
}
