using System.Runtime.CompilerServices;
using RecordedMusicCatalogue.DataAccessLayer.Contracts;
using RecordedMusicCatalogue.DomainModel.Models;

namespace RecordedMusicCatalogue.UI
{
    public partial class TracksForm : Form
    {
        readonly ITracksRepository _tracksRepository;
        private readonly RecordedMusicAlbum _record;
        public TracksForm(ITracksRepository tracksRepository, RecordedMusicAlbum record)
        {
            InitializeComponent();
            _tracksRepository = tracksRepository;
            _record = record;
            this.Text = _record.Title + " Tracks";
        }

        private void TracksForm_Load(object sender, EventArgs e)
        {
           CustomizeGridAppearance();
           RefreshDataGrid();
        }

        private async void RefreshDataGrid()
        {
            var recordedMusicAlbum = _record;
            TracksDataGrid.DataSource = await _tracksRepository.GetTracks(recordedMusicAlbum);
        }

        private void CustomizeGridAppearance()
        {
            TracksDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            TracksDataGrid.AutoGenerateColumns = false;

            DataGridViewColumn[] columns = new DataGridViewColumn[4];
            
            columns[0] = new DataGridViewTextBoxColumn() { DataPropertyName = "Id", Visible = false };
            columns[1] = new DataGridViewTextBoxColumn() { DataPropertyName = "Name", HeaderText = "Name" };
            columns[2] = new DataGridViewTextBoxColumn() { DataPropertyName = "Duration", HeaderText = "Duration" };
            columns[3] = new DataGridViewTextBoxColumn() { DataPropertyName = "Vinyl_Record_Id", Visible = false };

            TracksDataGrid.RowHeadersVisible = false;
            TracksDataGrid.Columns.Clear();
            TracksDataGrid.Columns.AddRange(columns);
        }
    }
}
