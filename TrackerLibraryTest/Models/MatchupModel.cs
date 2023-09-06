using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models
{
    public class MatchupModel
    {
        /// <summary>
        /// List of matchups entries
        /// </summary>
        public List<MatchupEntryModel> Entries { get; set; } = new List<MatchupEntryModel>();
        /// <summary>
        /// Winning team of the match
        /// </summary>
        public TeamModel Winner { get; set; }
        /// <summary>
        /// Round number of the match
        /// </summary>
        public int MatchupRound { get; set; }
    }
}
