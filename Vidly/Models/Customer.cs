using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class Customer
    {
        public int Id { get; set; }
        [Required]
        [StringLength(255)]
        [Display(Name ="First Name")]
        //[DisplayName("First Name")]
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public MemberShipType MemberShipType { get; set; }
        [DisplayFormat(DataFormatString ="")]
        public DateTime? BirthDate { get; set; }
        public int MemberShipTypeId { get; set; }
    }
}