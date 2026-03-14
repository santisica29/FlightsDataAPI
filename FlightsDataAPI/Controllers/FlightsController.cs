using FlightsDataAPI.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace FlightsDataAPI.Controllers;

[ApiController]
[Route("api/[controller]")]
public class FlightsController : ControllerBase
{
    private readonly IFlightService _flightService;
    public FlightsController(IFlightService flightService)
    {
        _flightService = flightService;
    }
}
