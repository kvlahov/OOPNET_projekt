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
            this.label1 = new System.Windows.Forms.Label();
            this.BtnSave = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.LbLeague = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CbTeams
            // 
            this.CbTeams.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbTeams.FormattingEnabled = true;
            this.CbTeams.Location = new System.Drawing.Point(33, 152);
            this.CbTeams.Margin = new System.Windows.Forms.Padding(5);
            this.CbTeams.Name = "CbTeams";
            this.CbTeams.Size = new System.Drawing.Size(315, 43);
            this.CbTeams.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 91);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(258, 35);
            this.label1.TabIndex = 1;
            this.label1.Text = "Choose favorite team";
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(39, 320);
            this.BtnSave.Margin = new System.Windows.Forms.Padding(5);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(311, 114);
            this.BtnSave.TabIndex = 2;
            this.BtnSave.Text = "Save";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 230);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 35);
            this.label2.TabIndex = 3;
            this.label2.Text = "League url:";
            // 
            // LbLeague
            // 
            this.LbLeague.AutoSize = true;
            this.LbLeague.Location = new System.Drawing.Point(171, 230);
            this.LbLeague.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LbLeague.Name = "LbLeague";
            this.LbLeague.Size = new System.Drawing.Size(0, 35);
            this.LbLeague.TabIndex = 4;
            // 
            // FavoriteTeam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 35F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 474);
            this.Controls.Add(this.LbLeague);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CbTeams);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FavoriteTeam";
            this.Text = "FavoriteTeam";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CbTeams;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LbLeague;
    }
}