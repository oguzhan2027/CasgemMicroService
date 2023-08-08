using AutoMapper;
using CasgemMicroService.Services.Catalog.Dtos.CategoryDtos;
using CasgemMicroService.Services.Catalog.Dtos.ProductDtos;
using CasgemMicroService.Services.Catalog.Models;

namespace CasgemMicroService.Services.Catalog.Mapping
{
    public class GeneralMapping : Profile
    {
        public GeneralMapping() 
        {
            CreateMap<Product, ResultProductDto>().ReverseMap();
            CreateMap<Product, CreateProductDto>().ReverseMap();
            CreateMap<Product, UpdateProductDto>().ReverseMap();

            CreateMap<Category, ResultCategoryDto>().ReverseMap();
            CreateMap<Category, CreateCategoryDto>().ReverseMap();
            CreateMap<Category, UpdateCategoryDto>().ReverseMap();




        }
    }
}
