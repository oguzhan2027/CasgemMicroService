using CasgemMicroService.Services.Catalog.Dtos.CategoryDtos;
using CasgemMicroService.Shared.Dtos;

namespace CasgemMicroService.Services.Catalog.Services.CategoryServices
{
    public interface ICategoryService
    {
        Task<Response<List<ResultCategoryDto>>> GetAllCategoryAsync();
        Task<Response<ResultCategoryDto>> GetByIdCategoryAsync(string id);
        Task<Response<NoContent>> CreateCategoryAsync(CreateCategoryDto categoryDto);
        Task<Response<NoContent>> UpdateCategoryAsync(UpdateCategoryDto updateDto);
        Task<Response<NoContent>> DeleteCategoryAsync(string id);
    }
}
