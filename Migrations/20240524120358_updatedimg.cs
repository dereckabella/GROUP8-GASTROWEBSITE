using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GastroWebsiteNew.Migrations
{
    /// <inheritdoc />
    public partial class updatedimg : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImagePaths",
                value: "[\"lantaw.jpg\",\"lantaw1.jpg\"]");

            migrationBuilder.UpdateData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImagePaths",
                value: "[\"tamp.jpg\",\"tamp1.jpg\"]");

            migrationBuilder.UpdateData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Description", "ImagePaths" },
                values: new object[] { "A sophisticated rooftop dining experience with panoramic views of the city skyline and ocean, complemented by a diverse menu of international cuisine and signature cocktails, perfect for a memorable evening under the stars.", "[\"scape.jpg\",\"scape1.jpg\"]" });

            migrationBuilder.UpdateData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 4,
                column: "ImagePaths",
                value: "[\"abaca.jpg\",\"abaca1.jpg\"]");

            migrationBuilder.UpdateData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 5,
                column: "ImagePaths",
                value: "[\"pig.jpg\",\"pig1.jpg\"]");

            migrationBuilder.UpdateData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 6,
                column: "ImagePaths",
                value: "[\"lighthouse.jpg\",\"lighthouse1.jpg\"]");

            migrationBuilder.UpdateData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 7,
                column: "ImagePaths",
                value: "[\"cafebai.jpeg\",\"cafebai1.jpg\"]");

            migrationBuilder.UpdateData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Description", "ImagePaths" },
                values: new object[] { "Delights discerning diners with its elegant ambiance and exquisite Mediterranean-inspired cuisine, delivering a sophisticated culinary experience.", "[\"anzani.png\",\"anzani1.jpg\"]" });

            migrationBuilder.UpdateData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Description", "ImagePaths" },
                values: new object[] { "A cozy retreat for bookworms and coffee lovers alike, combining a curated selection of literature with aromatic brews for a tranquil escape.", "[\"cafetalk.jpg\",\"cafetalk11.jpg\"]" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImagePaths",
                value: "[\"lantaw.jpg\"]");

            migrationBuilder.UpdateData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImagePaths",
                value: "[\"tamp.jpg\"]");

            migrationBuilder.UpdateData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Description", "ImagePaths" },
                values: new object[] { "a sophisticated rooftop dining experience with panoramic views of the city skyline and ocean, complemented by a diverse menu of international cuisine and signature cocktails, perfect for a memorable evening under the stars.", "[\"scape.jpg\"]" });

            migrationBuilder.UpdateData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 4,
                column: "ImagePaths",
                value: "[\"abaca.jpg\"]");

            migrationBuilder.UpdateData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 5,
                column: "ImagePaths",
                value: "[\"pig.jpg\"]");

            migrationBuilder.UpdateData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 6,
                column: "ImagePaths",
                value: "[\"lighthouse.jpg\"]");

            migrationBuilder.UpdateData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 7,
                column: "ImagePaths",
                value: "[\"cafebai.jpeg\"]");

            migrationBuilder.UpdateData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Description", "ImagePaths" },
                values: new object[] { " delights discerning diners with its elegant ambiance and exquisite Mediterranean-inspired cuisine, delivering a sophisticated culinary experience.", "[\"anzani.png\"]" });

            migrationBuilder.UpdateData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Description", "ImagePaths" },
                values: new object[] { "A cozy retreat for bookworms and coffee lovers alike, combining a curated selection of literature with aromatic brews for a tranquil escape", "[\"cafetalk.jpg\"]" });


            migrationBuilder.UpdateData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Description", "ImagePaths" },
                values: new object[] { "Sip on your favorite brew while indulging in delectable treats, surrounded by a modern yet inviting atmosphere. Whether you're catching up with friends", "[\"starbucks.jpg\"]" });
        }
    }
}
