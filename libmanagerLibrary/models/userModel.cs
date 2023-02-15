using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libmanagerLibrary.models
{
    /// <summary>
    /// represnts the user details 
    /// </summary>
    public  class userModel
    {

        /// <summary>
        /// the unique identifier for each of the users
        /// </summary>
        public int Id { get; set; }



        /// <summary>
        /// the first name of the saved user 
        /// </summary>
        public string? firstName { get; set; }


        /// <summary>
        /// the second and last name of the user
        /// </summary>
        public string? secondName { get; set; }

        /// <summary>
        /// user email adress for emailing and texts
        /// </summary>
        public string? emailaddress { get; set; }


        /// <summary>
        /// user password
        /// would be used to login each time when needed
        /// </summary>
        public string? Password { get; set; }

        /// <summary>
        /// user age
        /// </summary>
        public int? age { get; set; }
        public string username
        {
            get
            {
                return $"{firstName} {secondName}";
            }
        }

        public TimeSpan now { get; set; }
        public DateTime created = DateTime.Now;
        //public DateTime updated = DateTime.Today;

    }
}
