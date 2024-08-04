using ETicaret.Catalog.Dtos.CategoryDtos;

namespace ETicaret.Catalog.Services.CategoryServices
{
    public interface  ICatagoryService
    {
        Task<List<ResultCategoryDto>> GetAllCategoriesAsync();

        Task CreateCategoryAsync(CreateCategoryDto createCategoryDto);
        Task UpdateCategoryAsync(UpdateCategoryDto updateCategoryDto);
        Task DeleteCategoryAsync(string id);
        Task<GetByIdCategoryDto> GetByIdCategoryAsync(string id);
    }
}
