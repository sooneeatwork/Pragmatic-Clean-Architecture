using Bookify.Application.Abstractions.Messaging;

namespace Bookify.Application.Apartments.SearchApartments;

public class SearchApartmentsQuery:IQuery<IReadOnlyList<ApartmentListModel>>
{
    public DateOnly StartDate { get; set; }
    
    public DateOnly EndDate { get; set; }
}
