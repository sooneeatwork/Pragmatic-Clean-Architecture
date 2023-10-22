using Bookify.Domain.Abstractions;

namespace Bookify.Domain.Bookings;

public static class BookingErrors
{
    #region Fields

    public static readonly Error AlreadyStarted = new Error("Booking.AlreadyStarted", "THe booking has already started");

    public static readonly Error NotConfirmed = new Error("Booking.NotConfirmed", "The booking is not confirmed");

    public static readonly Error NotFound = new Error("Booking.Found", "The booking with the specified identifier was not found");

    public static readonly Error NotReserved = new Error("Booking.NotReserved", "The booking is not pending");

    public static readonly Error Overlap = new Error("Booking.Overlap", "The current booking os overlapping with an existing one");

    #endregion
}
