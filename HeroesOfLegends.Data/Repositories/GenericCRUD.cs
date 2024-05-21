
using HeroesOfLegends.Data.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace HeroesOfLegends.Data.Repositories
{
	public abstract class GenericCRUD<TEntity, Databaze> : IGenericCRUD<TEntity>

		where Databaze : DbContext
		where TEntity : class
	{
		protected readonly Databaze db;
		protected readonly DbSet<TEntity> dbSet;

		public GenericCRUD(Databaze db)
		{
			this.db = db;
			dbSet = db.Set<TEntity>();
		}
		/// <summary>
		/// Vložení položky do databáze
		/// </summary>
		/// <param name="entity">položka</param>
		/// <returns></returns>
		public TEntity Insert(TEntity entity)
		{
			EntityEntry<TEntity> entityEntry = dbSet.Add(entity);
			db.SaveChanges();
			return entityEntry.Entity;
		}

		/// <summary>
		/// Smazání vybrané položky podle Id
		/// </summary>
		/// <param name="id"></param>
		public virtual void Delete(int id)
		{
			TEntity? entity = dbSet.Find(id);

			if(entity is null)
				return;

			try
			{
				dbSet.Remove(entity);
				db.SaveChanges();
			}
			catch
			{
				db.Entry(entity).State = EntityState.Unchanged;
				throw;
			}
		}

		/// <summary>
		/// Vyhledání položky podle ID
		/// </summary>
		/// <param name="id"></param>
		/// <returns>položka</returns>
		public TEntity? FindById(int id)
		{
			return dbSet.Find(id);
		}

		/// <summary>
		/// Vyhledá všechny položky podle zvoleného klíče
		/// </summary>
		/// <param name="predicate">vyhledávaná položka</param>
		/// <returns>vyfiltrovaný List</returns>
		public IList<TEntity> FindByParameter(Func<TEntity,bool> predicate)
		{
			return dbSet.Where(predicate).ToList();
		}

		/// <summary>
		/// Vypíše všechny položky
		/// </summary>
		/// <returns>IList</returns>
		public IList<TEntity> All() => dbSet.ToList();

		/// <summary>
		/// Zobrazí x položek na n-té stránce
		/// </summary>
		/// <param name="page">n-stran(default 0)</param>
		/// <param name="pageSize">x položek na staně</param>
		/// <returns>IList</returns>
		public IList<TEntity> Page(int page,int pageSize)
		{
			return dbSet
					.Skip(page * pageSize)
					.Take(pageSize)
					.ToList();
		}

		/// <summary>
		/// Zobrazí x položek na n-té stránce podle kritéria
		/// </summary>
		/// <param name="page">n-stran(default 0)</param>
		/// <param name="pageSize">x položek na staně</param>
		/// <param name="search">hledané výraz</param>
		/// <returns></returns>
		public IList<TEntity> PageSelect(int page,int pageSize,Func<TEntity,bool> search)
		{
			return dbSet
					.Where(search)
					.Skip(page * pageSize)
					.Take(pageSize)
					.ToList();
		}

		public TEntity Update(TEntity entity)
		{
			EntityEntry<TEntity> entityEntry = dbSet.Update(entity);
			db.SaveChanges();
			return entityEntry.Entity;
		}

		/// <summary>
		/// Kontrola existence ID
		/// </summary>
		/// <param name="id"></param>
		/// <returns>true/false</returns>
		public bool ExistsWithId(int id)
		{
			TEntity? entity = dbSet.Find(id);
			if(entity is not null)
				db.Entry(entity).State = EntityState.Detached;
			return entity is not null;
		}


	}
}
