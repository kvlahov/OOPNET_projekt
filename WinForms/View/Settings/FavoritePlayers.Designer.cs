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
            this.LbSelectedTeamTitle = new System.Windows.Forms.Label();
            this.LbSelectedTeam = new System.Windows.Forms.Label();
            this.BtnSave = new System.Windows.Forms.Button();
            this.BtnAddFavoritePlayer = new System.Windows.Forms.Button();
            this.BtnRemoveFavoritePlayer = new System.Windows.Forms.Button();
            this.LbFavoritePlayersTitle = new System.Windows.Forms.Label();
            this.LbAllPlayersTitle = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.LbFavoritesCount = new System.Windows.Forms.Label();
            this.PnFavoritePlayers = new WinForms.View.UserControls.PlayerListControl();
            this.PnAllPlayers = new WinForms.View.UserControls.PlayerListControl();
            this.SuspendLayout();
            // 
            // LbSelectedTeamTitle
            // 
            this.LbSelectedTeamTitle.AutoSize = true;
            this.LbSelectedTeamTitle.Location = new System.Drawing.Point(10, 10);
            this.LbSelectedTeamTitle.Name = "LbSelectedTeamTitle";
            this.LbSelectedTeamTitle.Size = new System.Drawing.Size(159, 29);
            this.LbSelectedTeamTitle.TabIndex = 0;
            this.LbSelectedTeamTitle.Text = "Selected team:";
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
            // LbFavoritePlayersTitle
            // 
            this.LbFavoritePlayersTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.LbFavoritePlayersTitle.AutoSize = true;
            this.LbFavoritePlayersTitle.Location = new System.Drawing.Point(6, 65);
            this.LbFavoritePlayersTitle.Name = "LbFavoritePlayersTitle";
            this.LbFavoritePlayersTitle.Size = new System.Drawing.Size(169, 29);
            this.LbFavoritePlayersTitle.TabIndex = 7;
            this.LbFavoritePlayersTitle.Text = "Favorite players";
            // 
            // LbAllPlayersTitle
            // 
            this.LbAllPlayersTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.LbAllPlayersTitle.AutoSize = true;
            this.LbAllPlayersTitle.Location = new System.Drawing.Point(726, 65);
            this.LbAllPlayersTitle.Name = "LbAllPlayersTitle";
            this.LbAllPlayersTitle.Size = new System.Drawing.Size(115, 29);
            this.LbAllPlayersTitle.TabIndex = 8;
            this.LbAllPlayersTitle.Text = "All players";
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
            this.PnFavoritePlayers.AllowDrop = true;
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
            // PnAllPlayers
            // 
            this.PnAllPlayers.AllowDrop = true;
            this.PnAllPlayers.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.PnAllPlayers.AutoSize = true;
            this.PnAllPlayers.ItemCount = 0;
            this.PnAllPlayers.Location = new System.Drawing.Point(731, 98);
            this.PnAllPlayers.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.PnAllPlayers.Name = "PnAllPlayers";
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
            this.Controls.Add(this.LbAllPlayersTitle);
            this.Controls.Add(this.LbFavoritePlayersTitle);
            this.Controls.Add(this.BtnRemoveFavoritePlayer);
            this.Controls.Add(this.BtnAddFavoritePlayer);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.LbSelectedTeam);
            this.Controls.Add(this.LbSelectedTeamTitle);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FavoritePlayers";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Text = "FavoritePlayers";
            this.Load += new System.EventHandler(this.FavoritePlayers_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LbSelectedTeamTitle;
        private System.Windows.Forms.Label LbSelectedTeam;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Button BtnAddFavoritePlayer;
        private System.Windows.Forms.Button BtnRemoveFavoritePlayer;
        private System.Windows.Forms.Label LbFavoritePlayersTitle;
        private System.Windows.Forms.Label LbAllPlayersTitle;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label LbFavoritesCount;
        private UserControls.PlayerListControl PnFavoritePlayers;
        private UserControls.PlayerListControl PnAllPlayers;
    }
}