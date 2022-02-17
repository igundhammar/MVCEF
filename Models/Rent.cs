using System.ComponentModel.DataAnnotations;

namespace CDCollection.Models;

public class Rent
{
    public int Id { get; set; }
    [Display(Name="First Name")]
    public string? FirstName { get; set; }
    [Display(Name="Last Name")]
    public string? LastName { get; set; }
    public DateTime Date { get; set; }
    
    [Display(Name="Album Name")]
    public int AlbumId { get; set; }
    public Album? Album { get; set; }
}