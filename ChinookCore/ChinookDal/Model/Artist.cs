﻿using System;
using System.Collections.Generic;

namespace ChinookDal.Model
{
    public partial class Artist
    {
        public Artist()
        {
            Album = new HashSet<Album>();
        }

        public int ArtistId { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Album> Album { get; set; }
    }
}
