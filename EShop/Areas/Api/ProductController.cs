using AutoMapper;
using EShop.Application.Dtos;
using EShop.Application.Services;
using EShop.Domain.Interfaces;
using EShop.Domain.Models;
using EShop.ModelViews;
using Microsoft.AspNetCore.Mvc;

namespace EShop.Presentation.Areas.Api
{
    [ApiController]
    [Area("Api")]
    [Route("[area]/[controller]")]
    public class ProductController : Controller
    {
        private readonly IProductRepository _productRepository;
        private readonly IProductService _productService;
        private readonly IMapper _mapper;

        public ProductController(IProductRepository productRepository, IMapper mapper, IProductService productService)
        {
            _productRepository = productRepository;
            _productService = productService;
            _mapper = mapper;
        }

        [HttpGet("all_products")]
        public async Task<IActionResult> GetAllProducts()
        {
            var products = await _productRepository.GetAllProductsAsync();
            var productDtos = _mapper.Map<List<ProductDto>>(products);
            return Ok(productDtos);
        }

        [HttpPost("create")]
        public async Task<IActionResult> CreateProduct([FromBody] ProductCreateDto dto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var viewModel = new CreateProductViewModel
            {
                ProductData = new Product
                {
                    Name = dto.Name,
                    Description = dto.Description,
                    Price = dto.Price,
                    Image = dto.Image,
                    numberInStock = dto.NumberInStock
                },
                CategorySelect = new CategorySelectModelViews
                {
                    CategoryIds = dto.CategoryIds
                }
            };

            var result = await _productService.AddProductAsync(viewModel);

            if (result > 0)
                return Ok(new { message = "Product created successfully.", productId = result });

            return StatusCode(500, "Failed to create product.");
        }
    }
}
