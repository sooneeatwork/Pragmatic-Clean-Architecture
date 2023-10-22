namespace Bookify.Domain.Apartments;

public record Money(decimal Amount, Currency Currency)
{
    #region Public Methods

    public static Money operator +(Money first, Money second)
    {
        if (first.Currency != second.Currency)
        {
            throw new InvalidOperationException("Currencies have to be equal");
        }

        return first with { Amount = first.Amount + second.Amount };
    }

    public static Money Zero() => new Money(0, Currency.None);

    #endregion
}
