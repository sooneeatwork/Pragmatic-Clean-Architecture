using AutoMapper;
using Bookify.Application.Bookings.GetBooking;
using Bookify.Domain.Bookings;

namespace Bookify.Application.Bookings;

public class BookingsMappingProfile: Profile
{
    #region Construction

    public BookingsMappingProfile()
    {
        CreateMap<Booking, BookingResponse>();
    }

    #endregion
}
