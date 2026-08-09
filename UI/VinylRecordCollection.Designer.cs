namespace RecordedMusicCatalogue.UI
{
    partial class VinylRecordCollection
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            VinylRecordCollectionGrid = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)VinylRecordCollectionGrid).BeginInit();
            SuspendLayout();
            // 
            // VinylRecordCollectionGrid
            // 
            VinylRecordCollectionGrid.BorderStyle = BorderStyle.None;
            VinylRecordCollectionGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            VinylRecordCollectionGrid.Dock = DockStyle.Fill;
            VinylRecordCollectionGrid.Location = new Point(50, 0);
            VinylRecordCollectionGrid.Margin = new Padding(3, 10, 3, 10);
            VinylRecordCollectionGrid.Name = "VinylRecordCollectionGrid";
            VinylRecordCollectionGrid.RowHeadersWidth = 82;
            VinylRecordCollectionGrid.Size = new Size(1682, 579);
            VinylRecordCollectionGrid.TabIndex = 0;
            VinylRecordCollectionGrid.CellContentClick += VinylRecordCollectionGrid_CellClick;
            // 
            // VinylRecordCollection
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1782, 629);
            Controls.Add(VinylRecordCollectionGrid);
            Name = "VinylRecordCollection";
            Padding = new Padding(50, 0, 50, 50);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "VinylRecordCollection";
            Load += VinylRecordCollection_Load;
            ((System.ComponentModel.ISupportInitialize)VinylRecordCollectionGrid).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView VinylRecordCollectionGrid;
    }
}