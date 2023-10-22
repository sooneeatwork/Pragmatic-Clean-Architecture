using Bookify.Application.Abstractions.Email;
using Bookify.Domain.Bookings;
using Bookify.Domain.Bookings.Events;
using Bookify.Domain.Users;
using MediatR;

namespace Bookify.Application.Bookings.ReserveBooking;

internal sealed class BookingReservedDomainEventHandler: INotificationHandler<BookingReservedDomainEvent>
{
    #region Fields

    private readonly IBookingRepository _bookingRepository;
    private readonly IEmailService _emailService;
    private readonly IUserRepository _userRepository;

    #endregion

    #region Construction

    public BookingReservedDomainEventHandler(IBookingRepository bookingRepository, IUserRepository userRepository, IEmailService emailService)
    {
        _bookingRepository = bookingRepository;
        _userRepository = userRepository;
        _emailService = emailService;
    }

    #endregion

    #region Public Methods

    public async Task Handle(BookingReservedDomainEvent notification, CancellationToken cancellationToken)
    {
        var booking = await _bookingRepository.GetByIdAsync(notification.BookingId, cancellationToken);

        if (booking == null)
        {
            return;
        }

        var user = await _userRepository.GetByIdAsync(booking.UserId, cancellationToken);

        if (user == null)
        {
            return;
        }

        await _emailService.SendAsync(user.Email, "Booking reserved!", "You have 10 minutes to confirm this booking");
    }

    #endregion
}
