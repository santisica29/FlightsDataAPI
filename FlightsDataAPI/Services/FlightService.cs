using FlightsDataAPI.Data;
using FlightsDataAPI.Interfaces;
using FlightsDataAPI.Models;

namespace FlightsDataAPI.Services;
public class FlightService : IFlightService
{
    private readonly FlightsDbContext _dbContext;

    public FlightService(FlightsDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public Flight CreateFlight(Flight flight)
    {
        var savedFlight = _dbContext.Flights.Add(flight);
        _dbContext.SaveChanges();
        return savedFlight.Entity;
    }
}
