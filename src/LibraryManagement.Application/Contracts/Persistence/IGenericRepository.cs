using LibraryManagement.Domain.Common;

namespace LibraryManagement.Application.Contracts.Persistence;

public interface IGenericRepository<T> where T : BaseEntity
{
    Task<List<T>> GetAllAsync();

    Task CreateAsync(T entity);
}
