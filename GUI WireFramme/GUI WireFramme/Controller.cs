using DBapplication;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Book_Fair
{
    public class Controller
    {
        DBManager DB;
        SqlDataReader rdr;

        public Controller()
        {
            DB = new DBManager();
        }


        public DataTable get_Events_Code()
        {
            string StoredProcedureName = StoredProcedures.Show_All_Events_Code;
            return DB.ExecuteReader(StoredProcedureName, null);
        }

        public DataTable get_Events_Name()
        {
            string StoredProcedureName = StoredProcedures.Show_All_Events_Name;
            return DB.ExecuteReader(StoredProcedureName, null);
        }

        public DataTable get_Events_Location()
        {
            string StoredProcedureName = StoredProcedures.Show_All_Events_Location;
            return DB.ExecuteReader(StoredProcedureName, null);
        }


        public DataTable Check_Login_Organizer(string name)
        {
            string procedure = StoredProcedures.Check_UserName_Exist_in_Organizer;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Username", name);
            return DB.ExecuteReader(procedure, Parameters);
        }

        //public DataTable Check_Password_of_Organizer(string name)
        //{
        //    string procedure = StoredProcedures.Check_Password_of_Organizer;
        //    Dictionary<string, object> Parameters = new Dictionary<string, object>();
        //    Parameters.Add("@Username", name);
        //    return DB.ExecuteReader(procedure, Parameters);
        //}

        public DataTable Check_Login_Bookseller(string name)
        {
            string procedure = StoredProcedures.Check_UserName_Exist_in_Bookseller;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Username", name);
            return DB.ExecuteReader(procedure, Parameters);
        }

        //public DataTable Check_Password_of_Bookseller(string name)
        //{
        //    string procedure = StoredProcedures.Check_Password_of_Bookseller;
        //    Dictionary<string, object> Parameters = new Dictionary<string, object>();
        //    Parameters.Add("@Username", name);
        //    return DB.ExecuteReader(procedure, Parameters);
        //}

        public DataTable Check_Login_Media(string name)
        {
            string procedure = StoredProcedures.Check_UserName_Exist_in_Media;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Username", name);
            return DB.ExecuteReader(procedure, Parameters);
        }

        //public DataTable Check_Password_of_Media(string name)
        //{
        //    string procedure = StoredProcedures.Check_Password_of_Media;
        //    Dictionary<string, object> Parameters = new Dictionary<string, object>();
        //    Parameters.Add("@Username", name);
        //    return DB.ExecuteReader(procedure, Parameters);
        //}

        public DataTable Check_Login_Ticket_reserver(string name)
        {
            string procedure = StoredProcedures.Check_UserName_Exist_in_Ticket_reserver;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Username", name);
            return DB.ExecuteReader(procedure, Parameters);
        }

        //public DataTable Check_Password_of_Ticket_reserver(string name)
        //{
        //    string procedure = StoredProcedures.Check_Password_of_Ticket_reserver;
        //    Dictionary<string, object> Parameters = new Dictionary<string, object>();
        //    Parameters.Add("@Username", name);
        //    return DB.ExecuteReader(procedure, Parameters);
        //}

        public DataTable Check_Login_Visitors(string name)
        {
            string procedure = StoredProcedures.Check_UserName_Exist_in_Visitors;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Username", name);
            return DB.ExecuteReader(procedure, Parameters);
        }

        //public DataTable Check_Password_of_Visitors(string name)
        //{
        //    string procedure = StoredProcedures.Check_Password_of_Visitors;
        //    Dictionary<string, object> Parameters = new Dictionary<string, object>();
        //    Parameters.Add("@Username", name);
        //    return DB.ExecuteReader(procedure, Parameters);
        //}

        public DataTable Check_Login_Volunter(string name)
        {
            string procedure = StoredProcedures.Check_UserName_Exist_in_Volunter;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Username", name);
            return DB.ExecuteReader(procedure, Parameters);
        }

        //public DataTable Check_Password_of_Volunter(string name)
        //{
        //    string procedure = StoredProcedures.Check_Password_of_Volunter;
        //    Dictionary<string, object> Parameters = new Dictionary<string, object>();
        //    Parameters.Add("@Username", name);
        //    return DB.ExecuteReader(procedure, Parameters);
        //}


        public DataTable Recover_Organizer_Password(string name)
        {
            string procedure = StoredProcedures.Recover_Organizer_Password;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Username", name);
            return DB.ExecuteReader(procedure, Parameters);
        }


        public DataTable Recover_Bookseller_Password(string name)
        {
            string procedure = StoredProcedures.Recover_Bookseller_Password;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Username", name);
            return DB.ExecuteReader(procedure, Parameters);
        }


        public DataTable Recover_Media_man_Password(string name)
        {
            string procedure = StoredProcedures.Recover_Media_man_Password;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Username", name);
            return DB.ExecuteReader(procedure, Parameters);
        }


        public DataTable Recover_Ticket_Reserves_Password(string name)
        {
            string procedure = StoredProcedures.Recover_Ticket_Reserves_Password;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Username", name);
            return DB.ExecuteReader(procedure, Parameters);
        }


        public DataTable Recover_Visitor_Password(string name)
        {
            string procedure = StoredProcedures.Recover_Visitor_Password;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Username", name);
            return DB.ExecuteReader(procedure, Parameters);
        }


        public DataTable Recover_Volunters_Password(string name)
        {
            string procedure = StoredProcedures.Recover_Volunters_Password;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Username", name);
            return DB.ExecuteReader(procedure, Parameters);
        }


        public int Add_New_Organizer(string FName, string MName, string LName, int ID, long National_ID, Char GENDER, string PASSWORD, string USERNAME)
        {
            string StoredProcedureName = StoredProcedures.Add_New_Organizer;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@FirstName", FName);
            Parameters.Add("@MidName", MName);
            Parameters.Add("@LastName", LName);
            Parameters.Add("@ID", ID);
            Parameters.Add("@National_ID", National_ID);
            Parameters.Add("@GENDER", GENDER);
            Parameters.Add("@PASSWORD", PASSWORD);
            Parameters.Add("@USERNAME", USERNAME);
            return DB.ExecuteNonQuery(StoredProcedureName, Parameters);
        }

        public int Add_New_Bookseller(string FName, string MName, string LName, int ID, long National_ID, Char GENDER, string PASSWORD, string USERNAME)
        {
            string StoredProcedureName = StoredProcedures.Add_New_Bookseller;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@FirstName", FName);
            Parameters.Add("@MidName", MName);
            Parameters.Add("@LastName", LName);
            Parameters.Add("@ID", ID);
            Parameters.Add("@National_ID", National_ID);
            Parameters.Add("@GENDER", GENDER);
            Parameters.Add("@PASSWORD", PASSWORD);
            Parameters.Add("@USERNAME", USERNAME);
            return DB.ExecuteNonQuery(StoredProcedureName, Parameters);
        }

        public int Add_Book_Seller_Works_IN(char Letter, int Section_Number, int Hall_Number, int Bookseller_ID)
        {
            string StoredProcedureName = StoredProcedures.Add_Book_Seller_Works_IN;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Letter", Letter);
            Parameters.Add("@Section_Number", Section_Number);
            Parameters.Add("@Hall_Number", Hall_Number);
            Parameters.Add("@Bookseller_ID", Bookseller_ID);
            return DB.ExecuteNonQuery(StoredProcedureName, Parameters);
        }

        public int Add_Book_Seller_Shifts(string SHIFT_TIME_Start, string SHIFT_TIME_End, int Book_Seller_ID)
        {
            string StoredProcedureName = StoredProcedures.Add_Book_Seller_Shifts;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@SHIFT_TIME_Start", SHIFT_TIME_Start);
            Parameters.Add("@SHIFT_TIME_End", SHIFT_TIME_End);
            Parameters.Add("@Book_Seller_ID", Book_Seller_ID);
            return DB.ExecuteNonQuery(StoredProcedureName, Parameters);
        }

        public int Add_New_Media_man(string FName, string MName, string LName, int ID, long National_ID, Char GENDER, string Channel_Name, string PASSWORD, string USERNAME)
        {
            string StoredProcedureName = StoredProcedures.Add_New_Media_man;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@FirstName", FName);
            Parameters.Add("@MidName", MName);
            Parameters.Add("@LastName", LName);
            Parameters.Add("@ID", ID);
            Parameters.Add("@National_ID", National_ID);
            Parameters.Add("@GENDER", GENDER);
            Parameters.Add("@Channel_Name", Channel_Name);
            Parameters.Add("@PASSWORD", PASSWORD);
            Parameters.Add("@USERNAME", USERNAME);
            return DB.ExecuteNonQuery(StoredProcedureName, Parameters);
        }

        public int Add_Media_Shifts(string SHIFT_TIME_Start, string SHIFT_TIME_End, int Media_ID)
        {
            string StoredProcedureName = StoredProcedures.Add_Media_Shifts;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@SHIFT_TIME_Start", SHIFT_TIME_Start);
            Parameters.Add("@SHIFT_TIME_End", SHIFT_TIME_End);
            Parameters.Add("@Media_ID", Media_ID);
            return DB.ExecuteNonQuery(StoredProcedureName, Parameters);
        }


        public int Add_Organizer_Shifts(string SHIFT_TIME_Start, string SHIFT_TIME_End, int Organizer_ID)
        {
            string StoredProcedureName = StoredProcedures.Add_Organizer_Shifts;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@SHIFT_TIME_Start", SHIFT_TIME_Start);
            Parameters.Add("@SHIFT_TIME_End", SHIFT_TIME_End);
            Parameters.Add("@Organizer_ID", Organizer_ID);
            return DB.ExecuteNonQuery(StoredProcedureName, Parameters);
        }

        public int Add_Ticket_Reserver_Shifts(string SHIFT_TIME_Start, string SHIFT_TIME_End, int Ticket_Reserve_ID)
        {
            string StoredProcedureName = StoredProcedures.Add_Ticket_Reserver_Shifts;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@SHIFT_TIME_Start", SHIFT_TIME_Start);
            Parameters.Add("@SHIFT_TIME_End", SHIFT_TIME_End);
            Parameters.Add("@Ticket_Reserve_ID", Ticket_Reserve_ID);
            return DB.ExecuteNonQuery(StoredProcedureName, Parameters);
        }

        public int Add_Volanteer_Shifts(string SHIFT_TIME_Start, string SHIFT_TIME_End, int Volunter_ID)
        {
            string StoredProcedureName = StoredProcedures.Add_Volanteer_Shifts;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@SHIFT_TIME_Start", SHIFT_TIME_Start);
            Parameters.Add("@SHIFT_TIME_End", SHIFT_TIME_End);
            Parameters.Add("@Volunter_ID", Volunter_ID);
            return DB.ExecuteNonQuery(StoredProcedureName, Parameters);
        }

        public int Add_New_Ticket_Reserver(string FName, string MName, string LName, int ID, long National_ID, Char GENDER, string PASSWORD, string USERNAME)
        {
            string StoredProcedureName = StoredProcedures.Add_New_Ticket_Reserver;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@FirstName", FName);
            Parameters.Add("@MidName", MName);
            Parameters.Add("@LastName", LName);
            Parameters.Add("@ID", ID);
            Parameters.Add("@National_ID", National_ID);
            Parameters.Add("@GENDER", GENDER);
            Parameters.Add("@PASSWORD", PASSWORD);
            Parameters.Add("@USERNAME", USERNAME);
            return DB.ExecuteNonQuery(StoredProcedureName, Parameters);
        }
        public int Add_New_Volanteer(string FName, string MName, string LName, int ID, long National_ID, Char GENDER, string PASSWORD, string USERNAME)
        {
            string StoredProcedureName = StoredProcedures.Add_New_Volanteer;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@FirstName", FName);
            Parameters.Add("@MidName", MName);
            Parameters.Add("@LastName", LName);
            Parameters.Add("@ID", ID);
            Parameters.Add("@National_ID", National_ID);
            Parameters.Add("@GENDER", GENDER);
            Parameters.Add("@PASSWORD", PASSWORD);
            Parameters.Add("@USERNAME", USERNAME);
            return DB.ExecuteNonQuery(StoredProcedureName, Parameters);
        }
        public int Add_New_Visitor(string FName, string MName, string LName, int ID, Char GENDER, string PASSWORD, string USERNAME, DateTime Birth_Date, int Attendance)
        {
            string StoredProcedureName = StoredProcedures.Add_New_Visitor;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@FirstName", FName);
            Parameters.Add("@MidName", MName);
            Parameters.Add("@LastName", LName);
            Parameters.Add("@ID", ID);
            Parameters.Add("@GENDER", GENDER);
            Parameters.Add("@PASSWORD", PASSWORD);
            Parameters.Add("@USERNAME", USERNAME);
            Parameters.Add("@Birth_Date", Birth_Date);
            Parameters.Add("@Attendance", Attendance);
            return DB.ExecuteNonQuery(StoredProcedureName, Parameters);
        }

        public int Delete_Organizer(int ID)
        {
            string StoredProcedureName = StoredProcedures.Delete_Organizer;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@ID", ID);
            return DB.ExecuteNonQuery(StoredProcedureName, Parameters);
        }

        public int Delete_Organizer_Phone(int ID, long PhoneNumber)
        {
            string StoredProcedureName = StoredProcedures.Delete_Organizer_Phone;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@ID", ID);
            Parameters.Add("@PhoneNumber", PhoneNumber);
            return DB.ExecuteNonQuery(StoredProcedureName, Parameters);
        }

        public int Delete_Visitor(int ID)
        {
            string StoredProcedureName = StoredProcedures.Delete_Visitor;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@ID", ID);
            return DB.ExecuteNonQuery(StoredProcedureName, Parameters);
        }

        public int Delete_Visitor_Phones(int ID, long PhoneNumber)
        {
            string StoredProcedureName = StoredProcedures.Delete_Visitor_Phones;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@ID", ID);
            Parameters.Add("@PhoneNumber", PhoneNumber);
            return DB.ExecuteNonQuery(StoredProcedureName, Parameters);
        }

        public int Delete_BookSeller(int ID)
        {
            string StoredProcedureName = StoredProcedures.Delete_BookSeller;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@ID", ID);
            return DB.ExecuteNonQuery(StoredProcedureName, Parameters);
        }


        public int Delete_Bookseller_Phone(int ID, long PhoneNumber)
        {
            string StoredProcedureName = StoredProcedures.Delete_Bookseller_Phone;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@ID", ID);
            Parameters.Add("@PhoneNumber", PhoneNumber);
            return DB.ExecuteNonQuery(StoredProcedureName, Parameters);
        }

        public int Delete_Book_Seller_Shifts(int ID, string SHIFT_TIME_Start, string SHIFT_TIME_End)
        {
            string StoredProcedureName = StoredProcedures.Delete_Book_Seller_Shifts;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@ID", ID);
            Parameters.Add("@SHIFT_TIME_Start", SHIFT_TIME_Start);
            Parameters.Add("@SHIFT_TIME_End", SHIFT_TIME_End);
            return DB.ExecuteNonQuery(StoredProcedureName, Parameters);
        }

        public int Delete_Media_man(int ID)
        {
            string StoredProcedureName = StoredProcedures.Delete_Media_man;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@ID", ID);
            return DB.ExecuteNonQuery(StoredProcedureName, Parameters);
        }

        public int Delete_Media_Phones(int ID, long PhoneNumber)
        {
            string StoredProcedureName = StoredProcedures.Delete_Media_Phones;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@ID", ID);
            Parameters.Add("@PhoneNumber", PhoneNumber);
            return DB.ExecuteNonQuery(StoredProcedureName, Parameters);
        }

        public int Delete_Ticket_Reserve(int ID)
        {
            string StoredProcedureName = StoredProcedures.Delete_Ticket_Reserve;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@ID", ID);
            return DB.ExecuteNonQuery(StoredProcedureName, Parameters);
        }

        public int Delete_Ticket_Reserve_Phone(int ID, long PhoneNumber)
        {
            string StoredProcedureName = StoredProcedures.Delete_Ticket_Reserve_Phone;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@ID", ID);
            Parameters.Add("@PhoneNumber", PhoneNumber);
            return DB.ExecuteNonQuery(StoredProcedureName, Parameters);
        }

        public int Delete_Volunter(int ID)
        {
            string StoredProcedureName = StoredProcedures.Delete_Volunter;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@ID", ID);
            return DB.ExecuteNonQuery(StoredProcedureName, Parameters);
        }

        public int Delete_Volunter_Phones(int ID, long PhoneNumber)
        {
            string StoredProcedureName = StoredProcedures.Delete_Volunter_Phones;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@ID", ID);
            Parameters.Add("@PhoneNumber", PhoneNumber);
            return DB.ExecuteNonQuery(StoredProcedureName, Parameters);
        }



        public DataTable Select_All_Interests()
        {
            string StoredProcedureName = StoredProcedures.Select_All_Interests;
            return DB.ExecuteReader(StoredProcedureName, null);
        }


        public DataTable Is_ID_Organizers_Unique(int ID)
        {
            string StoredProcedureName = StoredProcedures.Is_ID_Organizers_Unique;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@ID", ID);
            return DB.ExecuteReader(StoredProcedureName, Parameters);
        }
        
        public DataTable Is_ID_Bookseller_unique(int ID)
        {
            string StoredProcedureName = StoredProcedures.Is_ID_Bookseller_unique;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@ID", ID);
            return DB.ExecuteReader(StoredProcedureName, Parameters);
        }

        public DataTable Is_ID_Media_Man_Unique(int ID)
        {
            string StoredProcedureName = StoredProcedures.Is_ID_Media_Man_Unique;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@ID", ID);
            return DB.ExecuteReader(StoredProcedureName, Parameters);
        }

        public DataTable Is_ID_Ticket_Reserves_Unique(int ID)
        {
            string StoredProcedureName = StoredProcedures.Is_ID_Ticket_Reserves_Unique;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@ID", ID);
            return DB.ExecuteReader(StoredProcedureName, Parameters);
        }

        public DataTable Is_ID_Visitors_unique(int ID)
        {
            string StoredProcedureName = StoredProcedures.Is_ID_Visitors_unique;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@ID", ID);
            return DB.ExecuteReader(StoredProcedureName, Parameters);
        }

        public DataTable Is_ID_Volunters_unique(int ID)
        {
            string StoredProcedureName = StoredProcedures.Is_ID_Volunters_unique;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@ID", ID);
            return DB.ExecuteReader(StoredProcedureName, Parameters);
        }

        public int Insert_Organizer_Phone(long PhoneNum, int ID)
        {
            string StoredProcedureName = StoredProcedures.Insert_Organizer_Phone;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@PhoneNumber", PhoneNum);
            Parameters.Add("@ID", ID);
            return DB.ExecuteNonQuery(StoredProcedureName, Parameters);
        }

        public int Insert_Ticket_Reserve_Phone(long PhoneNum, int ID)
        {
            string StoredProcedureName = StoredProcedures.Insert_Ticket_Reserve_Phone;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@PhoneNumber", PhoneNum);
            Parameters.Add("@ID", ID);
            return DB.ExecuteNonQuery(StoredProcedureName, Parameters);
        }

        public int Insert_Book_Seller_Phones(long PhoneNum, int ID)
        {
            string StoredProcedureName = StoredProcedures.Insert_Book_Seller_Phones;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@PhoneNumber", PhoneNum);
            Parameters.Add("@ID", ID);
            return DB.ExecuteNonQuery(StoredProcedureName, Parameters);
        }

        public int Insert_Media_Phone(long PhoneNum, int ID)
        {
            string StoredProcedureName = StoredProcedures.Insert_Media_Phone;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@PhoneNumber", PhoneNum);
            Parameters.Add("@ID", ID);
            return DB.ExecuteNonQuery(StoredProcedureName, Parameters);
        }

        public int Insert_Visitor_Phones(long PhoneNum, int ID)
        {
            string StoredProcedureName = StoredProcedures.Insert_Visitor_Phones;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@PhoneNumber", PhoneNum);
            Parameters.Add("@ID", ID);
            return DB.ExecuteNonQuery(StoredProcedureName, Parameters);
        }

        public int Insert_Volunter_Phones(long PhoneNum, int ID)
        {
            string StoredProcedureName = StoredProcedures.Insert_Volunter_Phones;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@PhoneNumber", PhoneNum);
            Parameters.Add("@ID", ID);
            return DB.ExecuteNonQuery(StoredProcedureName, Parameters);
        }


        public DataTable Is_National_ID_Unique(long NID)
        {
            string StoredProcedureName = StoredProcedures.Is_National_ID_Unique;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@NID", NID);
            return DB.ExecuteReader(StoredProcedureName, Parameters);
        }

        public DataTable Is_Phone_Number_Unique(int phoneNum)
        {
            string StoredProcedureName = StoredProcedures.Is_Phone_Number_Unique;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@PhoneNum", phoneNum);
            return DB.ExecuteReader(StoredProcedureName, Parameters);
        }

        public DataTable Is_Ticket_Used(int Serial_Num)
        {
            string StoredProcedureName = StoredProcedures.Is_Ticket_Used;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Serial_Number", Serial_Num);
            return DB.ExecuteReader(StoredProcedureName, Parameters);
        }

        public DataTable Is_Bookseller_UserName_Unique(string username)
        {
            string StoredProcedureName = StoredProcedures.Is_Bookseller_UserName_Unique;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@UserName", username);
            return DB.ExecuteReader(StoredProcedureName, Parameters);
        }

        public DataTable Is_Media_Man_UserName_Unique(string username)
        {
            string StoredProcedureName = StoredProcedures.Is_Media_Man_UserName_Unique;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@UserName", username);
            return DB.ExecuteReader(StoredProcedureName, Parameters);
        }

        public DataTable Is_Organizers_UserName_Unique(string username)
        {
            string StoredProcedureName = StoredProcedures.Is_Organizers_UserName_Unique;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@UserName", username);
            return DB.ExecuteReader(StoredProcedureName, Parameters);
        }

        public DataTable Is_Ticket_Reserves_UserName_Unique(string username)
        {
            string StoredProcedureName = StoredProcedures.Is_Ticket_Reserves_UserName_Unique;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@UserName", username);
            return DB.ExecuteReader(StoredProcedureName, Parameters);
        }

        public DataTable Is_Visitors_UserName_Unique(string username)
        {
            string StoredProcedureName = StoredProcedures.Is_Visitors_UserName_Unique;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@UserName", username);
            return DB.ExecuteReader(StoredProcedureName, Parameters);
        }

        public DataTable Is_Volunters_UserName_Unique(string username)
        {
            string StoredProcedureName = StoredProcedures.Is_Volunters_UserName_Unique;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@UserName", username);
            return DB.ExecuteReader(StoredProcedureName, Parameters);
        }

        public int Use_Ticket(long Serial_Num, int Visitor_ID, DateTime dateTime)
        {
            string StoredProcedureName = StoredProcedures.Use_Ticket;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Serial_Number", Serial_Num);
            Parameters.Add("@Visitor_ID", Visitor_ID);
            Parameters.Add("@Time_Used_in", dateTime);
            return DB.ExecuteNonQuery(StoredProcedureName, Parameters);
        }


        public int Add_Visitor_Interest(string Interest, int Visitor_ID)
        {
            string StoredProcedureName = StoredProcedures.Add_Visitor_Interest;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Interest", Interest);
            Parameters.Add("@Visitor_ID", Visitor_ID);
            return DB.ExecuteNonQuery(StoredProcedureName, Parameters);
        }

        public int Add_New_Interest(string Interest)
        {
            string StoredProcedureName = StoredProcedures.Add_New_Interest;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Interest", Interest);
            return DB.ExecuteNonQuery(StoredProcedureName, Parameters);
        }

        public int Is_Visitor_Interest_Exists(string Interest, int ID)
        {
            string StoredProcedureName = StoredProcedures.Is_Visitor_Interest_Exists;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Interest", Interest);
            Parameters.Add("@Visitor_ID", ID);
            return (int)DB.ExecuteScalar(StoredProcedureName, Parameters);
        }

        public int Is_Interest_Exists(string Interest)
        {
            string StoredProcedureName = StoredProcedures.Is_Interest_Exists;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Interest", Interest);
            return (int)DB.ExecuteScalar(StoredProcedureName, Parameters);
        }



        public int Update_Visitor_atendance_Number(int ID)
        {
            string StoredProcedureName = StoredProcedures.Update_Visitor_atendance_Number;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@ID", ID);
            return DB.ExecuteNonQuery(StoredProcedureName, Parameters);
        }


        public DataTable get_Organizer_ID(string Name)
        {
            string StoredProcedureName = StoredProcedures.get_Organizer_ID;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Username", Name);
            return DB.ExecuteReader(StoredProcedureName, Parameters);
        }


        public DataTable get_Visitor_ID(string username)
        {
            string StoredProcedureName = StoredProcedures.get_Visitor_ID;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@USERNAME", username);
            return DB.ExecuteReader(StoredProcedureName, Parameters);
        }


        public DataTable get_Bookseller_ID(string username)
        {
            string StoredProcedureName = StoredProcedures.get_Bookseller_ID;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@USERNAME", username);
            return DB.ExecuteReader(StoredProcedureName, Parameters);
        }


        public DataTable get_Media_Man_ID(string username)
        {
            string StoredProcedureName = StoredProcedures.get_Media_Man_ID;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@USERNAME", username);
            return DB.ExecuteReader(StoredProcedureName, Parameters);
        }


        public DataTable get_Ticket_reserver_ID(string username)
        {
            string StoredProcedureName = StoredProcedures.get_Ticket_reserver_ID;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@USERNAME", username);
            return DB.ExecuteReader(StoredProcedureName, Parameters);
        }


        public DataTable get_Volunteer_ID(string username)
        {
            string StoredProcedureName = StoredProcedures.get_Volunteer_ID;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@USERNAME", username);
            return DB.ExecuteReader(StoredProcedureName, Parameters);
        }

        public DataTable Select_Volunteer_All_PhoneNumbers(int ID)
        {
            string StoredProcedureName = StoredProcedures.Select_Volunteer_All_PhoneNumbers;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@ID", ID);
            return DB.ExecuteReader(StoredProcedureName, Parameters);
        }

        public DataTable Select_Bookseller_All_PhoneNumbers(int ID)
        {
            string StoredProcedureName = StoredProcedures.Select_Bookseller_All_PhoneNumbers;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@ID", ID);
            return DB.ExecuteReader(StoredProcedureName, Parameters);
        }

        public DataTable Select_Media_Man_All_PhoneNumbers(int ID)
        {
            string StoredProcedureName = StoredProcedures.Select_Media_Man_All_PhoneNumbers;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@ID", ID);
            return DB.ExecuteReader(StoredProcedureName, Parameters);
        }

        public DataTable Select_Organizer_All_PhoneNumbers(int ID)
        {
            string StoredProcedureName = StoredProcedures.Select_Organizer_All_PhoneNumbers;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@ID", ID);
            return DB.ExecuteReader(StoredProcedureName, Parameters);
        }

        public DataTable Select_Ticket_Reserver_All_PhoneNumbers(int ID)
        {
            string StoredProcedureName = StoredProcedures.Select_Ticket_Reserver_All_PhoneNumbers;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@ID", ID);
            return DB.ExecuteReader(StoredProcedureName, Parameters);
        }

        public DataTable Select_Visitor_All_PhoneNumbers(int ID)
        {
            string StoredProcedureName = StoredProcedures.Select_Visitor_All_PhoneNumbers;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@ID", ID);
            return DB.ExecuteReader(StoredProcedureName, Parameters);
        }

        public int Is_Bookseller_PhoneNumber_Exists(long PhoneNum)
        {
            string StoredProcedureName = StoredProcedures.Is_Bookseller_PhoneNumber_Exists;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@PhoneNum", PhoneNum);
            return (int)DB.ExecuteScalar(StoredProcedureName, Parameters);
        }

        public int Is_Media_Man_PhoneNumber_Exists(long PhoneNum)
        {
            string StoredProcedureName = StoredProcedures.Is_Media_Man_PhoneNumber_Exists;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@PhoneNum", PhoneNum);
            return (int)DB.ExecuteScalar(StoredProcedureName, Parameters);
        }

        public int Is_Organizer_PhoneNumber_Exists(long PhoneNum)
        {
            string StoredProcedureName = StoredProcedures.Is_Organizer_PhoneNumber_Exists;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@PhoneNum", PhoneNum);
            return (int)DB.ExecuteScalar(StoredProcedureName, Parameters);
        }

        public int Is_Ticket_Reserver_PhoneNumber_Exists(long PhoneNum)
        {
            string StoredProcedureName = StoredProcedures.Is_Ticket_Reserver_PhoneNumber_Exists;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@PhoneNum", PhoneNum);
            return (int)DB.ExecuteScalar(StoredProcedureName, Parameters);
        }

        public int Is_Visitor_PhoneNumber_Exists(long PhoneNum)
        {
            string StoredProcedureName = StoredProcedures.Is_Visitor_PhoneNumber_Exists;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@PhoneNum", PhoneNum);
            return (int)DB.ExecuteScalar(StoredProcedureName, Parameters);
        }

        public int Is_Volunteer_PhoneNumber_Exists(long PhoneNum)
        {
            string StoredProcedureName = StoredProcedures.Is_Volunteer_PhoneNumber_Exists;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@PhoneNum", PhoneNum);
            return (int)DB.ExecuteScalar(StoredProcedureName, Parameters);
        }

        public int Change_Visitor_Password(int ID, string OLDPassword, string NEWPassword)
        {
            string StoredProcedureName = StoredProcedures.Change_Visitor_Password;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@ID", ID);
            Parameters.Add("@OLDPassword", OLDPassword);
            Parameters.Add("@NEWPassword", NEWPassword);
            return DB.ExecuteNonQuery(StoredProcedureName, Parameters);
        }

        public int Change_Volunteer_Password(int ID, string OLDPassword, string NEWPassword)
        {
            string StoredProcedureName = StoredProcedures.Change_Volunteer_Password;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@ID", ID);
            Parameters.Add("@OLDPassword", OLDPassword);
            Parameters.Add("@NEWPassword", NEWPassword);
            return DB.ExecuteNonQuery(StoredProcedureName, Parameters);
        }

        public int Change_Bookseller_Password(int ID, string OLDPassword, string NEWPassword)
        {
            string StoredProcedureName = StoredProcedures.Change_Bookseller_Password;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@ID", ID);
            Parameters.Add("@OLDPassword", OLDPassword);
            Parameters.Add("@NEWPassword", NEWPassword);
            return DB.ExecuteNonQuery(StoredProcedureName, Parameters);
        }

        public int Change_Media_Man_Password(int ID, string OLDPassword, string NEWPassword)
        {
            string StoredProcedureName = StoredProcedures.Change_Media_Man_Password;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@ID", ID);
            Parameters.Add("@OLDPassword", OLDPassword);
            Parameters.Add("@NEWPassword", NEWPassword);
            return DB.ExecuteNonQuery(StoredProcedureName, Parameters);
        }

        public int Change_Organizer_Password(int ID, string OLDPassword, string NEWPassword)
        {
            string StoredProcedureName = StoredProcedures.Change_Organizer_Password;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@ID", ID);
            Parameters.Add("@OLDPassword", OLDPassword);
            Parameters.Add("@NEWPassword", NEWPassword);
            return DB.ExecuteNonQuery(StoredProcedureName, Parameters);
        }

        public int Change_Ticket_Reserver_Password(int ID, string OLDPassword, string NEWPassword)
        {
            string StoredProcedureName = StoredProcedures.Change_Ticket_Reserver_Password;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@ID", ID);
            Parameters.Add("@OLDPassword", OLDPassword);
            Parameters.Add("@NEWPassword", NEWPassword);
            return DB.ExecuteNonQuery(StoredProcedureName, Parameters);
        }

        public DataTable get_Volunteer(int ID)
        {
            string StoredProcedureName = StoredProcedures.get_Volunteer;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@ID", ID);
            return DB.ExecuteReader(StoredProcedureName, Parameters);
        }

        public DataTable get_User_Name(int ID)
        {
            string StoredProcedureName = StoredProcedures.get_User_Name;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@ID", ID);
            return DB.ExecuteReader(StoredProcedureName, Parameters);
        }

        public int Update_Volunteer_Info(int ID, string FName, string MName, string LName, string Username, string GENDER)
        {
            string StoredProcedureName = StoredProcedures.Update_Volunteer_Info;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@ID", ID);
            Parameters.Add("@FName", FName);
            Parameters.Add("@MName", MName);
            Parameters.Add("@LName", LName);
            Parameters.Add("@Username", Username);
            Parameters.Add("@GENDER", GENDER);
            return DB.ExecuteNonQuery(StoredProcedureName, Parameters);
        }

        public int Count_Num_volunteer_phone(int ID)
        {
            string StoredProcedureName = StoredProcedures.Count_Num_volunteer_phone;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@ID", ID);
            return (int)DB.ExecuteScalar(StoredProcedureName, Parameters);
        }

        public DataTable get_Volunteer_Shifts(int ID)
        {
            string StoredProcedureName = StoredProcedures.get_Volunteer_Shifts;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@ID", ID);
            return DB.ExecuteReader(StoredProcedureName, Parameters);
        }

        public int Count_Num_volunteer_shifts(int ID)
        {
            string StoredProcedureName = StoredProcedures.Count_Num_volunteer_shifts;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@ID", ID);
            return (int)DB.ExecuteScalar(StoredProcedureName, Parameters);
        }

        public DataTable get_Event(int Code)
        {
            string StoredProcedureName = StoredProcedures.get_Event;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Code", Code);
            return DB.ExecuteReader(StoredProcedureName, Parameters);
        }


        public DataTable get_Booths_Location_Letter()
        {
            string StoredProcedureName = StoredProcedures.get_Booths_Location_Letter;
            return DB.ExecuteReader(StoredProcedureName, null);
        }

        public DataTable get_Booths_Location_Hall()
        {
            string StoredProcedureName = StoredProcedures.get_Booths_Location_Hall;
            return DB.ExecuteReader(StoredProcedureName, null);
        }

        public DataTable get_Booths_Location_Section()
        {
            string StoredProcedureName = StoredProcedures.get_Booths_Location_Section;
            return DB.ExecuteReader(StoredProcedureName, null);
        }

        public DataTable get_Volanteer_Worked_Event(int ID, int Code)
        {
            string StoredProcedureName = StoredProcedures.get_Volanteer_Worked_Event;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@ID", ID);
            Parameters.Add("@Event_Code", Code);
            return DB.ExecuteReader(StoredProcedureName, Parameters);
        }

        public DataTable get_Event_Code_ByName(string Event_Name)
        {
            string StoredProcedureName = StoredProcedures.get_Event_Code_ByName;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Event_Name", Event_Name);
            return DB.ExecuteReader(StoredProcedureName, Parameters);
        }

        public DataTable get_Event_Code_ByLocation(string Letter, int Hall, int Section)
        {
            string StoredProcedureName = StoredProcedures.get_Event_Code_ByLocation;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Letter", Letter);
            Parameters.Add("@Hall", Hall);
            Parameters.Add("@Section", Section);
            return DB.ExecuteReader(StoredProcedureName, Parameters);
        }

        public DataTable get_Event_Code_ByTime(DateTime Date)
        {
            string StoredProcedureName = StoredProcedures.get_Event_Code_ByTime;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Date", Date);
            return DB.ExecuteReader(StoredProcedureName, Parameters);
        }


        public DataTable get_Volanteer_Past_Activity(int Code, int ID)
        {
            string StoredProcedureName = StoredProcedures.get_Volanteer_Past_Activity;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Code", Code);
            Parameters.Add("@ID", ID);
            return DB.ExecuteReader(StoredProcedureName, Parameters);
        }

        public DataTable get_ALL_Volanteer_Past_Activity(int ID)
        {
            string StoredProcedureName = StoredProcedures.get_ALL_Volanteer_Past_Activity;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@ID", ID);
            return DB.ExecuteReader(StoredProcedureName, Parameters);
        }
        






































        static List<string> Book_title = new List<string>();
        static int len_book = Book_title.Count;

        /*static List<string> Booth_Date = new List<string>();
        static int len_boothD = Booth_Date.Count;

        static List<string> Booth_Time = new List<string>();
        static int len_boothT = Booth_Time.Count;*/

        public DataTable searchBook(string Booktitle)
        {
            for (int k = 0; k < len_book; k++)
            {
                if (Book_title[k] == Booktitle)
                {
                    //return Booktitle;
                }
                else
                {
                    Console.WriteLine("This book is not here");
                    MessageBox.Show("This book is not here");
                }

            }
            return null;
        }
        public DataTable DisplayBookInfo(string BookTitle)
        {
            string StoredProcedureName = StoredProcedures.DisplayBookInfo;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            //Parameters.Add("Pname", BookTitle);
            //Parameters.Add("Pauthor", Author);
            //Parameters.Add("Pprice", price);
            //Parameters.Add("pOffer", offer);
            //Parameters.Add("pAvailable", available);
            rdr = DB.ExecuteScalar(StoredProcedureName, Parameters) as SqlDataReader;
            rdr.Read();
            BookInfo Form = new BookInfo();
            Form.title_textBox.Text = rdr["Pname"].ToString();
            Form.author_textBox.Text = rdr["Pauthor"].ToString();
            Form.price_textBox.Text = rdr["Pprice"].ToString();
            Form.offer_textBox.Text = rdr["pOffer"].ToString();
            Form.available_textBox.Text = rdr["pAvailable"].ToString();
            //return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
            return DB.ExecuteReader(StoredProcedureName, Parameters);
        }

        public int AddBook(string BookTitle, string Author, int price, string offer, bool available, string series, string category, int num)
        {
            string StoredProcedureName = StoredProcedures.DisplayBookInfo;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Pname", BookTitle);
            Parameters.Add("@Pauthor", Author);
            Parameters.Add("@Pprice", price);
            Parameters.Add("@pOffer", offer);
            Parameters.Add("@pAvailable", available);
            Parameters.Add("@pSeries", series);
            Parameters.Add("@pcategory", category);
            Parameters.Add("@pNum_Of_Books", num);

            return DB.ExecuteNonQuery(StoredProcedureName, Parameters);

        }
        public int AddVisitor(string Name, int Ticket, int ID)
        {
            string StoredProcedureName = StoredProcedures.AddVisitor;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@PName", Name);
            Parameters.Add("@pID", ID);
            Parameters.Add("@pTicket_Number", Ticket);
            return DB.ExecuteNonQuery(StoredProcedureName, Parameters);
        }
        public int Registration(string Name, int Ticket)
        {
            string StoredProcedureName = StoredProcedures.Registration;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@PName", Name);
            Parameters.Add("@pTicketNumber", Ticket);
            return DB.ExecuteNonQuery(StoredProcedureName, Parameters);
        }

        public int Selling_Book(string book_title)
        {
            string StoredProcedureName = StoredProcedures.Selling_Book;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@pBook_Title", book_title);
            return DB.ExecuteNonQuery(StoredProcedureName, Parameters);
        }

        public DataTable SelectBookTitle()
        {
            String StoredProcedureName = StoredProcedures.SelectBookTitle;

            return DB.ExecuteReader(StoredProcedureName, null);

        }

        public DataTable DisplayEventsInfo(string Startdate)
        {

            string StoredProcedureName = StoredProcedures.DisplayEventsInfo;
            return DB.ExecuteReader(StoredProcedureName, null);

        }


        /*  public DataTable searchBooth(string BoothDate, string BoothTime)
    {
      for (int k = 0; k < len_boothD; k++)
      {
          if (Booth_Date[k] == BoothDate)
          {
              for (int i = 0; i < len_boothT; i++)
              {
                  if (Booth_Time[i] == BoothTime)
                  {
                      return BoothDate;
                      return BoothTime;

                  }
              }
          }
          else
          {
              // MessageBox.Show ( "This book is not here");
              Console.WriteLine("No Booth available");
          }

      }
      return "null";
    }*/

/*
 public DataTable DisplayBookInfo(string BookTitle, string Author, int price, string offer, bool available)
        {
            string StoredProcedureName = Stored_procedure.DisplayBookInfo;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("Pname", BookTitle);
            Parameters.Add("Pauthor", Author);
            Parameters.Add("Pprice", price);
            Parameters.Add("pOffer", offer);
            Parameters.Add("pAvailable", available);
            using sdr as SqlDataReader=dbMan.ExecuteReader()
            sdr.Read()
            textBox.Text=sdr("Pname").toString()
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        } 
 */












        //public int Add_New_Organizer (string FirstName, string MidName, string LastName, int ID, int super_ID, string UserName, string Password, string Sex, DateTime birthDate, string Team_Name)
        //{
        //    //string StoredProcedureName = StoredProcedures.SignUp_Organizer;
        //    //Dictionary<string, object> Parameters = new Dictionary<string, object>();
        //    //Parameters.Add("@FirstName", FirstName);
        //    //Parameters.Add("@MidName", MidName);
        //    //Parameters.Add("@LastName", LastName);
        //    //Parameters.Add("@ID", ID);
        //    //Parameters.Add("@Supervisor_ID", super_ID);
        //    //Parameters.Add( "", UserName);
        //    //Parameters.Add( , Password);
        //    //Parameters.Add( , Sex);
        //    //Parameters.Add( , birthDate);
        //    //Parameters.Add( , Team_Name);
        //    //Parameters.Add( , 0);
        //    //Parameters.Add( , );
        //    //Parameters.Add( , );
        //    //return DB.ExecuteNonQuery(StoredProcedureName, Parameters);

        //}

    }
}
