namespace Bookify.Application.Bookings.GetBooking;

public sealed class BookingResponse
{
    #region Properties

    public decimal AmenitiesUpChargeAmount { get; init; }

    public string AmenitiesUpChargeCurrency { get; init; }

    public Guid ApartmentId { get; init; }

    public decimal CleaningFeeAMount { get; init; }

    public string CleaningFeeCurrency { get; init; }

    public DateTime CreatedOnUtc { get; init; }

    public DateOnly DurationEnd { get; init; }

    public DateOnly DurationStart { get; init; }

    public Guid Id { get; init; }

    public decimal PriceAmount { get; init; }

    public string PriceCurrency { get; init; }

    public int Status { get; init; }

    public decimal TotalPriceAmount { get; init; }

    public string TotalPriceCurrency { get; init; }

    public Guid UserId { get; init; }

    #endregion
}
