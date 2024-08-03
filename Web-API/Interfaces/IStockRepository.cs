using Web_API.Dtos.Stock;
using Web_API.Helpers;
using Web_API.Models;

namespace Web_API.Interfaces
{
    public interface IStockRepository
    {
        Task<List<Stock>> GetAllAsync(QueryObject queryObject);
        Task<Stock?> GetByIdAsync(int id); // null gelebilir
        Task<Stock> CreateAsync(Stock stock);
        Task<Stock?> UpdateAsync(int id, UpdateStockRequestDto stockDto);
        Task<Stock?> DeleteAsync(int id);

        // FLuent Validation ile buna ihtiyaç yok
        Task<bool> StockExist(int id);

    }
}
