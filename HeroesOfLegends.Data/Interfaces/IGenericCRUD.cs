
namespace HeroesOfLegends.Data.Interfaces
{
	public interface IGenericCRUD<TEntity> where TEntity : class
	{
		IList<TEntity> All();
		void Delete(int id);
		bool ExistsWithId(int id);
		TEntity? FindById(int id);
		IList<TEntity> FindByParameter(Func<TEntity,bool> predicate);
		TEntity Insert(TEntity entity);
		IList<TEntity> Page(int page,int pageSize);
		IList<TEntity> PageSelect(int page,int pageSize,Func<TEntity,bool> search);
		TEntity Update(TEntity entity);
	}
}