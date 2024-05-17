using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BigBasketApp.Migrations.Items
{
    /// <inheritdoc />
    public partial class B2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Items",
                columns: table => new
                {
                    ItemId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    Category = table.Column<string>(type: "text", nullable: false),
                    Price = table.Column<double>(type: "double precision", nullable: false),
                    Quantity = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Items", x => x.ItemId);
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "ItemId", "Category", "Description", "Name", "Price", "Quantity" },
                values: new object[,]
                {
                    { 1001, "Vegitable", "Hybrid Tomato's", "Tomato", 20.0, "500g" },
                    { 1002, "Vegitable", "Organically grown", "Onions", 25.0, "1kg" },
                    { 1003, "Vegitable", "Fresh Coriander", "Coriander Leaves", 10.0, "200g" },
                    { 1004, "Vegitable", "Hybrid Carrots", "Carrot", 50.0, "500g" },
                    { 1005, "Vegitable", "Potato's Loose", "Potato", 30.0, "1kg" },
                    { 1006, "Fruits", "Organic Apples", "Apples", 200.0, "1kg" },
                    { 1007, "Fruits", "Hybrid Oranges's", "Oranges", 120.0, "500g" },
                    { 1008, "Fruits", "Local", "Banana", 50.0, "1kg" },
                    { 1009, "Vegitable", "Green Chillies", "Chillies", 10.0, "100g" },
                    { 1010, "Vegitable", "Curry leaves loose", "Curry leaves", 5.0, "100g" },
                    { 1011, "Fruits", "Organic Mango's", "Mango", 200.0, "1.5kg" },
                    { 1012, "Vegitable", "Lemons", "Lemon", 8.0, "1pc" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Items");
        }
    }
}
