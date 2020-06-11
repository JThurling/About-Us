using System.Collections.Generic;
using Core.Entity;
using Microsoft.EntityFrameworkCore;

namespace Infrastucture.Data
{
    public class UserContext : DbContext
    {
        public UserContext(DbContextOptions<UserContext> options)
        : base(options)
        { }

        public DbSet<UserEntity> UserInformation { get; set; }
    }
}