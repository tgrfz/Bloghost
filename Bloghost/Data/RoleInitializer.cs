using System;
using System.IO;
using System.Text.Json;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Bloghost.Domain;

namespace Bloghost.Data
{
    public static class RoleInitializer
    {
        public static async Task InitializeAsync(UserManager<User> userManager,
            RoleManager<IdentityRole> roleManager)
        {
            if (await roleManager.FindByNameAsync("admin") == null)
                await roleManager.CreateAsync(new IdentityRole("admin"));
            if (await roleManager.FindByNameAsync("moderator") == null)
                await roleManager.CreateAsync(new IdentityRole("moderator"));
            if (await roleManager.FindByNameAsync("user") == null)
                await roleManager.CreateAsync(new IdentityRole("user"));

            if (await userManager.FindByNameAsync("admin") == null)
            {
                User admin;
                string path = @"D:\admin.json";
                using (FileStream fs = new FileStream(path, FileMode.Open))
                {
                    admin = await JsonSerializer.DeserializeAsync<User>(fs);
                }
                IdentityResult result = await userManager.CreateAsync(admin, "adminpassword");
                if (result.Succeeded)
                    await userManager.AddToRoleAsync(admin, "admin");
                await userManager.UpdateAsync(admin);
            }
        }
    }
}