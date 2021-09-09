namespace CleaningWeb.Data.Seeding
{
    using System;
    using System.Threading.Tasks;

    using CleaningWeb.Common;
    using CleaningWeb.Data.Models;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.Extensions.DependencyInjection;

    public class UsersSeeder : ISeeder
    {
        public async Task SeedAsync(CleaningDbContext dbContext, IServiceProvider serviceProvider)
        {
            var userManager = serviceProvider.GetRequiredService<UserManager<ApplicationUser>>();

            await SeedUserAsync(userManager, "admin@admin.com");
        }

        private static async Task SeedUserAsync(UserManager<ApplicationUser> userManager, string username)
        {
            var user = await userManager.FindByNameAsync(username);
            if (user == null)
            {
                ApplicationUser appUser = new();
                appUser.UserName = username;
                appUser.Email = username;

                IdentityResult result = new();

                if (username == " ") // Admin email
                {
                    result = userManager.CreateAsync(appUser, " ").Result; //Admin password
                }

                if (result.Succeeded)
                {
                    if (username == " ") // Admin email
                    {
                        userManager.AddToRoleAsync(appUser, GlobalConstants.AdministratorRoleName).Wait();
                    }
                }
            }
        }
    }
}
