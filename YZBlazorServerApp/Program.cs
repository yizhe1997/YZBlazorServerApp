using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Identity;
using YZBlazorServerApp.Areas.Identity;
using YZBlazorServerApp.Datas;
using YZBlazorServerApp.Datas.Services;
using YZBlazorServerApp.Infrastructures.EFCore;
using YZBlazorServerApp.Pages.Items;

var builder = WebApplication.CreateBuilder(args);
var configuration = builder.Configuration;

#region Adding services to container

// Blazor
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();

// EFCore
builder.Services.AddEFCoreServices(configuration);

// Authentication
builder.Services.AddScoped<AuthenticationStateProvider, RevalidatingIdentityAuthenticationStateProvider<IdentityUser>>();

// DB seed and update
builder.Services.AddDbServices();

// Misc.
builder.Services.AddSingleton<WeatherForecastService>();
builder.Services.AddHttpClient();

// Blazor Services
builder.Services.AddScoped<ItemConfigDialogService>();

#endregion

var app = builder.Build();

#region WebApp scoped services

// Scoped services
using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;

    // EFCore
    services.UseEFCoreServices();

    // DB seed and update
    services.UseDbServices();
}

#endregion

#region WebApp MiddleWare

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseMigrationsEndPoint();
}
else
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();
app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

// what this??
app.MapControllerRoute("default", "{controller=Home}/{action=Index}/{id?}");

#endregion

app.Run();
