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
    }
}
