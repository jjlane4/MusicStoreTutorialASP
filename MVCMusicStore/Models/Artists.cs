using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCMusicStore.Models
{
    public class Artist
    {

        public int ArtistID { get; set; }

        public string Name { get; set; }

        public int AlbumID { get; set; }

        public virtual List<Album> Album { get; set; }
    }
}