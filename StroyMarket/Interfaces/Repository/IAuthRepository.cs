using MohirdevNet.Model;

namespace MohirdevNet.Interfaces.Repository
{
    public interface IAuthRepository
    {

        // ICollection<User> GetUsers();
        // User GetUser(int id);
        bool Create(User user);
        bool Verify(int id);
        User GetOne(string phone);

        bool Save();

    }
}
