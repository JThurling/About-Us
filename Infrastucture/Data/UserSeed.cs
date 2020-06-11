using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text.Json;
using System.Threading.Tasks;
using Core.Entity;

namespace Infrastucture.Data
{
    public class UserSeed
    {
        public static async Task SeedAsync(UserContext context)
        {
            try
            {
                if (!context.UserInformation.Any())
                {
                    var users = File.ReadAllText("../Infrastucture/Data/SeedData/userInfo.json");

                    var userInfo = JsonSerializer.Deserialize<List<UserEntity>>(users);

                    foreach (var user in userInfo)
                    {
                        context.UserInformation.Add(user);
                    }

                    await context.SaveChangesAsync();
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                throw;
            }
        }
    }
}