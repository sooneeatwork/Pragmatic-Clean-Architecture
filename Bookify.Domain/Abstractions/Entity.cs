namespace Bookify.Domain.Abstractions;

public abstract class Entity
{
    #region Properties

    public Guid Id { get; init; }

    #endregion

    #region Construction

    protected Entity(Guid id)
    {
        Id = id;
    }

    #endregion
}
