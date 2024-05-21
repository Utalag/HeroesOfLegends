using HeroesOfLegends.Businsess.Models;

namespace HeroesOfLegends.Businsess.Interfaces
{
	public interface ICharacterManager
	{
		CharacterDto AddCharacter(CharacterDto charcterDto);
		ICollection<CharacterDto> GetAllData();

	}
}