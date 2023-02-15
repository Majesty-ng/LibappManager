using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using libmanagerLibrary.models;

namespace libmanagerLibrary.DataAccess
{
    /// <summary>
    /// the data connection
    /// </summary>
    public interface Idataconnector
    {
        userModel createnewuser(userModel model);
        NewBookmodel createnewbook(NewBookmodel model);
        List<userModel> getusers_all();
        List<NewBookmodel> getbooks_all();
    }
}
