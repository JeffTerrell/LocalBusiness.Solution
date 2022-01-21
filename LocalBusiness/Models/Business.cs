using System.ComponentModel.DataAnnotations;

namespace LocalBusiness.Models
{
  public class Business
  {
    public int BusinessId { get; set; }
    [Required]
    [StringLength(30)]
    public string Name { get; set; }
    public string StreetAddress { get; set; }
    public string City { get; set; }
    public string State { get; set; }
    public string County { get; set; }
    [Required]
    public string Type { get; set; }
    public string Category { get; set; }
    [Range(1, 5, ErrorMessage = "Price level must be between 1 and 5")]
    public int Price { get; set; }
    public string Review { get; set; }
    [Range(1, 5, ErrorMessage = "Rating must be between 1 and 5")]
    public int Rating { get; set; }
  }
}