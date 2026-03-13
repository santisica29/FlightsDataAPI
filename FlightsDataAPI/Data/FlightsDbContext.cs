using FlightsDataAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace FlightsDataAPI.Data;
public class FlightsDbContext : DbContext
{
    public FlightsDbContext(DbContextOptions options) : base(options)
    {
    }

    public DbSet<Flight> Flights { get; set; }
}
