using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace ChinookDal.Model
{
    public partial class Album
    {
        public Album()
        {
            Track = new HashSet<Track>();
        }

        public int AlbumId { get; set; }
        public string Title { get; set; }
        public int ArtistId { get; set; }

        [JsonIgnore]
        public virtual Artist Artist { get; set; }
        public virtual ICollection<Track> Track { get; set; }
    }
}
