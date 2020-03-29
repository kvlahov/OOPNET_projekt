namespace WinForms.View.Settings
{
    partial class FavoritePlayers
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
            this.label1 = new System.Windows.Forms.Label();
            this.LbSelectedTeam = new System.Windows.Forms.Label();
            this.BtnSave = new System.Windows.Forms.Button();
            this.BtnAddFavoritePlayer = new System.Windows.Forms.Button();
            this.BtnRemoveFavoritePlayer = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.PnFavoritePlayers = new System.Windows.Forms.FlowLayoutPanel();
            this.PnAllPlayers = new System.Windows.Forms.FlowLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.LbFavoritesCount = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Selected team:";
            // 
            // LbSelectedTeam
            // 
            this.LbSelectedTeam.AutoSize = true;
            this.LbSelectedTeam.Location = new System.Drawing.Point(190, 0);
            this.LbSelectedTeam.Name = "LbSelectedTeam";
            this.LbSelectedTeam.Size = new System.Drawing.Size(184, 35);
            this.LbSelectedTeam.TabIndex = 1;
            this.LbSelectedTeam.Text = "Selected team:";
            // 
            // BtnSave
            // 
            this.BtnSave.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.BtnSave.Location = new System.Drawing.Point(379, 501);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(190, 69);
            this.BtnSave.TabIndex = 4;
            this.BtnSave.Text = "Save";
            this.BtnSave.UseVisualStyleBackColor = true;
            // 
            // BtnAddFavoritePlayer
            // 
            this.BtnAddFavoritePlayer.Location = new System.Drawing.Point(378, 116);
            this.BtnAddFavoritePlayer.Name = "BtnAddFavoritePlayer";
            this.BtnAddFavoritePlayer.Size = new System.Drawing.Size(190, 69);
            this.BtnAddFavoritePlayer.TabIndex = 5;
            this.BtnAddFavoritePlayer.Text = "<<";
            this.BtnAddFavoritePlayer.UseVisualStyleBackColor = true;
            // 
            // BtnRemoveFavoritePlayer
            // 
            this.BtnRemoveFavoritePlayer.Location = new System.Drawing.Point(377, 417);
            this.BtnRemoveFavoritePlayer.Name = "BtnRemoveFavoritePlayer";
            this.BtnRemoveFavoritePlayer.Size = new System.Drawing.Size(190, 69);
            this.BtnRemoveFavoritePlayer.TabIndex = 6;
            this.BtnRemoveFavoritePlayer.Text = ">>";
            this.BtnRemoveFavoritePlayer.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(194, 35);
            this.label2.TabIndex = 7;
            this.label2.Text = "Favorite players";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(570, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 35);
            this.label3.TabIndex = 8;
            this.label3.Text = "All players";
            // 
            // PnFavoritePlayers
            // 
            this.PnFavoritePlayers.AllowDrop = true;
            this.PnFavoritePlayers.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.PnFavoritePlayers.AutoScroll = true;
            this.PnFavoritePlayers.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.PnFavoritePlayers.Location = new System.Drawing.Point(10, 116);
            this.PnFavoritePlayers.Name = "PnFavoritePlayers";
            this.PnFavoritePlayers.Size = new System.Drawing.Size(358, 370);
            this.PnFavoritePlayers.TabIndex = 10;
            this.PnFavoritePlayers.DragDrop += new System.Windows.Forms.DragEventHandler(this.PnFavoritePlayers_DragDrop);
            this.PnFavoritePlayers.DragEnter += new System.Windows.Forms.DragEventHandler(this.PnFavoritePlayers_DragEnter);
            // 
            // PnAllPlayers
            // 
            this.PnAllPlayers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PnAllPlayers.AutoScroll = true;
            this.PnAllPlayers.Location = new System.Drawing.Point(576, 117);
            this.PnAllPlayers.Name = "PnAllPlayers";
            this.PnAllPlayers.Size = new System.Drawing.Size(635, 369);
            this.PnAllPlayers.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(417, 214);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 57);
            this.button1.TabIndex = 12;
            this.button1.Text = "+";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(417, 293);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(115, 57);
            this.button2.TabIndex = 13;
            this.button2.Text = "-";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 35);
            this.label4.TabIndex = 14;
            this.label4.Text = "Count:";
            // 
            // LbFavoritesCount
            // 
            this.LbFavoritesCount.AutoSize = true;
            this.LbFavoritesCount.Location = new System.Drawing.Point(92, 43);
            this.LbFavoritesCount.Name = "LbFavoritesCount";
            this.LbFavoritesCount.Size = new System.Drawing.Size(92, 35);
            this.LbFavoritesCount.TabIndex = 15;
            this.LbFavoritesCount.Text = "Count:";
            // 
            // FavoritePlayers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 35F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1223, 582);
            this.Controls.Add(this.LbFavoritesCount);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.PnAllPlayers);
            this.Controls.Add(this.PnFavoritePlayers);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnRemoveFavoritePlayer);
            this.Controls.Add(this.BtnAddFavoritePlayer);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.LbSelectedTeam);
            this.Controls.Add(this.label1);
            this.Name = "FavoritePlayers";
            this.Text = "FavoritePlayers";
            this.Load += new System.EventHandler(this.FavoritePlayers_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FavoritePlayers_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LbSelectedTeam;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Button BtnAddFavoritePlayer;
        private System.Windows.Forms.Button BtnRemoveFavoritePlayer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.FlowLayoutPanel PnFavoritePlayers;
        private System.Windows.Forms.FlowLayoutPanel PnAllPlayers;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label LbFavoritesCount;
    }
}