using System;
using System.Collections.Generic;
using Utilities.Model;

namespace Utilities.POCO
{
    public class StartPreferences
    {
        public int LeagueId { get; set; }
        public int LanguageId { get; set; }

        public long FavoriteTeamId { get; set; }
        public string FavoriteTeamCode { get; set; }

        public List<Player> FavoritePlayers { get; set; }
    }
}
