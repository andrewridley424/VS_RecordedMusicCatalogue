using System.Windows.Forms.VisualStyles;
using RecordedMusicCatalogue.UI;
using Microsoft.Extensions.DependencyInjection;

namespace RecordedMusicCatalogue
{
    public partial class RecordedMusicCatalogueForm : Form
    {
        private readonly IServiceProvider _serviceProvider;

        public RecordedMusicCatalogueForm(IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _serviceProvider = serviceProvider;
            ApplyStyles();
        }

        private void VinylRecordCollectionBtn_Click(object sender, EventArgs e)
        {
            ShowForm(_serviceProvider.GetRequiredService<VinylRecordCollection>());
        }
        private static void ShowForm(Form form)
        {
            form.ShowDialog();
        }
        private void ApplyStyles()
        {
            this.Text = "Recorded Music Catalogue";
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.Size = new System.Drawing.Size(320, 355);
            this.BackColor = Color.FromArgb(45, 66, 91);
            this.VinylRecordCollectionBtn.BackColor = Color.FromArgb(91, 66, 45);
            this.VinylRecordCollectionBtn.ForeColor = Color.Wheat;
            this.CDCollectionBtn.BackColor = Color.FromArgb(91, 66, 45);
            this.CDCollectionBtn.ForeColor = Color.Wheat;
            this.CassetteCollectionBtn.BackColor = Color.FromArgb(91, 66, 45);
            this.CassetteCollectionBtn.ForeColor = Color.Wheat;
        }

        private void CassetteCollectionBtn_Click(object sender, EventArgs e)
        {
            ShowForm(_serviceProvider.GetRequiredService<CassetteCollectionForm>());
        }

        private void CDCollectionBtn_Click(object sender, EventArgs e)
        {
            ShowForm(_serviceProvider.GetRequiredService<CDCollectionForm>());
        }
    }
}
