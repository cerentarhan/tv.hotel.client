using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TourVisio.Hotel.Client.Data
{
    public class LoginTutorialDbContext:IdentityDbContext<IdentityUser>
    {
        public LoginTutorialDbContext(DbContextOptions<LoginTutorialDbContext> options) : base(options)
        {
            Database.EnsureCreated();
        }
        

        
    }
}
