namespace Bookify.Domain.Bookings;

public record DateRange
{
    #region Properties

    public DateOnly End { get; init; }

    public int LengthInDays => End.DayNumber - Start.DayNumber;

    public DateOnly Start { get; init; }

    #endregion

    #region Construction

    private DateRange()
    {
    }

    #endregion

    #region Public Methods

    public static DateRange Create(DateOnly start, DateOnly end)
    {
        if (start > end)
        {
            throw new ApplicationException("End date precedes start date");
        }

        return new DateRange
               {
                   Start = start,
                   End = end
               };
    }

    #endregion
}
