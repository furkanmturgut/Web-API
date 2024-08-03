using Web_API.Dtos.Comment;
using Web_API.Dtos.Stock;
using Web_API.Models;

namespace Web_API.Interfaces
{
    public interface ICommentRepository
    {
        Task<List<Comment>> GetAllAsync();
        Task<Comment?> GetByIdAsync(int id);
        Task<Comment> CreateAsync(Comment comment);
        Task<Comment?> UpdateAsync(int id, UpdateCommentRequestDto comment);
        Task<Comment?> DeleteAsync(int id);
    }
}
