using Microsoft.AspNetCore.Identity;
using Parcial3_FlorezRamirezSebastian.DAL.Entities;

namespace Parcial3_FlorezRamirezSebastian.Helpers
{
    public interface IUserHelper//para indicar la firma del usuario, firma metodo
    {
        Task<User>GetUserAsync(string email);//traer usuario buscando por email
        Task<IdentityResult>AddUserAsync(User user,string password);

        Task CheckRoleAsync(string roleName);// valida si el rol existe
        Task AddUserToRoleAsync(User user, string roleName);//agregar nuevo usuario a un rol

        Task<bool>IsUserInRoleAsync(User user, string roleName); //validar si esta relacionado a un rol este usuario 

    }
}
