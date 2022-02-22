using System.ComponentModel.DataAnnotations;
namespace CDCollection.Models;

public class Rent
{
    public int Id { get; set; }
    [Required]
    [Display(Name="First Name")]
    public string? FirstName { get; set; }
    [Required]
    [Display(Name="Last Name")]
    public string? LastName { get; set; }
    
    [Required]
    [DisplayFormat(DataFormatString = "{0:U}")]
    public DateTime Date { get; set; }
    [Required]
    
    [Display(Name="Album Name")]
    public int AlbumId { get; set; }
    public Album? Album { get; set; }
}