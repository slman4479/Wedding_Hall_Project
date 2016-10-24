using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace TEST
{
    /// <summary>
    /// Summary description for HallsWebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class HallsWebService1 : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }
        [WebMethod]
        public double sum(int n1, int n2)
        {
            return n1 + n2;
        }
        [WebMethod]
        public bool ValidateUser1(string email, string password)
        {

            Users s = new Users();
            bool isVialed = s.logInUser(email, password);
            return isVialed;
        }
        //Methoed To Add New User to Our App
        [WebMethod]
        public bool addNewUser(string Fname, string Lname, string email, string password, string mobile, int idUser)
        {
            Users s = new Users();

            bool inserted = s.addUser(Fname, Lname, email, password, mobile, idUser);

            return inserted;
        }

        [WebMethod]
        public bool DeletUserByID(String  ID_User)
        {

            Users s = new Users();
            bool sucess = s.DeletUser(ID_User);

            return sucess;
        
        }



    }
}
