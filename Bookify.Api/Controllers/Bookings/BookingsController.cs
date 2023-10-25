using Bookify.Application.Bookings.GetBooking;
using Bookify.Application.Bookings.ReserveBooking;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Bookify.Api.Controllers.Bookings;

[ApiController]
[Route("api/[controller]")]
public class BookingsController: ControllerBase
{
    #region Fields

    private readonly ISender _sender;

    #endregion

    #region Construction

    public BookingsController(ISender sender)
    {
        _sender = sender;
    }

    #endregion

    #region Public Methods

    [HttpGet("{id}")]
    public async Task<IActionResult> GetBooking([FromQuery] GetBookingQuery query, CancellationToken cancellationToken)
    {
        var result = await _sender.Send(query, cancellationToken);

        return result.IsSuccess ? Ok(result.Value) : NotFound();
    }

    [HttpPost]
    public async Task<IActionResult> ReserveBooking(ReserveBookingCommand command, CancellationToken cancellationToken)
    {
        var result = await _sender.Send(command, cancellationToken);

        if (result.IsFailure)
        {
            return BadRequest(result.Error);
        }

        return CreatedAtAction(nameof(GetBooking), new { id = result.Value }, result.Value);
        
        // return GetBooking(...);
    }

    #endregion
}
