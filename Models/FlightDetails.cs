using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FlightTicketsReservationMVC.Models
{
    public class FlightDetails
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("Airport")]
        public int SourceAirportId { get; set; }

        [ForeignKey("Airport")]
        public int DestinationAirportId { get; set; }

        [ForeignKey("PNR")]
        public string? PNR { get; set; }
        //string strPNR = System.Guid.NewGuid().ToString();

        public Airport? SourceAirport { get; set; }

        public Airport? DestinationAirport { get; set; }

        public DateOnly DepartureDate { get; set; }

        public DateOnly ArrivalDate { get; set; }

        public TimeOnly Time { get; set; }

    }
}
