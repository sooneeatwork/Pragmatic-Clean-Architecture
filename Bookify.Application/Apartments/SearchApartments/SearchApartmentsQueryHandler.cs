using AutoMapper;
using Bookify.Application.Abstractions.Messaging;
using Bookify.Domain.Abstractions;

namespace Bookify.Application.Apartments.SearchApartments;

public class SearchApartmentsQueryHandler: IQueryHandler<SearchApartmentsQuery, IReadOnlyList<ApartmentListModel>>
{
    #region Fields

    private readonly IMapper _mapper;
    private readonly ISearchApartmentsDbQuery _searchApartmentsDbQuery;

    #endregion

    #region Construction

    public SearchApartmentsQueryHandler(IMapper mapper, ISearchApartmentsDbQuery searchApartmentsDbQuery)
    {
        _mapper = mapper;
        _searchApartmentsDbQuery = searchApartmentsDbQuery;
    }

    #endregion

    #region Public Methods

    public async Task<Result<IReadOnlyList<ApartmentListModel>>> Handle(SearchApartmentsQuery query, CancellationToken cancellationToken)
    {
        if (query.StartDate > query.EndDate)
        {
            return new List<ApartmentListModel>();
        }

        var apartments = await _searchApartmentsDbQuery.WithParams(query.StartDate, query.EndDate)
                                                       .WithNoTracking()
                                                       .ExecuteAsync(cancellationToken);

        return _mapper.Map<List<ApartmentListModel>>(apartments);
    }

    #endregion
}
