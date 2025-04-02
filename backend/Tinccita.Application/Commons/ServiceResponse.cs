namespace Tinccita.Application.DTOs
{
    public record class ServiceResponse(bool Success = false, string Message = null!);
}
