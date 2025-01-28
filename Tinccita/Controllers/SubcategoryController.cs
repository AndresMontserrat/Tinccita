using Microsoft.AspNetCore.Mvc;
using Tinccita.Application.DTOs.Subcategory;
using Tinccita.Application.Services.Interfaces;

namespace Tinccita.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubcategoryController(ISubcategoryService subcategoryService) : ControllerBase
    {
        [HttpGet("all")]
        public async Task<IActionResult> GetAll()
        {
            var data = await subcategoryService.GetAllAsync();
            return data.Any() ? Ok(data) : NotFound();
        }
        [HttpGet("single/{id}")]
        public async Task<IActionResult> GetSingle(Guid id)
        {
            var data = await subcategoryService.GetByIdAsync(id);
            return data != null ? Ok(data) : NotFound();
        }
        [HttpPost("add")]
        public async Task<IActionResult> Add([FromBody] CreateSubcategory subcategory)
        {
            var result = await subcategoryService.AddAsync(subcategory);
            return result.Success ? Ok(result) : BadRequest(result);
        }
        [HttpPut("update")]
        public async Task<IActionResult> Update([FromBody] UpdateSubcategory subcategory)
        {
            var result = await subcategoryService.UpdateAsync(subcategory);
            return result.Success ? Ok(result) : BadRequest(result);
        }
        [HttpDelete("delete/{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var result = await subcategoryService.DeleteAsync(id);
            return result.Success ? Ok(result) : BadRequest(result);
        }
    }
}
