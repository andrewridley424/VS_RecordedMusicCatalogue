using System;
using System.Collections.Generic;
using System.Text;

namespace RecordedMusicCatalogue.DomainModel.Models
{
    public class Track
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public decimal Duration { get; set; } = 0; 
        public int Vinyl_Record_Id { get; set; }

        public Track(int id, string name, decimal duration, int vinyl_record_id)
        {
           Id = id;
            Name = name;
            Duration = duration;
            Vinyl_Record_Id = vinyl_record_id;
        }
        public Track(int id,string name, decimal duration)
        {
            Id = id;
            Name = name;
            Duration = duration;
        }
        public Track() { }  

    }
}
