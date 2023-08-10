using CasgemMicroService.Services.Discount.Dtos;
using CasgemMicroService.Services.Discount.Models;
using CasgemMicroService.Shared.Dtos;

namespace CasgemMicroService.Services.Discount.Services
{
    public interface IDiscountService
    {
        Task<Response<List<ResultDiscountDto>>> GetAllDiscountCouponsAsync();
        Task<Response<ResultDiscountDto>> GetByIdDiscountCouponsAsync(int id);
        Task<Response<NoContent>> CreateDiscountCouponsAsync(CreateDiscountDto createDiscountDto);
        Task<Response<NoContent>> UpdateDiscountCouponsAsync(UpdateDiscountDto updateDiscountDto);
        Task<Response<NoContent>> DeleteDiscountCouponsAsync(int id);
    }
}
