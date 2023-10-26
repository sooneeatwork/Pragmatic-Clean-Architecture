using Bookify.Application.Bookings.GetBooking;
using Bookify.Domain.Bookings;

namespace Bookify.Infrastructure.Data.Queries.Bookings;

public class GetBookingsDbQuery:IGetBookingDbQuery
{
    public Task<Booking> ExecuteAsync(CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public IGetBookingDbQuery WithNoTracking()
    {
        throw new NotImplementedException();
    }

    public IGetBookingDbQuery WithParams(Guid id)
    {
        throw new NotImplementedException();
    }
}
