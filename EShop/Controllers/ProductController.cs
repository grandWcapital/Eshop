using EShop.Application.Services;
using EShop.Domain.Interfaces;
using EShop.ModelViews;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Net.Http;
using System.Text;
using Newtonsoft.Json;

namespace EShop.Presentation.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService _productService;
        private readonly ICategoryRepository _categoryRepository;
        private readonly IHttpClientFactory _httpClientFactory;
        public ProductController(IProductService productService, ICategoryRepository categoryRepository, IHttpClientFactory httpClientFactory)
        {
            _productService = productService;
            _categoryRepository = categoryRepository;
            _httpClientFactory = httpClientFactory;
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> Create()
        {
            // Imagine you call your CategoryService or repository
            var categories = await _categoryRepository.GetAllCategoriesAsync();

            var model = new CreateProductViewModel
            {
                AllCategories = categories.Select(c => new SelectListItem
                {
                    Value = c.Id.ToString(),
                    Text = c.Name
                }).ToList()
            };

            return View(model);
        }
        [HttpGet]
        public IActionResult ProductDescription()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(CreateProductViewModel model)
        {
            if (!ModelState.IsValid)
            {
                // reload category list
                model.AllCategories = (await _categoryRepository.GetAllCategoriesAsync())
                    .Select(c => new SelectListItem
                    {
                        Value = c.Id.ToString(),
                        Text = c.Name
                    }).ToList();
                return View(model);
            }

            var dto = new ProductCreateDto
            {
                Name = model.Name,
                Description = model.Description,
                Price = model.Price,
                Image = model.Image,
                NumberInStock = model.NumberInStock,
                CategoryIds = model.CategoryIds
            };

            var json = JsonConvert.SerializeObject(dto);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var client = _httpClientFactory.CreateClient();
            var response = await client.PostAsync("/api/product/create", content);

            if (response.IsSuccessStatusCode)
                return RedirectToAction("Index");

            ModelState.AddModelError("", "Failed to create product.");
            return View(model);
        }

    }
}