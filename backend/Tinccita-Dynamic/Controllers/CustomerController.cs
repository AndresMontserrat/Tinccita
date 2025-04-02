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
        [HttpGet("find-by-email/{email}")]
        public async Task<IActionResult> GetByEmail(string email)
        {
            var data = await customerService.GetByEmailAsync(email);
            return data != null ? Ok(data) : NotFound();
        }
        [HttpGet("find-by-phone/{phone}")]
        public async Task<IActionResult> GetByPhone(string phone)
        {
            var data = await customerService.GetByPhoneAsync(phone);
            return data != null ? Ok(data) : NotFound();
        }
        [HttpGet("find-by-name/{characters}")]
        public async Task<IActionResult> GetByName(string characters)
        {
            var data = await customerService.GetByNameSurnameAsync(characters);
            return data != null ? Ok(data) : NotFound();
        }
        [HttpPost("add")]
        public async Task<IActionResult> Add([FromBody] CreateCustomer customer)
        {
            if (!ModelState.IsValid)
            {
                var errors = ModelState
                    .Where(ms => ms.Value!.Errors.Count > 0) 
                    .ToDictionary(
                        ms => ms.Key,
                        ms => ms.Value!.Errors.Select(e => e.ErrorMessage).ToList()
                    );
                return BadRequest(new { Message = "Validation failed", Errors = errors });
            }
            var result = await customerService.AddAsync(customer);
            return result.Success ? Ok(result) : BadRequest(result);
        }
        [HttpPut("update")]
        public async Task<IActionResult> Update([FromBody] UpdateCustomer customer)
        {
            if (!ModelState.IsValid)
            {
                var errors = ModelState
                    .Where(ms => ms.Value!.Errors.Count > 0)
                    .ToDictionary(
                        ms => ms.Key,
                        ms => ms.Value!.Errors.Select(e => e.ErrorMessage).ToList()
                    );
                return BadRequest(new { Message = "Validation failed", Errors = errors });
            }
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
