using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace GastroWebsiteNew.Migrations
{
    /// <inheritdoc />
    public partial class seedupdateddata : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ImagePath", "Location", "Name", "Type" },
                values: new object[] { "scape.jpg", "AZON Residences, Roof Deck, M.L. Quezon National Highway, Lapu-Lapu City", "Scape Skydeck", "Restaurant" });

            migrationBuilder.InsertData(
                table: "Places",
                columns: new[] { "Id", "ImagePath", "Location", "Name", "Type" },
                values: new object[,]
                {
                    { 4, "abaca.jpg", "Paseo Arcenas, Banawa", "Abaca Baking Company", "Cafe" },
                    { 5, "pig.jpg", "G/F, MSY Tower, Negros Rd, Cebu City", "The Pig and Palm", "Restaurant" },
                    { 6, "lighthouse.jpg", "General Maxilom Ave, Cebu City", "Lighthouse Restaurant", "Restaurant" },
                    { 7, "cafebai.jpeg", "Ouano Ave, cor C.D.Seno, Mandaue City", "Cafe Bai", "Cafe" },
                    { 8, "anzani.png", "Panorama Heights Nivel Hills, Cebu City", "Anzani Restaurant", "Restaurant" },
                    { 9, "cafetalk.jpg", "Escario Building, 731 N Escario St, Cebu City", "Cafe Talk Library", "Cafe" }
                
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.UpdateData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ImagePath", "Location", "Name", "Type" },
                values: new object[] { "abaca.jpg", "Paseo Arcenas, Banawa", "Abaca Baking Company", "Cafe" });
        }
    }
}
