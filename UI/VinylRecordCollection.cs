using Microsoft.Extensions.DependencyInjection;
using RecordedMusicCatalogue.DataAccessLayer.Contracts;
using RecordedMusicCatalogue.DomainModel.Models;

namespace RecordedMusicCatalogue.UI
{
    public partial class VinylRecordCollection : Form
    {
        readonly IVinylRecordRepository _vinylRecordRepository;
        readonly ITracksRepository _tracksRepository;

        private readonly IServiceProvider _serviceProvider;
        public VinylRecordCollection(IVinylRecordRepository vinylRecordRepository, ITracksRepository tracksRepository)
        {
            InitializeComponent();
            _vinylRecordRepository = vinylRecordRepository; 
            _tracksRepository = tracksRepository;   
        }

       private void VinylRecordCollection_Load(object sender, EventArgs e)
        {
           CustomizeGridAppearance();
           RefreshDataGrid();
        }

        private async void RefreshDataGrid()
        {
            VinylRecordCollectionGrid.DataSource = await _vinylRecordRepository.GetVinylRecords();
        }
        private void CustomizeGridAppearance()
        {
            VinylRecordCollectionGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            VinylRecordCollectionGrid.AutoGenerateColumns = false;

            DataGridViewColumn[] columns = new DataGridViewColumn[7];

            columns[0] = new DataGridViewTextBoxColumn() { DataPropertyName = "Id", Visible = false };
            columns[1] = new DataGridViewTextBoxColumn() { DataPropertyName = "Title", HeaderText = "Title" };
            columns[2] = new DataGridViewTextBoxColumn() { DataPropertyName = "Artist", HeaderText = "Artist" };
            columns[3] = new DataGridViewTextBoxColumn() { DataPropertyName = "Genre", HeaderText = "Genre" };
            columns[4] = new DataGridViewTextBoxColumn() { DataPropertyName = "Rpm", HeaderText = "RPM" };
            columns[5] = new DataGridViewTextBoxColumn() { DataPropertyName = "Size", HeaderText = "Size" };
           columns[6] = new DataGridViewButtonColumn()
            {
                Text = "Tracks",
                Name = "TracksBtn",
                HeaderText = "",
                UseColumnTextForButtonValue = true,
                FlatStyle = FlatStyle.Flat,
                DefaultCellStyle = new DataGridViewCellStyle()
                {
                    //BackColor = ColorTranslator.FromHtml((string)themeConfig["primaryBtnBgr"]),
                    //ForeColor = ColorTranslator.FromHtml((string)themeConfig["primaryBtnFgr"]),
                    Alignment = DataGridViewContentAlignment.MiddleCenter
                }
            };
            
            VinylRecordCollectionGrid.RowHeadersVisible = false;
            VinylRecordCollectionGrid.Columns.Clear();
            VinylRecordCollectionGrid.Columns.AddRange(columns);
        }
        private async void VinylRecordCollectionGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && VinylRecordCollectionGrid.CurrentCell is DataGridViewButtonCell)
            {
               VinylRecord clickedRecord = (VinylRecord)VinylRecordCollectionGrid.Rows[e.RowIndex].DataBoundItem;
                if (e.ColumnIndex.Equals(6))
                {
                   TracksForm tracksForm = new TracksForm(_tracksRepository, clickedRecord);
                    tracksForm.ShowDialog();
                }
                
               /* else if (e.RowIndex == 0 && e.ColumnIndex == 1)
                {
                    await _ingredientsRepository.GetIngredients();
                }*/
            }
        }

    }
}
