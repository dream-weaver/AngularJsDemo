using System;
using System.Collections.Generic;
using System.Globalization;

namespace Airlines.Models
{
    public class Flight
    {
        public int Id { get; set; }
        public string Airline { get; set; }
        public string FlightNumber { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public string _totalDuration;
        public string TotalDuration
        {
            get
            {
                return _totalDuration;
            }
            set
            {
                _totalDuration = String.Format("{0}:{1}:{2}", EndTime.Subtract(StartTime).Hours, EndTime.Subtract(StartTime).Minutes, EndTime.Subtract(StartTime).Seconds);
            }
        }
        public decimal Price { get; set; }
        public DateTime Date { get; set; }
        public IList<City> Cities { get; set; }
        public bool Approved { get; set; }
        public string SelectText { get; set; }
        public string ClassName { get; set; }
    }
}