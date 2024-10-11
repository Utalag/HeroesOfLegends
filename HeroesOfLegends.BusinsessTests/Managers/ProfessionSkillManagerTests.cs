using AutoMapper;
using HeroesOfLegends.Businsess.Managers;
using HeroesOfLegends.Businsess.Models;
using HeroesOfLegends.Data.Models;
using HeroesOfLegends.Database;
using Microsoft.Extensions.Logging;
using HeroesOfLegends.Data.Interfaces;
using Moq;
using Xunit;
using Microsoft.EntityFrameworkCore;

public class ProfessionSkillManagerTests
{
    //private readonly Mock<HoLDbContext> _mockDbContext;
    //private readonly Mock<IMapper> _mockMapper;
    //private readonly Mock<ILogger<GenericManager<ProfessionSkill,ProfessionSkillDto>>> _mockLogger;
    //private readonly Mock<IProfessionSkillRepository> _mockSkillRepository;
    //private readonly ProfessionSkillManager _manager;

    //public ProfessionSkillManagerTests()
    //{
    //    _mockDbContext = new Mock<HoLDbContext>();
    //    _mockMapper = new Mock<IMapper>();
    //    _mockLogger = new Mock<ILogger<DbSet<ProfessionSkillDto>>>();
    //    _mockSkillRepository = new Mock<IProfessionSkillRepository>();

    //    _manager = new ProfessionSkillManager(
    //        _mockDbContext.Object,
    //        _mockMapper.Object,
    //        _mockLogger.Object,
    //        _mockSkillRepository.Object
    //    );
    //}

    //[Fact]
    //public async Task GetSkillClassAsync_ReturnsSkills()
    //{
    //    // Arrange
    //    var skillClass = SkillClassEnum.combatSkill;
    //    var skills = new List<ProfessionSkill>
    //    {
    //        new ProfessionSkill { SkillClass = skillClass },
    //        new ProfessionSkill { SkillClass = skillClass }
    //    };
    //    _mockSkillRepository.Setup(repo => repo.GetSkillClassAsync(skillClass)).ReturnsAsync(skills);

    //    // Act
    //    var result = _manager.GetProfessionSkillBySkillClassAsync(skillClass);

    //    // Assert
    //    Xunit.Assert.NotNull(result);
    //    Xunit.Assert.Equal(2,result.Count);
    //}
}
