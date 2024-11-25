using System.ComponentModel.DataAnnotations;

namespace LitList.Models;

public class Book 
{
    public int BookID {get; set;} // Primary key

    public string Title {get; set;} = string.Empty;

    public string Author {get; set;} = string.Empty;

    public int Pages {get; set;}

    public string Genre {get; set;} = string.Empty;

    public List<UserBook>? UserBooks {get; set;} = default!;

}