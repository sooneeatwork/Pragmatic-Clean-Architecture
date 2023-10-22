using Bookify.Domain.Abstractions;

namespace Bookify.Domain.Apartments;

public static class ApartmentErrors
{
    #region Fields

    public static Error NotFound = new Error("Property.Found", "The property with the specified identifier was not found");

    #endregion
}
