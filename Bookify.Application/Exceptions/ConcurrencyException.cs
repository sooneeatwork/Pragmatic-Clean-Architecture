namespace Bookify.Application.Exceptions;

public class ConcurrencyException: Exception
{
    #region Construction

    public ConcurrencyException(string message, Exception innerException): base(message, innerException)
    {
    }

    #endregion
}
