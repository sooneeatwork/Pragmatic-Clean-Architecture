using AutoMapper;
using Bookify.Application.Abstractions.Messaging;
using Bookify.Domain.Abstractions;

namespace Bookify.Application.Bookings.GetBooking;

internal sealed class GetBookingQueryHandler: IQueryHandler<GetBookingQuery, BookingResponse>
{
    #region Fields

    private readonly IGetBookingDbQuery _getBookingDbQuery;
    private readonly IMapper _mapper;

    #endregion

    #region Construction

    public GetBookingQueryHandler(IGetBookingDbQuery getBookingDbQuery, IMapper mapper)
    {
        _getBookingDbQuery = getBookingDbQuery;
        _mapper = mapper;
    }

    #endregion

    #region Public Methods

    public async Task<Result<BookingResponse>> Handle(GetBookingQuery query, CancellationToken cancellationToken)
    {
        var booking = await _getBookingDbQuery
                            .WithParams(query.Id)
                            .WithNoTracking()
                            .ExecuteAsync(cancellationToken);

        return _mapper.Map<BookingResponse>(booking);
    }

    #endregion
}
