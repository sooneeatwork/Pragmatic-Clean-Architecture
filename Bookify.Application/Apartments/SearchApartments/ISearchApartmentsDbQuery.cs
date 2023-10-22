using Bookify.Domain.Abstractions;
using Bookify.Domain.Apartments;

namespace Bookify.Application.Apartments.SearchApartments;

public interface ISearchApartmentsDbQuery: IDbQuery<List<Apartment>>
{
    ISearchApartmentsDbQuery WithNoTracking();

    ISearchApartmentsDbQuery WithParams(DateOnly startDate, DateOnly endDate);
}
