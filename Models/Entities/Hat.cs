using System.ComponentModel.DataAnnotations;

namespace Hats.Models {
    public class Hat {
        public int HatId { get; set; }
        [Required] public string Name { get; set; }
        // Other rules are allowed, like max length
        [Required] public string Color { get; set; }
    }
}