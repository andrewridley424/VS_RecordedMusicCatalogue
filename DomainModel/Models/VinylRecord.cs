namespace RecordedMusicCatalogue.DomainModel.Models
{
    public class VinylRecord : RecordedMusicAlbum
    {
        public int Rpm { get; set; } = 0;
        public int Size { get; set; } = 0;
        public int NumberOfDiscs { get; set; } = 0;

        public VinylRecord(int id, string title, string artist, string label, string genre, int numberOfDiscs, int rpm, int size) : base(id, title, artist, label, genre)
        {
            NumberOfDiscs = numberOfDiscs;
            Rpm = rpm;
            Size = size;
        }
        public VinylRecord() { }
    }
}
