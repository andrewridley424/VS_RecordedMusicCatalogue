using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace RecordedMusicCatalogue.DomainModel.Models
{
    public class VinylRecord : RecordedMusicAlbum
    {
        public int Rpm { get; set; } = 0;
        public int Size { get; set; } = 0;

        public VinylRecord(int id, string title, string artist, string genre, int rpm, int size) : base(id, title, artist, genre)
        {
            Rpm = rpm;
            Size = size;
        }
        public VinylRecord() { }
    }
}
