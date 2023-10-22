namespace Bookify.Domain.Shared;

public record Currency
{
    #region Fields

    internal static readonly Currency None = new Currency("");
    public static readonly Currency Aud = new Currency("AUD");
    public static readonly Currency Usd = new Currency("USD");
    public static readonly IReadOnlyCollection<Currency> All = new[] { Usd, Aud };

    #endregion

    #region Properties

    public string Code { get; init; }

    #endregion

    #region Construction

    private Currency(string code)
    {
        Code = code;
    }

    #endregion

    #region Public Methods

    public static Currency FromCode(string code)
    {
        return All.FirstOrDefault(c => c.Code == code) ?? throw new ApplicationException("The currency code is invalid");
    }

    #endregion
}
