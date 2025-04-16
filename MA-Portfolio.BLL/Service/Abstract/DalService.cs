using MA_Portfolio.DTOs.Abstract;
using MA_Portfolio.Entities.Abstract;

namespace MA_Portfolio.BLL.Service.Abstract
{
    public abstract class DalService<TEntity, TDTO> : IDalService<TDTO>
        where TDTO : BaseDTO
        where TEntity : BaseEntity
    {
        public Task AddAsync(TDTO dto)
        {
            throw new NotImplementedException();
        }

        public Task<List<TDTO>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<TDTO> GetByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task HardDeleteAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task SoftDeleteAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(TDTO dto)
        {
            throw new NotImplementedException();
        }
    }
}
