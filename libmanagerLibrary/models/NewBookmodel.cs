using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using libmanagerLibrary.DataAccess.Texthelpers;

namespace libmanagerLibrary.models
{
    /// <summary>
    /// book details
    /// </summary>
    public class NewBookmodel
    {
        public int Id { get; set; }
        public string? AuthorName { get; set; }
        public string? Noofpages { get; set; }
        public string? Category { get; set; }
        public string? Bookname { get; set; }
        
        //public DateTime created = System.DateTime.Now;
        
    }
}
