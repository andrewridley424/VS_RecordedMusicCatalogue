namespace RecordedMusicCatalogue.DomainModel.Models
{
   public class RecordedMusicAlbum
    {
        public required int Id { get; set; }
        public required string  Title { get; set; }
        public required string Artist { get; set; }
        public required string Label { get; set; }
        public required string  Genre { get; set; } 

        public  RecordedMusicAlbum( int id, string title, string artist, string label, string genre)
        {
            Id = id;
            Title = title;
            Artist = artist;
            Label = label;
            Genre = genre;
        }
        public RecordedMusicAlbum() { }
    }

}
