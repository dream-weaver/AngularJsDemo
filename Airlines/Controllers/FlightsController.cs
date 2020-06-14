using Airlines.Models;
using Airlines.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Airlines.Controllers
{
    public class FlightsController : ApiController
    {

        private readonly IFlightService _flights;

        public FlightsController(IFlightService flights)
        {
            _flights = flights;
        }
        public IHttpActionResult GetAllFlights()
        {
            var flights = _flights.GetFlights();            
            return Ok(flights);
        }
    }
}
