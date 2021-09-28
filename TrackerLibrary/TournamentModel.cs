using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public class TournamentModel
    {   /// <summary>
        /// Represents the name of the tournament
        /// </summary>
        public string TournamentName { get; set; }
        public decimal EntryFee { get; set; }

        /// <summary>
        /// Represents all the teams in the tournament as a list
        /// </summary>
        public List<TeamModel> EnteredTeams { get; set; } = new List<TeamModel>();

        /// <summary>
        /// Represents all the prizes as a list
        /// </summary>
        public List<PrizeModel> Prizes { get; set; } = new List<PrizeModel>();

        /// <summary>
        /// Represents all the matchups as a list from a list of matchups
        /// </summary>
        public List<List<MatchupModel>> Rounds { get; set; } = new List<List<MatchupModel>>();
    }
}
