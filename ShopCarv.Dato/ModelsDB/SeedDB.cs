namespace ShopCarv.Dato.ModelsDB
{
    using Entities;
    using Microsoft.AspNetCore.Identity;
    using ShopCarv.Dato.Helper;
    using System;
    using System.Linq;
    using System.Threading.Tasks;
    public class SeedDB
    {

        private readonly DataContext context;
        //private readonly UserManager<User> userManager; se cambio al implementear el userhelper
        private readonly IUserHelper userHelper;
        private readonly Random random;

        public SeedDB(DataContext context, IUserHelper userHelper)
        {
            this.context = context;
            //this.userManager = userManager; se cambio al implementear el userhelper
            this.userHelper = userHelper;
            random = new Random();
        }

        public async Task SeedDBAsync()
        {
            await context.Database.EnsureCreatedAsync();

            //var user = await this.userManager.FindByEmailAsync("carvin.viera@osdop.org.ar");se cambio al implementear el userhelper
            var user = await userHelper.GetUserByMailAsync("carvin.viera@osdop.org.ar");
            if (user == null)
            {
                user = new User
                {
                    Id = "1",
                    FirstName = "Carvin Jourda",
                    LastName = "Viera Sanoja",
                    Email = "carvin.viera@osdop.org.ar",
                    UserName = "carvin.viera@osdop.org.ar",
                    PhoneNumber = "5491122538768",
                    LockoutEnd = DateTime.Now,
                };

                //var result = await this.userManager.CreateAsync(user, "101284");se cambio al implementear el userhelper
                var result = await userHelper.AddUserAsync(user, "101284");
                if (result != IdentityResult.Success)
                {
                    throw new InvalidOperationException("Could not create the user in Seeder");
                }
            }

            if (!context.Products.Any())
            {
                AddProducts("Iphone X", user);
                AddProducts("I Waths Pro", user);
                AddProducts("Smart Tv 4k", user);
                await context.SaveChangesAsync();
            }
        }

        private void AddProducts(string Name, User user)
        {
            context.Products.Add(new Product
            {
                Name = Name,
                Price = random.Next(1000),
                IsAvailabe = true,
                Stock = random.Next(100),
                User = user
            });
        }
    }
}