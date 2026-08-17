using Newtonsoft.Json.Linq;
using RecordedMusicCatalogue.DataAccessLayer.Contracts;
using RecordedMusicCatalogue.DomainModel.Models;

namespace RecordedMusicCatalogue.UI
{
    public partial class CassetteCollectionForm : Form
    {
        readonly ICassetteRepository _cassetteRepository;
        readonly ITracksRepository _tracksRepository;
        JObject themeConfig = ThemeConfigurationManager.LoadThemeConfig();
        public CassetteCollectionForm(ICassetteRepository cassetteRepository, ITracksRepository tracksRepository)
        {
            InitializeComponent();
            _cassetteRepository = cassetteRepository;
            _tracksRepository = tracksRepository;
        }
        private void CassetteCollectionForm_Load(object sender, EventArgs e)
        {
           CustomizeGridAppearance();
           RefreshDataGrid();
           ApplyStyles();
        }

        private async void RefreshDataGrid()
        {
            try
            {
                CassetteCollectionDataGrid.DataSource = await _cassetteRepository.GetCassettes();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void CustomizeGridAppearance()
        {
            CassetteCollectionDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            CassetteCollectionDataGrid.AutoGenerateColumns = false;

            DataGridViewColumn[] columns = new DataGridViewColumn[6];

            columns[0] = new DataGridViewTextBoxColumn() { DataPropertyName = "Id", Visible = false };
            columns[1] = new DataGridViewTextBoxColumn() { DataPropertyName = "Title", HeaderText = "Title" };
            columns[2] = new DataGridViewTextBoxColumn() { DataPropertyName = "Artist", HeaderText = "Artist" };
            columns[3] = new DataGridViewTextBoxColumn() { DataPropertyName = "Label", HeaderText = "Label" };
            columns[4] = new DataGridViewTextBoxColumn() { DataPropertyName = "Genre", HeaderText = "Genre" };
            columns[5] = new DataGridViewButtonColumn()
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

            CassetteCollectionDataGrid.RowHeadersVisible = false;
            CassetteCollectionDataGrid.Columns.Clear();
            CassetteCollectionDataGrid.Columns.AddRange(columns);
        }

        private async void CassetteCollectionDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && CassetteCollectionDataGrid.CurrentCell is DataGridViewButtonCell)
            {
                Cassette clickedCassette = (Cassette)CassetteCollectionDataGrid.Rows[e.RowIndex].DataBoundItem;
                if (e.ColumnIndex.Equals(5))
                {
                    TracksForm tracksForm = new TracksForm(_tracksRepository, clickedCassette);
                    tracksForm.ShowDialog();
                }

            }
        }
        private void ApplyStyles()
        {
            this.BackColor = ColorTranslator.FromHtml((string)themeConfig["secondaryBgr"]);
            CassetteCollectionDataGrid.BackgroundColor = ColorTranslator.FromHtml((string)themeConfig["secondaryBgr"]);
            this.ForeColor = ColorTranslator.FromHtml((string)themeConfig["primaryFgr"]);
            CassetteCollectionDataGrid.DefaultCellStyle.BackColor = ColorTranslator.FromHtml((string)themeConfig["secondaryBgr"]);
            CassetteCollectionDataGrid.DefaultCellStyle.ForeColor = ColorTranslator.FromHtml((string)themeConfig["primaryFgr"]);
            CassetteCollectionDataGrid.ColumnHeadersDefaultCellStyle.BackColor = ColorTranslator.FromHtml((string)themeConfig["primaryBgr"]);
            CassetteCollectionDataGrid.ColumnHeadersDefaultCellStyle.ForeColor = ColorTranslator.FromHtml((string)themeConfig["tertiaryHeaderFgr"]);
        }
    }
}
