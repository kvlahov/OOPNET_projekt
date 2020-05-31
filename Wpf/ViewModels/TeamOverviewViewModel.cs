using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilities.Model;

namespace Wpf.ViewModels
{
    public class TeamOverviewViewModel : ViewModelBase
    {
        public ObservableCollection<Team> AllTeams { get; set; }
        public ObservableCollection<Team> OpposingTeams { get; set; }
        public Dictionary<Team, ISet<Team>> TeamMatches { get; set; }

        private Team _selectedFavoriteTeam;
        public Team SelectedFavoriteTeam
        {
            get { return _selectedFavoriteTeam; }
            set
            {
                var isNewValueValid = AllTeams.FirstOrDefault(t => t.FifaCode == value.FifaCode) != null;
                var newValue = isNewValueValid ? value : AllTeams.First();

                FillOpposingTeams(newValue);
                SetProperty(ref _selectedFavoriteTeam, newValue);

            }
        }

        private bool _dataLoaded = false;
        public bool IsDataLoaded
        {
            get { return _dataLoaded; }
            set
            {
                SetProperty(ref _dataLoaded, value);
            }
        }

        private void FillOpposingTeams(Team selectedTeam)
        {
            OpposingTeams.Clear();

            TeamMatches[selectedTeam].ToList().ForEach(t => OpposingTeams.Add(t));

            SelectedOpposingTeamIndex = 0;
        }

        private int _selectedFavoriteTeamIndex;

        public int SelectedFavoriteTeamIndex
        {
            get { return _selectedFavoriteTeamIndex; }
            set { SetProperty(ref _selectedFavoriteTeamIndex, value); }
        }


        private Team _selectedOpposingTeam;
        public Team SelectedOpposingTeam
        {
            get { return _selectedOpposingTeam; }
            set { SetProperty(ref _selectedOpposingTeam, value); }
        }

        private int _selectedOpposingTeamIndex;
        public int SelectedOpposingTeamIndex
        {
            get { return _selectedOpposingTeamIndex; }
            set { SetProperty(ref _selectedOpposingTeamIndex, value); }
        }

        public TeamOverviewViewModel()
        {
            AllTeams = new ObservableCollection<Team>();
            OpposingTeams = new ObservableCollection<Team>();
            TeamMatches = new Dictionary<Team, ISet<Team>>();
        }
    }
}
