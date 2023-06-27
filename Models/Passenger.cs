using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FlightTicketsReservationMVC.Models
{
    public class Passenger : IdentityUser
    {
        public string FirstName { get; set; } = string.Empty;

        public string LastName { get; set; } = string.Empty;

        public int TCKN { get; set; }

        [ForeignKey("Reservation")]
        public int? ReservationId { get; set; }

        public Reservation? Reservation { get; set; }
    }
}
