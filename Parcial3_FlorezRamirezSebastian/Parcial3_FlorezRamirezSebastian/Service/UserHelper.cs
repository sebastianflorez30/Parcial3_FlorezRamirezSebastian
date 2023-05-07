using Microsoft.AspNetCore.Identity;
using Parcial3_FlorezRamirezSebastian.DAL;
using Parcial3_FlorezRamirezSebastian.DAL.Entities;
using Parcial3_FlorezRamirezSebastian.Helpers;

namespace Parcial3_FlorezRamirezSebastian.Service
{
    public class UserHelper : IUserHelper 
    {
        private readonly DatabaseContext _context;
        private readonly UserManager<User> _userManager;
        private readonly RoleManager<IdentityRole>_roleManager;


        public UserHelper(DatabaseContext context, UserManager<User>userManager,RoleManager<IdentityRole>roleManager)
        {
            _context = context;
            _userManager = userManager;
            _roleManager = roleManager;
        }
        public async Task<IdentityResult> AddUserAsync(User user, string password)
        {
            return await _userManager.CreateAsync(user, password);
        }

        public async Task AddUserToRoleAsync(User user, string roleName)
        {
            await _userManager.AddToRoleAsync(user, roleName);
        }

        public async Task CheckRoleAsync(string roleName)
        {
            bool roleExists=await _roleManager.RoleExistsAsync(roleName); //valida si el rol existe o no
            if (!roleExists) await _roleManager.CreateAsync(new IdentityRole { Name = roleName });
        }

        public Task<User> GetUserAsync(string email)
        {
            throw new NotImplementedException();
        }

        public Task<bool> IsUserInRoleAsync(User user, string roleName)
        {
            throw new NotImplementedException();
        }
    }
}
