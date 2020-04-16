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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.BtnPrintPlayerStats = new System.Windows.Forms.Button();
            this.PbLoading = new WinForms.View.UserControls.TransparentPictureBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.BtnPrintMatchStats = new System.Windows.Forms.Button();
            this.PbLoadingMatches = new WinForms.View.UserControls.TransparentPictureBox();
            this.DgMatchesStats = new System.Windows.Forms.DataGridView();
            this.PrintDocument = new System.Drawing.Printing.PrintDocument();
            this.PrintPreviewDialog = new System.Windows.Forms.PrintPreviewDialog();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.DgPlayerStats = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbLoading)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbLoadingMatches)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgMatchesStats)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgPlayerStats)).BeginInit();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
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
            this.tabPage1.Controls.Add(this.tableLayoutPanel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 38);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1059, 611);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Player statistics";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // BtnPrintPlayerStats
            // 
            this.BtnPrintPlayerStats.Location = new System.Drawing.Point(3, 3);
            this.BtnPrintPlayerStats.Name = "BtnPrintPlayerStats";
            this.BtnPrintPlayerStats.Size = new System.Drawing.Size(128, 45);
            this.BtnPrintPlayerStats.TabIndex = 5;
            this.BtnPrintPlayerStats.Text = "Print";
            this.BtnPrintPlayerStats.UseVisualStyleBackColor = true;
            this.BtnPrintPlayerStats.Click += new System.EventHandler(this.BtnPrintPlayerStats_Click);
            // 
            // PbLoading
            // 
            this.PbLoading.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PbLoading.BackColor = System.Drawing.Color.Transparent;
            this.PbLoading.Image = ((System.Drawing.Image)(resources.GetObject("PbLoading.Image")));
            this.PbLoading.Location = new System.Drawing.Point(120, 65);
            this.PbLoading.Name = "PbLoading";
            this.PbLoading.Size = new System.Drawing.Size(791, 423);
            this.PbLoading.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PbLoading.TabIndex = 3;
            this.PbLoading.TabStop = false;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tableLayoutPanel2);
            this.tabPage2.Location = new System.Drawing.Point(4, 38);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1059, 611);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Match statistics";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // BtnPrintMatchStats
            // 
            this.BtnPrintMatchStats.Location = new System.Drawing.Point(3, 3);
            this.BtnPrintMatchStats.Name = "BtnPrintMatchStats";
            this.BtnPrintMatchStats.Size = new System.Drawing.Size(128, 51);
            this.BtnPrintMatchStats.TabIndex = 6;
            this.BtnPrintMatchStats.Text = "Print";
            this.BtnPrintMatchStats.UseVisualStyleBackColor = true;
            this.BtnPrintMatchStats.Click += new System.EventHandler(this.BtnPrintMatchStats_Click);
            // 
            // PbLoadingMatches
            // 
            this.PbLoadingMatches.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PbLoadingMatches.BackColor = System.Drawing.Color.Transparent;
            this.PbLoadingMatches.Image = ((System.Drawing.Image)(resources.GetObject("PbLoadingMatches.Image")));
            this.PbLoadingMatches.Location = new System.Drawing.Point(239, 61);
            this.PbLoadingMatches.Name = "PbLoadingMatches";
            this.PbLoadingMatches.Size = new System.Drawing.Size(572, 429);
            this.PbLoadingMatches.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PbLoadingMatches.TabIndex = 3;
            this.PbLoadingMatches.TabStop = false;
            // 
            // DgMatchesStats
            // 
            this.DgMatchesStats.AllowUserToAddRows = false;
            this.DgMatchesStats.AllowUserToDeleteRows = false;
            this.DgMatchesStats.AllowUserToResizeColumns = false;
            this.DgMatchesStats.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.DgMatchesStats.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgMatchesStats.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgMatchesStats.Location = new System.Drawing.Point(0, 0);
            this.DgMatchesStats.Name = "DgMatchesStats";
            this.DgMatchesStats.ReadOnly = true;
            this.DgMatchesStats.RowHeadersWidth = 62;
            this.DgMatchesStats.RowTemplate.Height = 28;
            this.DgMatchesStats.Size = new System.Drawing.Size(1047, 542);
            this.DgMatchesStats.TabIndex = 0;
            // 
            // PrintDocument
            // 
            this.PrintDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.PrintDocument_PrintPage);
            // 
            // PrintPreviewDialog
            // 
            this.PrintPreviewDialog.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.PrintPreviewDialog.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.PrintPreviewDialog.ClientSize = new System.Drawing.Size(400, 300);
            this.PrintPreviewDialog.Document = this.PrintDocument;
            this.PrintPreviewDialog.Enabled = true;
            this.PrintPreviewDialog.Icon = ((System.Drawing.Icon)(resources.GetObject("PrintPreviewDialog.Icon")));
            this.PrintPreviewDialog.Name = "PrintPreviewDialog";
            this.PrintPreviewDialog.Visible = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.BtnPrintPlayerStats, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1053, 605);
            this.tableLayoutPanel1.TabIndex = 6;
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
            this.DgPlayerStats.Location = new System.Drawing.Point(0, 0);
            this.DgPlayerStats.Margin = new System.Windows.Forms.Padding(4);
            this.DgPlayerStats.Name = "DgPlayerStats";
            this.DgPlayerStats.ReadOnly = true;
            this.DgPlayerStats.RowHeadersWidth = 62;
            this.DgPlayerStats.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DgPlayerStats.RowTemplate.Height = 28;
            this.DgPlayerStats.Size = new System.Drawing.Size(1047, 548);
            this.DgPlayerStats.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.PbLoading);
            this.panel1.Controls.Add(this.DgPlayerStats);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 54);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1047, 548);
            this.panel1.TabIndex = 6;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.BtnPrintMatchStats, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel2, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1053, 605);
            this.tableLayoutPanel2.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.PbLoadingMatches);
            this.panel2.Controls.Add(this.DgMatchesStats);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 60);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1047, 542);
            this.panel2.TabIndex = 6;
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
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PbLoading)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PbLoadingMatches)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgMatchesStats)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgPlayerStats)).EndInit();
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView DgMatchesStats;
        private UserControls.TransparentPictureBox PbLoadingMatches;
        private UserControls.TransparentPictureBox PbLoading;
        private System.Windows.Forms.Button BtnPrintPlayerStats;
        private System.Windows.Forms.Button BtnPrintMatchStats;
        private System.Drawing.Printing.PrintDocument PrintDocument;
        private System.Windows.Forms.PrintPreviewDialog PrintPreviewDialog;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView DgPlayerStats;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panel2;
    }
}