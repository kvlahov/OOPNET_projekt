using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using Utilities.Model;

namespace Utilities.Helpers
{
    public class DataHelper
    {
        public static async Task<IEnumerable<Player>> GetAllPlayersAsync(string leagueUrl, string fifaCode)
        {
            var helper = new ApiHelper(leagueUrl)
            {
                FilterByCode = true,
                CountryCode = fifaCode
            };

            var matches = await helper.GetDataList<Match>();

            var team = matches.Select(m =>
            {
                if (m.HomeTeam.Code == fifaCode)
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

        public static async Task<IEnumerable<Player>> GetStartingEleven(string leagueUrl, string fifaCode)
        {
            var helper = new ApiHelper(leagueUrl)
            {
                FilterByCode = true,
                CountryCode = fifaCode
            };

            var matches = await helper.GetDataList<Match>();

            var team = matches.Select(m =>
            {
                if (m.HomeTeam.Code == fifaCode)
                {
                    return m.HomeTeamStatistics;
                }
                else
                {
                    return m.AwayTeamStatistics;
                }
            }).First();

            return team.StartingEleven;
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

        public static async Task<Dictionary<Team, ISet<Team>>> GetMatchPairings(string leagueUrl)
        {
            var helper = new ApiHelper(leagueUrl)
            {
                Path = "matches"
            };

            //each entry represents one pairing
            var matches = await helper.GetDataList<Match>();
            var matchPairings = new Dictionary<Team, ISet<Team>>();

            matches.Select(m => new
            {
                HomeTeam = new Team { Country = m.HomeTeam.Country, FifaCode = m.HomeTeam.Code },
                AwayTeam = new Team { Country = m.AwayTeam.Country, FifaCode = m.AwayTeam.Code }
            })
            .ToList()
            .ForEach(p =>
            {
                AddToPairingsDictionary(matchPairings, p.HomeTeam, p.AwayTeam);
            });

            return matchPairings;
        }

        public static async Task<IEnumerable<Match>> GetMatches(string leagueUrl)
        {
            var helper = new ApiHelper(leagueUrl)
            {
                Path = "matches"
            };

            return await helper.GetDataList<Match>();
        }

        private static void AddToPairingsDictionary(Dictionary<Team, ISet<Team>> matchPairings, Team firstTeam, Team secondTeam)
        {
            //add first team to dictionary or update it's entry
            if (matchPairings.ContainsKey(firstTeam))
            {
                matchPairings[firstTeam].Add(secondTeam);
            }
            else
            {
                matchPairings[firstTeam] = new SortedSet<Team> { secondTeam };
            }

            //then add second
            if (matchPairings.ContainsKey(secondTeam))
            {
                matchPairings[secondTeam].Add(firstTeam);
            }
            else
            {
                matchPairings[secondTeam] = new SortedSet<Team> { firstTeam };
            }
        }

        public static async Task<Match> GetMatchInformation(string leagueUrl, Team firstTeam, Team secondTeam)
        {
            var helper = new ApiHelper(leagueUrl)
            {
                FilterByCode = true,
                CountryCode = firstTeam.FifaCode
            };

            var matches = await helper.GetDataList<Match>();

            bool isHomeTeam(Match match, Team team) => match.HomeTeamCountry == team.Country;
            bool isAwayTeam(Match match, Team team) => match.AwayTeamCountry == team.Country;

            bool matchCondition(Match m) => (isHomeTeam(m, firstTeam) && isAwayTeam(m, secondTeam))
                || (isHomeTeam(m, secondTeam) && isAwayTeam(m, firstTeam));

            return matches.FirstOrDefault(m => matchCondition(m));
        }
    }
}
