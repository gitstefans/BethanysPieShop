using System;
using BethanysPieShop.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

[assembly: HostingStartup(typeof(BethanysPieShop.Areas.Identity.IdentityHostingStartup))]
namespace BethanysPieShop.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            //need to register the identity services with the services collection.
            builder.ConfigureServices((context, services) => {
                //ADI bring in support for Identity in services collection
                //call AEFS and pass db context
                //appdbcontext will be used to store Identity information(user info...)
                services.AddDefaultIdentity<IdentityUser>().AddEntityFrameworkStores<AppDbContext>();
            });
        }
    }
}