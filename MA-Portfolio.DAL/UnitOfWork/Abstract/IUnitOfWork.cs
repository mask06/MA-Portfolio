using MA_Portfolio.DAL.Repository.Abstract;
using MA_Portfolio.Entities.Abstract;

namespace MA_Portfolio.DAL.UnitOfWork.Abstract
{
    public interface IUnitOfWork : IAsyncDisposable
    {
        // IUnitOfWork arayüzü, birim iş mantığını temsil eder ve repository'leri yönetir.
        // Repository'lerin eklenmesi ve kaydedilmesi için gerekli metotları tanımlar.
        IRepository<TEntity> GetRepository<TEntity>() where TEntity : BaseEntity;
        Task<int> SaveChangesAsync();
       
    }

}
