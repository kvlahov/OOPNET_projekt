using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wpf.ViewModels
{
    public class TeamViewModel
    {
        public string Name { get; set; }
        public string FifaCode { get; set; }
        public int MatchesPlayed { get; set; }
        public int MatchesWon { get; set; }
        public int MatchesLost { get; set; }
        public int MatchesDraw { get; set; }
        public int GoalsScored { get; set; }
        public int GoalsTaken { get; set; }
        public int GoalsDifference { get; set; }

    }
}
