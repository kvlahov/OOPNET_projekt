namespace WinForms.View.Settings
{
    partial class Preferences
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
            this.GbLeague = new System.Windows.Forms.GroupBox();
            this.RbContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.RbMenLeague = new System.Windows.Forms.RadioButton();
            this.RbWomenLeague = new System.Windows.Forms.RadioButton();
            this.LbLanguageTitle = new System.Windows.Forms.Label();
            this.CbLanguage = new System.Windows.Forms.ComboBox();
            this.GbLanguage = new System.Windows.Forms.GroupBox();
            this.BtnSave = new System.Windows.Forms.Button();
            this.BtnConfirm = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.GbLeague.SuspendLayout();
            this.RbContainer.SuspendLayout();
            this.GbLanguage.SuspendLayout();
            this.SuspendLayout();
            // 
            // GbLeague
            // 
            this.GbLeague.Controls.Add(this.RbContainer);
            this.GbLeague.Location = new System.Drawing.Point(57, 41);
            this.GbLeague.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.GbLeague.Name = "GbLeague";
            this.GbLeague.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.GbLeague.Size = new System.Drawing.Size(309, 149);
            this.GbLeague.TabIndex = 0;
            this.GbLeague.TabStop = false;
            this.GbLeague.Text = "Choose league";
            // 
            // RbContainer
            // 
            this.RbContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RbContainer.Controls.Add(this.RbMenLeague);
            this.RbContainer.Controls.Add(this.RbWomenLeague);
            this.RbContainer.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.RbContainer.Location = new System.Drawing.Point(9, 36);
            this.RbContainer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.RbContainer.Name = "RbContainer";
            this.RbContainer.Size = new System.Drawing.Size(286, 93);
            this.RbContainer.TabIndex = 0;
            // 
            // RbMenLeague
            // 
            this.RbMenLeague.AutoSize = true;
            this.RbMenLeague.Location = new System.Drawing.Point(3, 4);
            this.RbMenLeague.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.RbMenLeague.Name = "RbMenLeague";
            this.RbMenLeague.Size = new System.Drawing.Size(169, 33);
            this.RbMenLeague.TabIndex = 0;
            this.RbMenLeague.TabStop = true;
            this.RbMenLeague.Tag = "1";
            this.RbMenLeague.Text = "Men\'s league";
            this.RbMenLeague.UseVisualStyleBackColor = true;
            // 
            // RbWomenLeague
            // 
            this.RbWomenLeague.AutoSize = true;
            this.RbWomenLeague.Location = new System.Drawing.Point(3, 45);
            this.RbWomenLeague.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.RbWomenLeague.Name = "RbWomenLeague";
            this.RbWomenLeague.Size = new System.Drawing.Size(200, 33);
            this.RbWomenLeague.TabIndex = 1;
            this.RbWomenLeague.TabStop = true;
            this.RbWomenLeague.Tag = "2";
            this.RbWomenLeague.Text = "Women\'s league";
            this.RbWomenLeague.UseVisualStyleBackColor = true;
            // 
            // LbLanguageTitle
            // 
            this.LbLanguageTitle.AutoSize = true;
            this.LbLanguageTitle.Location = new System.Drawing.Point(9, 61);
            this.LbLanguageTitle.Name = "LbLanguageTitle";
            this.LbLanguageTitle.Size = new System.Drawing.Size(107, 29);
            this.LbLanguageTitle.TabIndex = 1;
            this.LbLanguageTitle.Text = "Language";
            // 
            // CbLanguage
            // 
            this.CbLanguage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbLanguage.FormattingEnabled = true;
            this.CbLanguage.Location = new System.Drawing.Point(130, 56);
            this.CbLanguage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CbLanguage.Name = "CbLanguage";
            this.CbLanguage.Size = new System.Drawing.Size(160, 37);
            this.CbLanguage.TabIndex = 2;
            // 
            // GbLanguage
            // 
            this.GbLanguage.Controls.Add(this.CbLanguage);
            this.GbLanguage.Controls.Add(this.LbLanguageTitle);
            this.GbLanguage.Location = new System.Drawing.Point(57, 220);
            this.GbLanguage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.GbLanguage.Name = "GbLanguage";
            this.GbLanguage.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.GbLanguage.Size = new System.Drawing.Size(309, 145);
            this.GbLanguage.TabIndex = 3;
            this.GbLanguage.TabStop = false;
            this.GbLanguage.Text = "Choose language";
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(122, 387);
            this.BtnSave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(177, 64);
            this.BtnSave.TabIndex = 4;
            this.BtnSave.Text = "Save";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // BtnConfirm
            // 
            this.BtnConfirm.BackColor = System.Drawing.Color.LawnGreen;
            this.BtnConfirm.Location = new System.Drawing.Point(212, 387);
            this.BtnConfirm.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnConfirm.Name = "BtnConfirm";
            this.BtnConfirm.Size = new System.Drawing.Size(177, 64);
            this.BtnConfirm.TabIndex = 5;
            this.BtnConfirm.Text = "Confirm";
            this.BtnConfirm.UseVisualStyleBackColor = false;
            this.BtnConfirm.Visible = false;
            // 
            // BtnCancel
            // 
            this.BtnCancel.BackColor = System.Drawing.Color.Gold;
            this.BtnCancel.Location = new System.Drawing.Point(28, 387);
            this.BtnCancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(177, 64);
            this.BtnCancel.TabIndex = 6;
            this.BtnCancel.Text = "Cancel";
            this.BtnCancel.UseVisualStyleBackColor = false;
            this.BtnCancel.Visible = false;
            // 
            // Preferences
            // 
            this.AcceptButton = this.BtnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 474);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnConfirm);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.GbLanguage);
            this.Controls.Add(this.GbLeague);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "Preferences";
            this.Padding = new System.Windows.Forms.Padding(14, 15, 14, 15);
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Preferences";
            this.GbLeague.ResumeLayout(false);
            this.RbContainer.ResumeLayout(false);
            this.RbContainer.PerformLayout();
            this.GbLanguage.ResumeLayout(false);
            this.GbLanguage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GbLeague;
        private System.Windows.Forms.FlowLayoutPanel RbContainer;
        private System.Windows.Forms.RadioButton RbMenLeague;
        private System.Windows.Forms.RadioButton RbWomenLeague;
        private System.Windows.Forms.Label LbLanguageTitle;
        private System.Windows.Forms.ComboBox CbLanguage;
        private System.Windows.Forms.GroupBox GbLanguage;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Button BtnConfirm;
        private System.Windows.Forms.Button BtnCancel;
    }
}