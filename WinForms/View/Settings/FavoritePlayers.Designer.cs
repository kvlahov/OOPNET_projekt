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
            this.label4 = new System.Windows.Forms.Label();
            this.LbFavoritesCount = new System.Windows.Forms.Label();
            this.PnFavoritePlayers = new WinForms.View.UserControls.PlayerListControl();
            this.PnAllPlayers = new WinForms.View.UserControls.PlayerListControl();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Selected team:";
            // 
            // LbSelectedTeam
            // 
            this.LbSelectedTeam.AutoSize = true;
            this.LbSelectedTeam.Location = new System.Drawing.Point(173, 10);
            this.LbSelectedTeam.Name = "LbSelectedTeam";
            this.LbSelectedTeam.Size = new System.Drawing.Size(159, 29);
            this.LbSelectedTeam.TabIndex = 1;
            this.LbSelectedTeam.Text = "Selected team:";
            // 
            // BtnSave
            // 
            this.BtnSave.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.BtnSave.Location = new System.Drawing.Point(560, 448);
            this.BtnSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(163, 57);
            this.BtnSave.TabIndex = 4;
            this.BtnSave.Text = "Save";
            this.BtnSave.UseVisualStyleBackColor = true;
            // 
            // BtnAddFavoritePlayer
            // 
            this.BtnAddFavoritePlayer.Location = new System.Drawing.Point(560, 98);
            this.BtnAddFavoritePlayer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnAddFavoritePlayer.Name = "BtnAddFavoritePlayer";
            this.BtnAddFavoritePlayer.Size = new System.Drawing.Size(163, 57);
            this.BtnAddFavoritePlayer.TabIndex = 5;
            this.BtnAddFavoritePlayer.Text = "<<";
            this.BtnAddFavoritePlayer.UseVisualStyleBackColor = true;
            this.BtnAddFavoritePlayer.Click += new System.EventHandler(this.BtnAddFavoritePlayer_Click);
            // 
            // BtnRemoveFavoritePlayer
            // 
            this.BtnRemoveFavoritePlayer.Location = new System.Drawing.Point(560, 364);
            this.BtnRemoveFavoritePlayer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnRemoveFavoritePlayer.Name = "BtnRemoveFavoritePlayer";
            this.BtnRemoveFavoritePlayer.Size = new System.Drawing.Size(163, 57);
            this.BtnRemoveFavoritePlayer.TabIndex = 6;
            this.BtnRemoveFavoritePlayer.Text = ">>";
            this.BtnRemoveFavoritePlayer.UseVisualStyleBackColor = true;
            this.BtnRemoveFavoritePlayer.Click += new System.EventHandler(this.BtnRemoveFavoritePlayer_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 29);
            this.label2.TabIndex = 7;
            this.label2.Text = "Favorite players";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(726, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 29);
            this.label3.TabIndex = 8;
            this.label3.Text = "All players";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(202, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 29);
            this.label4.TabIndex = 14;
            this.label4.Text = "Count:";
            // 
            // LbFavoritesCount
            // 
            this.LbFavoritesCount.AutoSize = true;
            this.LbFavoritesCount.Location = new System.Drawing.Point(271, 65);
            this.LbFavoritesCount.Name = "LbFavoritesCount";
            this.LbFavoritesCount.Size = new System.Drawing.Size(79, 29);
            this.LbFavoritesCount.TabIndex = 15;
            this.LbFavoritesCount.Text = "Count:";
            // 
            // PnFavoritePlayers
            // 
            this.PnFavoritePlayers.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.PnFavoritePlayers.AutoSize = true;
            this.PnFavoritePlayers.ItemCount = 0;
            this.PnFavoritePlayers.Location = new System.Drawing.Point(13, 98);
            this.PnFavoritePlayers.Margin = new System.Windows.Forms.Padding(4);
            this.PnFavoritePlayers.Name = "PnFavoritePlayers";
            this.PnFavoritePlayers.Size = new System.Drawing.Size(540, 323);
            this.PnFavoritePlayers.TabIndex = 16;
            // 
            // PbAllPlayers
            // 
            this.PnAllPlayers.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.PnAllPlayers.AutoSize = true;
            this.PnAllPlayers.ItemCount = 0;
            this.PnAllPlayers.Location = new System.Drawing.Point(731, 98);
            this.PnAllPlayers.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.PnAllPlayers.Name = "PbAllPlayers";
            this.PnAllPlayers.Size = new System.Drawing.Size(541, 323);
            this.PnAllPlayers.TabIndex = 17;
            // 
            // FavoritePlayers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 517);
            this.Controls.Add(this.PnAllPlayers);
            this.Controls.Add(this.PnFavoritePlayers);
            this.Controls.Add(this.LbFavoritesCount);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnRemoveFavoritePlayer);
            this.Controls.Add(this.BtnAddFavoritePlayer);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.LbSelectedTeam);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FavoritePlayers";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Text = "FavoritePlayers";
            this.Load += new System.EventHandler(this.FavoritePlayers_Load);
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
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label LbFavoritesCount;
        private UserControls.PlayerListControl PnFavoritePlayers;
        private UserControls.PlayerListControl PnAllPlayers;
    }
}