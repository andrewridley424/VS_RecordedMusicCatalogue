using System;
using System.Collections.Generic;
using System.Runtime.Intrinsics.Arm;
using System.Text;

namespace RecordedMusicCatalogue.DomainModel.Models
{
   public class Cassette : RecordedMusicAlbum
    {
       
        public Cassette(int id, string title, string artist, string label, string genre) : base(id, title, artist, label, genre)
        {
           
        }
        public Cassette() { }
    }
}
