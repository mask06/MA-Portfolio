using MA_Portfolio.DAL.Context;
using MA_Portfolio.DAL.Repository.Abstract;
using MA_Portfolio.DAL.UnitOfWork.Abstract;
using MA_Portfolio.Entities.Abstract;

namespace MA_Portfolio.DAL.UnitOfWork.Concrete
{
    public class UnitOfWork : IUnitOfWork
    {
        // UnitOfWork sınıfı, IUnitOfWork arayüzünü implement eder ve repository'leri yönetir.
        // Repository'lerin eklenmesi ve kaydedilmesi için gerekli metotları tanımlar.
        private readonly MADbContext _dbContext;
        private readonly Dictionary<Type, object> _repositories;
        public UnitOfWork(MADbContext dbContext)
        {
            _dbContext = dbContext;
            _repositories = new Dictionary<Type, object>();
        }
        public IRepository<TEntity> GetRepository<TEntity>() where TEntity : BaseEntity
        {
            var type = typeof(TEntity);
            if (!_repositories.ContainsKey(type))
            {
                var repositoryInstance = new Repository<TEntity>(_dbContext);
                _repositories[type] = repositoryInstance;
            }
            return (IRepository<TEntity>)_repositories[type];
        }
        public async Task<int> SaveChangesAsync()
        {
          return await _dbContext.SaveChangesAsync();
        }
        public ValueTask DisposeAsync()
        {
            return _dbContext.DisposeAsync();
        }

    }
}
