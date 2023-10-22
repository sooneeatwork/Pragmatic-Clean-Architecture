namespace Bookify.Domain.Apartments;

// value object
public record Address(
    string Country,
    string State,
    string ZipCode,
    string City,
    string Street
);
