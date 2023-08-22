using LibraryManagement.Application.Contracts.Persistence;
using LibraryManagement.Domain.Common;
using Microsoft.EntityFrameworkCore;

namespace LibraryManagement.Infrastructure.Persistence.Repositories;

public class GenericRepository<T> : IGenericRepository<T> where T : BaseAuditableEntity
{
    protected readonly ApplicationDbContext _context;

    public GenericRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<List<T>> GetAllAsync()
    {
        return await _context.Set<T>().ToListAsync();
    }

    public async Task CreateAsync(T entity)
    {
        await _context.AddAsync(entity);
        await _context.SaveChangesAsync();
    }
}
