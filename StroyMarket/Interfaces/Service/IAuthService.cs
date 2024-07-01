using StroyMarket.Dto;
using StroyMarket.Model;

namespace StroyMarket.Interfaces.Service
{
    public interface IAuthService
    {
        bool Create(UserDto user);
        bool Verify(string phone, int code);
        User Find(string phone);
    }
}
