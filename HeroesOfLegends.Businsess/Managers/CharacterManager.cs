using AutoMapper;
using HeroesOfLegends.Businsess.Interfaces;
using HeroesOfLegends.Businsess.Models;
using HeroesOfLegends.Data.Interfaces;
using HeroesOfLegends.Models;

namespace HeroesOfLegends.Businsess.Managers
{
    public class CharacterManager : ICharacterManager
    {
        private readonly IMapper mapper;
        private readonly ICharacterRepository characterRepository;
        public CharacterManager(IMapper mapper,ICharacterRepository characterRepository)
        {
            this.mapper = mapper;
            this.characterRepository = characterRepository;
        }

        public ICollection<CharacterDto> GetAllData()
        {
            IList<Character> characters = characterRepository.All();
            return mapper.Map<List<CharacterDto>>(characters);
        }


        public CharacterDto AddCharacter(CharacterDto charcterDto)
        {
            Character character = mapper.Map<Character>(charcterDto);
            Character addCharacter = characterRepository.AddCharacter(character);
            return mapper.Map<CharacterDto>(addCharacter);
        }



    }

}
