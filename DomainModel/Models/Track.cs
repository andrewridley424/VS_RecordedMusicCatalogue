namespace RecordedMusicCatalogue.DomainModel.Models
{
    public class Track
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public decimal Duration { get; set; } = 0;
        public int Vinyl_Record_Id { get; set; } = 0;
        public int Cassette_Id { get; set; } = 0;
        public int Cd_Id { get; set; } = 0;

        public Track(int id, string name, decimal duration, int vinyl_record_id, int cassette_id, int cd_id)
        {
           Id = id;
            Name = name;
            Duration = duration;
            Vinyl_Record_Id = vinyl_record_id;
            Cassette_Id = cassette_id;
            Cd_Id = cd_id;
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
