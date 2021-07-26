namespace ShopCarv.Dato.Helper
{
    using Microsoft.AspNetCore.Identity;
    using ShopCarv.Dato.ModelsDB.Entities;
    using System.Threading.Tasks;
    public interface IUserHelper
    {
        Task<User> GetUserByMailAsync(string email);
        Task<IdentityResult> AddUserAsync(User user, string password);
    }
}
