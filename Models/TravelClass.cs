using System.ComponentModel.DataAnnotations;

namespace FlightTicketsReservationMVC.Models
{
    public class TravelClass
    {
        [Key]
        public int Id { get; set; }

        public string? Name { get; set; }
    }
}
