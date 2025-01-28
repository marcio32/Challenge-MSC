using UI.Shared.Interfaces;
using UI.Web.Services;
using UIV.Services;
using UIV.Web.Components;

namespace UIV
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddRazorComponents()
                .AddInteractiveServerComponents();

            // Add device-specific services used by the UIV.Shared project
            builder.Services.AddSingleton<IPlatformService, PlatformServiceWeb>();
            builder.Services.AddSingleton<INotificationService, DesktopSnackbarService>();
            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();

            app.UseStaticFiles();
            app.UseAntiforgery();

            app.MapRazorComponents<App>()
                .AddInteractiveServerRenderMode()
                .AddAdditionalAssemblies(typeof(UIV.Shared._Imports).Assembly);

            app.Run();
        }
    }
}
