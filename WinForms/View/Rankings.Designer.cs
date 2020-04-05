namespace WinForms.View
{
    partial class Rankings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Rankings));
            this.DgPlayerStats = new System.Windows.Forms.DataGridView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.DgMatchesStats = new System.Windows.Forms.DataGridView();
            this.PbLoading = new WinForms.View.UserControls.TransparentPictureBox();
            this.PbLoadingMatches = new WinForms.View.UserControls.TransparentPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.DgPlayerStats)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgMatchesStats)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbLoading)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbLoadingMatches)).BeginInit();
            this.SuspendLayout();
            // 
            // DgPlayerStats
            // 
            this.DgPlayerStats.AllowUserToAddRows = false;
            this.DgPlayerStats.AllowUserToDeleteRows = false;
            this.DgPlayerStats.AllowUserToOrderColumns = true;
            this.DgPlayerStats.AllowUserToResizeColumns = false;
            this.DgPlayerStats.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DgPlayerStats.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgPlayerStats.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgPlayerStats.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.DgPlayerStats.Location = new System.Drawing.Point(3, 3);
            this.DgPlayerStats.Margin = new System.Windows.Forms.Padding(4);
            this.DgPlayerStats.Name = "DgPlayerStats";
            this.DgPlayerStats.ReadOnly = true;
            this.DgPlayerStats.RowHeadersWidth = 62;
            this.DgPlayerStats.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DgPlayerStats.RowTemplate.Height = 28;
            this.DgPlayerStats.Size = new System.Drawing.Size(1053, 605);
            this.DgPlayerStats.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1067, 653);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.PbLoading);
            this.tabPage1.Controls.Add(this.DgPlayerStats);
            this.tabPage1.Location = new System.Drawing.Point(4, 38);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1059, 611);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Player statistics";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.PbLoadingMatches);
            this.tabPage2.Controls.Add(this.DgMatchesStats);
            this.tabPage2.Location = new System.Drawing.Point(4, 38);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1059, 611);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Match statistics";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // DgMatchesStats
            // 
            this.DgMatchesStats.AllowUserToAddRows = false;
            this.DgMatchesStats.AllowUserToDeleteRows = false;
            this.DgMatchesStats.AllowUserToResizeColumns = false;
            this.DgMatchesStats.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.DgMatchesStats.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgMatchesStats.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgMatchesStats.Location = new System.Drawing.Point(3, 3);
            this.DgMatchesStats.Name = "DgMatchesStats";
            this.DgMatchesStats.ReadOnly = true;
            this.DgMatchesStats.RowHeadersWidth = 62;
            this.DgMatchesStats.RowTemplate.Height = 28;
            this.DgMatchesStats.Size = new System.Drawing.Size(1053, 605);
            this.DgMatchesStats.TabIndex = 0;
            // 
            // PbLoading
            // 
            this.PbLoading.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PbLoading.BackColor = System.Drawing.Color.Transparent;
            this.PbLoading.Image = ((System.Drawing.Image)(resources.GetObject("PbLoading.Image")));
            this.PbLoading.Location = new System.Drawing.Point(217, 90);
            this.PbLoading.Name = "PbLoading";
            this.PbLoading.Size = new System.Drawing.Size(572, 407);
            this.PbLoading.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PbLoading.TabIndex = 3;
            this.PbLoading.TabStop = false;
            // 
            // PbLoadingMatches
            // 
            this.PbLoadingMatches.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PbLoadingMatches.BackColor = System.Drawing.Color.Transparent;
            this.PbLoadingMatches.Image = ((System.Drawing.Image)(resources.GetObject("PbLoadingMatches.Image")));
            this.PbLoadingMatches.Location = new System.Drawing.Point(228, 80);
            this.PbLoadingMatches.Name = "PbLoadingMatches";
            this.PbLoadingMatches.Size = new System.Drawing.Size(572, 425);
            this.PbLoadingMatches.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PbLoadingMatches.TabIndex = 3;
            this.PbLoadingMatches.TabStop = false;
            // 
            // Rankings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 653);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Rankings";
            this.Text = "Rankings";
            this.Load += new System.EventHandler(this.Rankings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgPlayerStats)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgMatchesStats)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbLoading)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbLoadingMatches)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DgPlayerStats;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView DgMatchesStats;
        private UserControls.TransparentPictureBox PbLoadingMatches;
        private UserControls.TransparentPictureBox PbLoading;
    }
}