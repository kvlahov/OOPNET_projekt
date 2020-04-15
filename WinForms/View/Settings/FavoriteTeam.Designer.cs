namespace WinForms.View.Settings
{
    partial class FavoriteTeam
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
            this.CbTeams = new System.Windows.Forms.ComboBox();
            this.LbChooseTeam = new System.Windows.Forms.Label();
            this.BtnSave = new System.Windows.Forms.Button();
            this.LbLeagueTitle = new System.Windows.Forms.Label();
            this.LbLeague = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CbTeams
            // 
            this.CbTeams.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbTeams.FormattingEnabled = true;
            this.CbTeams.Location = new System.Drawing.Point(28, 126);
            this.CbTeams.Margin = new System.Windows.Forms.Padding(4);
            this.CbTeams.Name = "CbTeams";
            this.CbTeams.Size = new System.Drawing.Size(271, 37);
            this.CbTeams.TabIndex = 0;
            // 
            // LbChooseTeam
            // 
            this.LbChooseTeam.AutoSize = true;
            this.LbChooseTeam.Location = new System.Drawing.Point(22, 75);
            this.LbChooseTeam.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LbChooseTeam.Name = "LbChooseTeam";
            this.LbChooseTeam.Size = new System.Drawing.Size(224, 29);
            this.LbChooseTeam.TabIndex = 1;
            this.LbChooseTeam.Text = "Choose favorite team";
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(33, 265);
            this.BtnSave.Margin = new System.Windows.Forms.Padding(4);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(267, 94);
            this.BtnSave.TabIndex = 2;
            this.BtnSave.Text = "Save";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // LbLeagueTitle
            // 
            this.LbLeagueTitle.AutoSize = true;
            this.LbLeagueTitle.Location = new System.Drawing.Point(28, 191);
            this.LbLeagueTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LbLeagueTitle.Name = "LbLeagueTitle";
            this.LbLeagueTitle.Size = new System.Drawing.Size(121, 29);
            this.LbLeagueTitle.TabIndex = 3;
            this.LbLeagueTitle.Text = "League url:";
            // 
            // LbLeague
            // 
            this.LbLeague.AutoSize = true;
            this.LbLeague.Location = new System.Drawing.Point(147, 191);
            this.LbLeague.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LbLeague.Name = "LbLeague";
            this.LbLeague.Size = new System.Drawing.Size(0, 29);
            this.LbLeague.TabIndex = 4;
            // 
            // FavoriteTeam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 393);
            this.Controls.Add(this.LbLeague);
            this.Controls.Add(this.LbLeagueTitle);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.LbChooseTeam);
            this.Controls.Add(this.CbTeams);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FavoriteTeam";
            this.Text = "FavoriteTeam";
            this.Load += new System.EventHandler(this.FavoriteTeam_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CbTeams;
        private System.Windows.Forms.Label LbChooseTeam;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Label LbLeagueTitle;
        private System.Windows.Forms.Label LbLeague;
    }
}