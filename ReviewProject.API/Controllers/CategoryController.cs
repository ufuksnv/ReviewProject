using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ReviewProject.Core.DTOs;
using ReviewProject.Core.Models;
using ReviewProject.Core.Services;

namespace ReviewProject.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : CustomBaseController
    {
        private readonly IServiceGeneric<Category, CategoryDto> _categoryService;

        public CategoryController(IServiceGeneric<Category, CategoryDto> categoryService)
        {
            _categoryService = categoryService;
        }


        [HttpGet]
        public async Task<IActionResult> GetCategory()
        {
            return ActionResultInstance(await _categoryService.GetAllAsync());
        }

        [HttpPost]
        public async Task<IActionResult> SaveCategory(CategoryDto categoryDto)
        {
            return ActionResultInstance(await _categoryService.AddAsync(categoryDto));
        }

        [HttpPut]
        public async Task<IActionResult> UpdateCategory(CategoryDto categoryDto)
        {
            return ActionResultInstance(await _categoryService.Update(categoryDto, categoryDto.CategoryId));
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCategory(int id)
        {
            return ActionResultInstance(await _categoryService.Remove(id));
        }



    }
}
