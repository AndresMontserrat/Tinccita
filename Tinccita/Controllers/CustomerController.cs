using Microsoft.AspNetCore.Mvc;
using Tinccita.Application.DTOs.Customer;
using Tinccita.Application.Services.Interfaces;

namespace Tinccita.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerService(ICustomerService customerService) : ControllerBase
    {
        [HttpGet("single/{id}")]
        public async Task<IActionResult> GetSingle(Guid id)
        {
            var data = await customerService.GetByIdAsync(id);
            return data != null ? Ok(data) : NotFound();
        }
        [HttpGet("find/{id}")]
        public async Task<IActionResult> GetByEmail(string email)
        {
            var data = await customerService.GetByEmailAsync(email);
            return data != null ? Ok(data) : NotFound();
        }
        [HttpPost("add")]
        public async Task<IActionResult> Add([FromBody] CreateCustomer customer)
        {
            var result = await customerService.AddAsync(customer);
            return result.Success ? Ok(result) : BadRequest(result);
        }
        [HttpPut("update")]
        public async Task<IActionResult> Update([FromBody] UpdateCustomer customer)
        {
            var result = await customerService.UpdateAsync(customer);
            return result.Success ? Ok(result) : BadRequest(result);
        }
        [HttpDelete("delete/{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var result = await customerService.DeleteAsync(id);
            return result.Success ? Ok(result) : BadRequest(result);
        }
    }
}
