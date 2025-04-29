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
            Name = createProductViewModel.ProductData.Name,
            Description = createProductViewModel.ProductData.Description,
            Price = createProductViewModel.ProductData.Price,
            Image = createProductViewModel.ProductData.Image,
            numberInStock = createProductViewModel.ProductData.numberInStock
        };

        
        await _productRepository.AddProductAsync(product);

        
        foreach (var categoryId in createProductViewModel.CategorySelect.CategoryIds)
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
