using System.Collections.Generic;
using System.Linq;
using Airlines.Data;
using Airlines.Models;

namespace Airlines.Service.Implementation
{
    public class FlightService : IFlightService
    {
        //private readonly AppDBContext _context;

        //public FlightService(AppDBContext ctx)
        //{
        //    _context = ctx;
        //}
        IEnumerable<Flight> IFlightService.GetFlights()
        {
            using (var context = new AppDBContext())
            {
                var flights = context.Flights.Include("Cities").ToList();
                return flights;
            }
        }
    }
}
