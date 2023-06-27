using System.ComponentModel.DataAnnotations;

namespace FlightTicketsReservationMVC.Models
{
    public class Airport
    {
        [Key]
        public int Id { get; set; }

        public string AirportName { get; set; } = string.Empty;

        public string AirportCity { get; set; } = string.Empty;

        public string AirportCountry { get; set; } = string.Empty;
    }
}
