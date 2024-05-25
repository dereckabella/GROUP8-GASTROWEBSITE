using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GastroWebsiteNew.Migrations
{
    /// <inheritdoc />
    public partial class descriptionadd : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Places",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 1,
                column: "Description",
                value: "A unique dining experience with its picturesque waterfront setting and a menu featuring authentic Filipino cuisine, capturing the essence of local flavors amidst breathtaking views.");

            migrationBuilder.UpdateData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 2,
                column: "Description",
                value: "Offers a cozy ambiance and a diverse menu of delicious coffee blends and delectable treats, making it the perfect spot to unwind and enjoy a delightful culinary experience.");

            migrationBuilder.UpdateData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 3,
                column: "Description",
                value: "a sophisticated rooftop dining experience with panoramic views of the city skyline and ocean, complemented by a diverse menu of international cuisine and signature cocktails, perfect for a memorable evening under the stars.");

            migrationBuilder.UpdateData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 4,
                column: "Description",
                value: "A delightful fusion of artisanal baked goods, gourmet sandwiches, and specialty coffee in a cozy, chic setting, embodying a haven for pastry enthusiasts and foodies alike in Cebu.");

            migrationBuilder.UpdateData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 5,
                column: "Description",
                value: "Epitomizes culinary excellence with its innovative dishes inspired by global flavors, served in a stylish yet inviting atmosphere, setting the standard for modern dining experiences in Cebu.");

            migrationBuilder.UpdateData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 6,
                column: "Description",
                value: "Beckons with its charming seaside ambiance and delectable seafood offerings, providing a memorable dining experience by the shore in Cebu.");

            migrationBuilder.UpdateData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 7,
                column: "Description",
                value: "A diverse culinary journey with its fusion of local and international flavors, promising a cozy and vibrant dining atmosphere.");

            migrationBuilder.UpdateData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 8,
                column: "Description",
                value: " delights discerning diners with its elegant ambiance and exquisite Mediterranean-inspired cuisine, delivering a sophisticated culinary experience.");

            migrationBuilder.UpdateData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 9,
                column: "Description",
                value: "A cozy retreat for bookworms and coffee lovers alike, combining a curated selection of literature with aromatic brews for a tranquil escape");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "Places");
        }
    }
}
