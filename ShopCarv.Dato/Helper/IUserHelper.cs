﻿namespace ShopCarv.Dato.Helper
{
    using Microsoft.AspNetCore.Identity;
    using ShopCarv.Dato.ModelsDB.Entities;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    public interface IUserHelper
    {
        Task<User> GetUserByMailAsync(string email);
        Task<IdentityResult> AddUserAsync(User user, string password);
    }
}
