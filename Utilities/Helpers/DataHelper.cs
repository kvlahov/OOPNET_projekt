using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilities.Model;

namespace Utilities.Helpers
{
    public class DataHelper
    {
        public static async Task<IEnumerable<Player>> GetAllPlayersAsync(ApiHelper apiHelper)
        {
            var matches = await apiHelper.GetDataList<Match>();
            var countryCode = apiHelper.CountryCode;

            var team = matches.Select(m =>
            {
                if (m.HomeTeam.Code == countryCode)
                {
                    return m.HomeTeamStatistics;
                }
                else
                {
                    return m.AwayTeamStatistics;
                }
            }).First();

            return team.StartingEleven.Union(team.Substitutes);
        }

        public static async Task<TeamResult> GetTeamResult(string leagueUrl, string fifaCode)
        {
            var helper = new ApiHelper(leagueUrl)
            {
                Path = "teams/results"
            };

            var results = await helper.GetDataList<TeamResult>();
            return results.FirstOrDefault(t => t.FifaCode == fifaCode);
        }

        public static async Task<IEnumerable<Team>> GetTeams(string leagueUrl)
        {
            var helper = new ApiHelper(leagueUrl)
            {
                Path = "teams"
            };

            return await helper.GetDataList<Team>();
        }
    }
}
