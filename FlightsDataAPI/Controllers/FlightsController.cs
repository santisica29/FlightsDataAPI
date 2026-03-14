using FlightsDataAPI.Interfaces;
using FlightsDataAPI.Models;
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

    [HttpGet]
    public ActionResult<List<Flight>> GetAllFlights()
    {
        return Ok(_flightService.GetAllFlights());
    }

    [HttpGet("{id}")]
    public ActionResult<Flight> GetFlightById(int id)
    {
        return Ok(_flightService.GetFlightById(id));
    }

    [HttpPost]
    public ActionResult<Flight> CreateFlight(Flight flight)
    {
        return Ok(_flightService.CreateFlight(flight));
    }

    [HttpPut("{id}")]
    public ActionResult<Flight> UpdateFlight(int id, Flight updatedFlight)
    {
        return Ok(_flightService.UpdateFlight(id, updatedFlight));
    }

    [HttpDelete("{id}")]
    public ActionResult<string> DeleteFlight(int id)
    {
        return Ok(_flightService.DeleteFlight(id));
    }
}
