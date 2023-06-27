using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FlightTicketsReservationMVC.Models
{
    public class Reservation
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("TravelClass")]
        public int TravelClassId { get; set; }

        [ForeignKey("FlightDetails")]
        public int FlightId { get; set; }

        [ForeignKey("PNR")]
        public int PNR { get; set; }

        public TravelClass? TravelClass { get; set; }

        public FlightDetails? FlightDetails { get; set; }

        public PNR? PNRInfo { get; set; }

    }
}
