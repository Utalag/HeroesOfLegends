

using HeroesOfLegends.Models;

namespace HeroesOfLegends.Data.Interfaces
{
	public interface ICharacterRepository : IGenericCRUD<Character>
	{
		Character AddCharacter(Character entity);

	}
}