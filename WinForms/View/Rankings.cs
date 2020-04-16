using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Utilities.Helpers;
using Utilities.Model;
using WinForms.Helpers;
using WinForms.ViewModels;

namespace WinForms.View
{
    public partial class Rankings : BaseForm
    {
        public List<Match> Matches { get; set; }
        public List<Player> Players { get; set; }
        public Rankings()
        {
            InitializeComponent();
        }

        private void InitPlayerStatsDataGrid()
        {
            List<PlayerStatsViewModel> playerStats = GetPlayerStatistics();

            InitPlayerPictures(playerStats);

            DgPlayerStats.DataSource = new SortableBindingList<PlayerStatsViewModel>(playerStats);
            DgPlayerStats.AutoGenerateColumns = true;
            DgPlayerStats.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            DgPlayerStats.Columns["PlayerImage"].DisplayIndex = 0;
            (DgPlayerStats.Columns["PlayerImage"] as DataGridViewImageColumn).ImageLayout = DataGridViewImageCellLayout.Zoom;

            PbLoading.Visible = false;
        }

        private void InitPlayerPictures(List<PlayerStatsViewModel> playerStats)
        {
            var images = FileHelper.GetAllImagesFromPath(FileHelper.GetImagesPath());
            var playerImages = images.ToDictionary(
                path => Path.GetFileNameWithoutExtension(path).Replace('_', ' '),
                path => Image.FromFile(path));

            playerStats.ForEach(p =>
            {
                if (playerImages.ContainsKey(p.FullName.ToLower()))
                {
                    p.PlayerImage = playerImages[p.FullName.ToLower()];
                }
                else
                {
                    p.PlayerImage = Properties.Resources.emptyPlayer;
                }
            });
        }

        private List<PlayerStatsViewModel> GetPlayerStatistics()
        {
            var goalFilters = new List<TypeOfEvent> { TypeOfEvent.Goal, TypeOfEvent.GoalPenalty };
            var cardFilters = new List<TypeOfEvent> { TypeOfEvent.YellowCard, TypeOfEvent.YellowCardSecond };
            var allFilters = goalFilters.Concat(cardFilters).ToList();
            var country = Properties.Settings.Default.FavoriteTeam.Country;

            //select based on condition because sometimes team is home sometimes away
            var playerStats =
            Matches
                .SelectMany(m => m.HomeTeamCountry == country ? m.HomeTeamEvents : m.AwayTeamEvents)
                .Where(m => allFilters.Contains(m.TypeOfEvent))
                .GroupBy(
                    m => m.Player,
                    (player, group) => new { Player = player, TypeOfEvents = group.Select(m => m.TypeOfEvent) })
                .Select(group => new PlayerStatsViewModel
                {
                    FullName = group.Player,
                    NoGoalsScored = group.TypeOfEvents.Count(m => goalFilters.Contains(m)),
                    NoYellowCards = group.TypeOfEvents.Count(m => cardFilters.Contains(m))
                })
                .OrderByDescending(m => m.NoGoalsScored)
                .ToList();

            //Fill with rest of players
            var playerNames = playerStats.Select(s => s.FullName);

            playerStats = playerStats.Concat(
                 Players.Where(p => !playerNames.Contains(p.Name))
                 .Select(p => new PlayerStatsViewModel
                 {
                     FullName = p.Name
                 }))
                 .ToList();
            return playerStats;
        }

        private async Task<List<Match>> GetMatchesAsync()
        {
            var settings = Properties.Settings.Default;

            var helper = new ApiHelper(settings.ApiUrl)
            {
                FilterByCode = true,
                CountryCode = settings.FavoriteTeam.FifaCode
            };

            return await helper.GetDataList<Match>();
        }

        private async void Rankings_Load(object sender, EventArgs e)
        {
            Matches = await GetMatchesAsync();

            var stats = Matches.First().HomeTeamStatistics;
            Players = stats.StartingEleven.Union(stats.Substitutes).ToList();

            InitPlayerStatsDataGrid();

            InitMatchStatsDataGrid();

        }

        private void InitMatchStatsDataGrid()
        {
            var matchesVm = Matches.Select(m => new MatchStatsViewModel
            {
                Location = $"{m.Venue} - {m.Location}",
                NumberOfVisitors = m.Attendance,
                HomeTeam = $"{m.HomeTeamCountry} ({m.HomeTeam.Code})",
                AwayTeam = $"{m.AwayTeamCountry} ({m.AwayTeam.Code})"
            }).ToList();

            DgMatchesStats.DataSource = new SortableBindingList<MatchStatsViewModel>(matchesVm);
            DgMatchesStats.AutoGenerateColumns = true;
            DgMatchesStats.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            PbLoadingMatches.Visible = false;
        }

        private void BtnPrintPlayerStats_Click(object sender, EventArgs e)
        {
            bitmapToPrint = GetDataGridViewBitmap(DgPlayerStats);
            PrintPreviewDialog.ShowDialog();
        }

        private Bitmap bitmapToPrint;
        private void BtnPrintMatchStats_Click(object sender, EventArgs e)
        {
            bitmapToPrint = GetDataGridViewBitmap(DgMatchesStats);
            PrintPreviewDialog.ShowDialog();
        }

        private Bitmap GetDataGridViewBitmap(DataGridView dataGridView)
        {
            var oldHeight = dataGridView.Height;
            dataGridView.Dock = DockStyle.None;

            dataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            dataGridView.Rows.Cast<DataGridViewRow>().ToList().ForEach(r => r.Height = 45);

            dataGridView.Height = dataGridView.RowCount * dataGridView.RowTemplate.Height * 2;

            var bmp = new Bitmap(dataGridView.Width, dataGridView.Height);
            dataGridView.DrawToBitmap(bmp, new Rectangle(0, 0, dataGridView.Width, dataGridView.Height));
            dataGridView.Height = oldHeight;
            dataGridView.Dock = DockStyle.Fill;
            dataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            return bmp;
        }

        private void PrintDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bitmapToPrint, 0, 0);
        }
    }
}
