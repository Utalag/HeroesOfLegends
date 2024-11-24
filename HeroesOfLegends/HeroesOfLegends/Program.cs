using HeroesOfLegends.Businsess.Interfaces;
using HeroesOfLegends.Businsess.Managers;
using HeroesOfLegends.Businsess.Models;
using HeroesOfLegends.Components;
using HeroesOfLegends.Data.Database;
using HeroesOfLegends.Data.Interfaces;
using HeroesOfLegends.Data.Models;
using HeroesOfLegends.Data.Repositories;
using HeroesOfLegends.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;

namespace HeroesOfLegends
{
    public class Program
    {
        public static async Task Main(string[] args)
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
            //builder.Services.AddScoped<IProfession,Profession>();


            // repository
            builder.Services.AddScoped<IRaceRepository,RaceRepository>();
            builder.Services.AddScoped<INarrativeRepository,NarrativeRepository>();
            builder.Services.AddScoped<IWorldRepository,WorldRepository>();
            builder.Services.AddScoped<IProfessionRepository,ProfessionRepository>();
            builder.Services.AddScoped<ICharacterRepository,CharacterRepository>();
            builder.Services.AddScoped<IProfessionSkillRepository,ProfessionSkillRepository>();
            builder.Services.AddScoped<ISpecificSkillReposotory,SpecificSkillReposotory>();
            

            //manazery
            builder.Services.AddScoped<INarrativeManager,NarrativeManager>();
            builder.Services.AddScoped<IRaceManager,RaceManager>();
            builder.Services.AddScoped<IWorldManager,WorldManager>();
            builder.Services.AddScoped<IProfessionManager,ProfessionManager>();
            builder.Services.AddScoped<ICharacterManager,CharacterManager>();
            builder.Services.AddScoped<IProfessionSkillManager,ProfessionSkillManager>();
            builder.Services.AddScoped<ISpecificSkillManager,SpecificSkillManager>();


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
                app.UseSwaggerUI(c => { c.SwaggerEndpoint("/swagger/v1/swagger.json","HeroesOfLegends API V1"); });

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

            //using(var scope = app.Services.CreateScope())
            //{
            //    var context = scope.ServiceProvider.GetRequiredService<HoLDbContext>();
            //    var professionRepository = scope.ServiceProvider.GetRequiredService<IProfessionRepository>();
            //    var characterRepository = scope.ServiceProvider.GetRequiredService<ICharacterRepository>();
            //    var professionSkillRepository = scope.ServiceProvider.GetRequiredService<IProfessionSkillRepository>();
            //    var specificSkillReposotory = scope.ServiceProvider.GetRequiredService<ISpecificSkillReposotory>();
            //    var raceRepository = scope.ServiceProvider.GetRequiredService<IRaceRepository>();
            //    var narrativeRepository = scope.ServiceProvider.GetRequiredService<INarrativeRepository>();
            //    var worldRepository = scope.ServiceProvider.GetRequiredService<IWorldRepository>();
            //    await DbInitializer.InitializeAsync(context,professionRepository,characterRepository,professionSkillRepository,specificSkillReposotory,raceRepository,narrativeRepository,worldRepository);
            //}


            app.Run();
        }
    }
}
