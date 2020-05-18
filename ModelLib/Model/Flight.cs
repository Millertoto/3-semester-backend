using System;
using System.Collections.Generic;
using System.Text;

namespace ModelLib.Model
{
    public class Flight
    {
        // instance fields
        private string _flightNr;
        private string _departingFrom;
        private string _destination;
        private double _distance;
        private double _travelTime;
        private int _capacity;
        private double _fuelConsumption;

        public Flight()
        {

        }

        public Flight(string flightNr, string departingFrom, string destination, double distance,
            double travelTime, int capacity, double fuelConsumption, bool stopOver, string company, Booking[] seats)

        {
            
            FlightNr = flightNr;
            DepartingFrom = departingFrom;
            Destination = destination;
            Distance = distance;
            TravelTime = travelTime;
            Capacity = capacity;
            FuelConsumption = fuelConsumption;
            StopOver = stopOver;
            Company = company;
            Seats = seats;
        }
        public int Id
        {
            get;
            set;
        }

        public string FlightNr
        {
            get;
            set;
        }
        public string DepartingFrom
        {
            get;
            set;
        }
        public string Destination
        {
            get;
            set;
        }
        public double Distance
        {
            get;
            set;
        }

        public double TravelTime
        {
            get;
            set;
        }

        public int Capacity
        {
            get;
            set;
        }

        public double FuelConsumption
        {
            get;
            set;
        }

        public bool StopOver { get; set; }

        public string Company { get; set; }

        public Booking[] Seats { get; set; }

        public string ToString()
        {
            return FlightNr + " " + DepartingFrom + " " + Destination + " " + Capacity + " " +
                TravelTime + " " + FuelConsumption + " " + Distance + " " + StopOver + " " + Company;
        }
    }
}
    

