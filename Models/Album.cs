using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography;

namespace CDCollection.Models;

public class Album
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public int Year { get; set; }
    public string? Genre { get; set; }
    
    [Display(Name="Artist")]
    public int ArtistId { get; set; }
    public Artist? Artist { get; set; }
}