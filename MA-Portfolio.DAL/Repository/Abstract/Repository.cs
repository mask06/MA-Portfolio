using MA_Portfolio.DAL.Context;
using MA_Portfolio.Entities.Abstract;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace MA_Portfolio.DAL.Repository.Abstract
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : BaseEntity
    {
        // Repository sınıfı, IRepository arayüzünü implement eder ve temel CRUD işlemlerini tanımlar.

        // DbContext'i alır ve repository sınıfına atar.
        private protected MADbContext _dbContext;
        // DbSet<TEntity> türünde bir değişken tanımlar. Bu, veritabanındaki tabloyu temsil eder.
        private protected DbSet<TEntity> _entities;
        public Repository(MADbContext dbContext)
        {
            _dbContext = dbContext;
            // DbContext'ten gelen Set<TEntity>() metodu ile veritabanındaki tabloyu temsil eden DbSet<TEntity> nesnesini alır.
            _entities = dbContext.Set<TEntity>();
        }
        public virtual async Task<ICollection<TEntity>> GetAllAsync(Expression<Func<TEntity, bool>> predicate = null)
        {
            IQueryable<TEntity> query = _entities.AsNoTracking();

            if (predicate is not null)
                query = query.Where(predicate);

            return await query.ToListAsync();
        }
        public virtual async Task<TEntity> GetByIdAsync(Guid id)
        {
            TEntity? entity = await _entities.AsNoTracking().FirstOrDefaultAsync(e => e.Id == id && !e.IsDeleted && e.IsActive);

            return entity;
        }
        public virtual async Task<TEntity> AddAsync(TEntity entity)
        {
            var entry = await _entities.AddAsync(entity);

            return entry.Entity;
        }
        public virtual Task<TEntity> Update(TEntity entity)
        {
            if (!entity.IsDeleted)
            {
                entity.UpdatedDate = DateTime.Now;
                _entities.Update(entity);
            }
            return Task.FromResult(entity);
        }
        public virtual async Task HardDeleteAsync(Guid id)
        {
            TEntity? entity = await GetByIdAsync(id);

            if (entity is not null)
                _entities.Remove(entity);
        }
        public virtual async Task<TEntity> SoftDeleteAsync(Guid id)
        {
            TEntity? entity = await GetByIdAsync(id);
            if (entity is not null)
            {
                entity.IsDeleted = true;
                entity.DeletedDate = DateTime.Now;
                return await Update(entity);
            }
            return null;
        }
    }

}
