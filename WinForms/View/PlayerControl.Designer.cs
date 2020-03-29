namespace WinForms.View
{
    partial class PlayerControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.PbImage = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.LbPosition = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.LbNumber = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LbName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LbIsCaptain = new System.Windows.Forms.Label();
            this.LbIsFavoritePlayer = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PbImage)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PbImage
            // 
            this.PbImage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.PbImage.Image = global::WinForms.Properties.Resources.emptyPlayer;
            this.PbImage.InitialImage = global::WinForms.Properties.Resources.emptyPlayer;
            this.PbImage.Location = new System.Drawing.Point(13, 42);
            this.PbImage.Name = "PbImage";
            this.PbImage.Size = new System.Drawing.Size(97, 147);
            this.PbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PbImage.TabIndex = 0;
            this.PbImage.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.2891F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.7109F));
            this.tableLayoutPanel1.Controls.Add(this.LbPosition, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.LbNumber, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.LbName, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.LbIsCaptain, 1, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(116, 42);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.57143F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.42857F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(188, 147);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // LbPosition
            // 
            this.LbPosition.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.LbPosition.AutoSize = true;
            this.LbPosition.Location = new System.Drawing.Point(95, 76);
            this.LbPosition.Name = "LbPosition";
            this.LbPosition.Size = new System.Drawing.Size(58, 21);
            this.LbPosition.TabIndex = 5;
            this.LbPosition.Text = "label6";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(8, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 21);
            this.label5.TabIndex = 4;
            this.label5.Text = "Position";
            // 
            // LbNumber
            // 
            this.LbNumber.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.LbNumber.AutoSize = true;
            this.LbNumber.Location = new System.Drawing.Point(95, 39);
            this.LbNumber.Name = "LbNumber";
            this.LbNumber.Size = new System.Drawing.Size(58, 21);
            this.LbNumber.TabIndex = 3;
            this.LbNumber.Text = "label4";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Number";
            // 
            // LbName
            // 
            this.LbName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.LbName.AutoSize = true;
            this.LbName.Location = new System.Drawing.Point(95, 6);
            this.LbName.Name = "LbName";
            this.LbName.Size = new System.Drawing.Size(58, 21);
            this.LbName.TabIndex = 1;
            this.LbName.Text = "label2";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // LbIsCaptain
            // 
            this.LbIsCaptain.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.LbIsCaptain.AutoSize = true;
            this.LbIsCaptain.Location = new System.Drawing.Point(95, 116);
            this.LbIsCaptain.Name = "LbIsCaptain";
            this.LbIsCaptain.Size = new System.Drawing.Size(72, 21);
            this.LbIsCaptain.TabIndex = 6;
            this.LbIsCaptain.Text = "Captain";
            // 
            // LbIsFavoritePlayer
            // 
            this.LbIsFavoritePlayer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LbIsFavoritePlayer.AutoSize = true;
            this.LbIsFavoritePlayer.Location = new System.Drawing.Point(162, 10);
            this.LbIsFavoritePlayer.Name = "LbIsFavoritePlayer";
            this.LbIsFavoritePlayer.Size = new System.Drawing.Size(141, 21);
            this.LbIsFavoritePlayer.TabIndex = 7;
            this.LbIsFavoritePlayer.Text = "Favorite player *";
            // 
            // PlayerControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.LbIsFavoritePlayer);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.PbImage);
            this.Font = new System.Drawing.Font("Arial", 9F);
            this.Name = "PlayerControl";
            this.Size = new System.Drawing.Size(326, 209);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PlayerControl_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.PbImage)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PbImage;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label LbPosition;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label LbNumber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LbName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LbIsCaptain;
        private System.Windows.Forms.Label LbIsFavoritePlayer;
    }
}
