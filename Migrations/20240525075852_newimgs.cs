using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GastroWebsiteNew.Migrations
{
    /// <inheritdoc />
    public partial class newimgs : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImagePaths",
                value: "[\"lantaw.jpg\",\"lantaw1.jpg, lantaw2.jpg\"]");

            migrationBuilder.UpdateData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImagePaths",
                value: "[\"tamp.jpg\",\"tamp1.jpg, tamp2.jpg\"]");

            migrationBuilder.UpdateData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 3,
                column: "ImagePaths",
                value: "[\"scape.jpg\",\"scape1.jpg, scape2.jpg\"]");

            migrationBuilder.UpdateData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 4,
                column: "ImagePaths",
                value: "[\"abaca.jpg\",\"abaca1.jpg, abaca.jpg\"]");

            migrationBuilder.UpdateData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 5,
                column: "ImagePaths",
                value: "[\"pig.jpg\",\"pig1.jpg, pig2.jpg\"]");

            migrationBuilder.UpdateData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 6,
                column: "ImagePaths",
                value: "[\"lighthouse.jpg\",\"lighthouse1.jpg, lighthouse2.jpg\"]");

            migrationBuilder.UpdateData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 7,
                column: "ImagePaths",
                value: "[\"cafebai.jpeg\",\"cafebai1.jpg, cafebai2.jpeg\"]");

            migrationBuilder.UpdateData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 8,
                column: "ImagePaths",
                value: "[\"anzani.png\",\"anzani1.jpg, anzani.jpg\"]");

            migrationBuilder.UpdateData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 9,
                column: "ImagePaths",
                value: "[\"cafetalk.jpg\",\"cafetalk1.jpg, cafetalk2.jpg\"]");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                column: "ImagePaths",
                value: "[\"scape.jpg\",\"scape1.jpg\"]");

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
                column: "ImagePaths",
                value: "[\"anzani.png\",\"anzani1.jpg\"]");

            migrationBuilder.UpdateData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 9,
                column: "ImagePaths",
                value: "[\"cafetalk.jpg\",\"cafetalk11.jpg\"]");
        }
    }
}
