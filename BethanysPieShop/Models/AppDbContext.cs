using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BethanysPieShop.Models
{
    //replace dbcontext with IdentityDbContext and pass deafult type for the user(IdentityUser)
    //now we can work with type user.
    public class AppDbContext:IdentityDbContext<IdentityUser>
    {
        //options need to be passed to the base type
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {

        }
        //EF Core is now aware of the pies type and it will later on also create the corresponding table in DB
        public DbSet<Pie> Pies { get; set; } 

        public DbSet<Feedback> Feedbacks { get; set; }
    }
}
