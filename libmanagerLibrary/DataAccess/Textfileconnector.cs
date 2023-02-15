using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using libmanagerLibrary.models;
using libmanagerLibrary.DataAccess.Texthelpers;

namespace libmanagerLibrary.DataAccess
{
    internal class Textfileconnector : Idataconnector
    {
        private const string UserFiles = "Usermodel.csv";
        private const string newBookFiles = "Newbookmodel.csv";

        public  userModel createnewuser (userModel model)
        {
            List<userModel> newuser= UserFiles.Fullfilepath().loadfile().ConvertTouserModels();

            int currentId = 1;
            if(newuser.Count > 0)
            {
                currentId = newuser.OrderByDescending(x => x.Id).First().Id+ 1;
            }
            model.Id = currentId;
            newuser.Add(model); 
            newuser.SaveusermodelFiles(UserFiles);
            return model;
        }
        public NewBookmodel createnewbook(NewBookmodel model)
        {
            List<NewBookmodel> Newbooks = newBookFiles.Fullfilepath().loadfile().converttobookmodel();

            int currentId = 1;
            if (Newbooks.Count > 0)
            {
                currentId = Newbooks.OrderByDescending(x => x.Id).First().Id + 1;
            }
            model.Id = currentId;
            Newbooks.Add(model);
            Newbooks.SavenewbookFiles(newBookFiles);
            return  model;
        }

        public  List<userModel> getusers_all()
        {
            return UserFiles.Fullfilepath().loadfile().ConvertTouserModels();
        }
       

        List<NewBookmodel> Idataconnector.getbooks_all()
        {
            return newBookFiles.Fullfilepath().loadfile().converttobookmodel();
        }
    }
}
