using Bookify.Domain.Abstractions;
using Bookify.Domain.Shared;

namespace Bookify.Domain.Apartments;

public sealed class Apartment: Entity
{
    #region Properties

    public Apartment(Guid id, Name name, Description description, Address address, Money price, Money cleaningFee, DateTime? lastBookedOnUtc): base(id)
    {
        Name = name;
        Description = description;
        Address = address;
        Price = price;
        CleaningFee = cleaningFee;
        LastBookedOnUtc = lastBookedOnUtc;
    }

    public Name Name { get; private set; }

    public Description Description { get; private set; }

    public Address Address { get; private set; }

    public Money Price { get; private set; }

    public Money CleaningFee { get; private set; }

    public List<Amenity> Amenities { get; private set; } = new();

    public DateTime? LastBookedOnUtc { get; internal set; }

    #endregion

    #region Construction

    public Apartment(Guid id): base(id)
    {
    }

    #endregion
}
