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
            SuspendLayout();
            // 
            // VinylRecordCollectionBtn
            // 
            VinylRecordCollectionBtn.Location = new Point(93, 90);
            VinylRecordCollectionBtn.Name = "VinylRecordCollectionBtn";
            VinylRecordCollectionBtn.Size = new Size(328, 66);
            VinylRecordCollectionBtn.TabIndex = 0;
            VinylRecordCollectionBtn.Text = "Vinyl Record Collection";
            VinylRecordCollectionBtn.UseVisualStyleBackColor = true;
            VinylRecordCollectionBtn.Click += VinylRecordCollectionBtn_Click;
            // 
            // RecordedMusicCatalogueForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(VinylRecordCollectionBtn);
            Name = "RecordedMusicCatalogueForm";
            Text = "Recorded Music Catalogue";
            ResumeLayout(false);
        }

        #endregion

        private Button VinylRecordCollectionBtn;
    }
}
