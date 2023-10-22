using Bookify.Domain.Abstractions;

namespace Bookify.Domain.Users;

public static class UserErrors
{
    #region Fields

    public static Error InvalidCredentials = new Error("User.InvalidCredentials", "The provided credentials were invalid");

    public static Error NotFound = new Error("User.Found", "The user with the specified identifier was not found");

    #endregion
}
