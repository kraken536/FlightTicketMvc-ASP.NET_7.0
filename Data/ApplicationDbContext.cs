using FlightTicketsReservationMVC.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace FlightTicketsReservationMVC.Data
{
    public class ApplicationDbContext : IdentityDbContext<Passenger>
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> context) : base(context)
        {
            
        }

        public DbSet<Airport> Airports { get; set; }

        public DbSet<Reservation> Reservations { get; set; }

        public DbSet<Passenger> Passengers { get; set; }

        public DbSet<SeatDetails> SeatDetails { get; set; }

        public DbSet<TravelClass> TravelClasses { get; set; }

        public DbSet<FlightDetails> FlightDetails { get; set; }

        public DbSet<PNR> PNRs { get; set; }
    }
}
