using System.ComponentModel.DataAnnotations;

namespace LitList.Models;

public class UserBook 
{
    public int UserID {get; set;}
    public int BookID {get; set;}
    public User User {get; set;} = default!;
    public Book Book {get; set;} = default!;
}