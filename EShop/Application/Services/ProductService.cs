using EShop.Application.Services;
using EShop.Domain.Interfaces;
using EShop.Domain.Models;
using EShop.ModelViews;

public class ProductService : IProductService
{
    private readonly IProductRepository _productRepository;
    private readonly IProductCategoryRepository _productCategoryRepository;

    public ProductService(IProductRepository productRepository, IProductCategoryRepository productCategoryRepository)
    {
        _productRepository = productRepository;
        _productCategoryRepository = productCategoryRepository;
    }

    public async Task<int> AddProductAsync(CreateProductViewModel createProductViewModel)
    {
        Product product = new Product
        {
            Name = createProductViewModel.Name,
            Description = createProductViewModel.Description,
            Price = createProductViewModel.Price,
            Image = createProductViewModel.Image,
            numberInStock = createProductViewModel.NumberInStock
        };

        
        await _productRepository.AddProductAsync(product);

        
        foreach (var categoryId in createProductViewModel.CategoryIds)
        {
            ProductCategory productCategory = new ProductCategory
            {
                ProductId = product.Id, // Now ID is available
                CategoryId = categoryId
            };

            await _productCategoryRepository.AddProductCategory(productCategory);
        }

        return product.Id;
    }
}
