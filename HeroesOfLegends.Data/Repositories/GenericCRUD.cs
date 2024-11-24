using HeroesOfLegends.Data.Interfaces;
using HeroesOfLegends.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.Extensions.Logging;


namespace HeroesOfLegends.Data.Repositories
{
    public abstract class GenericCRUD<TEntity> : IGenericCRUD<TEntity>

        where TEntity : class
    {
        protected readonly HoLDbContext db;
        protected readonly DbSet<TEntity> dbSet;
        protected readonly ILogger<DbSet<TEntity>> logger;

        public GenericCRUD(HoLDbContext db,ILogger<DbSet<TEntity>> logger)
        {
            this.db = db;
            dbSet = db.Set<TEntity>();
            this.logger = logger;
        }

        /// <summary>
        /// Vložení položky do databáze
        /// </summary>
        /// <param name="entity">položka</param>
        /// <returns></returns>
        public virtual TEntity Insert(TEntity entity)
        {
            EntityEntry<TEntity> entityEntry = dbSet.Add(entity);
            db.SaveChanges();
            return entityEntry.Entity;
        }

        /// <summary>
        /// async variant of Insert method 
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public async Task<TEntity> InsertAsync(TEntity entity)
        {
            EntityEntry<TEntity> entityEntry = await dbSet.AddAsync(entity);
            await db.SaveChangesAsync();
            return entityEntry.Entity;
        }





        /// <summary>
        /// Method for deleting entity by id
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
        /// Async variant method for deleting entity by id
        /// </summary>
        /// <param name="id"></param>
        public virtual async Task DeleteAsync(int id)
        {
            TEntity? entity = await dbSet.FindAsync(id);

            if(entity is null)
                return;

            try
            {
                dbSet.Remove(entity);
                await db.SaveChangesAsync();
            }
            catch
            {
                db.Entry(entity).State = EntityState.Unchanged;
                throw;
            }
        }




        /// <summary>
        /// Finf entity by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Entity with id</returns>
        public TEntity? FindById(int id)
        {
            logger.LogInformation("Looking for entity with ID: {Id}",id);
            var entity = dbSet.Find(id);
            if(entity == null)
            {
                logger.LogWarning("Entity with ID: {Id} not found",id);
            }
            return entity;
        }

        /// <summary>
        /// Async variant Finf entity by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Entity with id</returns>
        public async Task<TEntity?> FindByIdAsync(int id)
        {
            logger.LogInformation("Looking for entity with ID: {Id}",id);
            var entity = dbSet.FindAsync(id);
            if(entity == null)
            {
                logger.LogWarning("Entity with ID: {Id} not found",id);
            }
            return await entity;
        }




        /// <summary>
        /// Find entity by parameter
        /// </summary>
        /// <param name="predicate">selected parameter</param>
        /// <returns>List result</returns>
        public IList<TEntity> FindByParameter(Func<TEntity,bool> predicate)
        {
            return dbSet.Where(predicate).ToList();
        }


        /// <summary>
        /// Async variant Find entity by parameter
        /// </summary>
        /// <param name="predicate">selected parameter</param>
        /// <returns>List result</returns>
        public async Task<IList<TEntity>> FindByParameterAsync(Func<TEntity,bool> predicate)
        {
            //return await Task.Run(() => dbSet.Where(predicate).ToList());
            return await Task.Run(() => dbSet.Where(predicate).ToList());
        }




        /// <summary>
        /// Lists all items
        /// </summary>
        /// <returns>IList</returns>
        public virtual IList<TEntity> All() => dbSet.ToList();

        /// <summary>
        ///Async variant Lists all items
        /// </summary>
        /// <returns>IList</returns>
        public async Task<IList<TEntity>> AllAsync()
        {
            return await dbSet.ToListAsync();
        }





        /// <summary>
        /// Displays x items on the n page
        /// </summary>
        /// <param name="page">n-pages(default 0)</param>
        /// <param name="pageSize">x items on the page</param>
        /// <returns>IList</returns>
        public IList<TEntity> Page(int page,int pageSize)
        {
            return dbSet
                    .Skip(page * pageSize)
                    .Take(pageSize)
                    .ToList();
        }

        /// <summary>
        /// Async variant Displays x items on the n page
        /// </summary>
        /// <param name="page">n-pages(default 0)</param>
        /// <param name="pageSize">x items on the page</param>
        /// <returns>IList</returns>
        public async Task<IList<TEntity>> PageAsync(int page,int pageSize)
        {
            return await Task.Run(() => dbSet
                    .Skip(page * pageSize)
                    .Take(pageSize)
                    .ToList());
        }





        /// <summary>
        /// Displays x items on the nth page according to the criteria
        /// </summary>
        /// <param name="page">n-pages(default 0)</param>
        /// <param name="pageSize">x items on the page</param>
        /// <param name="search">serch term</param>
        /// <returns></returns>
        public IList<TEntity> PageSelect(int page,int pageSize,Func<TEntity,bool> search)
        {
            return dbSet
                    .Where(search)
                    .Skip(page * pageSize)
                    .Take(pageSize)
                    .ToList();
        }

        /// <summary>
        /// Async variant Displays x items on the nth page according to the criteria
        /// </summary>
        /// <param name="page">n-pages(default 0)</param>
        /// <param name="pageSize">x items on the page</param>
        /// <param name="search">serch term</param>
        /// <returns></returns>
        public async Task<IList<TEntity>> PageSelectAsync(int page,int pageSize,Func<TEntity,bool> search)
        {
            return await Task.Run(() => dbSet
                    .Where(search)
                    .Skip(page * pageSize)
                    .Take(pageSize)
                    .ToList());
        }




        public TEntity Update(TEntity entity)
        {
            EntityEntry<TEntity> entityEntry = dbSet.Update(entity);
            db.SaveChanges();
            return entityEntry.Entity;
        }
        public async Task<TEntity> UpdateAsync(TEntity entity)
        {
            EntityEntry<TEntity> entityEntry = dbSet.Update(entity);
            await db.SaveChangesAsync();
            return entityEntry.Entity;
        }


        public IList<TEntity>? FindEntitiesByIds(List<int> ids)
        {
            List<TEntity> entities = new();
            foreach(int id in ids)
            {
                if(ExistsWithId(id))
                {
                    TEntity? entity = dbSet.Find(id);
                    if(entity is not null)
                        entities.Add(entity);
                }
            }
            if(entities.Count == 0)
            {
                logger.LogWarning("No entities found");
            }
            return entities;
        }
        public async Task<IList<TEntity>?> FindEntitiesByIdsAsync(List<int> ids)
        {
            List<TEntity> entities = new();
            foreach(int id in ids)
            {
                if(await ExistsWithIdAsync(id))
                {
                    TEntity? entity = await dbSet.FindAsync(id);
                    if(entity is not null)
                        entities.Add(entity);
                }
            }
            if(entities.Count == 0)
            {
                logger.LogWarning("No entities found");
            }
            return entities;
        }

        /// <summary>
        /// ID existence check
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

        /// <summary>
        /// Async variant ID existence check
        /// </summary>
        /// <param name="id"></param>
        /// <returns>true/false</returns>
        public async Task<bool> ExistsWithIdAsync(int id)
        {
            TEntity? entity = await dbSet.FindAsync(id);
            if(entity is not null)
                db.Entry(entity).State = EntityState.Detached;
            return entity is not null;
        }

    }
}
