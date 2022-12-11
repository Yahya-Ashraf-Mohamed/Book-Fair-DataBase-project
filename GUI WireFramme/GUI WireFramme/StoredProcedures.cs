using System;
using System.Collections.Generic;
using System.Text;

namespace Book_Fair
{
    class StoredProcedures
    {
        public static string Show_All_Events_Code = "SelectEventCode";
        public static string Show_All_Events_Name = "SelectEventName";
        public static string Show_All_Events_Location = "SelectEventLocation";
        public static string Check_UserName_Exist_in_Organizer = "Check_Organizer_Username";
        public static string Check_UserName_Exist_in_Bookseller = "Check_Bookseller_Username";
        public static string Check_UserName_Exist_in_Media = "Check_Media_Username";
        public static string Check_UserName_Exist_in_Ticket_reserver = "Check_Ticket_reserver_Username";
        public static string Check_UserName_Exist_in_Visitors = "Check_Visitors_Username";
        public static string Check_UserName_Exist_in_Volunter = "Check_Volunter_Username";
        public static string Recover_Organizer_Password = "Recover_Organizer_Password";
        public static string Recover_Bookseller_Password = "Recover_Bookseller_Password";
        public static string Recover_Media_man_Password = "Recover_Media_man_Password";
        public static string Recover_Ticket_Reserves_Password = "Recover_Ticket_Reserves_Password";
        public static string Recover_Visitor_Password = "Recover_Visitor_Password";
        public static string Recover_Volunters_Password = "Recover_Volunters_Password";
        public static string Add_New_Organizer = "Add_New_Organizer";
        public static string Add_New_Bookseller = "Add_New_Bookseller";
        public static string Add_New_Media_man = "Add_New_Media_man";
        public static string Add_New_Ticket_Reserver = "Add_New_Ticket_Reserver";
        public static string Add_New_Volanteer = "Add_New_Volanteer";
        public static string Add_New_Visitor = "Add_New_Visitor";
        public static string Is_ID_Bookseller_unique = "Is_ID_Bookseller_unique";
        public static string Is_ID_Organizers_Unique = "Is_ID_Organizers_Unique";
        public static string Is_ID_Media_Man_Unique = "Is_ID_Media_Man_Unique";
        public static string Is_ID_Ticket_Reserves_Unique = "Is_ID_Ticket_Reserves_Unique";
        public static string Is_ID_Visitors_unique = "Is_ID_Visitors_unique";
        public static string Is_ID_Volunters_unique = "Is_ID_Volunters_unique";
        public static string Insert_Organizer_Phone = "Add_Organizer_Phone";
        public static string Insert_Ticket_Reserve_Phone = "Add_Ticket_Reserve_Phone";
        public static string Insert_Book_Seller_Phones = "Add_Book_Seller_Phones";
        public static string Insert_Media_Phone = "Add_Media_Phone";
        public static string Insert_Visitor_Phones = "Add_Visitor_Phones";
        public static string Insert_Volunter_Phones = "Add_Volunter_Phones";
        public static string Is_National_ID_Unique = "Is_National_ID_Unique";
        public static string Is_Bookseller_UserName_Unique = "Is_Bookseller_Unique";
        public static string Is_Media_Man_UserName_Unique = "Is_Media_Man_Unique";
        public static string Is_Organizers_UserName_Unique = "Is_Organizers_Unique";
        public static string Is_Ticket_Reserves_UserName_Unique = "Is_Ticket_Reserves_Unique";
        public static string Is_Visitors_UserName_Unique = "Is_Visitors_Unique";
        public static string Is_Volunters_UserName_Unique = "Is_Volunters_Unique";
        public static string Is_Phone_Number_Unique = "Is_Phone_Number_Unique";
        public static string Is_Ticket_Used = "Is_Ticket_Used";
        public static string Use_Ticket = "Use_Ticket";
        public static string Select_All_Interests = "Select_All_Interests";
        public static string Add_Visitor_Interest = "Add_Visitor_Interest";
        public static string Add_New_Interest = "Add_New_Interest";
        public static string Is_Visitor_Interest_Exists = "Is_Visitor_Interest_Exists";
        public static string Is_Interest_Exists = "Is_Interest_Exists";
        public static string Add_Book_Seller_Works_IN = "Add_Book_Seller_Works_IN";
        public static string Add_Book_Seller_Shifts = "Add_Book_Seller_Shifts";
        public static string Add_Media_Shifts = "Add_Media_Shifts";
        public static string Add_Organizer_Shifts = "Add_Organizer_Shifts";
        public static string Add_Ticket_Reserver_Shifts = "Add_Ticket_Reserver_Shifts";
        public static string Add_Volanteer_Shifts = "Add_Volanteer_Shifts";
        public static string Delete_Organizer = "Delete_Organizer";
        public static string Delete_Organizer_Phone = "Delete_Organizer_Phone";
        public static string Delete_Visitor = "Delete_Visitor";
        public static string Delete_Visitor_Phones = "Delete_Visitor_Phones";
        public static string Delete_BookSeller = "Delete_BookSeller";
        public static string Delete_Bookseller_Phone = "Delete_Bookseller_Phone";
        public static string Delete_Book_Seller_Shifts = "Delete_Book_Seller_Shifts";
        public static string Delete_Media_man = "Delete_Media_man";
        public static string Delete_Media_Phones = "Delete_Media_Phones";
        public static string Delete_Ticket_Reserve = "Delete_Ticket_Reserve";
        public static string Delete_Ticket_Reserve_Phone = "Delete_Ticket_Reserve_Phone";
        public static string Delete_Volunter = "Delete_Volunter";
        public static string Delete_Volunter_Phones = "Delete_Volunter_Phones";
        public static string Update_Visitor_atendance_Number = "Update_Visitor_atendance_Number";
        public static string get_Visitor_ID = "get_Visitor_ID";
        public static string get_Organizer_ID = "get_Organizer_ID";
        public static string get_Bookseller_ID = "get_Bookseller_ID";
        public static string get_Media_Man_ID = "get_Media_Man_ID";
        public static string get_Ticket_reserver_ID = "get_Ticket_reserver_ID";
        public static string get_Volunteer_ID = "get_Volunteer_ID";
        public static string Select_Bookseller_All_PhoneNumbers = "Select_Bookseller_All_PhoneNumbers";
        public static string Select_Media_Man_All_PhoneNumbers = "Select_Media_Man_All_PhoneNumbers";
        public static string Select_Organizer_All_PhoneNumbers = "Select_Organizer_All_PhoneNumbers";
        public static string Select_Ticket_Reserver_All_PhoneNumbers = "Select_Ticket_Reserver_All_PhoneNumbers";
        public static string Select_Visitor_All_PhoneNumbers = "Select_Visitor_All_PhoneNumbers";
        public static string Select_Volunteer_All_PhoneNumbers = "Select_Volunteer_All_PhoneNumbers";
        public static string Is_Bookseller_PhoneNumber_Exists = "Is_Bookseller_PhoneNumber_Exists";
        public static string Is_Media_Man_PhoneNumber_Exists = "Is_Media_Man_PhoneNumber_Exists";
        public static string Is_Organizer_PhoneNumber_Exists = "Is_Organizer_PhoneNumber_Exists";
        public static string Is_Ticket_Reserver_PhoneNumber_Exists = "Is_Ticket_Reserver_PhoneNumber_Exists";
        public static string Is_Visitor_PhoneNumber_Exists = "Is_Visitor_PhoneNumber_Exists";
        public static string Is_Volunteer_PhoneNumber_Exists = "Is_Volunteer_PhoneNumber_Exists";
        public static string Change_Volunteer_Password = "Change_Volunteer_Password";
        public static string Change_Bookseller_Password = "Change_Bookseller_Password";
        public static string Change_Media_Man_Password = "Change_Media_Man_Password";
        public static string Change_Organizer_Password = "Change_Organizer_Password";
        public static string Change_Ticket_Reserver_Password = "Change_Ticket_Reserver_Password";
        public static string Change_Visitor_Password = "Change_Visitor_Password";
        public static string get_Volunteer = "get_Volunteer";
        public static string get_User_Name = "get_User_Name";
        public static string Update_Volunteer_Info = "Update_Volunteer_Info";
        public static string get_Volunteer_PhoneNumbers = "get_Volunteer_PhoneNumbers";
        public static string get_Volunteer_Shifts = "get_Volunteer_Shifts";
        public static string Count_Num_volunteer_phone = "Count_Num_volunteer_phone";
        public static string Count_Num_volunteer_shifts = "Count_Num_volunteer_shifts";
        public static string get_Event = "get_Event";
        public static string get_Booths_Location_Letter = "get_Booths_Location_Letter";
        public static string get_Booths_Location_Hall = "get_Booths_Location_Hall";
        public static string get_Booths_Location_Section = "get_Booths_Location_Section";
        public static string get_Volanteer_Worked_Event = "get_Volanteer_Worked_Event";
        public static string get_Event_Code_ByName = "get_Event_Code_ByName";
        public static string get_Event_Code_ByLocation = "get_Event_Code_ByLocation";
        public static string get_Event_Code_ByTime = "get_Event_Code_ByTime";
        public static string get_Volanteer_Past_Activity = "get_Volanteer_Past_Activity";
        public static string get_ALL_Volanteer_Past_Activity = "get_ALL_Volanteer_Past_Activity";

        





        public static string AddVisitor = "AddVisitor";
        public static string DisplayBookInfo = "DisplayBookInfo";
        public static string AddBook = "AddBook";
        public static string DisplayEvents = "DisplayEvents";
        public static string PublishinghouseInfo = "PublishingHouseInfo";
        public static string SelectBookTitle = "SelectBookTitle";
        public static string Registration = "Registration";
        public static string Selling_Book = "Selling_Book";
        public static string DisplayEventsInfo = "DisplayEventsInfo";
    }
}
