using Microsoft.EntityFrameworkCore;

namespace LocalBusiness.Models
{
  
  public class LocalBusinessContext : DbContext
  {
    public LocalBusinessContext(DbContextOptions<LocalBusinessContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<Business>()
        .HasData(
          new Business { BusinessId = 1, Name = "Cracker Barrel", StreetAddress = "3389 Busbee Dr NW", City = "Kennesaw", State ="GA", County = "Cobb", Type = "Restaurant", Category = "Southern", Price = 3, Review = "Great place to eat", Rating = 3 },
          new Business { BusinessId = 2, Name = "Marietta Diner", StreetAddress = "306 Cobb Parkway S", City = "Marietta", State ="GA", County = "Cobb", Type = "Restaurant", Category = "American Diner", Price = 3, Review = "Excellent food and quality service", Rating = 5 },
          new Business { BusinessId = 3, Name = "Character's Famous BBQ", StreetAddress = "6419 Joe Frank Harris Pkwy", City = "Adairsville", State ="GA", County = "Bartow", Type = "Restaurant", Category = "BBQ", Price = 2, Review = "Excellent BBQ in a small town, featured on BBQ Pit Wars and BBQ Pitmasters", Rating = 5 },
          new Business { BusinessId = 4, Name = "Three Dollar Cafe", StreetAddress = "3000 Windy Hill Road, Suite 132", City = "Marietta", State ="GA", County = "Cobb", Type = "Restaurant", Category = "American", Price = 3, Review = "The best wings around Atlanta, also good beer selection", Rating = 4 },
          new Business { BusinessId = 5, Name = "The Vortex", StreetAddress = "438 Moreland Ave NE", City = "Atlanta", State ="GA", County = "Fulton", Type = "Restaurant", Category = "American", Price = 3, Review = "One of the best burger joints in Atlanta with an adult comedy theme", Rating = 4 },
          new Business { BusinessId = 6, Name = "Wendy's", StreetAddress = "957 Highway 140 W", City = "Adairsville", State ="GA", County = "Bartow", Type = "Restaurant", Category = "Fast Food", Price = 1, Review = "Unfriendly staff and your order is rarely correct, avoid if you can", Rating = 1 },
          new Business { BusinessId = 7, Name = "The Red Eyed Mule", StreetAddress = "430 South Marietta Pkwy SE", City = "Marietta", State ="GA", County = "Cobb", Type = "Restaurant", Category = "Southern Breakfast", Price = 3, Review = "Mouth melting breakfast food at a reasonable price", Rating = 4 },
          new Business { BusinessId = 8, Name = "Fat Matt's Rib Shack", StreetAddress = "1811 Piedmont Ave NE", City = "Atlanta", State ="GA", County = "Fulton", Type = "Restaurant", Category = "BBQ", Price = 3, Review = "The best ribs and BBQ in Atlanta!", Rating = 5 },
          new Business { BusinessId = 9, Name = "Watch Shop", StreetAddress = "504 Tick Tock Pkwy", City = "Kennesaw", State ="GA", County = "Cobb", Type = "Shop", Category = "Watches", Price = 3, Review = "Decent selection of watches, great repair shop!", Rating = 4 },
          new Business { BusinessId = 10, Name = "Full of Things", StreetAddress = "374 Antique Rd", City = "Marietta", State ="GA", County = "Cobb", Type = "Shop", Category = "Antiques", Price = 4, Review = "Unique items, all in good shape, be prepared to spend a lot", Rating = 5 },
          new Business { BusinessId = 11, Name = "Hat House", StreetAddress = "Mall Blvd", City = "Dallas", State ="GA", County = "Paulding", Type = "Shop", Category = "Hats", Price = 2, Review = "Decent selection of hats and lower than average prices", Rating = 3 },
          new Business { BusinessId = 12, Name = "Shoes R Us", StreetAddress = "A Mall Somewhere Rd", City = "Tucker", State ="GA", County = "Dekalb", Type = "Shop", Category = "Shoes", Price = 4, Review = "Limited selection and high prices, last time I'm shopping here", Rating = 2 },
          new Business { BusinessId = 13, Name = "Righteous Guitars", StreetAddress = "1455 Hembree Rd", City = "Roswell", State ="GA", County = "Fulton", Type = "Shop", Category = "Guitars", Price = 3, Review = "Friend and helpful staff, great selection of guitars", Rating = 5 },
          new Business { BusinessId = 14, Name = "A Local Thrift Store", StreetAddress = "Strip Mall Plaza", City = "Adairsville", State ="GA", County = "Bartow", Type = "Shop", Category = "Thrift Store", Price = 1, Review = "It's a thrift store", Rating = 3 },
          new Business { BusinessId = 15, Name = "Can't Believe It's Not Real Wood Furniture", StreetAddress = "Somewhere In China St", City = "Marietta", State ="GA", County = "Cobb", Type = "Shop", Category = "Furniture", Price = 2, Review = "No false advertising here", Rating = 3 },
          new Business { BusinessId = 16, Name = "Clothing Store 101", StreetAddress = "999 Everywhere St", City = "Atlanta", State ="GA", County = "Fulton", Type = "Shop", Category = "Clothing", Price = 5, Review = "The finest clothing money can buy, pretty sure I saw a celebrity buy something so I bought it too", Rating = 5 }
        );
    }
  
    public DbSet<Business> Businesses { get; set;}
  }
}