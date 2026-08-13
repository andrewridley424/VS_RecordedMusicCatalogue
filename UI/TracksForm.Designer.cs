namespace RecordedMusicCatalogue.UI
{
    partial class TracksForm
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
            TracksDataGrid = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)TracksDataGrid).BeginInit();
            SuspendLayout();
            // 
            // TracksDataGrid
            // 
            TracksDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            TracksDataGrid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            TracksDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            TracksDataGrid.Dock = DockStyle.Fill;
            TracksDataGrid.Location = new Point(50, 0);
            TracksDataGrid.Margin = new Padding(3, 50, 50, 50);
            TracksDataGrid.Name = "TracksDataGrid";
            TracksDataGrid.RowHeadersWidth = 82;
            TracksDataGrid.ScrollBars = ScrollBars.Vertical;
            TracksDataGrid.Size = new Size(700, 400);
            TracksDataGrid.TabIndex = 0;
            // 
            // TracksForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(TracksDataGrid);
            Name = "TracksForm";
            Padding = new Padding(50, 0, 50, 50);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Album Tracks";
            Load += TracksForm_Load;
            ((System.ComponentModel.ISupportInitialize)TracksDataGrid).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView TracksDataGrid;
    }
}