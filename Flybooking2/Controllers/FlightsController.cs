using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using ModelLib.Model;

namespace Flybooking2.Controllers

{
    [Route("api/localFlights")]
    [ApiController]
    public class FlightsController : ControllerBase
    {
        private static List<Flight> flights = new List<Flight>()
        {
            new Flight("8u665-8", "Alburquerque", "Pismo", 5.7, 10.3, 9, 50.59, false, "Warner Bros"),
            new Flight("Dg2-9eD", "Oakland", "Minsk", 10.7, 20.3, 18, 60.69, true, "British Airways"),
            new Flight("Qj4-10l", "Copenhagen", "Zürich", 20.7, 30.3, 36, 70.79, false, "SAS"),
            new Flight("Tk1-09m", "New York", "Copenhagen", 30.7, 40.3, 50, 50.50, false, "Ryanair"),
            new Flight("Fw7-5rp", "Copenhagen", "Paris", 49.7, 50.3, 60, 70.70, true, "Emirates")
        };

        // GET: api/Flights
        [HttpGet]
        public IEnumerable<Flight> GetAllFlights()
        {
            return flights;
        }

        // GET: api/Flights/5
        [HttpGet]
        [Route("{FlightNr}")]
        public Flight GetSpecificFlight(string FlightNr)
        {
            //Flight f1 = new Flight();
            //f1 = flights.Find(i => i.FlightNr.Contains(FlightNr));
            //return f1;
            return flights.Find(i => i.FlightNr == FlightNr);
        } 
        [HttpGet]
        [Route("{FlightNr}")]
        public IEnumerable<Flight> GetFromSubstring(String substring)
        {
            return flights.FindAll(i => i.FlightNr.Contains(substring));
        }

        // POST: api/Flights
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Flights/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
