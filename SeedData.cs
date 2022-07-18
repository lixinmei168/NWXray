using Microsoft.AspNetCore.Identity;

namespace NWXray
{
    public static class SeedData
    {
        public static void Seed(UserManager<IdentityUser> userManager,
        RoleManager<IdentityRole> roleManager)
        {
            SeedRoles(roleManager);
            SeedUsers(userManager);

        }
        private static void SeedUsers(UserManager<IdentityUser> userManager)
        {
            //Add administrator user
            if(userManager.FindByNameAsync("admin").Result == null)
            {
                var user = new IdentityUser 
                { 
                    UserName = "admin",
                    Email = "adminNWXray@gmail.com"

                };
                var result = userManager.CreateAsync(user, "Password1").Result;
                if (result.Succeeded)
                {
                    userManager.AddToRoleAsync(user, "Administrator").Wait();
                }
            }

        }
        private static void SeedRoles(RoleManager<IdentityRole> roleManager)
        {

            //Add three roles: Adminstrator, Dealer and Client
            if (!roleManager.RoleExistsAsync("Administrator").Result)
            {
                var role = new IdentityRole
                {
                    Name = "Administrator"
                };
                var result = roleManager.CreateAsync(role).Result;
            }
            if (!roleManager.RoleExistsAsync("Dealer").Result)
            {
                var role = new IdentityRole
                {
                    Name = "Dealer"
                };
                var result = roleManager.CreateAsync(role).Result;
            }
            if (!roleManager.RoleExistsAsync("Client").Result)
            {
                var role = new IdentityRole
                {
                    Name = "Client"
                };
                var result = roleManager.CreateAsync(role).Result;
            }

        }
    }
}
