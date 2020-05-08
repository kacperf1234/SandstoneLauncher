using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using ElectronNET.API;
using ElectronNET.API.Entities;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace SandstoneLauncher.App
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            services.AddHttpsRedirection(x =>
            {
                x.HttpsPort = 5001;
                x.RedirectStatusCode = StatusCodes.Status307TemporaryRedirect;
            });
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();
            app.UseEndpoints(x => x.MapControllerRoute("default", "{controller}/{action}"));
            app.UseStaticFiles();
            app.UseHttpsRedirection();
            
            Task.Run(async () =>
            {
                BrowserWindowOptions options = new BrowserWindowOptions()
                {
                    Center = true,
                    Width = 800,
                    Height = 600,
                    Show = false
                };

                BrowserWindow window = await Electron.WindowManager.CreateWindowAsync(options, "http://localhost:8001/start");
                
                window.OnReadyToShow += () =>
                {
                    window.RemoveMenu();
                    window.Show();
                    window.ShowInactive();
                };
            });
        }
    }
}