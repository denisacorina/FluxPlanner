using FluxPlanner.Data;
using System.ComponentModel.DataAnnotations;

namespace FluxPlanner.Models
{
    public class DeskReservation
    {
        [Key]
        public int ReservationId { get; set; }  
        public int DeskId { get; set; }
        public int UserId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public ReservationStatus ReservationStatus { get; set; }
        public User User { get; set; }

    }
}