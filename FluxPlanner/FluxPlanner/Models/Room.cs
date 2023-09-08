using System.ComponentModel.DataAnnotations;

namespace FluxPlanner.Models
{
    public class Room
    {
        [Key]
        public int RoomId { get; set; }
        public string RoomName { get; set; }
        public int TotalDesks { get; set; }
        public int AvailableDesks { get; set; }
        public Floor? Floor { get; set; }
        public int FloorId { get; set; }
    }
}
