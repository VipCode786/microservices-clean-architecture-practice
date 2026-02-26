
using eCommerce.Core.Entities;

namespace eCommerce.Core.RepositoryContracts
{
    public interface IUserRepository
    {
        // Task<return value ?> , task means async , ? nullable
        Task<ApplicationUser?> AddUser(ApplicationUser user);
        Task<ApplicationUser?> GetUserByEmailAndPassword(string? email, string? password) ;
    }
}
