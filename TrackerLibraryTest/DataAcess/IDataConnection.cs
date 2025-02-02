﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.Models;

namespace TrackerLibrary.DataAcess
{
    public interface IDataConnection
    {
        PrizeModel CreatePrize(PrizeModel model);
        PersonModel CreatePerson(PersonModel model);
        List<PersonModel> GetPerson_All();
        TeamModel CreateTeam(TeamModel model);
        List<TeamModel> GetTeams_All();
        void CreateTournament(TournamentModel model);
    }
}
