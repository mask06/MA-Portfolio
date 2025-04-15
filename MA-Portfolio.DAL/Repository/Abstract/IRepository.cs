using MA_Portfolio.Entities.Abstract;
using System.Linq.Expressions;


namespace MA_Portfolio.DAL.Repository.Abstract
{
    public interface IRepository<TEntity> where TEntity : BaseEntity
    {
        Task<ICollection<TEntity>> GetAllAsync(Expression<Func<TEntity,bool>> predicate=null);
        Task<TEntity> GetByIdAsync(Guid id);

        Task<TEntity> AddAsync(TEntity entity);
        Task<TEntity> Update(TEntity entity);

        Task<TEntity> SoftDeleteAsync(Guid id); // IsDeleted = true
        Task HardDeleteAsync(Guid id); // Gerçekten sil
    }
}
