using Newtonsoft.Json.Linq;
using RecordedMusicCatalogue.DataAccessLayer.Contracts;
using RecordedMusicCatalogue.DomainModel.Models;

namespace RecordedMusicCatalogue.UI
{
    public partial class VinylRecordCollection : Form
    {
        readonly IVinylRecordRepository _vinylRecordRepository;
        readonly ITracksRepository _tracksRepository;
        JObject themeConfig = ThemeConfigurationManager.LoadThemeConfig();

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
           ApplyStyles();
        }

        private async void RefreshDataGrid()
        {
            VinylRecordCollectionGrid.DataSource = await _vinylRecordRepository.GetVinylRecords();
        }
        private void CustomizeGridAppearance()
        {
            VinylRecordCollectionGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            VinylRecordCollectionGrid.AutoGenerateColumns = false;

            DataGridViewColumn[] columns = new DataGridViewColumn[9];

            columns[0] = new DataGridViewTextBoxColumn() { DataPropertyName = "Id", Visible = false };
            columns[1] = new DataGridViewTextBoxColumn() { DataPropertyName = "Title", HeaderText = "Title" };
            columns[2] = new DataGridViewTextBoxColumn() { DataPropertyName = "Artist", HeaderText = "Artist" };
            columns[3] = new DataGridViewTextBoxColumn() {DataPropertyName = "Label", HeaderText = "Label" }; 
            columns[4] = new DataGridViewTextBoxColumn() { DataPropertyName = "Genre", HeaderText = "Genre" };
            columns[5] = new DataGridViewTextBoxColumn() { DataPropertyName = "NumberOfDiscs", HeaderText = "Discs" };
            columns[6] = new DataGridViewTextBoxColumn() { DataPropertyName = "Rpm", HeaderText = "RPM" };
            columns[7] = new DataGridViewTextBoxColumn() { DataPropertyName = "Size", HeaderText = "Size" };
           columns[8] = new DataGridViewButtonColumn()
            {
                Text = "Tracks",
                Name = "TracksBtn",
                HeaderText = "",
                UseColumnTextForButtonValue = true,
                FlatStyle = FlatStyle.Flat,
                DefaultCellStyle = new DataGridViewCellStyle()
                {
                    BackColor = ColorTranslator.FromHtml((string)themeConfig["primaryBtnBgr"]),
                    ForeColor = ColorTranslator.FromHtml((string)themeConfig["primaryBtnFgr"]),
                    Alignment = DataGridViewContentAlignment.MiddleCenter
                }
            };
            
            VinylRecordCollectionGrid.RowHeadersVisible = false;
            VinylRecordCollectionGrid.Columns.Clear();
            VinylRecordCollectionGrid.Columns.AddRange(columns);
        }
        private void ApplyStyles()
        {
            this.BackColor = ColorTranslator.FromHtml((string)themeConfig["secondaryBgr"]);
            VinylRecordCollectionGrid.BackgroundColor = ColorTranslator.FromHtml((string)themeConfig["secondaryBgr"]);
            this.ForeColor = ColorTranslator.FromHtml((string)themeConfig["primaryFgr"]);
            VinylRecordCollectionGrid.DefaultCellStyle.BackColor = ColorTranslator.FromHtml((string)themeConfig["secondaryBgr"]);
            VinylRecordCollectionGrid.DefaultCellStyle.ForeColor = ColorTranslator.FromHtml((string)themeConfig["primaryFgr"]);
            VinylRecordCollectionGrid.ColumnHeadersDefaultCellStyle.BackColor = ColorTranslator.FromHtml((string)themeConfig["primaryBgr"]);
            VinylRecordCollectionGrid.ColumnHeadersDefaultCellStyle.ForeColor = ColorTranslator.FromHtml((string)themeConfig["tertiaryHeaderFgr"]);
        }
        private async void VinylRecordCollectionGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && VinylRecordCollectionGrid.CurrentCell is DataGridViewButtonCell)
            {
               VinylRecord clickedVinylRecord = (VinylRecord)VinylRecordCollectionGrid.Rows[e.RowIndex].DataBoundItem;
                if (e.ColumnIndex.Equals(8))
                {
                   TracksForm tracksForm = new TracksForm(_tracksRepository, clickedVinylRecord);
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
