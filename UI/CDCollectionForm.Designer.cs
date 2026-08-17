namespace RecordedMusicCatalogue.UI
{
    partial class CDCollectionForm
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
            CDDataGrid = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)CDDataGrid).BeginInit();
            SuspendLayout();
            // 
            // CDDataGrid
            // 
            CDDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            CDDataGrid.Location = new Point(50, 0);
            CDDataGrid.Margin = new Padding(3, 10, 3, 10);
            CDDataGrid.Name = "CDDataGrid";
            CDDataGrid.RowHeadersWidth = 82;
            CDDataGrid.ScrollBars = ScrollBars.Vertical;
            CDDataGrid.Size = new Size(1682, 579);
            CDDataGrid.TabIndex = 0;
            CDDataGrid.CellClick += CDDataGrid_CellClick;
            // 
            // CDCollectionForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(1782, 629);
            Controls.Add(CDDataGrid);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "CDCollectionForm";
            Padding = new Padding(50, 0, 50, 50);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CD Collection";
            Load += CDCollectionForm_Load_1;
            ((System.ComponentModel.ISupportInitialize)CDDataGrid).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView CDDataGrid;
    }
}