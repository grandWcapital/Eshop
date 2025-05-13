using AutoMapper;
using EShop.Application.Dtos;
using EShop.Domain.Models;
using EShop.ModelViews;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<Product, ProductCreateDto>();
        CreateMap<ProductCreateDto, Product>();

        // ✅ Add this line to fix the exception
        CreateMap<Product, ProductDto>();
    }
}
