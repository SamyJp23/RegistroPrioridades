using Microsoft.Extensions.Options;
using Prioridad.Components;

using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Components.Web;
using RegistroPrioridades;
using Radzen;
using Microsoft.AspNetCore.Mvc.ModelBinding.Binders;

var builder = WebApplication.CreateBuilder(args);
{
// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

    
    


       //Constructor
    var ConStr = builder.Configuration.GetConnectionString("ConStr");
      //Contexto
      builder.Services.AddDbContext<ClienteContext>(Options => Options.UseSqlite(ConStr));
      //BLL
     builder.Services.AddScoped<ClientesBLL>();
}
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
