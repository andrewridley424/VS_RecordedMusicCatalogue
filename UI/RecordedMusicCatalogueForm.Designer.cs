namespace RecordedMusicCatalogue
{
    partial class RecordedMusicCatalogueForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            VinylRecordCollectionBtn = new Button();
            CDCollectionBtn = new Button();
            CassetteCollectionBtn = new Button();
            SuspendLayout();
            // 
            // VinylRecordCollectionBtn
            // 
            VinylRecordCollectionBtn.FlatAppearance.BorderSize = 0;
            VinylRecordCollectionBtn.FlatStyle = FlatStyle.Flat;
            VinylRecordCollectionBtn.Font = new Font("Segoe UI", 12F);
            VinylRecordCollectionBtn.Location = new Point(82, 59);
            VinylRecordCollectionBtn.Name = "VinylRecordCollectionBtn";
            VinylRecordCollectionBtn.Size = new Size(382, 80);
            VinylRecordCollectionBtn.TabIndex = 0;
            VinylRecordCollectionBtn.Text = "Vinyl Record Collection";
            VinylRecordCollectionBtn.UseVisualStyleBackColor = true;
            VinylRecordCollectionBtn.Click += VinylRecordCollectionBtn_Click;
            // 
            // CDCollectionBtn
            // 
            CDCollectionBtn.FlatAppearance.BorderSize = 0;
            CDCollectionBtn.FlatStyle = FlatStyle.Flat;
            CDCollectionBtn.Font = new Font("Segoe UI", 12F);
            CDCollectionBtn.ForeColor = SystemColors.ControlLight;
            CDCollectionBtn.Location = new Point(82, 172);
            CDCollectionBtn.Name = "CDCollectionBtn";
            CDCollectionBtn.Size = new Size(382, 80);
            CDCollectionBtn.TabIndex = 1;
            CDCollectionBtn.Text = "CD Collection";
            CDCollectionBtn.UseVisualStyleBackColor = true;
            // 
            // CassetteCollectionBtn
            // 
            CassetteCollectionBtn.BackgroundImageLayout = ImageLayout.None;
            CassetteCollectionBtn.FlatAppearance.BorderSize = 0;
            CassetteCollectionBtn.FlatStyle = FlatStyle.Flat;
            CassetteCollectionBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CassetteCollectionBtn.Location = new Point(82, 292);
            CassetteCollectionBtn.Name = "CassetteCollectionBtn";
            CassetteCollectionBtn.Size = new Size(382, 80);
            CassetteCollectionBtn.TabIndex = 2;
            CassetteCollectionBtn.Text = "Cassette Collection";
            CassetteCollectionBtn.UseVisualStyleBackColor = true;
            // 
            // RecordedMusicCatalogueForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(547, 532);
            Controls.Add(CassetteCollectionBtn);
            Controls.Add(CDCollectionBtn);
            Controls.Add(VinylRecordCollectionBtn);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "RecordedMusicCatalogueForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Recorded Music Catalogue";
            ResumeLayout(false);
        }

        #endregion

        private Button VinylRecordCollectionBtn;
        private Button CDCollectionBtn;
        private Button CassetteCollectionBtn;
    }
}
