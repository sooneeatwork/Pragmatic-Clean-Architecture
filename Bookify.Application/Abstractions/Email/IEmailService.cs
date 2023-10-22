namespace Bookify.Application.Abstractions.Email;

using Domain.Users;

public interface IEmailService
{
    Task SendAsync(Email recipient, string subject, string body);
}
