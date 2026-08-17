using System;
using System.Collections.Generic;
using System.Text;

namespace RecordedMusicCatalogue.DomainModel.Models
{
   public class Cd : RecordedMusicAlbum
    {
       public int NumberOfDiscs { get; set; } = 0;
        public Cd(int id, string title, string artist, string label, string genre, int number_of_discs) : base(id, title, artist, label, genre)
        {
            NumberOfDiscs = number_of_discs;
        }
        public Cd() { }
    }
}
