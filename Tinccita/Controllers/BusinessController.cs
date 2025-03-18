using Microsoft.AspNetCore.Mvc;
using Tinccita.Application.DTOs.Business;
using Tinccita.Application.Services.Interfaces;

namespace Tinccita.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BusinessController(IBusinessService businessService) : ControllerBase
    {
        [HttpGet("single/{id}")]
        public async Task<IActionResult> GetSingle(Guid id)
        {
            var data = await businessService.GetByIdAsync(id);
            return data != null ? Ok(data) : NotFound();
        }
        [HttpGet("find-by-name/{name}")]
        public async Task<IActionResult> GetByName(string name)
        {
            var data = await businessService.GetByNameAsync(name);
            return data != null ? Ok(data) : NotFound();
        }
        [HttpGet("find-by-doc/{document}")]
        public async Task<IActionResult> GetByDocument(string document)
        {
            var data = await businessService.GetByDocument(document);
            return data != null ? Ok(data) : NotFound();
        }
        [HttpGet("find-by-email/{email}")]
        public async Task<IActionResult> GetByEmail(string email)
        {
            var data = await businessService.GetByEmail(email);
            return data != null ? Ok(data) : NotFound();
        }
        [HttpPost("add")]
        public async Task<IActionResult> Add([FromBody] CreateBusiness business)
        {
            var result = await businessService.AddAsync(business);
            return result.Success ? Ok(result) : BadRequest(result);
        }
        [HttpPut("update")]
        public async Task<IActionResult> Update([FromBody] UpdateBusiness business)
        {
            var result = await businessService.UpdateAsync(business);
            return result.Success ? Ok(result) : BadRequest(result);
        }
        [HttpDelete("delete/{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var result = await businessService.DeleteAsync(id);
            return result.Success ? Ok(result) : BadRequest(result);
        }
    }
}
