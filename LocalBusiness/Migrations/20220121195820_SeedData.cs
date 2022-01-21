using Microsoft.EntityFrameworkCore.Migrations;

namespace LocalBusiness.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Businesses",
                columns: new[] { "BusinessId", "Category", "City", "County", "Name", "Price", "Rating", "Review", "State", "StreetAddress", "Type" },
                values: new object[,]
                {
                    { 1, "Southern", "Kennesaw", "Cobb", "Cracker Barrel", 3, 3, "Great place to eat", "GA", "3389 Busbee Dr NW", "Restaurant" },
                    { 2, "American Diner", "Marietta", "Cobb", "Marietta Diner", 3, 5, "Excellent food and quality service", "GA", "306 Cobb Parkway S", "Restaurant" },
                    { 3, "BBQ", "Adairsville", "Bartow", "Character's Famous BBQ", 2, 5, "Excellent BBQ in a small town, featured on BBQ Pit Wars and BBQ Pitmasters", "GA", "6419 Joe Frank Harris Pkwy", "Restaurant" },
                    { 4, "American", "Marietta", "Cobb", "Three Dollar Cafe", 3, 4, "The best wings around Atlanta, also good beer selection", "GA", "3000 Windy Hill Road, Suite 132", "Restaurant" },
                    { 5, "American", "Atlanta", "Fulton", "The Vortex", 3, 4, "One of the best burger joints in Atlanta with an adult comedy theme", "GA", "438 Moreland Ave NE", "Restaurant" },
                    { 6, "Fast Food", "Adairsville", "Bartow", "Wendy's", 1, 1, "Unfriendly staff and your order is rarely correct, avoid if you can", "GA", "957 Highway 140 W", "Restaurant" },
                    { 7, "Southern Breakfast", "Marietta", "Cobb", "The Red Eyed Mule", 3, 4, "Mouth melting breakfast food at a reasonable price", "GA", "430 South Marietta Pkwy SE", "Restaurant" },
                    { 8, "BBQ", "Atlanta", "Fulton", "Fat Matt's Rib Shack", 3, 5, "The best ribs and BBQ in Atlanta!", "GA", "1811 Piedmont Ave NE", "Restaurant" },
                    { 9, "Watches", "Kennesaw", "Cobb", "Watch Shop", 3, 4, "Decent selection of watches, great repair shop!", "GA", "504 Tick Tock Pkwy", "Shop" },
                    { 10, "Antiques", "Marietta", "Cobb", "Full of Things", 4, 5, "Unique items, all in good shape, be prepared to spend a lot", "GA", "374 Antique Rd", "Shop" },
                    { 11, "Hats", "Dallas", "Paulding", "Hat House", 2, 3, "Decent selection of hats and lower than average prices", "GA", "Mall Blvd", "Shop" },
                    { 12, "Shoes", "Tucker", "Dekalb", "Shoes R Us", 4, 2, "Limited selection and high prices, last time I'm shopping here", "GA", "A Mall Somewhere Rd", "Shop" },
                    { 13, "Guitars", "Roswell", "Fulton", "Righteous Guitars", 3, 5, "Friend and helpful staff, great selection of guitars", "GA", "1455 Hembree Rd", "Shop" },
                    { 14, "Thrift Store", "Adairsville", "Bartow", "A Local Thrift Store", 1, 3, "It's a thrift store", "GA", "Strip Mall Plaza", "Shop" },
                    { 15, "Furniture", "Marietta", "Cobb", "Can't Believe It's Not Real Wood Furniture", 2, 3, "No false advertising here", "GA", "Somewhere In China St", "Shop" },
                    { 16, "Clothing", "Atlanta", "Fulton", "Clothing Store 101", 5, 5, "The finest clothing money can buy, pretty sure I saw a celebrity buy something so I bought it too", "GA", "999 Everywhere St", "Shop" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 16);
        }
    }
}
