namespace WinForms.View
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.MiPreferences = new System.Windows.Forms.ToolStripButton();
            this.BtnFavoriteTeams = new System.Windows.Forms.Button();
            this.BtnRankings = new System.Windows.Forms.Button();
            this.BtnUploadImages = new System.Windows.Forms.Button();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MiPreferences});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.toolStrip1.Size = new System.Drawing.Size(1066, 34);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // MiPreferences
            // 
            this.MiPreferences.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.MiPreferences.Image = ((System.Drawing.Image)(resources.GetObject("MiPreferences.Image")));
            this.MiPreferences.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.MiPreferences.Name = "MiPreferences";
            this.MiPreferences.Size = new System.Drawing.Size(130, 29);
            this.MiPreferences.Text = "Preferences";
            this.MiPreferences.Click += new System.EventHandler(this.MiPreferences_Click);
            // 
            // BtnFavoriteTeams
            // 
            this.BtnFavoriteTeams.Location = new System.Drawing.Point(10, 41);
            this.BtnFavoriteTeams.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnFavoriteTeams.Name = "BtnFavoriteTeams";
            this.BtnFavoriteTeams.Size = new System.Drawing.Size(266, 59);
            this.BtnFavoriteTeams.TabIndex = 1;
            this.BtnFavoriteTeams.Text = "Show favorite teams";
            this.BtnFavoriteTeams.UseVisualStyleBackColor = true;
            this.BtnFavoriteTeams.Click += new System.EventHandler(this.BtnFavoriteTeams_Click);
            // 
            // BtnRankings
            // 
            this.BtnRankings.Location = new System.Drawing.Point(10, 163);
            this.BtnRankings.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnRankings.Name = "BtnRankings";
            this.BtnRankings.Size = new System.Drawing.Size(266, 68);
            this.BtnRankings.TabIndex = 4;
            this.BtnRankings.Text = "Show rankings";
            this.BtnRankings.UseVisualStyleBackColor = true;
            this.BtnRankings.Click += new System.EventHandler(this.BtnRankings_Click);
            // 
            // BtnUploadImages
            // 
            this.BtnUploadImages.Location = new System.Drawing.Point(12, 301);
            this.BtnUploadImages.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnUploadImages.Name = "BtnUploadImages";
            this.BtnUploadImages.Size = new System.Drawing.Size(266, 68);
            this.BtnUploadImages.TabIndex = 5;
            this.BtnUploadImages.Text = "Upload images";
            this.BtnUploadImages.UseVisualStyleBackColor = true;
            this.BtnUploadImages.Click += new System.EventHandler(this.BtnUploadImages_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1066, 653);
            this.Controls.Add(this.BtnUploadImages);
            this.Controls.Add(this.BtnRankings);
            this.Controls.Add(this.BtnFavoriteTeams);
            this.Controls.Add(this.toolStrip1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton MiPreferences;
        private System.Windows.Forms.Button BtnFavoriteTeams;
        private System.Windows.Forms.Button BtnRankings;
        private System.Windows.Forms.Button BtnUploadImages;
    }
}