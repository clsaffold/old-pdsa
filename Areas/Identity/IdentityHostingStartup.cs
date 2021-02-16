using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using pdsatracker.Data;

[assembly: HostingStartup(typeof(pdsatracker.Areas.Identity.IdentityHostingStartup))]
namespace pdsatracker.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<PdsatrackerContext>(options =>
                    options.UseMySql(
                        context.Configuration.GetConnectionString("PdsatrackerContextConnection")));

                services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
                    .AddEntityFrameworkStores<PdsatrackerContext>();
            });
        }
    }
}