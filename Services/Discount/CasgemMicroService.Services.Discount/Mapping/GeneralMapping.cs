using AutoMapper;
using CasgemMicroService.Services.Discount.Dtos;
using CasgemMicroService.Services.Discount.Models;

namespace CasgemMicroService.Services.Discount.Mapping
{
    public class GeneralMapping : Profile
    {
        public GeneralMapping()
        {
            CreateMap<DiscountCoupons, ResultDiscountDto>().ReverseMap();
            CreateMap<DiscountCoupons, CreateDiscountDto>().ReverseMap();
            CreateMap<DiscountCoupons, UpdateDiscountDto>().ReverseMap();

        }
    }
}
