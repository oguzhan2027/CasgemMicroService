using CasgemMicroService.Services.Catalog.Dtos.ProductDtos;
using CasgemMicroService.Shared.Dtos;

namespace CasgemMicroService.Services.Catalog.Services.ProductServices
{
    public interface IProductService
    {
        Task<Response<List<ResultProductDto>>> GetAllProductAsync();
        Task<Response<ResultProductDto>> GetByIdProductAsync(string id);
        Task<Response<NoContent>> CreateProductAsync(CreateProductDto categoryDto);
        Task<Response<NoContent>> UpdateProductAsync(UpdateProductDto updateDto);
        Task<Response<NoContent>> DeleteProductAsync(string id);
    }
}
