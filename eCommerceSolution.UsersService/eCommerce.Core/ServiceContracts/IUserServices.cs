

using eCommerce.Core.DTO;

namespace eCommerce.Core.ServiceContracts
{
    public interface IUserServices
    {
        Task<AuthenticationResponse?> Login(LoginRequest loginRequest);
        Task<AuthenticationResponse?> Register(RegisterRequest registerRequest);

    }
}
