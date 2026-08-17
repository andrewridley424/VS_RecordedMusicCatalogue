namespace RecordedMusicCatalogue.UI
{
    partial class CassetteCollectionForm
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
            CassetteCollectionDataGrid = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)CassetteCollectionDataGrid).BeginInit();
            SuspendLayout();
            // 
            // CassetteCollectionDataGrid
            // 
            CassetteCollectionDataGrid.ColumnHeadersHeight = 27;
            CassetteCollectionDataGrid.Dock = DockStyle.Fill;
            CassetteCollectionDataGrid.Location = new Point(50, 0);
            CassetteCollectionDataGrid.Margin = new Padding(3, 10, 3, 10);
            CassetteCollectionDataGrid.Name = "CassetteCollectionDataGrid";
            CassetteCollectionDataGrid.RowHeadersWidth = 82;
            CassetteCollectionDataGrid.ScrollBars = ScrollBars.Vertical;
            CassetteCollectionDataGrid.Size = new Size(1682, 579);
            CassetteCollectionDataGrid.TabIndex = 0;
            CassetteCollectionDataGrid.CellClick += CassetteCollectionDataGrid_CellClick;
            // 
            // CassetteCollectionForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1782, 629);
            Controls.Add(CassetteCollectionDataGrid);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "CassetteCollectionForm";
            Padding = new Padding(50, 0, 50, 50);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cassette Collection";
            Load += CassetteCollectionForm_Load;
            ((System.ComponentModel.ISupportInitialize)CassetteCollectionDataGrid).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView CassetteCollectionDataGrid;
    }
}