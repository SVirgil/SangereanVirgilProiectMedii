﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesWebMedii.Models
{
    public class Studio
    {
        public int ID { get; set; }
        public string StudioName { get; set; }
        public ICollection<Movie> Movies { get; set; } // navigation property
    }
}

