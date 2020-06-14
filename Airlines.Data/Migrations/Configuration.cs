namespace Airlines.Data.Migrations
{
    using Airlines.Models;
    using System;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<AppDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(AppDBContext context)
        {
            if (!context.Flights.Any())
            {
                #region Add City
               
                //
                #endregion
                context.Flights.AddRange(
                    new List<Flight>(){
                        new Flight() {
                        Airline = "United Commercial",
                        FlightNumber = "UCB34321",
                        StartTime = Convert.ToDateTime("13:00").ToUniversalTime(),
                        EndTime =  Convert.ToDateTime("15:30").ToUniversalTime(),
                        TotalDuration = "",
                        Price = 200,
                        Date = Convert.ToDateTime("6/10/2020"),
                        Approved = false,
                        SelectText = "Select",
                        ClassName = "flightCard"
                        },
                        new Flight(){
                        Airline = "BRB Commercial",
                        FlightNumber = "BRB34321",
                        StartTime = Convert.ToDateTime("13:00").ToUniversalTime(),
                        EndTime =  Convert.ToDateTime("16:00").ToUniversalTime(),
                        TotalDuration = "",
                        Price = 150,
                        
                        Date = Convert.ToDateTime("6/10/2020"),
                        Approved = false,
                        SelectText = "Select",
                        ClassName = "flightCard"
                        },
                        new Flight(){
                        Airline = "United",
                        FlightNumber = "UNO34321",
                        StartTime = Convert.ToDateTime("13:00").ToUniversalTime(),
                        EndTime =  Convert.ToDateTime("15:45").ToUniversalTime(),
                        TotalDuration = "",
                        Price = 210,
                       
                        Date = Convert.ToDateTime("6/10/2020"),
                        Approved = false,
                        SelectText = "Select",
                        ClassName = "flightCard"
                        },
                        new Flight(){
                        Airline = "Square",
                        FlightNumber = "SQR34321",
                        StartTime = Convert.ToDateTime("13:00").ToUniversalTime(),
                        EndTime =  Convert.ToDateTime("16:15").ToUniversalTime(),
                        TotalDuration = "",
                        Price = 190,
                        
                        Date = Convert.ToDateTime("6/10/2020"),
                        Approved = false,
                        SelectText = "Select",
                        ClassName = "flightCard"
                        }
                    }

                );
            }
        }
    }
}
