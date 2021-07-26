namespace ShopCarv.Dato.Helper
{
    using Microsoft.AspNetCore.Identity;
    using ShopCarv.Dato.ModelsDB.Entities;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class UserHelper : IUserHelper
    {
        private readonly UserManager<User> userManager;

        public UserHelper(UserManager<User> userManager)
        {
            this.userManager = userManager;
        }

        public async Task<IdentityResult> AddUserAsync(User user, string password)
        {
            return await this.userManager.CreateAsync(user, password);
        }

        public async Task<User> GetUserByMailAsync(string email)
        {
            return await this.userManager.FindByEmailAsync(email);
        }

    }

}
