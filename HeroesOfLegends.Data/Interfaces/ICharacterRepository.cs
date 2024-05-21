

using HeroeOfLegends.Models;

namespace HeroeOfLegends.Data.Interfaces
{
	public interface ICharacterRepository : IGenericCRUD<Character>
	{
		Character AddCharacter(Character entity);

	}
}