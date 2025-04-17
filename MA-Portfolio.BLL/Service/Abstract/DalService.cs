using AutoMapper;
using MA_Portfolio.DAL.UnitOfWork.Abstract;
using MA_Portfolio.DTOs.Abstract;
using MA_Portfolio.Entities.Abstract;

namespace MA_Portfolio.BLL.Service.Abstract
{
    public abstract class DalService<TEntity, TDTO> : IDalService<TDTO>
        where TDTO : BaseDTO
        where TEntity : BaseEntity
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        protected DalService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _mapper = mapper;
            _unitOfWork = unitOfWork;
        }
        public async Task<List<TDTO>> GetAllAsync()
        {
            var entities = await _unitOfWork.GetRepository<TEntity>().GetAllAsync(x => !x.IsDeleted && x.IsActive);
            return _mapper.Map<List<TDTO>>(entities);
        }
        public async Task<TDTO> GetByIdAsync(Guid id)
        {
            var entity = _unitOfWork.GetRepository<TEntity>().GetByIdAsync(id);
            return _mapper.Map<TDTO>(entity);
        }
        public async Task AddAsync(TDTO dto)
        {
            var entity = _mapper.Map<TEntity>(dto);
            await _unitOfWork.GetRepository<TEntity>().AddAsync(entity);
            await _unitOfWork.SaveChangesAsync();
        }

        public async Task UpdateAsync(TDTO dto)
        {
            var entity = _mapper.Map<TEntity>(dto);
            await _unitOfWork.GetRepository<TEntity>().Update(entity);
            await _unitOfWork.SaveChangesAsync();
        }
        public async Task SoftDeleteAsync(Guid id)
        {
            await _unitOfWork.GetRepository<TEntity>().SoftDeleteAsync(id);
            await _unitOfWork.SaveChangesAsync();
        }
        public async Task HardDeleteAsync(Guid id)
        {
            await _unitOfWork.GetRepository<TEntity>().HardDeleteAsync(id);
            await _unitOfWork.SaveChangesAsync();
        }


    }
}
