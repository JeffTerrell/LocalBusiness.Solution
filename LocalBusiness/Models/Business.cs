namespace LocalBusiness.Models
{
  public class Business
  {
    public int BusinessId { get; set; }
    public string Name { get; set; }
    public string StreetAddress { get; set; }
    public string City { get; set; }
    public string State { get; set; }
    public string County { get; set; }
    public string Type { get; set; }
    public string Category { get; set; }
    public int Price { get; set; }
    public string Review { get; set; }
    public int Rating { get; set; }
  }
}