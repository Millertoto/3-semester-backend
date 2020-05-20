using System;
using System.Collections.Generic;
using System.Text;

namespace ModelLib.Model
{
    public class Booking
    {
        private string _flightNr;
        private int _seatNr;
        private string _travelClass;
        private bool _alreadyBooked;

        public Booking()
        {

        }
        public Booking(string flightNr, int seatNr, string travelClass, bool alreadyBooked)
        {
            FlightNr = flightNr;
            SeatNr = seatNr;
            TravelClass = travelClass;
            AlreadyBooked = alreadyBooked;
        }
        public int Id { get; set; }
        public string FlightNr { get; set; }
        public int SeatNr { get; set; }
        public string TravelClass { get; set; }
        public bool AlreadyBooked { get; set; }
        public Flight flight { get; set; }
    }
}

