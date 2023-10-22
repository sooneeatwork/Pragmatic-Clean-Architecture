namespace Bookify.Domain.Abstractions;

public abstract class Entity
{
    #region Fields

    private readonly List<IDomainEvent> _domainEvents = new();

    #endregion

    #region Properties

    public Guid Id { get; init; }

    #endregion

    #region Construction

    protected Entity(Guid id)
    {
        Id = id;
    }

    #endregion

    #region Private Methods

    protected void RaiseDomainEvent(IDomainEvent domainEvent)
    {
        _domainEvents.Add(domainEvent);
    }

    #endregion

    #region Public Methods

    public void ClearDomainEvents()
    {
        _domainEvents.Clear();
    }

    public IReadOnlyList<IDomainEvent> GetDomainEvents()
    {
        return _domainEvents.ToList();
    }

    #endregion
}
