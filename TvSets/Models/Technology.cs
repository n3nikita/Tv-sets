﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TvSets.Models
{
    public class Technology
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public ICollection<Tvset> Tvsets { get; set; }
        //public ICollection<Company> Companies { get; set; }
    }
}