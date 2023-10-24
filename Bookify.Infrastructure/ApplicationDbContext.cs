using Bookify.Domain.Abstractions;
using Microsoft.EntityFrameworkCore;

namespace Bookify.Infrastructure;

public sealed class ApplicationDbContext: DbContext, IUnitOfWork
{
    #region Construction

    public ApplicationDbContext(DbContextOptions options): base(options)
    {
    }

    #endregion
}
