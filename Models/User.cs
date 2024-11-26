using System.ComponentModel.DataAnnotations;

namespace LitList.Models;

public class User 
{
    public int UserID {get; set;} // Primary key

    public string Name {get; set;} = string.Empty;

    [Display(Name = "Date Joined")]
    [DataType(DataType.Date)]
    public DateTime DateJoined {get; set;}

    public string Bio {get; set;} = string.Empty;

    [Display(Name = "Books Read")]
    public List<UserBook>? UserBooks {get; set;} = default!;
}