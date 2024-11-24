


namespace HeroesOfLegends.Data.Interfaces
{
	public interface IGenericCRUD<TEntity> where TEntity : class
	{
		IList<TEntity> All();
        Task<IList<TEntity>> AllAsync();
        void Delete(int id);
        Task DeleteAsync(int id);
        bool ExistsWithId(int id);
        Task<bool> ExistsWithIdAsync(int id);
        TEntity? FindById(int id);
        Task<TEntity?> FindByIdAsync(int id);
        IList<TEntity> FindByParameter(Func<TEntity,bool> predicate);
        Task<IList<TEntity>> FindByParameterAsync(Func<TEntity,bool> predicate);
        IList<TEntity>? FindEntitiesByIds(List<int> ids);
        Task<IList<TEntity>?> FindEntitiesByIdsAsync(List<int> ids);
        TEntity Insert(TEntity entity);
        Task<TEntity> InsertAsync(TEntity entity);
        IList<TEntity> Page(int page,int pageSize);
        Task<IList<TEntity>> PageAsync(int page,int pageSize);
        IList<TEntity> PageSelect(int page,int pageSize,Func<TEntity,bool> search);
        Task<IList<TEntity>> PageSelectAsync(int page,int pageSize,Func<TEntity,bool> search);
        TEntity Update(TEntity entity);
        Task<TEntity> UpdateAsync(TEntity entity);
    }
}