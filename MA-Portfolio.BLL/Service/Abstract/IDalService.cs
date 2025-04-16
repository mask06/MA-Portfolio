using MA_Portfolio.DTOs.Abstract;


namespace MA_Portfolio.BLL.Service.Abstract
{
    public interface IDalService<TDTO> where TDTO : BaseDTO
    {
        Task<List<TDTO>> GetAllAsync();
        Task<TDTO> GetByIdAsync(Guid id);
        Task AddAsync(TDTO dto);
        Task UpdateAsync(TDTO dto);
        Task SoftDeleteAsync(Guid id);
        Task HardDeleteAsync(Guid id);
    }
}
