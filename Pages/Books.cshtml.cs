using LitList.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace LitList.Pages;

public class BooksModel : PageModel
{
    private readonly LitList.Models.AppDbContext _context;
    private readonly ILogger<BooksModel> _logger;

    [BindProperty(SupportsGet = true)]
    public string CurrentSort {get; set;} = string.Empty;

    public BooksModel(LitList.Models.AppDbContext context)
    {
        _context = context;
    }

    public IList<Book> Book { get;set; } = default!;

    public async Task OnGetAsync()
    {
        var query = _context.Books.Select(s => s);

        switch (CurrentSort)
        {
            case "title_asc":
                query = query.OrderBy(s => s.Title);
                break;
            case "title_desc":
                query = query.OrderByDescending(s => s.Title);
                break;
            case "author_asc":
                query = query.OrderBy(s => s.Author);
                break;
            case "author_desc":
                query = query.OrderByDescending(s => s.Author);
                break;
            case "genre_asc":
                query = query.OrderBy(s => s.Genre);
                break;
            case "genre_desc":
                query = query.OrderByDescending(s => s.Genre);
                break;
            case "pages_asc":
                query = query.OrderBy(s => s.Pages);
                break;
            case "pages_desc":
                query = query.OrderByDescending(s => s.Pages);
                break;
        }
                Book = await query.ToListAsync();
    }
}
