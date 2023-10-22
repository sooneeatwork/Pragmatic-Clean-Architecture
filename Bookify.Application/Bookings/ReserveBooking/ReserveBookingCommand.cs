using Bookify.Application.Abstractions.Messaging;

namespace Bookify.Application.Bookings.ReserveBooking;

public class ReserveBookingCommand: ICommand<Guid>
{
    #region Properties

    public Guid ApartmentId { get; set; }

    public DateOnly EndDate { get; set; }

    public DateOnly StartDate { get; set; }

    public Guid UserId { get; set; }

    #endregion
}
