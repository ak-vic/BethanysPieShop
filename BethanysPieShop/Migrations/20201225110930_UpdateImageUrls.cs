using Microsoft.EntityFrameworkCore.Migrations;

namespace BethanysPieShop.Migrations
{
    public partial class UpdateImageUrls : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Pies",
                keyColumn: "PieId",
                keyValue: 1,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "/images/pies/5ae1987679293d5b4a673582ba6fafb8.jpg", "/images/pies/5ae1987679293d5b4a673582ba6fafb8.jpg" });

            migrationBuilder.UpdateData(
                table: "Pies",
                keyColumn: "PieId",
                keyValue: 2,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "/images/pies/60e8ca531ecabd06ffcbbe7fd38883f3.jpg", "/images/pies/60e8ca531ecabd06ffcbbe7fd38883f3.jpg" });

            migrationBuilder.UpdateData(
                table: "Pies",
                keyColumn: "PieId",
                keyValue: 3,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "/images/pies/960w.jpg", "/images/pies/960w.jpg" });

            migrationBuilder.UpdateData(
                table: "Pies",
                keyColumn: "PieId",
                keyValue: 4,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "/images/pies/b52c0272.jpg", "/images/pies/b52c0272.jpg" });

            migrationBuilder.UpdateData(
                table: "Pies",
                keyColumn: "PieId",
                keyValue: 5,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "/images/pies/nachinki-dlya-pirogov-1.jpg", "/images/pies/nachinki-dlya-pirogov-1.jpg" });

            migrationBuilder.UpdateData(
                table: "Pies",
                keyColumn: "PieId",
                keyValue: 6,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "/images/pies/pirogi-1.jpg", "/images/pies/pirogi-1.jpg" });

            migrationBuilder.UpdateData(
                table: "Pies",
                keyColumn: "PieId",
                keyValue: 7,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "/images/pies/pirog-iz-sdobnogo-testa_1518867453_1_max.jpg", "/images/pies/pirog-iz-sdobnogo-testa_1518867453_1_max.jpg" });

            migrationBuilder.UpdateData(
                table: "Pies",
                keyColumn: "PieId",
                keyValue: 8,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "/images/pies/recipe_e912c85a-9c82-4ecb-a041-21237a3c7873_large.jpg", "/images/pies/recipe_e912c85a-9c82-4ecb-a041-21237a3c7873_large.jpg" });

            migrationBuilder.UpdateData(
                table: "Pies",
                keyColumn: "PieId",
                keyValue: 9,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "/images/pies/sladkie.jpg", "/images/pies/sladkie.jpg" });

            migrationBuilder.UpdateData(
                table: "Pies",
                keyColumn: "PieId",
                keyValue: 10,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "/images/pies/10.jpg", "/images/pies/10.jpg" });

            migrationBuilder.UpdateData(
                table: "Pies",
                keyColumn: "PieId",
                keyValue: 11,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "/images/pies/11.jpg", "/images/pies/11.jpg" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Pies",
                keyColumn: "PieId",
                keyValue: 1,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "https://gillcleerenpluralsight.blob.core.windows.net/files/applepiesmall.jpg", "https://gillcleerenpluralsight.blob.core.windows.net/files/applepie.jpg" });

            migrationBuilder.UpdateData(
                table: "Pies",
                keyColumn: "PieId",
                keyValue: 2,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "https://gillcleerenpluralsight.blob.core.windows.net/files/blueberrycheesecakesmall.jpg", "https://gillcleerenpluralsight.blob.core.windows.net/files/blueberrycheesecake.jpg" });

            migrationBuilder.UpdateData(
                table: "Pies",
                keyColumn: "PieId",
                keyValue: 3,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "https://gillcleerenpluralsight.blob.core.windows.net/files/cheesecakesmall.jpg", "https://gillcleerenpluralsight.blob.core.windows.net/files/cheesecake.jpg" });

            migrationBuilder.UpdateData(
                table: "Pies",
                keyColumn: "PieId",
                keyValue: 4,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "https://gillcleerenpluralsight.blob.core.windows.net/files/cherrypiesmall.jpg", "https://gillcleerenpluralsight.blob.core.windows.net/files/cherrypie.jpg" });

            migrationBuilder.UpdateData(
                table: "Pies",
                keyColumn: "PieId",
                keyValue: 5,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "https://gillcleerenpluralsight.blob.core.windows.net/files/christmasapplepiesmall.jpg", "https://gillcleerenpluralsight.blob.core.windows.net/files/christmasapplepie.jpg" });

            migrationBuilder.UpdateData(
                table: "Pies",
                keyColumn: "PieId",
                keyValue: 6,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "https://gillcleerenpluralsight.blob.core.windows.net/files/cranberrypiesmall.jpg", "https://gillcleerenpluralsight.blob.core.windows.net/files/cranberrypie.jpg" });

            migrationBuilder.UpdateData(
                table: "Pies",
                keyColumn: "PieId",
                keyValue: 7,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "https://gillcleerenpluralsight.blob.core.windows.net/files/peachpiesmall.jpg", "https://gillcleerenpluralsight.blob.core.windows.net/files/peachpie.jpg" });

            migrationBuilder.UpdateData(
                table: "Pies",
                keyColumn: "PieId",
                keyValue: 8,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "https://gillcleerenpluralsight.blob.core.windows.net/files/pumpkinpiesmall.jpg", "https://gillcleerenpluralsight.blob.core.windows.net/files/pumpkinpie.jpg" });

            migrationBuilder.UpdateData(
                table: "Pies",
                keyColumn: "PieId",
                keyValue: 9,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "https://gillcleerenpluralsight.blob.core.windows.net/files/rhubarbpiesmall.jpg", "https://gillcleerenpluralsight.blob.core.windows.net/files/rhubarbpie.jpg" });

            migrationBuilder.UpdateData(
                table: "Pies",
                keyColumn: "PieId",
                keyValue: 10,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "https://gillcleerenpluralsight.blob.core.windows.net/files/strawberrypiesmall.jpg", "https://gillcleerenpluralsight.blob.core.windows.net/files/strawberrypie.jpg" });

            migrationBuilder.UpdateData(
                table: "Pies",
                keyColumn: "PieId",
                keyValue: 11,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "https://gillcleerenpluralsight.blob.core.windows.net/files/strawberrycheesecakesmall.jpg", "https://gillcleerenpluralsight.blob.core.windows.net/files/strawberrycheesecake.jpg" });
        }
    }
}
