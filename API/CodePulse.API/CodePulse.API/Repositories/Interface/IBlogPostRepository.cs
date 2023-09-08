using CodePulse.API.Models.Domain;

namespace CodePulse.API.Repositories.Interface
{
    public interface IBlogPostRepository
    {
        Task<BlogPost> CreateAsync(BlogPost BlogPost);
        Task<IEnumerable<BlogPost>>GetAllAsync();
        Task<BlogPost?>GetByIdAsync(Guid id);
        Task<BlogPost?> UpdateAsync(BlogPost BlogPost);
        Task<BlogPost?> DeleteAsync(Guid id);
    }
}
