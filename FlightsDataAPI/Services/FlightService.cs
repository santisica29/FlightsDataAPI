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

    public string? DeleteFlight(int id)
    {
        Flight? savedFlight = GetFlightById(id);

        if (savedFlight == null)
            return null;

        _dbContext.Flights.Remove(savedFlight);
        _dbContext.SaveChanges();

        return $"Successfully deleted flight with id: {id}";
    }

    public List<Flight> GetAllFlights()
    {
        return _dbContext.Flights.ToList();
    }

    public Flight? GetFlightById(int id)
    {
        Flight? savedFlight = _dbContext.Flights.Find(id);
        return savedFlight;
    }

    public Flight? UpdateFlight(int id, Flight flight)
    {
        Flight? savedFlight = GetFlightById(id);

        if (savedFlight == null)
            return null;

        _dbContext.Entry(savedFlight).CurrentValues.SetValues(flight);
        _dbContext.SaveChanges();

        return savedFlight;
    }
}
