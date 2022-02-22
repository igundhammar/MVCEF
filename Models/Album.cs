using System.ComponentModel.DataAnnotations;

namespace CDCollection.Models;

public class Album
{
    public int Id { get; set; }
    [Required]
    public string? Name { get; set; }
    [Required]
    public int Year { get; set; }
    [Required]
    public string? Genre { get; set; }
    [Required]
    
    [Display(Name="Artist")]
    public int ArtistId { get; set; }
    public Artist? Artist { get; set; }
}