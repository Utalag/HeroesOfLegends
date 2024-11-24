using Microsoft.VisualStudio.TestTools.UnitTesting;
using HeroesOfLegends.Data.Repositories;
using HeroesOfLegends.Data.Models;
using HeroesOfLegends.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Moq;

namespace HeroesOfLegends.Data.Repositories.Tests
{
    [TestClass()]
    public class ProfessionRepositoryTests
    {
        private readonly Mock<ILogger<DbSet<Profession>>> _mockLogger;
        private readonly HoLDbContext _db;

        public ProfessionRepositoryTests()
        {
            _mockLogger = new Mock<ILogger<DbSet<Profession>>>();

            var options = new DbContextOptionsBuilder<HoLDbContext>()
                .UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=HeroesOfLegends-V1;Trusted_Connection=True;MultipleActiveResultSets=true")
                .Options;
            _db = new HoLDbContext(options);

            
        }

        [TestMethod()]
        public void AllTest()
        {
            // Arrange
            var professionRepository = new ProfessionRepository(_db,_mockLogger.Object);

            // Act
            var result = professionRepository.All();

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(2,result.Count());
            
            foreach (var item in result)
            {
                Console.WriteLine("* "+item.Name);

                foreach(var skill in item.ProfessionSkills)
                {
                    Console.WriteLine(skill.SkillName); 
                }
            }
            
        }
    }
}