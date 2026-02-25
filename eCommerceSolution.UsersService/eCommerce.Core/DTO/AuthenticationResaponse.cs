
namespace eCommerce.Core.DTO
{
    public record  AuthenticationResaponse
    (
        Guid UserID,
        string? Email,
        string? PersonName,
        string? Gender,
        string? Token,
        bool Success
    );
}
