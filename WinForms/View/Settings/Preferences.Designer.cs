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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RbContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.RbMenLeague = new System.Windows.Forms.RadioButton();
            this.RbWomenLeague = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.CbLanguage = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BtnSave = new System.Windows.Forms.Button();
            this.BtnConfirm = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.RbContainer.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RbContainer);
            this.groupBox1.Location = new System.Drawing.Point(66, 49);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(360, 180);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Choose league";
            // 
            // RbContainer
            // 
            this.RbContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RbContainer.Controls.Add(this.RbMenLeague);
            this.RbContainer.Controls.Add(this.RbWomenLeague);
            this.RbContainer.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.RbContainer.Location = new System.Drawing.Point(10, 44);
            this.RbContainer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.RbContainer.Name = "RbContainer";
            this.RbContainer.Size = new System.Drawing.Size(334, 112);
            this.RbContainer.TabIndex = 0;
            // 
            // RbMenLeague
            // 
            this.RbMenLeague.AutoSize = true;
            this.RbMenLeague.Location = new System.Drawing.Point(4, 5);
            this.RbMenLeague.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.RbMenLeague.Name = "RbMenLeague";
            this.RbMenLeague.Size = new System.Drawing.Size(191, 39);
            this.RbMenLeague.TabIndex = 0;
            this.RbMenLeague.TabStop = true;
            this.RbMenLeague.Tag = "1";
            this.RbMenLeague.Text = "Men\'s league";
            this.RbMenLeague.UseVisualStyleBackColor = true;
            // 
            // RbWomenLeague
            // 
            this.RbWomenLeague.AutoSize = true;
            this.RbWomenLeague.Location = new System.Drawing.Point(4, 54);
            this.RbWomenLeague.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.RbWomenLeague.Name = "RbWomenLeague";
            this.RbWomenLeague.Size = new System.Drawing.Size(228, 39);
            this.RbWomenLeague.TabIndex = 1;
            this.RbWomenLeague.TabStop = true;
            this.RbWomenLeague.Tag = "2";
            this.RbWomenLeague.Text = "Women\'s league";
            this.RbWomenLeague.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 74);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 35);
            this.label1.TabIndex = 1;
            this.label1.Text = "Language";
            // 
            // CbLanguage
            // 
            this.CbLanguage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbLanguage.FormattingEnabled = true;
            this.CbLanguage.Location = new System.Drawing.Point(152, 68);
            this.CbLanguage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CbLanguage.Name = "CbLanguage";
            this.CbLanguage.Size = new System.Drawing.Size(186, 43);
            this.CbLanguage.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.CbLanguage);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(66, 265);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(360, 175);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Choose language";
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(142, 467);
            this.BtnSave.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(206, 77);
            this.BtnSave.TabIndex = 4;
            this.BtnSave.Text = "Save";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // BtnConfirm
            // 
            this.BtnConfirm.BackColor = System.Drawing.Color.LawnGreen;
            this.BtnConfirm.Location = new System.Drawing.Point(247, 467);
            this.BtnConfirm.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnConfirm.Name = "BtnConfirm";
            this.BtnConfirm.Size = new System.Drawing.Size(206, 77);
            this.BtnConfirm.TabIndex = 5;
            this.BtnConfirm.Text = "Confirm";
            this.BtnConfirm.UseVisualStyleBackColor = false;
            this.BtnConfirm.Visible = false;
            // 
            // BtnCancel
            // 
            this.BtnCancel.BackColor = System.Drawing.Color.Gold;
            this.BtnCancel.Location = new System.Drawing.Point(33, 467);
            this.BtnCancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(206, 77);
            this.BtnCancel.TabIndex = 6;
            this.BtnCancel.Text = "Cancel";
            this.BtnCancel.UseVisualStyleBackColor = false;
            this.BtnCancel.Visible = false;
            // 
            // Preferences
            // 
            this.AcceptButton = this.BtnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 35F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 572);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnConfirm);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "Preferences";
            this.Padding = new System.Windows.Forms.Padding(16, 18, 16, 18);
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Preferences";
            this.groupBox1.ResumeLayout(false);
            this.RbContainer.ResumeLayout(false);
            this.RbContainer.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.FlowLayoutPanel RbContainer;
        private System.Windows.Forms.RadioButton RbMenLeague;
        private System.Windows.Forms.RadioButton RbWomenLeague;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CbLanguage;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Button BtnConfirm;
        private System.Windows.Forms.Button BtnCancel;
    }
}