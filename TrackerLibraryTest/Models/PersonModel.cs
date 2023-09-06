using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models
{
    public class PersonModel
    {
        /// <summary>
        /// Person first name
        /// </summary>
        public string FirstName { get; set; }
        /// <summary>
        /// Person Last name
        /// </summary>
        public string LastName { get; set; }
        /// <summary>
        /// Person email adress
        /// </summary>

        public string EmailAdress { get; set; }
        /// <summary>
        /// Person CellPhoneNumber
        /// </summary>
        public string CellphoneNumber { get; set; }
        /// <summary>
        /// Unique Id of the person object
        /// </summary>
        public int Id { get; set; }

        public string FullName 
        { 
            get 
            {
                return $"{FirstName} {LastName}";
            }
        }
    }
}
