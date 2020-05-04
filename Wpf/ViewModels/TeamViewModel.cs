using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilities.Model;

namespace Wpf.ViewModels
{
    public class TeamViewModel
    {
        public string Name { get; set; }
        public string FifaCode { get; set; }
        public long MatchesPlayed { get; set; }
        public long MatchesWon { get; set; }
        public long MatchesLost { get; set; }
        public long MatchesDraw { get; set; }
        public long GoalsScored { get; set; }
        public long GoalsTaken { get; set; }
        public long GoalsDifference { get; set; }

        public TeamViewModel(TeamResult model)
        {
            Name = model.Country;
            FifaCode = model.FifaCode;

            MatchesPlayed = model.GamesPlayed;
            MatchesWon = model.Wins;
            MatchesLost = model.Losses;
            MatchesDraw = model.Draws;

            GoalsScored = model.GoalsFor;
            GoalsTaken = model.GoalsAgainst;
            GoalsDifference = model.GoalDifferential;
        }

    }
}
