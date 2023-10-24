using Bookify.Domain.Users;

namespace Bookify.Infrastructure.Repositories;

internal sealed class UserRepository: Repository<User>, IUserRepository
{
    #region Construction

    public UserRepository(ApplicationDbContext dbContext): base(dbContext)
    {
    }

    #endregion
}
