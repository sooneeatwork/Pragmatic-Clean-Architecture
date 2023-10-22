using Bookify.Domain.Abstractions;

namespace Bookify.Domain.Reviews;

public sealed record Rating
{
    #region Fields

    public static readonly Error Invalid = new Error("Rating.Invalid", "The rating is invalid");

    #endregion

    #region Properties

    public int Value { get; init; }

    #endregion

    #region Construction

    private Rating(int value)
    {
        Value = value;
    }

    #endregion

    #region Public Methods

    public static Result<Rating> Create(int value)
    {
        if (value < 1 || value > 5)
        {
            return Result.Failure<Rating>(Invalid);
        }

        return new Rating(value);
    }

    #endregion
}
