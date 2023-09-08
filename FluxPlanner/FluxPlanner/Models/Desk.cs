using System.ComponentModel.DataAnnotations;

namespace FluxPlanner.Models
{
    public class Desk
    {
        [Key]
        public int DeskId { get; set; }
        public bool IsDeskAvailable { get; set; }
        public Room? Room { get; set; }
        public int RoomId { get; set; }
    }
}
