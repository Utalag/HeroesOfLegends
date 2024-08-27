using HeroesOfLegends.Businsess.Interfaces;
using HeroesOfLegends.Businsess.Managers;
using HeroesOfLegends.Businsess.Models;
using HeroesOfLegends.Data;
using HeroesOfLegends.Data.Interfaces;
using HeroesOfLegends.Data.Repositories;
using HeroesOfLegends.Models;
using HeroesOfLegends.Client.Pages;
using HeroesOfLegends.Components;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using System.Text.Json.Serialization;
using Microsoft.Build.Framework;
using Microsoft.Identity.Client;
using Microsoft.Identity.Client.Extensibility;

namespace HeroesOfLegends
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Date Database
            var connectionString = builder.Configuration.GetConnectionString("CharacterBookContext") ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");

            builder.Services.AddDbContext<HoLDbContext>(options =>
                options.UseSqlServer(connectionString)
                .UseLazyLoadingProxies()
                .ConfigureWarnings(x => x.Ignore(CoreEventId.LazyLoadOnDisposedContextWarning)));

            // nastaven� konverze enum hodnoty na string
            //builder.Services.AddControllers().AddJsonOptions(options =>
            //     options.JsonSerializerOptions.Converters.Add(new JsonStringEnumConverter()));

            // Add services to the container.
            builder.Services.AddRazorComponents()
                .AddInteractiveServerComponents()
                .AddInteractiveWebAssemblyComponents();

            //přidání swaggeru
            builder.Services.AddSwaggerGen();

            // add controller builder
            builder.Services.AddControllersWithViews();
            builder.Services.AddControllers();
            builder.Services.AddEndpointsApiExplorer();

            // add razer pages
            builder.Services.AddRazorPages();

            // add antiforgery token support for post requests in razor pages and controllers   
            builder.Services.AddDatabaseDeveloperPageExceptionFilter();

            // modely
            builder.Services.AddScoped<IProfession,Profession>();

            // registrace repositare
            builder.Services.AddScoped<IRaceRepository,RaceRepository>();
            builder.Services.AddScoped<INarrativeRepository,NarrativeRepository>();
            builder.Services.AddScoped<IWorldRepository,WorldRepository>();
            builder.Services.AddScoped<IProfessionRepository,ProfessionRepository>();
            builder.Services.AddScoped<ICharacterRepository,CharacterRepository>();

            //manazery
            builder.Services.AddScoped<INarrativeManager,NarrativeManager>();
            builder.Services.AddScoped<IRaceManager,RaceManager>();
            builder.Services.AddScoped<IWorldManager,WorldManager>();
            builder.Services.AddScoped<IProfessionManager,ProfessionManager>();
            builder.Services.AddScoped<ICharacterManager,CharacterManager>();

           // builder.Services.AddScoped<IWorldManager>();

            // registrase automapperu
            builder.Services.AddAutoMapper(typeof(AutoMapperConfigurationProfile));

            builder.Services.AddBlazorBootstrap();



            var app = builder.Build();

            //konfigurace swaageru
            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json","HeroesOfLegends API V1");
            });

            // Configure the HTTP request pipeline.
            if(app.Environment.IsDevelopment())
            {
                app.UseMigrationsEndPoint();
                app.UseSwagger();
                app.UseSwaggerUI(c =>{c.SwaggerEndpoint("/swagger/v1/swagger.json","HeroesOfLegends API V1");});

                app.UseWebAssemblyDebugging();
            }
            else
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
                .AddInteractiveWebAssemblyRenderMode()
                .AddAdditionalAssemblies(typeof(Client._Imports).Assembly);

            // mapování na kontrolery
            app.MapControllers();

            //app.UseRouting(); // not needed for Razor Components

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.Run();
        }
    }
}
