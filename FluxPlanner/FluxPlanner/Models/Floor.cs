using System.ComponentModel.DataAnnotations;

namespace FluxPlanner.Models
{
    public class Floor
    {
        [Key]
        public int FloorId { get; set; }
        public int FloorNumber { get; set;}
    }
}
