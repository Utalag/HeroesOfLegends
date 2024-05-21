using HeroeOfLegends.Businsess.Models;

namespace HeroeOfLegends.Businsess.Interfaces
{
	public interface ICharacterManager
	{
		CharacterDto AddCharacter(CharacterDto charcterDto);
		ICollection<CharacterDto> GetAllData();

	}
}