using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EShop.Migrations
{
    /// <inheritdoc />
    public partial class photos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Description", "Name" },
                values: new object[] { "GPU и ускорители", "Видеокарты" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Остальные комплектующие", "Комплектующие" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Description", "Image", "Name", "Price", "numberInStock" },
                values: new object[] { "Описание продукта 1", "/images/Без названия (1).jpg", "Без названия 1", 15.99m, 10 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Description", "Image", "Name", "Price", "numberInStock" },
                values: new object[] { "Описание продукта 2", "/images/Без названия.jpg", "Без названия 2", 12.49m, 7 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "Image", "Name", "Price", "numberInStock" },
                values: new object[,]
                {
                    { 3, "Мощная видеокарта RTX 5090 — версия A", "/images/geforce-rtx-5090-af550-t@2x.jpg", "GeForce RTX 5090 A", 1999.99m, 3 },
                    { 4, "Мощная видеокарта RTX 5090 — версия B", "/images/geforce-rtx-5090-af550-t@2x.jpg", "GeForce RTX 5090 B", 1999.99m, 4 },
                    { 5, "Мощная видеокарта RTX 5090 — версия C", "/images/geforce-rtx-5090-af550-t@2x.jpg", "GeForce RTX 5090 C", 1999.99m, 6 },
                    { 6, "Мощная видеокарта RTX 5090 — версия D", "/images/geforce-rtx-5090-af550-t@2x.jpg", "GeForce RTX 5090 D", 1999.99m, 2 }
                });

            migrationBuilder.InsertData(
                table: "ProductCategories",
                columns: new[] { "CategoryId", "ProductId" },
                values: new object[,]
                {
                    { 1, 3 },
                    { 1, 4 },
                    { 1, 5 },
                    { 1, 6 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 1, 3 });

            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 1, 4 });

            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 1, 5 });

            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 1, 6 });

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Description for Category 1", "Category 1" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Description for Category 2", "Category 2" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Description", "Image", "Name", "Price", "numberInStock" },
                values: new object[] { "Description for Product 1", "image1.jpg", "Product 1", 10.99m, 5 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Description", "Image", "Name", "Price", "numberInStock" },
                values: new object[] { "Description for Product 2", "image2.jpg", "Product 2", 20.99m, 10 });
        }
    }
}
