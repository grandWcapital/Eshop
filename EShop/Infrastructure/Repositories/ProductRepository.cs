﻿using EShop.Domain.Interfaces;
using EShop.Domain.Models;
using EShop.Interface.Data;
using Microsoft.EntityFrameworkCore;

namespace EShop.Infrastructure.Repositories
{
    public class ProductRepository : IProductRepository
    { 
        private readonly EShopDbContext _context;

        public ProductRepository(EShopDbContext context)
        {
            _context = context;

        }
        public async Task<IEnumerable<Product>> GetAllProductsAsync()
        {
            var products = from p in _context.Products
                           from pc in _context.ProductCategories.Where(pc => pc.ProductId == p.Id)
                           from c in _context.Categories.Where(c => c.Id == pc.CategoryId)
                           select new Product()
                           {
                               Id = p.Id,
                               Name = p.Name,
                               Description = p.Description,
                               Price = p.Price,
                               Image = p.Image,
                               numberInStock = p.numberInStock,
                               ProductCategories = new List<ProductCategory>
                                {
                                    new ProductCategory { ProductId = p.Id, CategoryId = c.Id,  }
                                }
                           };


            return await products.ToListAsync();
        }
        public async Task<int> AddProductAsync(Product product)
        {
            _context.Products.Add(product);
            return await _context.SaveChangesAsync();
        }

        public async Task<Product> GetProductByIdAsync(int id)
        {
            return await _context.Products.Include(p => p.ProductCategories)
                .ThenInclude(pc => pc.Category)
                .FirstOrDefaultAsync(p => p.Id == id);

        }
        public async Task UpdateProductAsync(Product product)
        {
            _context.Products.Update(product);
            await _context.SaveChangesAsync();
        }
        public async Task Delete(Product product)
        {
            _context.Products.Remove(product);
            await _context.SaveChangesAsync();
        }
    }
}
