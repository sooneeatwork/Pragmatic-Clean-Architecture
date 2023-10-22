using Bookify.Domain.Abstractions;
using Bookify.Domain.Users.Events;

namespace Bookify.Domain.Users;

public sealed class User: Entity
{
    #region Properties

    public FirstName FirstName { get; private set; }

    public LastName LastName { get; private set; }

    public Email Email { get; private set; }

    #endregion

    #region Construction

    private User(Guid id, FirstName firstName, LastName lastName, Email email): base(id)
    {
        FirstName = firstName;
        LastName = lastName;
        Email = email;
    }

    #endregion

    #region Public Methods

    public static User Create(FirstName firstName, LastName lastName, Email email)
    {
        var user = new User(Guid.NewGuid(), firstName, lastName, email);

        user.RaiseDomainEvent(new UserCreatedDomainEvent(user.Id));

        return user;
    }

    #endregion
}
