using Microsoft.AspNetCore.Mvc;
using Tinccita.Application.DTOs.Service;
using Tinccita.Application.Services.Interfaces;

namespace Tinccita.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServiceController(IServiceService serviceService) : ControllerBase
    {
        [HttpGet("single/{id}")]
        public async Task<IActionResult> GetSingle(Guid id)
        {
            var data = await serviceService.GetByIdAsync(id);
            return data != null ? Ok(data) : NotFound();
        }
        [HttpGet("find-by-subcategory/{id}")]
        public async Task<IActionResult> FindBySubcategory(Guid id)
        {
            var data = await serviceService.GetAllBySubcategoryAsync(id);
            return data != null ? Ok(data) : NotFound();
        }
        [HttpGet("find-by-title/{characters}")]
        public async Task<IActionResult> FindByTitle(string characters)
        {
            var data = await serviceService.GetByTitleDescriptionAsync(characters);
            return data != null ? Ok(data) : NotFound();
        }
        [HttpPost("add")]
        public async Task<IActionResult> Add([FromBody] CreateService service)
        {
            var result = await serviceService.AddAsync(service);
            return result.Success ? Ok(result) : BadRequest(result);
        }
        [HttpPut("update")]
        public async Task<IActionResult> Update([FromBody] UpdateService service)
        {
            var result = await serviceService.UpdateAsync(service);
            return result.Success ? Ok(result) : BadRequest(result);
        }
        [HttpDelete("delete/{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var result = await serviceService.DeleteAsync(id);
            return result.Success ? Ok(result) : BadRequest(result);
        }
    }
}
