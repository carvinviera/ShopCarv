using Microsoft.AspNetCore.Identity;

namespace ShopCarv.Dato.ModelsDB.Entities
{
    public class User : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

    }
}


