using System.ComponentModel.DataAnnotations;

namespace FlightTicketsReservationMVC.Models
{
    public class PNR
    {
        [Key]
        public int? Id { get; set; }

        public string? PNRCode { get; set; }  
    }
}
