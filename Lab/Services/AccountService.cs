using Lab.Model;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace Lab.Services
{
    public class AccountService : IAccount
    {
        UserManager<ApplicationUser> userManager;
        SignInManager<ApplicationUser> signInManager;
        RoleManager<IdentityRole> roleManager;
        public AccountService(UserManager<ApplicationUser> _userManager, SignInManager<ApplicationUser> _signInManager
            , RoleManager<IdentityRole> _roleManager)
        {
            userManager = _userManager;
            signInManager = _signInManager;
            roleManager = _roleManager;
        }

        public async Task<IdentityResult> CreateAccount(SignUpDTO signupDTO)
        {
            ApplicationUser user = new ApplicationUser();

            user.Name = signupDTO.Username;
            user.Email = signupDTO.Email;
            user.gender = signupDTO.Gender;
            user.UserName = signupDTO.Email;
            user.DateOfBirth = signupDTO.DateOfBirth;
            //user.PasswordHash = signupDTO.Password;

            // sending password to createasync so that microsoft code would hash the password , ENCRPYT THE PASSWRD
            var result = await userManager.CreateAsync(user, signupDTO.Password);

            return result;
        }

        public async Task<SignInResult> SignIn(SignInDTO signIn)
        {
            var result = await signInManager.PasswordSignInAsync(signIn.Username, signIn.Password, signIn.RememeberMe, false);

            return result;
        }

        public async Task<List<UsersDTO>> GetUsers()
        {
            List<ApplicationUser> allUsers = await userManager.Users.ToListAsync();
            List<UsersDTO> users = new List<UsersDTO>();
            foreach (ApplicationUser user in allUsers)
            {
                UsersDTO userDTO = new UsersDTO();
                userDTO.Id = user.Id;
                userDTO.Name = user.Name;
                userDTO.Email = user.Email;
         
                users.Add(userDTO);

            }

            return users;
        }
        public async Task<ApplicationUser> getUSerInfo(string username)
        {
            var result = await userManager.FindByNameAsync(username);
            return result;

        }

        public async Task Signout()
        {
            await signInManager.SignOutAsync();
        }

    }
}
