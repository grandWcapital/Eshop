using EShop.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace EShop.Interface.Data
{
    public static class DbInitializer
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    Id = 1,
                    Name = "Без названия 1",
                    Description = "Описание продукта 1",
                    Price = 15.99m,
                    Image = "/images/Без названия (1).jpg",
                    numberInStock = 10
                },
                new Product
                {
                    Id = 2,
                    Name = "Без названия 2",
                    Description = "Описание продукта 2",
                    Price = 12.49m,
                    Image = "/images/Без названия.jpg",
                    numberInStock = 7
                },
                new Product
                {
                    Id = 3,
                    Name = "GeForce RTX 5090 A",
                    Description = "Мощная видеокарта RTX 5090 — версия A",
                    Price = 1999.99m,
                    Image = "/images/geforce-rtx-5090-af550-t@2x.jpg",
                    numberInStock = 3
                },
                new Product
                {
                    Id = 4,
                    Name = "GeForce RTX 5090 B",
                    Description = "Мощная видеокарта RTX 5090 — версия B",
                    Price = 1999.99m,
                    Image = "/images/geforce-rtx-5090-af550-t@2x.jpg",
                    numberInStock = 4
                },
                new Product
                {
                    Id = 5,
                    Name = "GeForce RTX 5090 C",
                    Description = "Мощная видеокарта RTX 5090 — версия C",
                    Price = 1999.99m,
                    Image = "/images/geforce-rtx-5090-af550-t@2x.jpg",
                    numberInStock = 6
                },
                new Product
                {
                    Id = 6,
                    Name = "GeForce RTX 5090 D",
                    Description = "Мощная видеокарта RTX 5090 — версия D",
                    Price = 1999.99m,
                    Image = "/images/geforce-rtx-5090-af550-t@2x.jpg",
                    numberInStock = 2
                }
            );

            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Видеокарты", Description = "GPU и ускорители" },
                new Category { Id = 2, Name = "Комплектующие", Description = "Остальные комплектующие" }
            );

            modelBuilder.Entity<ProductCategory>().HasData(
                new ProductCategory { ProductId = 1, CategoryId = 1 },
                new ProductCategory { ProductId = 2, CategoryId = 2 },
                new ProductCategory { ProductId = 3, CategoryId = 1 },
                new ProductCategory { ProductId = 4, CategoryId = 1 },
                new ProductCategory { ProductId = 5, CategoryId = 1 },
                new ProductCategory { ProductId = 6, CategoryId = 1 }
            );
        }
    }
}
