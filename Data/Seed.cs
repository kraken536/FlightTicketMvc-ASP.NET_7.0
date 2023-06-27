using FlightTicketsReservationMVC.Models;

namespace FlightTicketsReservationMVC.Data
{
    public class Seed
    {
        public static void SeedData(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<ApplicationDbContext>();

                context?.Database.EnsureCreated();

                //Airport
                context?.Airports.AddRange(new List<Airport>()
                {
                    new Airport()
                    {
                        Id = 1,
                        AirportName = "Istanbul Airport",
                        AirportCity = "Istanbul",
                        AirportCountry = "Türkiye"
                    },
                    new Airport()
                    {
                        Id = 2,
                        AirportName = "JFK Airport",
                        AirportCity = "New York",
                        AirportCountry = "USA"
                    }
                });
                context?.SaveChanges();

                //FlightDetails
                context?.FlightDetails.AddRange(new List<FlightDetails>() 
                {
                    new FlightDetails()
                    {
                        SourceAirportId= 1,
                        DestinationAirportId= 2,
                        PNR = "458AWD47",
                        DepartureDate = new DateOnly(2023, 06, 21),
                        SourceAirport = new Airport()
                        {
                            AirportName = "Antalya Airport",
                            AirportCity = "Antalya",
                            AirportCountry = "Türkiye"
                        },
                        DestinationAirport = new Airport()
                        {
                            AirportName = "Casablanca Airport",
                            AirportCity = "Casablanca",
                            AirportCountry = "Morroco"
                        },
                        ArrivalDate = new DateOnly(2023,06, 23),
                        Time = new TimeOnly(22, 45)
                    },
                    new FlightDetails()
                    {
                        SourceAirportId= 2,
                        DestinationAirportId= 1,
                        PNR = "458BZD47",
                        DepartureDate = new DateOnly(2023, 01, 21),
                        ArrivalDate = new DateOnly(2023,01, 23),
                        Time = new TimeOnly(14, 20)
                    }
                });
                context?.SaveChanges();

                //Seats Details

                context?.SeatDetails.AddRange(new List<SeatDetails>()
                {
                    new SeatDetails()
                    {
                        
                    },
                 });

            }
        }
    }
}
