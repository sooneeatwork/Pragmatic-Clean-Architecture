using Bookify.Application.Abstractions.Messaging;
using FluentValidation;
using MediatR;
using ValidationException = Bookify.Application.Exceptions.ValidationException;

namespace Bookify.Application.Abstractions.Behaviours;

public class ValidationBehaviour<TRequest, TResponse>: IPipelineBehavior<TRequest, TResponse>
    where TRequest : IBaseCommand
{
    #region Fields

    private readonly IEnumerable<IValidator<TRequest>> _validators;

    #endregion

    #region Construction

    public ValidationBehaviour(IEnumerable<IValidator<TRequest>> validators)
    {
        _validators = validators;
    }

    #endregion

    #region Public Methods

    public async Task<TResponse> Handle(TRequest request, RequestHandlerDelegate<TResponse> next, CancellationToken cancellationToken)
    {
        if (!_validators.Any())
        {
            return await next();
        }

        var context = new ValidationContext<TRequest>(request);

        var validationErrors = _validators
                               .Select(validator => validator.Validate(context))
                               .Where(validationResult => validationResult.Errors.Any())
                               .SelectMany(validationResult => validationResult.Errors)
                               .Select(validationFailure => new ValidationError(
                                                                                validationFailure.PropertyName,
                                                                                validationFailure.ErrorMessage
                                                                               ))
                               .ToList();

        if (validationErrors.Any())
        {
            throw new ValidationException(validationErrors);
        }

        return await next();
    }

    #endregion
}
