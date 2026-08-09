using RecordedMusicCatalogue.UI;
using Microsoft.Extensions.DependencyInjection;
using System.Windows.Forms;

namespace RecordedMusicCatalogue
{
    public partial class RecordedMusicCatalogueForm : Form
    {
        private readonly IServiceProvider _serviceProvider;
        
        public RecordedMusicCatalogueForm(IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _serviceProvider = serviceProvider;
        }

        private void VinylRecordCollectionBtn_Click(object sender, EventArgs e)
        {
            ShowForm(_serviceProvider.GetRequiredService<VinylRecordCollection>()) ;    
        }
        private static void ShowForm(Form form)
        {
            form.ShowDialog();  
        }
    }
}
