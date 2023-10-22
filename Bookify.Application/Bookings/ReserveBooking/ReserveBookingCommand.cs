using Bookify.Application.Abstractions.Messaging;
using FluentValidation;

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

public class ReserveBookingCommandValidator: AbstractValidator<ReserveBookingCommand>
{
    #region Construction

    public ReserveBookingCommandValidator()
    {
        RuleFor(c => c.UserId).NotEmpty();
        RuleFor(c => c.ApartmentId).NotEmpty();
        RuleFor(c => c.StartDate).LessThan(c => c.EndDate);
    }

    #endregion
}
