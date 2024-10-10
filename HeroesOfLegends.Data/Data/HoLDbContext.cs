using HeroesOfLegends.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;


namespace HeroesOfLegends.Data
{
    public class HoLDbContext : IdentityDbContext
    {
        public DbSet<Race>? Races { get; set; }
        public DbSet<Narrative>? Naratives { get; set; }
        public DbSet<World>? Worlds { get; set; }
        public DbSet<Profession>? Professions { get; set; }
        public DbSet<Fight>? Fights { get; set; }
        public DbSet<Character>? Characters { get; set; }


        public HoLDbContext(DbContextOptions<HoLDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            //builder.Entity<Race>()
            //      .HasMany(m=>m.Narratives)
            //      .WithMany(m=>m.Races)
            //      .UsingEntity(mg=>mg.ToTable(nameof(World)));

            builder.Entity<Race>().HasData(new Race().Initial());
            builder.Entity<World>().HasData(new World().Initial());
            builder.Entity<Narrative>().HasData(new Narrative().Initial());
            builder.Entity<Profession>().HasData(new Profession().Initial());
            //builder.Entity<Character>().HasData(new Character().Initial());



            //IEnumerable<IMutableForeignKey> cascadeFKs = builder.Model.GetEntityTypes()
            //    .SelectMany(type => type.GetForeignKeys())
            //    .Where(foreignKey => !foreignKey.IsOwnership && foreignKey.DeleteBehavior == DeleteBehavior.Cascade);
            //foreach(IMutableForeignKey foreignKey in cascadeFKs)
            //    foreignKey.DeleteBehavior = DeleteBehavior.Restrict;
        }


    }
}
