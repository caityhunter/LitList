using Microsoft.EntityFrameworkCore;

namespace LitList.Models;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<UserBook>().HasKey(s => new {s.UserID, s.BookID});
    }

    public DbSet<User> Users {get; set;}
    public DbSet<Book> Books {get; set;}
    public DbSet<UserBook> UserBooks {get; set;}
}