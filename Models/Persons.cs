using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
namespace Models;
public class Persons {

    [Key]
    public int PersonId { get; set;}
    public string? LastName { get; set; }
    public string? FirstName { get; set; }
    public int Age { get; set; }
}
