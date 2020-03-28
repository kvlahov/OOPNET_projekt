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
            this.LbFavoritePlayers = new System.Windows.Forms.ListBox();
            this.LbAllPlayers = new System.Windows.Forms.ListBox();
            this.BtnSave = new System.Windows.Forms.Button();
            this.BtnAddFavoritePlayer = new System.Windows.Forms.Button();
            this.BtnRemoveFavoritePlayer = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
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
            // LbFavoritePlayers
            // 
            this.LbFavoritePlayers.FormattingEnabled = true;
            this.LbFavoritePlayers.ItemHeight = 35;
            this.LbFavoritePlayers.Location = new System.Drawing.Point(30, 93);
            this.LbFavoritePlayers.Name = "LbFavoritePlayers";
            this.LbFavoritePlayers.Size = new System.Drawing.Size(344, 319);
            this.LbFavoritePlayers.TabIndex = 2;
            // 
            // LbAllPlayers
            // 
            this.LbAllPlayers.FormattingEnabled = true;
            this.LbAllPlayers.ItemHeight = 35;
            this.LbAllPlayers.Location = new System.Drawing.Point(578, 93);
            this.LbAllPlayers.Name = "LbAllPlayers";
            this.LbAllPlayers.Size = new System.Drawing.Size(344, 319);
            this.LbAllPlayers.TabIndex = 3;
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(379, 457);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(190, 69);
            this.BtnSave.TabIndex = 4;
            this.BtnSave.Text = "Save";
            this.BtnSave.UseVisualStyleBackColor = true;
            // 
            // BtnAddFavoritePlayer
            // 
            this.BtnAddFavoritePlayer.Location = new System.Drawing.Point(380, 93);
            this.BtnAddFavoritePlayer.Name = "BtnAddFavoritePlayer";
            this.BtnAddFavoritePlayer.Size = new System.Drawing.Size(190, 69);
            this.BtnAddFavoritePlayer.TabIndex = 5;
            this.BtnAddFavoritePlayer.Text = "<<";
            this.BtnAddFavoritePlayer.UseVisualStyleBackColor = true;
            // 
            // BtnRemoveFavoritePlayer
            // 
            this.BtnRemoveFavoritePlayer.Location = new System.Drawing.Point(379, 343);
            this.BtnRemoveFavoritePlayer.Name = "BtnRemoveFavoritePlayer";
            this.BtnRemoveFavoritePlayer.Size = new System.Drawing.Size(190, 69);
            this.BtnRemoveFavoritePlayer.TabIndex = 6;
            this.BtnRemoveFavoritePlayer.Text = ">>";
            this.BtnRemoveFavoritePlayer.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(194, 35);
            this.label2.TabIndex = 7;
            this.label2.Text = "Favorite players";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(572, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 35);
            this.label3.TabIndex = 8;
            this.label3.Text = "All players";
            // 
            // FavoritePlayers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 35F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(943, 571);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnRemoveFavoritePlayer);
            this.Controls.Add(this.BtnAddFavoritePlayer);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.LbAllPlayers);
            this.Controls.Add(this.LbFavoritePlayers);
            this.Controls.Add(this.LbSelectedTeam);
            this.Controls.Add(this.label1);
            this.Name = "FavoritePlayers";
            this.Text = "FavoritePlayers";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LbSelectedTeam;
        private System.Windows.Forms.ListBox LbFavoritePlayers;
        private System.Windows.Forms.ListBox LbAllPlayers;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Button BtnAddFavoritePlayer;
        private System.Windows.Forms.Button BtnRemoveFavoritePlayer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}