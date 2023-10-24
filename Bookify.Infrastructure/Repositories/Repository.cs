using Bookify.Domain.Abstractions;
using Microsoft.EntityFrameworkCore;

namespace Bookify.Infrastructure.Repositories;

internal abstract class Repository<T>
    where T : Entity
{
    #region Fields

    protected readonly ApplicationDbContext _dbContext;

    #endregion

    #region Construction

    protected Repository(ApplicationDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    #endregion

    #region Public Methods

    public void Add(T entity)
    {
        _dbContext.Add(entity);
    }

    public async Task<T?> GetByIdAsync(Guid id, CancellationToken cancellationToken = default)
    {
        return await _dbContext.Set<T>().FirstOrDefaultAsync(e => e.Id == id, cancellationToken);
    }

    #endregion
}
