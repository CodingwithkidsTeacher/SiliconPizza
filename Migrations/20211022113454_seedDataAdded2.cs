using Microsoft.EntityFrameworkCore.Migrations;

namespace SiliconPizza.Migrations
{
    public partial class seedDataAdded2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Pizzas",
                keyColumn: "PizzaId",
                keyValue: 1,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "https://i.ibb.co/VHwKty8/pepperoni.png", "https://i.ibb.co/VHwKty8/pepperoni.png" });

            migrationBuilder.InsertData(
                table: "Pizzas",
                columns: new[] { "PizzaId", "AllergyInformation", "CategoryId", "ImageThumbnailUrl", "ImageUrl", "InStock", "IsPizzaOfTheWeek", "LongDescription", "Name", "Price", "ShortDescription" },
                values: new object[] { 2, "", 1, "https://i.ibb.co/pfPZR6Y/veggies.jpg", "https://i.ibb.co/pfPZR6Y/veggies.jpg", true, true, "Large veggies pizza with american cheese which comes with a side sauce and a small soft drink", "Veggie Piza", 7.99m, "Our famous Veggie pizza!" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Pizzas",
                keyColumn: "PizzaId",
                keyValue: 2);

            migrationBuilder.UpdateData(
                table: "Pizzas",
                keyColumn: "PizzaId",
                keyValue: 1,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "https://gillcleerenpluralsight.blob.core.windows.net/files/applepiesmall.jpg", "~/images/pepperoni.png" });
        }
    }
}
