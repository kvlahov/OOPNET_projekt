using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Utilities;
using Utilities.Helpers;
using Utilities.Model;

namespace WinForms.View
{
    public partial class UploadPictures : BaseForm
    {
        private readonly Properties.Settings settings = Properties.Settings.Default;

        private int visibleImageIndex;
        private Dictionary<string, string> playersImagesPath;
        private Dictionary<string, Image> originalFilesAndImages;

        private IEnumerable<Player> allPlayers;

        public UploadPictures()
        {
            InitializeComponent();
            allPlayers = Enumerable.Empty<Player>();
        }

        private async void SetInitialStateAsync()
        {
            playersImagesPath = new Dictionary<string, string>();
            originalFilesAndImages = new Dictionary<string, Image>();
            visibleImageIndex = -1;
            //disable all buttons untill images are uploaded
            DisableControls();

            allPlayers = await DataHelper.GetAllPlayersAsync(settings.ApiUrl, settings.FavoriteTeam.FifaCode);

            CbPlayers.Items.AddRange(allPlayers.ToArray());

            SetContextMenuItems(allPlayers);
        }

        private void SetContextMenuItems(IEnumerable<Player> players)
        {
            ImageContextMenuStrip.Items.Clear();
            players.Select(p => p.Name).ToList().ForEach(p =>
            {
                ImageContextMenuStrip.Items.Add(p, null, (sender, args) => TagPlayer(p));
            });
        }

        private void BtnUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog
            {
                // image filters  
                Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp",
                Title = "Select images",
                Multiselect = true
            };

            if (fileDialog.ShowDialog() == DialogResult.OK && fileDialog.FileNames.Any())
            {
                //get all images
                originalFilesAndImages = fileDialog.FileNames.ToDictionary(file => file, file => Image.FromFile(file));

                //show first
                PbPlayer.Image = originalFilesAndImages.Values.First();

                //set shown image index to first
                visibleImageIndex = 0;
                if (originalFilesAndImages.Count > 1)
                {
                    BtnImageRight.Enabled = true;
                }

                EnableControls();
            }
        }

        private void EnableControls()
        {
            BtnSave.Enabled = true;
            CbPlayers.Enabled = true;
        }
        private void DisableControls()
        {
            BtnSave.Enabled = false;
            BtnImageLeft.Enabled = false;
            BtnImageRight.Enabled = false;
            BtnTagPlayer.Enabled = false;
            CbPlayers.Enabled = false;
        }

        private void BtnImageLeft_Click(object sender, EventArgs e)
        {
            PbPlayer.Image = originalFilesAndImages.Values.ToList()[--visibleImageIndex];

            ImageChanged();

            //if showing first image disable
            if (visibleImageIndex == 0)
            {
                BtnImageLeft.Enabled = false;
            }

            //if right button is disabled enable it
            BtnImageRight.Enabled = true;

        }

        private void BtnImageRight_Click(object sender, EventArgs e)
        {
            PbPlayer.Image = originalFilesAndImages.Values.ToList()[++visibleImageIndex];

            ImageChanged();

            //disable if last image
            if (visibleImageIndex == originalFilesAndImages.Count - 1)
            {
                BtnImageRight.Enabled = false;
            }

            //definetly not first image so enable left
            BtnImageLeft.Enabled = true;
        }

        private void ImageChanged()
        {
            var selectedImagePath = originalFilesAndImages.Keys.ToList()[visibleImageIndex];
            if (playersImagesPath.ContainsValue(selectedImagePath))
            {
                var playerName = playersImagesPath.First(kv => kv.Value == selectedImagePath).Key;
                CbPlayers.SelectedItem = CbPlayers.Items.Cast<Player>().First(p => p.Name == playerName);
            }
            else
            {
                CbPlayers.SelectedIndex = -1;
            }
        }

        private void CbPlayers_SelectedIndexChanged(object sender, EventArgs e)
        {
            BtnTagPlayer.Enabled = true;
        }

        private void BtnTagPlayer_Click(object sender, EventArgs e)
        {
            var playerName = (CbPlayers.SelectedItem as Player)?.Name;
            TagPlayer(playerName);
        }

        private void TagPlayer(string playerName)
        {
            var imagePath = originalFilesAndImages.Keys.ToList()[visibleImageIndex];

            if (playersImagesPath.ContainsKey(playerName))
            {
                bool shouldUpdate = ShowAlert(playerName);
                if (shouldUpdate)
                {
                    playersImagesPath[playerName] = imagePath;
                }
            }
            else
            {
                playersImagesPath.Add(playerName, imagePath);
            }

            if (BtnImageRight.Enabled)
            {
                BtnImageRight.PerformClick();
            }
            else if (BtnImageLeft.Enabled)
            {
                BtnImageLeft.PerformClick();
            }

            //Set items of players not yet tagged
            SetContextMenuItems(allPlayers.Where(p => !playersImagesPath.Keys.Contains(p.Name)));
        }

        private bool ShowAlert(string playerName)
        {
            var result = MessageBox.Show($"You have already selected image for {playerName.ToTitleCase()}", "Warning", MessageBoxButtons.YesNo);
            return result == DialogResult.OK;
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            var favoriteTeamCode = settings.FavoriteTeam.FifaCode;
            var league = settings.League;

            try
            {
                playersImagesPath.ToList().ForEach(kv => FileHelper.CopyImageFromPath(kv.Value, kv.Key.ToLower().Replace(" ", "_"), league, favoriteTeamCode));
                MessageBox.Show("Succesfully saved", "Success", MessageBoxButtons.OK);
                Close();
            }
            catch (Exception ex)
            {
                var msg = "Error while saving" + Environment.NewLine;
                MessageBox.Show(msg + ex.Message, "Error", MessageBoxButtons.OK);

            }
        }

        private void UploadPictures_Load(object sender, EventArgs e)
        {
            SetInitialStateAsync();
        }
    }
}
