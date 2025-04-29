using AutoMapper;
using EShop.Application.Dtos;
using EShop.Domain.Models;

namespace EShop.Application.Helper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Product, ProductDto>();
        }
    }
}
