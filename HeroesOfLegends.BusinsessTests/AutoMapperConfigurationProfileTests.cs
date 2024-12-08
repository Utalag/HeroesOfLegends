using Microsoft.VisualStudio.TestTools.UnitTesting;
using HeroesOfLegends.Businsess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using HeroesOfLegends.Data.Models;

namespace HeroesOfLegends.Businsess.Models.Tests
{
    [TestClass()]
    public class AutoMapperConfigurationProfileTests
    {
        private readonly IMapper _mapper;

        public AutoMapperConfigurationProfileTests()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<AutoMapperConfigurationProfile>();
            });
            _mapper = config.CreateMapper();
        }

        [TestMethod()]
        public void AutoMapperConfigurationProfileTest()
        {
            // Arrange
            var profession = new Profession
            {
                Id = 1,
                Name = "Warrior",
                AllSkills = new List<ProfessionSkill>
                        {
                            new ProfessionSkill { Id = 1, SkillName = "Swordsmanship" },
                            new ProfessionSkill { Id = 2, SkillName = "Shield Defense" }
                        }
            };

            var list = new List<Profession>();
            list.Add(profession);
            list.Add(profession); list.Add(profession);

            // Act
            var professionDto = _mapper.Map<ProfessionDto>(profession);

            // Assert
            Assert.IsNotNull(professionDto);
            Assert.AreEqual(profession.Id,professionDto.Id);
            Assert.AreEqual(profession.Name,professionDto.Name);
            Assert.AreEqual(profession.AllSkills.Count,professionDto.SkillIds.Count);
            CollectionAssert.AreEqual(profession.AllSkills.Select(ps => ps.Id).ToList(),professionDto.SkillIds);

            foreach (var skillId in professionDto.SkillIds)
            {
                Console.WriteLine(skillId);
            }


            var listDto = _mapper.Map<IList<ProfessionDto>>(list);
            
            foreach(var dto in listDto)
            {
                foreach(var skillId in dto.SkillIds)
                {
                    Console.WriteLine(skillId);
                }
            }
            

        }
    }
}