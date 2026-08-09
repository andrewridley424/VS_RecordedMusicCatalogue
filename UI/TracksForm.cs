using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.Extensions.DependencyInjection;
using RecordedMusicCatalogue.DataAccessLayer.Contracts;
using RecordedMusicCatalogue.DataAccessLayer.Repositories;
using RecordedMusicCatalogue.DomainModel.Models;

namespace RecordedMusicCatalogue.UI
{
    public partial class TracksForm : Form
    {
        readonly ITracksRepository _tracksRepository;
        IServiceProvider _serviceProvider;
        readonly VinylRecord _vinylRecord;

        public  TracksForm(ITracksRepository tracksRepository, VinylRecord vinylRecord)
        {
            InitializeComponent();
            _tracksRepository = tracksRepository;
            _vinylRecord = vinylRecord;
        }

        private void TracksForm_Load(object sender, EventArgs e)
        {
           // CustomizeGridAppearance();
           RefreshDataGrid();
        }

        private async void RefreshDataGrid() => TracksDataGrid.DataSource = await _tracksRepository.GetTracks(_vinylRecord);
    }
}
