using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Configuration;
using libmanagerLibrary.models;

namespace libmanagerLibrary.DataAccess.Texthelpers
{
    public static class textconnectionProcessor
    {
        //*load text file
        //*convert text into list<newusermodel>
        //find the max id
        //create a new id(id +1)
        //convert user into list<new user>
        //save the list into the textfile
        public static string Fullfilepath(this string Filename)//createnewuser
        {
            //c:data\libraryapp\usermodels
            return $"{ConfigurationManager.AppSettings["filePath"]}\\{Filename}";
        }
        public static List<string>loadfile(this string file)
        {
            if (!File.Exists(file))
            {
                return new List<string>();
            }
            return File.ReadAllLines(file).ToList();
        }



        /// <summary>
        /// user text connection processor
        /// </summary>
        /// <param name="lines"></param>
        /// <returns></returns>
        public static List<userModel> ConvertTouserModels(this List<string> lines)
        {
            List<userModel> output = new List<userModel>();
            foreach(string line in lines)
            {
                string[] cols = line.Split(',');
                userModel p = new userModel();

                p.Id = int.Parse(cols[0]);
                p.firstName = cols[1];
                p.secondName = cols[2];
                p.emailaddress = cols[3];
                p.age = int.Parse(cols[4]);
                p.Password = cols[5];
                p.created = DateTime.Parse(cols[6]);
                output.Add(p);
            }
            return output;
        }

        /// <summary>
        /// book text conection processor
        /// </summary>
        /// <param name="lines"></param>
        /// <returns></returns>
        public static List<NewBookmodel> converttobookmodel(this List<string> lines)
        {
            List<NewBookmodel> output = new List<NewBookmodel>();
            foreach (string line in lines)
            {
                string[] cols = line.Split(',');
                NewBookmodel p = new NewBookmodel();

                p.Id = int.Parse(cols[0]);
                p.AuthorName = cols[1];
                p.Noofpages = cols[2];
                p.Category = cols[3];
                p.Bookname = cols[4];
                //p.created = DateTime.Parse(cols[5]);
                
                output.Add(p);
            }
            return output;
        }


        public static void SaveusermodelFiles(this List<userModel> models, string filename)
        {
            List<string> lines = new List<string>();
            foreach(userModel p in models)
            {
                lines.Add($"{p.Id},{p.firstName},{p.secondName}," +
                    $"{p.emailaddress},{p.age},{p.Password},{p.created}");
            }
            File.WriteAllLines(filename.Fullfilepath(), lines);
        }

        public static void SavenewbookFiles(this List<NewBookmodel> models, string filename)
        {
            List<string> lines = new();
            foreach (NewBookmodel p in models)
            {
               
                lines.Add($"{p.Id},{p.AuthorName},{p.Noofpages},{p.Category}," +
                    $"{p.Bookname} ");
            }
            File.WriteAllLines(filename.Fullfilepath(), lines);
        }



    }
}
