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

        private Team _selectedFavoriteTeam;
        public Team SelectedFavoriteTeam
        {
            get { return _selectedFavoriteTeam; }
            set { SetProperty(ref _selectedFavoriteTeam, value); }
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
    }
}
