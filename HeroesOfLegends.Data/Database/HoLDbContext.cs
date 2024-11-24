using HeroesOfLegends.Data.Builders;
using HeroesOfLegends.Data.Database;
using HeroesOfLegends.Data.Models;
using HeroesOfLegends.Data.Models.SkillsModels;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;


namespace HeroesOfLegends.Database
{
    public class HoLDbContext : IdentityDbContext
    {
        public DbSet<Race>? Races { get; set; }
        public DbSet<Narrative>? Naratives { get; set; }
        public DbSet<World>? Worlds { get; set; }
        public DbSet<Profession>? Professions { get; set; }
        public DbSet<Character>? Characters { get; set; }
        public DbSet<ProfessionSkill>? ProfessionSkill { get; set; }
        public DbSet<BaseSpecificSkill>? SpecificSkill { get; set; }
        //public DbSet<MultipleAttack>? MultipleAttacks { get; set; }


   


        public HoLDbContext(DbContextOptions<HoLDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            // ----------------- 1:N -----------------
            Configure_BaseSpecificSkill(builder);
            // ----------------- 1:1 -----------------

            // ----------------- M:N -----------------
            Configure_Profession(builder);
            // ----------------- INIT -----------------
            InitializeData(builder);
            // ----------------- TODO -----------------
            Configure_Race(builder);

            base.OnModelCreating(builder);
        }


        private void Configure_Profession(ModelBuilder builder)
        {
            //M:N
            // bindingTable: BindingProfessionsSkills
            builder.Entity<Profession>()
                .HasMany(m => m.ProfessionSkills)
                .WithMany(g => g.Professions)
                .UsingEntity<Dictionary<string, object>>("BindingProfessionsSkills",
                j => j.HasOne<ProfessionSkill>().WithMany().HasForeignKey("ProfessionSkillId"),
                j => j.HasOne<Profession>().WithMany().HasForeignKey("ProfessionId")
            );
        }
        private void Configure_BaseSpecificSkill(ModelBuilder builder)
        {
            builder.Entity<BaseSpecificSkill>()
                .HasDiscriminator<string>("Skill_type")
                .HasValue<MultipleAttack>("multiple_attack")
                .HasValue<Healing>("healing");
        }
        private void Configure_Race(ModelBuilder builder)
        {
            //builder.Entity<Race>()
            //      .HasMany(m=>m.Narratives)
            //      .WithMany(m=>m.Races)
            //      .UsingEntity(mg=>mg.ToTable(nameof(World)));
        }
        private void InitializeData(ModelBuilder builder)
        {
            builder.Entity<Race>().HasData(new Race().Initial());
            builder.Entity<World>().HasData(new World().Initial());
            builder.Entity<Narrative>().HasData(new Narrative().Initial());
            builder.Entity<Profession>().HasData(new Profession().ProfessionInit());
            //builder.Entity<Character>().HasData(new Character().Initial());


            builder.Entity<ProfessionSkill>().HasData(new ProfessionSkill().Initial(1));

            //Skills
            int baseSpecificSkillId = 1;
            baseSpecificSkillId = InitBaseSpecificSkill<Healing>(baseSpecificSkillId,builder);
            baseSpecificSkillId = InitBaseSpecificSkill<MultipleAttack>(baseSpecificSkillId,builder);
        }

        private int InitBaseSpecificSkill<T>(int firstId,ModelBuilder builder) where T : BaseSpecificSkill, new()
        {
            var skills = new T().Initial(firstId);
            builder.Entity<T>().HasData(skills);
            return firstId+skills.Length;
        }


        
    }
}
