using Web_API.Models;

namespace Web_API.Interfaces
{
    public interface ITokenService
    {
        string CreateToken(AppUser user);
    }
}
