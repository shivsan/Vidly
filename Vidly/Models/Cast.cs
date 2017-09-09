using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Vidly.Models
{
    public class Cast
    {
        public int Id { get; set; }
        [Required]
        public string Actors { get; set; }
    }
}