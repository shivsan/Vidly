using System.ComponentModel.DataAnnotations;

namespace Vidly.Models
{
    public class MemberShipType
    {
        [Required]
        [MinLength(2)]
        public string Name { get; set; }
        
        public int Id { get; set; }
    }
}