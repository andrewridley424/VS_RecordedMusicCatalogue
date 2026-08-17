

using Newtonsoft.Json.Linq;
using RecordedMusicCatalogue.DataAccessLayer.Contracts;
using RecordedMusicCatalogue.DataAccessLayer.Repositories;
using RecordedMusicCatalogue.DomainModel.Models;
using System.Runtime.InteropServices.JavaScript;

namespace RecordedMusicCatalogue.UI
{
    public partial class CDCollectionForm : Form
    {
        private readonly ICdRepository _cdRepository;
        private readonly ITracksRepository _tracksRepository;
        JObject themeConfig = ThemeConfigurationManager.LoadThemeConfig();
        public CDCollectionForm(ICdRepository cdRepository, ITracksRepository tracksRepository)
        {
            InitializeComponent();
            _cdRepository = cdRepository;
            _tracksRepository = tracksRepository;
        }
        private async void RefreshDataGrid()
        {
            try
            {
                CDDataGrid.DataSource = await _cdRepository.GetCds();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void CDCollectionForm_Load_1(object sender, EventArgs e)
        {
            RefreshDataGrid();
            CustomizeGridAppearance();
            ApplyStyles();
        }
        private void CustomizeGridAppearance()
        {
            CDDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            CDDataGrid.AutoGenerateColumns = false;

            DataGridViewColumn[] columns = new DataGridViewColumn[7];

            columns[0] = new DataGridViewTextBoxColumn() { DataPropertyName = "Id", Visible = false };
            columns[1] = new DataGridViewTextBoxColumn() { DataPropertyName = "Title", HeaderText = "Title" };
            columns[2] = new DataGridViewTextBoxColumn() { DataPropertyName = "Artist", HeaderText = "Artist" };
            columns[3] = new DataGridViewTextBoxColumn() { DataPropertyName = "Label", HeaderText = "Label" };
            columns[4] = new DataGridViewTextBoxColumn() { DataPropertyName = "Genre", HeaderText = "Genre" };
            columns[5] = new DataGridViewTextBoxColumn() { DataPropertyName = "NumberOfDiscs", HeaderText = "Discs" };
            columns[6] = new DataGridViewButtonColumn()
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

            CDDataGrid.RowHeadersVisible = false;
            CDDataGrid.Columns.Clear();
            CDDataGrid.Columns.AddRange(columns);
        }
        private async void CDDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && CDDataGrid.CurrentCell is DataGridViewButtonCell)
            {
                Cd clickedCd = (Cd)CDDataGrid.Rows[e.RowIndex].DataBoundItem;
                if (e.ColumnIndex.Equals(6))
                {
                    TracksForm tracksForm = new TracksForm(_tracksRepository, clickedCd);
                    tracksForm.ShowDialog();
                }

            }
        }
        private void ApplyStyles()
        {
            this.BackColor = ColorTranslator.FromHtml((string)themeConfig["secondaryBgr"]);
            CDDataGrid.BackgroundColor = ColorTranslator.FromHtml((string)themeConfig["secondaryBgr"]);
            this.ForeColor = ColorTranslator.FromHtml((string)themeConfig["primaryFgr"]);
            CDDataGrid.DefaultCellStyle.BackColor = ColorTranslator.FromHtml((string)themeConfig["secondaryBgr"]);
            CDDataGrid.DefaultCellStyle.ForeColor = ColorTranslator.FromHtml((string)themeConfig["primaryFgr"]);
            CDDataGrid.ColumnHeadersDefaultCellStyle.BackColor = ColorTranslator.FromHtml((string)themeConfig["primaryBgr"]);
            CDDataGrid.ColumnHeadersDefaultCellStyle.ForeColor = ColorTranslator.FromHtml((string)themeConfig["tertiaryHeaderFgr"]);
        }
    }
}
