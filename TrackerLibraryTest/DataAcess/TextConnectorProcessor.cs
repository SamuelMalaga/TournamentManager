using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.Models;

namespace TrackerLibrary.DataAcess.TextHelpers
{
    public static class TextConnectorProcessor
    {
        /// <summary>
        /// Get file fullpath
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns></returns>
        public static string FullFilePath(this string fileName) 
        {

            return $"{ConfigurationManager.AppSettings["filePath"]}\\{fileName}";
        }

        /// <summary>
        /// Load the file data into a list
        /// </summary>
        /// <param name="file"></param>
        /// <returns>List<string></returns>
        public static List<string> LoadFile(this string file) 
        {
            if(!File.Exists(file)) 
            { 
                return new List<string> ();

            }

            return File.ReadAllLines(file).ToList();
        }
        /// <summary>
        /// Convert the LoadFile output List<string> text to List<PrizeModel>
        /// </summary>
        /// <param name="lines"></param>
        /// <returns>List<PrizeModel></returns>
        public static List<PrizeModel> ConvertToPrizeModels(this List<string> lines) 
        {
            List<PrizeModel> output = new List<PrizeModel>();

            foreach (string line in lines) 
            {
                string[] cols = line.Split(',');

                PrizeModel p = new PrizeModel();
                p.Id = int.Parse(cols[0]);
                p.PlaceNumber = int.Parse(cols[1]);
                p.PlaceName = cols[2];
                p.PrizeAmount = decimal.Parse(cols[3]);
                p.PrizePercentage = int.Parse(cols[4]);
                output.Add(p);


            }

            return output;
        }
        /// <summary>
        /// Convert the List<Prizes> to List<String> formatted with the csv seaprator
        /// </summary>
        /// <param name="models"></param>
        /// <param name="filename"></param>
        public static void SaveToPrizeFile(this List<PrizeModel> models, string filename) 
        {
            List<string> lines = new List<string>();

            foreach(PrizeModel p in models) 
            {
                lines.Add($"{p.Id},{p.PlaceNumber},{p.PlaceName},{p.PrizeAmount},{p.PrizePercentage}");
            }
            File.WriteAllLines(filename.FullFilePath(), lines);
        }


        public static List<PersonModel> ConvertToPersonModels(this List<string> lines)
        {
            List<PersonModel> output = new List<PersonModel>();

            foreach (string line in lines)
            {
                string[] cols = line.Split(',');

                PersonModel p = new PersonModel();
                p.Id = int.Parse(cols[0]);
                p.FirstName = cols[1];
                p.LastName = cols[2];
                p.EmailAdress = cols[3];
                p.CellphoneNumber = cols[4];
                output.Add(p);


            }

            return output;
        }
        /// <summary>
        /// Convert the List<PersonModel> to List<String> formatted with the csv seaprator
        /// </summary>
        /// <param name="models"></param>
        /// <param name="filename"></param>
        public static void SaveToPeopleFile(this List<PersonModel> models, string filename)
        {
            List<string> lines = new List<string>();

            foreach (PersonModel p in models)
            {
                lines.Add($"{p.Id},{p.FirstName},{p.LastName},{p.EmailAdress},{p.CellphoneNumber}");
            }
            File.WriteAllLines(filename.FullFilePath(), lines);
        }
        public static List<TeamModel> ConvertToTeamModels(this List<string> lines, string peopleFileName) 
        {
            List<TeamModel> output = new List<TeamModel>();
            List<PersonModel> people = peopleFileName.FullFilePath().LoadFile().ConvertToPersonModels();

            foreach (string line in lines) 
            {
                string[] cols = line.Split(",");

                TeamModel t = new TeamModel();   
                t.Id = int.Parse(cols[0]);
                t.TeamName = cols[1];

                string[] personIds = cols[2].Split("|");

                foreach (string id in personIds) 
                {
                    t.TeamMembers.Add(people.Where(x => x.Id == int.Parse(id)).First());
                }
            }

            return output;
        }

        public static void SaveToTeamFile(this List<TeamModel> models, string filename)
        {
            List<string> lines = new List<string>();

            foreach (TeamModel t in models)
            {
                lines.Add($"{t.Id},{t.TeamName},{ConvertPeopleListToString(t.TeamMembers)}");
            }


            File.WriteAllLines(filename.FullFilePath(), lines);
        }
        private static string ConvertPeopleListToString(List<PersonModel> people) 
        {
            string output = "";
            if (people.Count == 0) 
            {
                return "";
            }
            foreach (PersonModel p in people)
            {
                output += $"{p.Id}|";
            }
            output = output.Substring(0, output.Length -1); 

            return output;
        }
    }
}
