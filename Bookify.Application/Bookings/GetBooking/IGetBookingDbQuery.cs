using Bookify.Domain.Abstractions;
using Bookify.Domain.Bookings;

namespace Bookify.Application.Bookings.GetBooking;

// A Service in the Infrastructure Layer will handler this 
// therefore meaning the application layer is not referencing the infrastructure outer layer
// but the infrastructure layer will reference the inner application layer
public interface IGetBookingDbQuery: IDbQuery<Booking>
{
    IGetBookingDbQuery WithNoTracking();

    IGetBookingDbQuery WithParams(Guid id);
}

// 
// public class GetBookingDbQuery:IGetBookingDbQuery
// {
//     public Task<Booking> ExecuteAsync(CancellationToken cancellationToken = default)
//     {
//         throw new NotImplementedException();
//     }
//
//     public IGetBookingDbQuery WithNoTracking()
//     {
//         throw new NotImplementedException();
//     }
//
//     public IGetBookingDbQuery Include(params string[] include)
//     {
//         throw new NotImplementedException();
//     }
//
//     public IGetBookingDbQuery WithParams(string id)
//     {
//         throw new NotImplementedException();
//     }
// }
