namespace WinForms.View
{
    partial class UploadPictures
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
            this.BtnUpload = new System.Windows.Forms.Button();
            this.BtnSave = new System.Windows.Forms.Button();
            this.PbPlayer = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CbPlayers = new System.Windows.Forms.ComboBox();
            this.BtnImageLeft = new System.Windows.Forms.Button();
            this.BtnImageRight = new System.Windows.Forms.Button();
            this.BtnTagPlayer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PbPlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnUpload
            // 
            this.BtnUpload.Location = new System.Drawing.Point(16, 17);
            this.BtnUpload.Margin = new System.Windows.Forms.Padding(4);
            this.BtnUpload.Name = "BtnUpload";
            this.BtnUpload.Size = new System.Drawing.Size(235, 90);
            this.BtnUpload.TabIndex = 0;
            this.BtnUpload.Text = "Upload images";
            this.BtnUpload.UseVisualStyleBackColor = true;
            this.BtnUpload.Click += new System.EventHandler(this.BtnUpload_Click);
            // 
            // BtnSave
            // 
            this.BtnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnSave.Location = new System.Drawing.Point(16, 608);
            this.BtnSave.Margin = new System.Windows.Forms.Padding(4);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(235, 90);
            this.BtnSave.TabIndex = 1;
            this.BtnSave.Text = "Save Changes";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // PbPlayer
            // 
            this.PbPlayer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PbPlayer.Location = new System.Drawing.Point(276, 17);
            this.PbPlayer.Margin = new System.Windows.Forms.Padding(4);
            this.PbPlayer.Name = "PbPlayer";
            this.PbPlayer.Size = new System.Drawing.Size(712, 681);
            this.PbPlayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PbPlayer.TabIndex = 2;
            this.PbPlayer.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 169);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "Who\'s this?";
            // 
            // CbPlayers
            // 
            this.CbPlayers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbPlayers.FormattingEnabled = true;
            this.CbPlayers.Location = new System.Drawing.Point(21, 201);
            this.CbPlayers.Name = "CbPlayers";
            this.CbPlayers.Size = new System.Drawing.Size(230, 37);
            this.CbPlayers.TabIndex = 4;
            this.CbPlayers.SelectedIndexChanged += new System.EventHandler(this.CbPlayers_SelectedIndexChanged);
            // 
            // BtnImageLeft
            // 
            this.BtnImageLeft.Location = new System.Drawing.Point(67, 328);
            this.BtnImageLeft.Name = "BtnImageLeft";
            this.BtnImageLeft.Size = new System.Drawing.Size(63, 57);
            this.BtnImageLeft.TabIndex = 5;
            this.BtnImageLeft.Text = "<";
            this.BtnImageLeft.UseVisualStyleBackColor = true;
            this.BtnImageLeft.Click += new System.EventHandler(this.BtnImageLeft_Click);
            // 
            // BtnImageRight
            // 
            this.BtnImageRight.Location = new System.Drawing.Point(136, 328);
            this.BtnImageRight.Name = "BtnImageRight";
            this.BtnImageRight.Size = new System.Drawing.Size(63, 57);
            this.BtnImageRight.TabIndex = 6;
            this.BtnImageRight.Text = ">";
            this.BtnImageRight.UseVisualStyleBackColor = true;
            this.BtnImageRight.Click += new System.EventHandler(this.BtnImageRight_Click);
            // 
            // BtnTagPlayer
            // 
            this.BtnTagPlayer.Location = new System.Drawing.Point(54, 259);
            this.BtnTagPlayer.Name = "BtnTagPlayer";
            this.BtnTagPlayer.Size = new System.Drawing.Size(161, 43);
            this.BtnTagPlayer.TabIndex = 7;
            this.BtnTagPlayer.Text = "Tag player";
            this.BtnTagPlayer.UseVisualStyleBackColor = true;
            this.BtnTagPlayer.Click += new System.EventHandler(this.BtnTagPlayer_Click);
            // 
            // UploadPictures
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 715);
            this.Controls.Add(this.BtnTagPlayer);
            this.Controls.Add(this.BtnImageRight);
            this.Controls.Add(this.BtnImageLeft);
            this.Controls.Add(this.CbPlayers);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PbPlayer);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.BtnUpload);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UploadPictures";
            this.Text = "Upload Pictures";
            ((System.ComponentModel.ISupportInitialize)(this.PbPlayer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnUpload;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.PictureBox PbPlayer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CbPlayers;
        private System.Windows.Forms.Button BtnImageLeft;
        private System.Windows.Forms.Button BtnImageRight;
        private System.Windows.Forms.Button BtnTagPlayer;
    }
}