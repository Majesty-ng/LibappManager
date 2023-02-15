using libmanagerLibrary.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using libmanagerLibrary.models;

namespace libmanagerLibrary
{
    public static class GlobalConfig
    {
        public static Idataconnector Connection { get; private set; } 

        public static void Initializeconnections(databaseType db)
        {
            //switch (db)
            //{
            //    case databaseType.sql:
            //        break;
            //    case databaseType.TextFile:
            //        break;
            //    default:
            //        break;
            //}
            if (db == databaseType.TextFile)
            {
                //TODO - add in the text file connection
                Textfileconnector Textfile = new Textfileconnector();
                Connection = Textfile;
            }
            //else if (db == databaseType.sql)
            //{
            //    //TODO - learn and create a SQL connection and database
            //    Sqlfileconnector sql = new Sqlfileconnector();
            //    Connection = sql;
            //}
            
        }
    }
}
