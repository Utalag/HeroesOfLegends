using HeroesOfLegends.Data.Models;
using HeroesOfLegends.Data.Models.SkillsModels;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;


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






        public HoLDbContext(DbContextOptions<HoLDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            // ----------------- 1:N -----------------
            Configure_BaseSpecificSkill(builder);
            // ----------------- 1:1 -----------------

            // -----------------M:N One-way -----------------
            Configure_Profession(builder);
            // ----------------- M:N -----------------

            // ----------------- INIT -----------------
            InitializeData(builder);
            // ----------------- TODO -----------------
            Configure_Race(builder);

            base.OnModelCreating(builder);
        }


        private void Configure_Profession(ModelBuilder builder)
        {
            //One - way M: N
            builder.Entity<Profession>()
                .HasMany(p => p.BeginnerSkills)
                .WithMany()
                .UsingEntity(t => t.ToTable("BindTable_Beginner_ProfessionSkill"));
            //One - way M: N
            builder.Entity<Profession>()
                .HasMany(p => p.AdvancedSkills)
                .WithMany()
                .UsingEntity(t => t.ToTable("BindTable_Advanced_ProfessionSkill"));
            //One - way M: N
            builder.Entity<Profession>()
                .HasMany(p => p.ExpertSkills)
                .WithMany()
                .UsingEntity(t => t.ToTable("BindTable_Expert_ProfessionSkill"));
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
            baseSpecificSkillId = Increment_Id_BaseSpecificSkill<Healing>(baseSpecificSkillId,builder);
            baseSpecificSkillId = Increment_Id_BaseSpecificSkill<MultipleAttack>(baseSpecificSkillId,builder);
        }

        private int Increment_Id_BaseSpecificSkill<T>(int firstId,ModelBuilder builder) where T : BaseSpecificSkill, new()
        {
            var skills = new T().Initial(firstId);
            builder.Entity<T>().HasData(skills);
            return firstId + skills.Length;
        }



    }

}
