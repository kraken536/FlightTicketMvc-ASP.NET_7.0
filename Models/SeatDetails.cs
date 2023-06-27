using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FlightTicketsReservationMVC.Models
{
    public class SeatDetails
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("TravelClass")]
        public int TravelClassId { get; set; }

        [ForeignKey("FlightDetails")]
        public int FlightId { get; set; }

        public TravelClass? TravelClass { get; set; }

        public FlightDetails? flightDetails { get; set; }
    }
}
