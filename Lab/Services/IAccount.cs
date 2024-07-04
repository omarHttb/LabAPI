using Lab.Model;
using Microsoft.AspNetCore.Identity;

namespace Lab.Services
{
    public interface IAccount
    {
        Task<IdentityResult> CreateAccount(SignUpDTO signupDTO);

        Task<SignInResult> SignIn(SignInDTO signIn);

        Task<List<UsersDTO>> GetUsers();

        Task Signout();
    }
}
