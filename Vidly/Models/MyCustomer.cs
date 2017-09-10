﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class MyCustomer
    {
        public int Id { get; set; }
        [Required]
        [DisplayName("Full name")]
        public string Name { get; set; }
    }
}