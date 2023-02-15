using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libmanagerLibrary.models
{
    public class applicationModel
    {
        //main library
        public List<NewBookmodel> books { get; set; } = new List<NewBookmodel>();
        public List<userModel> userdetails { get; set; } = new List<userModel>();
        public List<admin1DetailsModel> admin1details { get; set; } = new List<admin1DetailsModel>();
        public List<admin2DetailsModel> admin2details { get; set; } = new List<admin2DetailsModel>();
    }
    public class psuedecodefortheprogram
    {
        public string themthod(string name)
        {
            Console.WriteLine("hello user!: ");
            //TODO - work on this psuedecode

            /*
             for user log in
             collect user name
             collect user password
            if name == username and password == userpassword
                    proceed into the program
            else throw exception and try again

            proceed = true
            login into user dashboard
            if details == true
                show book details
            if borrow == true
                set borrow = borrow + 1
            if log out == true
                logout to login page
            

            for user sign in
            collect user first name
            colect user second name
            collect user email
            collect user password
            collect user age
            get and set user id
            sign in user into user dashboard
            if details == true
                show book details
            if borrow == true
                set borrow = borrow + 1
            if log out == true
                logout to login page

             */
            return name;
        }
    }
}
