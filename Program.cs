using EmptyProject.Components.Shared;
using EmptyProject_NET8_Blazor.Components;
using EmptyProject.DatabaseContexts;
using EmptyProject.Areas.CMS.UserBack.Repositories;
using EmptyProject.Areas.CMS.UserBack.Services;
using EmptyProject.Areas.CMS.RoleBack.Repositories;
using EmptyProject.Areas.CMS.RoleBack.Services;
using EmptyProject.Areas.CMS.MenuBack.Repositories;
using EmptyProject.Areas.CMS.MenuBack.Services;
using EmptyProject.Areas.CMS.RoleMenuBack.Repositories;
using EmptyProject.Areas.CMS.RoleMenuBack.Services;
using EmptyProject.Areas.System.FailureBack.Repositories;
using EmptyProject.Areas.System.FailureBack.Services;
using EmptyProject.Areas.System.ParameterBack.Repositories;
using EmptyProject.Areas.System.ParameterBack.Services;
using Microsoft.Extensions.Caching.Memory;

var builder = WebApplication.CreateBuilder(args);

//Add service to cache data
builder.Services.AddSingleton<IMemoryCache>(
    new MemoryCache(new MemoryCacheOptions()));

// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();
builder.Services.AddServerSideBlazor();
builder.Services.AddHttpClient();

builder.Services.AddDbContext<EmptyProjectContext>(ServiceLifetime.Scoped);

//Set access to repositories
builder.Services.AddScoped<UserRepository>();
builder.Services.AddScoped<UserService>();
builder.Services.AddScoped<RoleRepository>();
builder.Services.AddScoped<RoleService>();
builder.Services.AddScoped<MenuRepository>();
builder.Services.AddScoped<MenuService>();
builder.Services.AddScoped<RoleMenuRepository>();
builder.Services.AddScoped<RoleMenuService>();
builder.Services.AddScoped<FailureRepository>();
builder.Services.AddScoped<FailureService>();
builder.Services.AddScoped<ParameterRepository>();
builder.Services.AddScoped<ParameterService>();

//Set access to repositories: EmptyProject

//Set access to StateContainer to share data between Blazor components
builder.Services.AddScoped<StateContainer>();

//This line is to see other errors in the page, if appears
//builder.Services.AddServerSideBlazor().AddCircuitOptions(options => { options.DetailedErrors = true; });

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/500", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseStatusCodePagesWithRedirects("/404");

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

//app.UseMiddleware<ExceptionHandlerMiddleware>();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();
app.MapControllers();

app.Run();
