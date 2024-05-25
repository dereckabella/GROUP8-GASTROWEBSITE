using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GastroWebsiteNew.Migrations
{
    /// <inheritdoc />
    public partial class NewDescrip : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 1,
                column: "Description",
                value: "Delights patrons with its artisanal pastries, gourmet sandwiches, and specialty coffee, all served in a warm and inviting atmosphere.");

            migrationBuilder.UpdateData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 7,
                column: "Description",
                value: "Offers a vibrant dining experience with an extensive selection of local and international cuisines, set in a stylish and welcoming atmosphere.");

            migrationBuilder.UpdateData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 9,
                column: "Description",
                value: "Combines the cozy ambiance of a café with a curated selection of books, offering a serene haven for coffee enthusiasts and avid readers alike.");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 1,
                column: "Description",
                value: "A unique dining experience with its picturesque waterfront setting and a menu featuring authentic Filipino cuisine, capturing the essence of local flavors amidst breathtaking views.");

            migrationBuilder.UpdateData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 7,
                column: "Description",
                value: "A diverse culinary journey with its fusion of local and international flavors, promising a cozy and vibrant dining atmosphere.");

            migrationBuilder.UpdateData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 9,
                column: "Description",
                value: "A cozy retreat for bookworms and coffee lovers alike, combining a curated selection of literature with aromatic brews for a tranquil escape.");
        }
    }
}
