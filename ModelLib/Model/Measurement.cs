using System;
using System.Collections.Generic;
using System.Text;

namespace ModelLib.Model
{
    public class Measurement
    {
      
        public int Temperature { get; set; }
        public int Humidity { get; set; }
        public double Pressure { get; set; }



        public Measurement(int temperature, int humidity, double pressure)
        {
            Temperature = temperature;
            Humidity = humidity;
            Pressure = pressure;


        }

        public int Id
        {
            get;
            set;
        }


        public override string ToString()
        {

            return Temperature + " " + Humidity + " " + Pressure;
        }
    }
}
