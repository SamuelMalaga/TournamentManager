using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models
{
    public class TournamentModel
    {
        /// <summary>
        /// Represents the tournament name
        /// </summary>
        /// <value>string tournamentname</value>
        public string TournamentName { get; set; }
        /// <summary>
        /// Represents the tournament entry fee
        /// </summary>
        /// <value> decimal entryfee</value>
        public decimal EntryFee { get; set; }
        /// <summary>
        /// Represents the teams that entered the tournament
        /// </summary>
        /// <value>List of Teams</value>
        public List<TeamModel> EnteredTeams { get; set; } = new List<TeamModel>();
        /// <summary>
        /// Represent the prizes of the tournament
        /// </summary>
        /// <value>List of prizes</value>
        public List<PrizeModel> Prizes { get; set; } = new List<PrizeModel>();
        /// <summary>
        /// List of matchupModel lists 
        /// TODO: Refine description
        /// </summary>
        /// <value>List of lists</value>
        public List<List<MatchupModel>> Rounds { get; set; } = new List<List<MatchupModel>>();
        /// <summary>
        ///    Unique identifier for the tournament
        /// </summary>
        public int Id { get; set; }
    }
}
