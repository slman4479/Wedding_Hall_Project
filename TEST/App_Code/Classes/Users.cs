using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TEST
{


    public class Users
    {


        public string id;
        public string Fname;
        public string Lname;
        public string email;
        public string mobile;
        public string password;
        public string city;
        public string Dis;

        public Users()
        {



        }
        public void getUserData(int ID)
        {





        }
        //هنا ترجع لي boolean لو ابي ارجع الجدول او الكائن
        public bool ValidateUser1(string ID_Email, string pass)
        {
            bool isVialed = false;

            dynamic UDA = new DataSet1TableAdapters.USERTableAdapter();
            DataSet1.USERDataTable UTable = default(DataSet1.USERDataTable);
            DataSet1.USERRow URow = default(DataSet1.USERRow);
            //هنا المتغير بترج انتجر لو مثلاصف ايش المتغير وبعدين ولمن و 
            int num = UDA.Check_User1(ID_Email, pass);

            // UTable = UDA.Check_User1(ID_Email, pass);
            // if (UTable.Rows.Count > 0)
            // URow == UTable.Rows(0);
            //  if (URow.EMAIL == ID_Email && URow .PASSWORD == pass ) {
            if (num == 1)
            {
                isVialed = true;
            }
            else
            {
                isVialed = false;
            }
            return isVialed;
        }
        //Methoed To Add new User to App
        public bool addUser(string Fname, string Lname, string email, string password, string mobile, int idUser)
        {
            bool inserted = false;

            dynamic UDA = new DataSet1TableAdapters.USERTableAdapter();
            try
            {
                UDA.InsertNewUser(Fname, Lname, email, password, mobile, idUser);

                inserted = true;
            }
            catch (Exception ex)
            {
                inserted = false;
                System.Diagnostics.Debug.WriteLine("addUser failed");
            }

            return inserted;
        }

        //Mthoed to delet User By Email from DB
        public bool DeletUser(string ID_Email)
        {

            bool sucess = false;
            dynamic UDA = new DataSet1TableAdapters.USERTableAdapter();
            try
            {
                UDA.DeleteUserByEmail(ID_Email);

                sucess = true;
            }
            catch (Exception ex)
            {

                sucess = false;
                System.Diagnostics.Debug.WriteLine("DeletUser failed");
            }


            return sucess;
        }

        public Boolean logInUser(String Eamil, String password)
        {

            bool isVialed = false;

            dynamic UDA = new DataSet1TableAdapters.USERTableAdapter();
            DataSet1.USERDataTable UTable = default(DataSet1.USERDataTable);
            DataSet1.USERRow URow = default(DataSet1.USERRow);
            UTable = UDA.GetDataByEmail(Eamil);
            if (UTable.Rows.Count > 0)
            {
                for (int i = 0; i < UTable.Rows.Count; i++)
                {


                    if (URow == UTable.Rows[0]["Password"])
                    {
                        System.Diagnostics.Debug.WriteLine("come hare" + UTable.Rows.Count);
                        if (URow.EMAIL == Eamil && URow.PASSWORD == password)
                        {
                            isVialed = true;
                        }
                        //
                        else
                        {
                            isVialed = false;
                        }
                    }
                }
            }
            return isVialed;

        }
        public Boolean AddNewUser(String Email, String Fname, String Lname, String mobile, int idUser)
        {
            bool sucess = false;

            return sucess;
        }
        public Boolean ValidateUser(String Email, String password)
        {
            bool sucess = false;

            return sucess;
        }
        public Boolean RestPassword(String email, String mobile, String newPassword)
        {
            bool sucess = false;

            return sucess;
        }
        public void searchHall()
        {
            bool sucess = false;


        }
        public void makeBooking()
        {
            bool sucess = false;


        }

    }


}


