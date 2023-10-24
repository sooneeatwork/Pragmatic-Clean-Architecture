using Bookify.Application.Abstractions.Clock;

namespace Bookify.Infrastructure.Clock;

internal sealed class DateTimeProvider: IDateTimeProvider
{
    #region Properties

    public DateTime UtcNow => DateTime.UtcNow;

    #endregion
}
