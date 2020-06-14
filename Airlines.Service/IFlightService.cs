using Airlines.Models;
using System.Collections.Generic;

namespace Airlines.Service
{
    public interface IFlightService
    {
        IEnumerable<Flight> GetFlights();
    }
}
