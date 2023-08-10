using CasgemMicroService.Services.Basket.Dtos;
using CasgemMicroService.Shared.Dtos;

namespace CasgemMicroService.Services.Basket.Services
{
    public interface IBasketService
    {
       Task<Response<BasketDto>> GetBasket(string userID);
       Task<Response<bool>> SaveOrUpdate(BasketDto basketDto);
       Task<Response<bool>> DeleteBasket(string userID);
    }
}
