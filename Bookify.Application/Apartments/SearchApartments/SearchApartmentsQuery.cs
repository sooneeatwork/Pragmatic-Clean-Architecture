using Bookify.Application.Abstractions.Messaging;

namespace Bookify.Application.Apartments.SearchApartments;

public class SearchApartmentsQuery: IQuery<IReadOnlyList<ApartmentListModel>>
{
    #region Properties

    public DateOnly EndDate { get; set; }

    public DateOnly StartDate { get; set; }

    #endregion
}
