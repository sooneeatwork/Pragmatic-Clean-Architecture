namespace Bookify.Domain.Abstractions;

public interface IDbQuery
{
}

public interface IDbQuery<TResult>: IDbQuery
{
    Task<TResult> ExecuteAsync(CancellationToken cancellationToken = default);
    
}
