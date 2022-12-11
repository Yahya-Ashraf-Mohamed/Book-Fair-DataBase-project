GO
CREATE PROCEDURE SelectEventCode
	AS
BEGIN
	SELECT DISTINCT Code FROM Events
	UNION
	SELECT DISTINCT Code FROM Past_Events;
END

---------------------------------------------------------------------------------------------------------------
GO
CREATE PROCEDURE SelectEventName
  AS
BEGIN
	SELECT DISTINCT NAME FROM Events
	UNION
	SELECT DISTINCT NAME FROM Past_Events;
END
-------------------------------------------------------------------------------------------------------------------
GO
CREATE PROCEDURE SelectEventLocation
  AS
BEGIN
	SELECT Letter, Section_Number,Hall_Number FROM Events;
END
-------------------------------------------------------------------------------------------------------------------

CREATE PROCEDURE Check_Organizer_Username 
	@Username VARCHAR(15)
AS
BEGIN
SELECT PASSWORD
FROM Organizers
WHERE USERNAME = @Username
END
GO
------------------------------------------
-- To call the procedure 
EXEC Check_Organizer_Username @Username = 'Yahya_OL'
GO

-------------------------------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------------------------------

CREATE PROCEDURE Check_Bookseller_Username 
	@Username VARCHAR(15)
AS
BEGIN
SELECT PASSWORD
FROM Book_Seller
WHERE USERNAME = @Username
END
GO

SELECT * FROM Book_Seller
--------------------------------------------------------------------------------------------------------------------
--------------------------------------------------------------------------------------------------------------------

CREATE PROCEDURE Check_Media_Username 
	@Username VARCHAR(15)
AS
BEGIN
SELECT PASSWORD
FROM Media
WHERE USERNAME = @Username
END
GO


--------------------------------------------------------------------------------------------------------------------
--------------------------------------------------------------------------------------------------------------------

CREATE PROCEDURE Check_Ticket_reserver_Username 
	@Username VARCHAR(15)
AS
BEGIN
SELECT PASSWORD
FROM Ticket_Reserves
WHERE USERNAME = @Username
END
GO


--------------------------------------------------------------------------------------------------------------------
--------------------------------------------------------------------------------------------------------------------


CREATE PROCEDURE Check_Visitors_Username 
	@Username VARCHAR(15)
AS
BEGIN
SELECT PASSWORD
FROM Visitors
WHERE USERNAME = @Username
END
GO

-------------------------------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------------------------------


CREATE PROCEDURE Check_Volunter_Username 
	@Username VARCHAR(15)
AS
BEGIN
SELECT DPASSWORD
FROM Volunters
WHERE USERNAME = @Username
END
GO

--------------------------------------------------------------------------------------------------------------------
--------------------------------------------------------------------------------------------------------------------


GO
CREATE PROCEDURE Add_New_Organizer
	@FirstName VARCHAR(50), 
	@MidName VARCHAR(50), 
	@LastName VARCHAR(50), 
	@ID INT, 
	@National_ID BIGINT,
	@GENDER CHAR, 
	@PASSWORD VARCHAR(30), 
	@USERNAME VARCHAR(15)

AS
BEGIN
INSERT INTO Organizers (FirstName, MidName, LastName, ID, National_ID, GENDER, PASSWORD, USERNAME, Supervisor_ID, SALARY, Team_Name, Works_At_Event_code, Position)
VALUES (@FirstName, @MidName, @LastName, @ID, @National_ID, @GENDER, @PASSWORD, @USERNAME, 000000, NULL, 'Team 0', NULL, 'Worker');
END

--------------------------------------------------------------------------------------------------------------------
--------------------------------------------------------------------------------------------------------------------

GO
CREATE PROCEDURE Delete_Organizer
	@ID INT
AS
BEGIN
DELETE FROM Organizers WHERE ID = @ID 
END

--------------------------------------------------------------------------------------------------------------------
--------------------------------------------------------------------------------------------------------------------

GO
CREATE PROCEDURE Add_Organizer_Shifts
	@SHIFT_TIME_Start TIME, 
	@SHIFT_TIME_End TIME, 
	@Organizer_ID INT 	

AS
BEGIN
INSERT INTO Organizer_Shifts (SHIFT_TIME_Start, SHIFT_TIME_End, Organizer_ID)
VALUES (@SHIFT_TIME_Start, @SHIFT_TIME_End, @Organizer_ID);
END

--------------------------------------------------------------------------------------------------------------------
--------------------------------------------------------------------------------------------------------------------

GO
CREATE PROCEDURE Add_New_Bookseller
	@FirstName VARCHAR(50), 
	@MidName VARCHAR(50), 
	@LastName VARCHAR(50), 
	@ID INT, 
	@National_ID BIGINT,
	@GENDER CHAR, 
	@PASSWORD VARCHAR(30), 
	@USERNAME VARCHAR(15)

AS
BEGIN
INSERT INTO Book_Seller(FirstName, MidName, LastName, ID, National_ID, GENDER, PASSWORD, USERNAME, Supervisor_ID, SALARY, Position)
VALUES (@FirstName, @MidName, @LastName, @ID, @National_ID, @GENDER, @PASSWORD, @USERNAME, 100000, NULL, 'Worker');
END

--------------------------------------------------------------------------------------------------------------------
--------------------------------------------------------------------------------------------------------------------


GO
CREATE PROCEDURE Delete_BookSeller
	@ID INT
AS
BEGIN
DELETE FROM Book_Seller WHERE ID = @ID
END

--------------------------------------------------------------------------------------------------------------------
--------------------------------------------------------------------------------------------------------------------

GO
CREATE PROCEDURE Add_Book_Seller_Works_IN
	@Letter CHAR, 
	@Section_Number SMALLINT, 
	@Hall_Number SMALLINT, 
	@Bookseller_ID INT 	

AS
BEGIN
INSERT INTO Book_Seller_Works_IN(Letter, Section_Number, Hall_Number, Bookseller_ID)
VALUES (@Letter, @Section_Number, @Hall_Number, @Bookseller_ID);
END

--------------------------------------------------------------------------------------------------------------------
--------------------------------------------------------------------------------------------------------------------

GO
CREATE PROCEDURE Add_Book_Seller_Shifts
	@SHIFT_TIME_Start TIME, 
	@SHIFT_TIME_End TIME, 
	@Book_Seller_ID INT 	

AS
BEGIN
INSERT INTO Book_Seller_Shifts (SHIFT_TIME_Start, SHIFT_TIME_End, Book_Seller_ID)
VALUES (@SHIFT_TIME_Start, @SHIFT_TIME_End, @Book_Seller_ID);
END

--------------------------------------------------------------------------------------------------------------------
--------------------------------------------------------------------------------------------------------------------

GO
CREATE PROCEDURE Delete_Book_Seller_Shifts
	@ID INT,
	@SHIFT_TIME_Start TIME, 
	@SHIFT_TIME_End TIME
AS
BEGIN
DELETE FROM Book_Seller_Shifts WHERE Book_Seller_ID = @ID AND SHIFT_TIME_Start = @SHIFT_TIME_Start AND SHIFT_TIME_End = @SHIFT_TIME_End
END

--------------------------------------------------------------------------------------------------------------------
--------------------------------------------------------------------------------------------------------------------

GO
CREATE PROCEDURE Add_New_Media_man
	@FirstName VARCHAR(50), 
	@MidName VARCHAR(50), 
	@LastName VARCHAR(50), 
	@ID INT, 
	@National_ID BIGINT,
	@GENDER CHAR,
	@Channel_Name VARCHAR(30),
	@PASSWORD VARCHAR(30), 
	@USERNAME VARCHAR(15)

AS
BEGIN
INSERT INTO Media(FirstName, MidName, LastName, ID, National_ID, GENDER, Channel_Name, PASSWORD, USERNAME, Supervisor_ID, Event_Code, Position)
VALUES (@FirstName, @MidName, @LastName, @ID, @National_ID, @GENDER, @Channel_Name, @PASSWORD, @USERNAME, 300000, NULL, 'Worker');
END

--------------------------------------------------------------------------------------------------------------------
--------------------------------------------------------------------------------------------------------------------

GO
CREATE PROCEDURE Delete_Media_man
	@ID INT
AS
BEGIN
DELETE FROM Media WHERE ID = @ID
END

--------------------------------------------------------------------------------------------------------------------
--------------------------------------------------------------------------------------------------------------------

GO
CREATE PROCEDURE Add_Media_Shifts
	@SHIFT_TIME_Start TIME, 
	@SHIFT_TIME_End TIME, 
	@Media_ID INT 	

AS
BEGIN
INSERT INTO Media_Shifts (SHIFT_TIME_Start, SHIFT_TIME_End, Media_ID)
VALUES (@SHIFT_TIME_Start, @SHIFT_TIME_End, @Media_ID);
END

--------------------------------------------------------------------------------------------------------------------
--------------------------------------------------------------------------------------------------------------------

GO
CREATE PROCEDURE Add_New_Ticket_Reserver
	@FirstName VARCHAR(50), 
	@MidName VARCHAR(50), 
	@LastName VARCHAR(50), 
	@ID INT, 
	@National_ID BIGINT,
	@GENDER CHAR, 
	@PASSWORD VARCHAR(30), 
	@USERNAME VARCHAR(15)

AS
BEGIN
INSERT INTO Ticket_Reserves(FirstName, MidName, LastName, ID, National_ID, GENDER, PASSWORD, USERNAME, Supervisor_ID, SALARY, Position)
VALUES (@FirstName, @MidName, @LastName, @ID, @National_ID, @GENDER, @PASSWORD, @USERNAME, 000000, NULL, 'Worker');
END

--------------------------------------------------------------------------------------------------------------------
--------------------------------------------------------------------------------------------------------------------

GO
CREATE PROCEDURE Delete_Ticket_Reserve
	@ID INT
AS
BEGIN
DELETE FROM Ticket_Reserves WHERE ID = @ID
END


--------------------------------------------------------------------------------------------------------------------
--------------------------------------------------------------------------------------------------------------------


GO
CREATE PROCEDURE Add_Ticket_Reserver_Shifts
	@SHIFT_TIME_Start TIME, 
	@SHIFT_TIME_End TIME, 
	@Ticket_Reserve_ID INT 	

AS
BEGIN
INSERT INTO Ticket_Reserve_Shifts (SHIFT_TIME_Start, SHIFT_TIME_End, Ticket_Reserve_ID)
VALUES (@SHIFT_TIME_Start, @SHIFT_TIME_End, @Ticket_Reserve_ID);
END

--------------------------------------------------------------------------------------------------------------------
--------------------------------------------------------------------------------------------------------------------

GO
CREATE PROCEDURE Add_New_Volanteer
	@FirstName VARCHAR(50), 
	@MidName VARCHAR(50), 
	@LastName VARCHAR(50), 
	@ID INT, 
	@National_ID BIGINT,
	@GENDER CHAR, 
	@PASSWORD VARCHAR(30), 
	@USERNAME VARCHAR(15)

AS
BEGIN
INSERT INTO Volunters(FirstName, MidName, LastName, ID, NationalID, GENDER, DPASSWORD, USERNAME, Supervisor_ID, SALARY, Event_Code, Position, CATEGORY)
VALUES (@FirstName, @MidName, @LastName, @ID, @National_ID, @GENDER, @PASSWORD, @USERNAME, 000000, NULL, NULL, 'Worker', NULL);
END

--------------------------------------------------------------------------------------------------------------------
--------------------------------------------------------------------------------------------------------------------

GO
CREATE PROCEDURE Delete_Volunter
	@ID INT
AS
BEGIN
DELETE FROM Volunters WHERE ID = @ID
END

--------------------------------------------------------------------------------------------------------------------
--------------------------------------------------------------------------------------------------------------------


GO
CREATE PROCEDURE Add_Volanteer_Shifts
	@SHIFT_TIME_Start TIME, 
	@SHIFT_TIME_End TIME, 
	@Volunter_ID INT 	

AS
BEGIN
INSERT INTO Volunter_Shift (SHIFT_TIME_Start, SHIFT_TIME_End, Volunter_ID)
VALUES (@SHIFT_TIME_Start, @SHIFT_TIME_End, @Volunter_ID);
END

--------------------------------------------------------------------------------------------------------------------
--------------------------------------------------------------------------------------------------------------------

GO
CREATE PROCEDURE Add_New_Visitor
	@FirstName VARCHAR(50), 
	@MidName VARCHAR(50), 
	@LastName VARCHAR(50), 
	@ID INT, 
	@GENDER CHAR, 
	@PASSWORD VARCHAR(30), 
	@USERNAME VARCHAR(15),
	@Birth_Date Date,
	@Attendance INT

AS
BEGIN
INSERT INTO Visitors(FirstName, MidName, LastName, ID, GENDER, PASSWORD, USERNAME, Birth_Date, Attendance)
VALUES (@FirstName, @MidName, @LastName, @ID, @GENDER, @PASSWORD, @USERNAME, @Birth_Date, @Attendance);
END

select * from Visitors

--------------------------------------------------------------------------------------------------------------------
--------------------------------------------------------------------------------------------------------------------

GO
CREATE PROCEDURE Delete_Visitor
	@ID INT
AS
BEGIN
DELETE FROM Visitors WHERE ID = @ID
END

--------------------------------------------------------------------------------------------------------------------
--------------------------------------------------------------------------------------------------------------------

CREATE PROCEDURE Recover_Organizer_Password
	@Username VARCHAR(15)
AS
BEGIN
SELECT PASSWORD, ID
FROM Organizers
WHERE USERNAME = @Username
END
GO
------------------------------------------
-- To call the procedure 
EXEC Recover_Organizer_Password @Username = 'Yahya_Mohamed'
GO

--------------------------------------------------------------------------------------------------------------------
--------------------------------------------------------------------------------------------------------------------

CREATE PROCEDURE Recover_Bookseller_Password
	@Username VARCHAR(15)
AS
BEGIN
SELECT PASSWORD, ID
FROM Book_Seller
WHERE USERNAME = @Username
END
GO

--------------------------------------------------------------------------------------------------------------------
--------------------------------------------------------------------------------------------------------------------

CREATE PROCEDURE Recover_Media_man_Password
	@Username VARCHAR(15)
AS
BEGIN
SELECT PASSWORD, ID
FROM Media
WHERE USERNAME = @Username
END
GO

--------------------------------------------------------------------------------------------------------------------
--------------------------------------------------------------------------------------------------------------------

CREATE PROCEDURE Recover_Ticket_Reserves_Password
	@Username VARCHAR(15)
AS
BEGIN
SELECT PASSWORD, ID
FROM Ticket_Reserves
WHERE USERNAME = @Username
END
GO

--------------------------------------------------------------------------------------------------------------------
--------------------------------------------------------------------------------------------------------------------

CREATE PROCEDURE Recover_Visitor_Password
	@Username VARCHAR(15)
AS
BEGIN
SELECT PASSWORD, ID
FROM Visitors
WHERE USERNAME = @Username
END
GO

--------------------------------------------------------------------------------------------------------------------
--------------------------------------------------------------------------------------------------------------------

CREATE PROCEDURE Recover_Volunters_Password
	@Username VARCHAR(15)
AS
BEGIN
SELECT DPASSWORD, ID
FROM Volunters
WHERE USERNAME = @Username
END
GO

--------------------------------------------------------------------------------------------------------------------
--------------------------------------------------------------------------------------------------------------------

CREATE PROCEDURE Is_ID_Organizers_Unique
	@ID VARCHAR(30)
AS
BEGIN
SELECT USERNAME
FROM Organizers
WHERE ID = @ID
END
GO
------------------------------------------
-- To call the procedure 
EXEC Is_ID_Organizers_Unique @ID = '1'
GO

--------------------------------------------------------------------------------------------------------------------
--------------------------------------------------------------------------------------------------------------------

CREATE PROCEDURE Is_ID_Bookseller_Unique
	@ID VARCHAR(30)
AS
BEGIN
SELECT USERNAME
FROM Book_Seller
WHERE ID = @ID
END
GO

--------------------------------------------------------------------------------------------------------------------
--------------------------------------------------------------------------------------------------------------------

CREATE PROCEDURE Is_ID_Media_Man_Unique
	@ID VARCHAR(30)
AS
BEGIN
SELECT USERNAME
FROM Media
WHERE ID = @ID
END
GO

--------------------------------------------------------------------------------------------------------------------
--------------------------------------------------------------------------------------------------------------------

CREATE PROCEDURE Is_ID_Ticket_Reserves_Unique
	@ID VARCHAR(30)
AS
BEGIN
SELECT USERNAME
FROM Ticket_Reserves
WHERE ID = @ID
END
GO

--------------------------------------------------------------------------------------------------------------------
--------------------------------------------------------------------------------------------------------------------

CREATE PROCEDURE Is_ID_Visitors_Unique
	@ID VARCHAR(30)
AS
BEGIN
SELECT USERNAME
FROM Visitors
WHERE ID = @ID
END
GO

--------------------------------------------------------------------------------------------------------------------
--------------------------------------------------------------------------------------------------------------------

CREATE PROCEDURE Is_ID_Volunters_Unique
	@ID VARCHAR(30)
AS
BEGIN
SELECT USERNAME
FROM Volunters
WHERE ID = @ID
END
GO

--------------------------------------------------------------------------------------------------------------------
--------------------------------------------------------------------------------------------------------------------

CREATE PROCEDURE Is_National_ID_Unique
	@NID BIGINT
AS
BEGIN
SELECT USERNAME FROM Volunters
WHERE NationalID = @NID
UNION
SELECT USERNAME FROM Book_Seller
WHERE National_ID = @NID
UNION
SELECT USERNAME FROM Media
WHERE National_ID = @NID
UNION
SELECT USERNAME FROM Organizers
WHERE National_ID = @NID
UNION
SELECT USERNAME FROM Ticket_Reserves
WHERE National_ID = @NID
END
GO
------------------------------------------
-- To call the procedure 
EXEC Is_National_ID_Unique @NID = 26842687940
EXEC Is_National_ID_Unique @NID = 30201648759231
GO

--------------------------------------------------------------------------------------------------------------------
--------------------------------------------------------------------------------------------------------------------

CREATE PROCEDURE Is_Phone_Number_Unique
	@PhoneNum INT
AS
BEGIN
SELECT Volunter_ID FROM Volunter_Phone
WHERE PhoneNum = @PhoneNum
UNION
SELECT Book_Seller_ID FROM Book_Seller_Phones
WHERE PhoneNum = @PhoneNum
UNION
SELECT Media_ID FROM Media_Phones
WHERE PhoneNum = @PhoneNum
UNION
SELECT Organizer_ID FROM Organizer_Phones
WHERE PhoneNum = @PhoneNum
UNION
SELECT Ticket_Reserve_ID FROM Ticket_Reserve_Phones
WHERE Phone_Number = @PhoneNum
UNION
SELECT Visitor_ID FROM Visitor_Phones
WHERE Phone_Number = @PhoneNum
END
GO
------------------------------------------
-- To call the procedure 
EXEC Is_Phone_Number_Unique @PhoneNum = 1235469182
EXEC Is_Phone_Number_Unique @PhoneNum = 1036429418
GO

--------------------------------------------------------------------------------------------------------------------
--------------------------------------------------------------------------------------------------------------------

CREATE PROCEDURE Is_Ticket_Used
	@Serial_Number INT
AS
BEGIN
SELECT Visitor_ID FROM Used_Tickets
WHERE Serial_Number = @Serial_Number
END
GO
------------------------------------------
-- To call the procedure 
EXEC Is_Ticket_Used @Serial_Number = 654321

--------------------------------------------------------------------------------------------------------------------
--------------------------------------------------------------------------------------------------------------------

CREATE PROCEDURE Is_Bookseller_Unique
	@UserName VARCHAR(30)
AS
BEGIN
SELECT ID
FROM Book_Seller
WHERE USERNAME = @UserName
END
GO

--------------------------------------------------------------------------------------------------------------------
--------------------------------------------------------------------------------------------------------------------

CREATE PROCEDURE Is_Media_Man_Unique
	@UserName VARCHAR(30)
AS
BEGIN
SELECT ID
FROM Media
WHERE USERNAME = @UserName
END
GO

--------------------------------------------------------------------------------------------------------------------
--------------------------------------------------------------------------------------------------------------------

CREATE PROCEDURE Is_Organizers_Unique
	@UserName VARCHAR(30)
AS
BEGIN
SELECT ID
FROM Organizers
WHERE USERNAME = @UserName
END
GO

--------------------------------------------------------------------------------------------------------------------
--------------------------------------------------------------------------------------------------------------------

CREATE PROCEDURE Is_Ticket_Reserves_Unique
	@UserName VARCHAR(30)
AS
BEGIN
SELECT ID
FROM Ticket_Reserves
WHERE USERNAME = @UserName
END
GO

--------------------------------------------------------------------------------------------------------------------
--------------------------------------------------------------------------------------------------------------------

CREATE PROCEDURE Is_Visitors_Unique
	@UserName VARCHAR(30)
AS
BEGIN
SELECT ID
FROM Visitors
WHERE USERNAME = @UserName
END
GO

--------------------------------------------------------------------------------------------------------------------
--------------------------------------------------------------------------------------------------------------------

CREATE PROCEDURE Is_Volunters_Unique
	@UserName VARCHAR(30)
AS
BEGIN
SELECT ID
FROM Volunters
WHERE USERNAME = @UserName
END
GO

----------------------------------------------------------------------------------------------------------------------
----------------------------------------------------------------------------------------------------------------------

GO
CREATE PROCEDURE Use_Ticket
	@Serial_Number INT, 
	@Visitor_ID INT,
	@Time_Used_in DATETIME

AS
BEGIN
INSERT INTO Used_Tickets(Serial_Number, Visitor_ID, Time_Used_in)
VALUES (@Serial_Number, @Visitor_ID, @Time_Used_in);
END

------------------------------------------
-- To call the procedure 
EXEC Use_Ticket @Serial_Number = 123456, @Visitor_ID = 500000, @Time_Used_in = '2022-07-28 14:42:56'
GO

--------------------------------------------------------------------------------------------------------------------
--------------------------------------------------------------------------------------------------------------------

GO
CREATE PROCEDURE Add_Organizer_Phone
	@PhoneNumber INT, 
	@ID INT

AS
BEGIN
INSERT INTO Organizer_Phones(PhoneNum, Organizer_ID)
VALUES (@PhoneNumber, @ID);
END

--------------------------------------------------------------------------------------------------------------------
--------------------------------------------------------------------------------------------------------------------

GO
CREATE PROCEDURE Delete_Organizer_Phone
	@ID INT,
	@PhoneNumber INT
AS
BEGIN
DELETE FROM Organizer_Phones WHERE Organizer_ID = @ID AND PhoneNum = @PhoneNumber
END


------------------------------------------
-- To call the procedure 
EXEC Add_Organizer_Phone @PhoneNumber = 1202006004, @ID = 1
GO

---------------------------------------------------------------------------------------------------------------------
---------------------------------------------------------------------------------------------------------------------

GO
CREATE PROCEDURE Add_Ticket_Reserve_Phone
	@PhoneNumber INT, 
	@ID INT

AS
BEGIN
INSERT INTO Ticket_Reserve_Phones(Phone_Number, Ticket_Reserve_ID)
VALUES (@PhoneNumber, @ID);
END

--------------------------------------------------------------------------------------------------------------------
--------------------------------------------------------------------------------------------------------------------

GO
CREATE PROCEDURE Delete_Ticket_Reserve_Phone
	@ID INT,
	@PhoneNumber INT
AS
BEGIN
DELETE FROM Ticket_Reserve_Phones WHERE Ticket_Reserve_ID = @ID AND Phone_Number = @PhoneNumber
END

---------------------------------------------------------------------------------------------------------------------
---------------------------------------------------------------------------------------------------------------------

GO
CREATE PROCEDURE Add_Book_Seller_Phones
	@PhoneNumber INT, 
	@ID INT

AS
BEGIN
INSERT INTO Book_Seller_Phones(PhoneNum, Book_Seller_ID)
VALUES (@PhoneNumber, @ID);
END

--------------------------------------------------------------------------------------------------------------------
--------------------------------------------------------------------------------------------------------------------

GO
CREATE PROCEDURE Delete_Bookseller_Phone
	@ID INT,
	@PhoneNumber INT
AS
BEGIN
DELETE FROM Book_Seller_Phones WHERE Book_Seller_ID = @ID AND PhoneNum = @PhoneNumber
END

---------------------------------------------------------------------------------------------------------------------
---------------------------------------------------------------------------------------------------------------------

GO
CREATE PROCEDURE Add_Media_Phone
	@PhoneNumber INT, 
	@ID INT

AS
BEGIN
INSERT INTO Media_Phones(PhoneNum, Media_ID)
VALUES (@PhoneNumber, @ID);
END

--------------------------------------------------------------------------------------------------------------------
--------------------------------------------------------------------------------------------------------------------

GO
CREATE PROCEDURE Delete_Media_Phones
	@ID INT,
	@PhoneNumber INT
AS
BEGIN
DELETE FROM Media_Phones WHERE Media_ID = @ID AND PhoneNum = @PhoneNumber
END

---------------------------------------------------------------------------------------------------------------------
---------------------------------------------------------------------------------------------------------------------

GO
CREATE PROCEDURE Add_Visitor_Phones
	@PhoneNumber INT, 
	@ID INT

AS
BEGIN
INSERT INTO Visitor_Phones(Phone_Number, Visitor_ID)
VALUES (@PhoneNumber, @ID);
END

--------------------------------------------------------------------------------------------------------------------
--------------------------------------------------------------------------------------------------------------------

GO
CREATE PROCEDURE Delete_Visitor_Phones
	@ID INT,
	@PhoneNumber INT
AS
BEGIN
DELETE FROM Visitor_Phones WHERE Visitor_ID = @ID AND Phone_Number = @PhoneNumber
END

---------------------------------------------------------------------------------------------------------------------
---------------------------------------------------------------------------------------------------------------------

GO
CREATE PROCEDURE Add_Volunter_Phones
	@PhoneNumber INT, 
	@ID INT

AS
BEGIN
INSERT INTO Volunter_Phone(PhoneNum, Volunter_ID)
VALUES (@PhoneNumber, @ID);
END

--------------------------------------------------------------------------------------------------------------------
--------------------------------------------------------------------------------------------------------------------

GO
CREATE PROCEDURE Delete_Volunter_Phones
	@ID INT,
	@PhoneNumber INT
AS
BEGIN
DELETE FROM Volunter_Phone WHERE Volunter_ID = @ID AND PhoneNum = @PhoneNumber
END

--------------------------------------------------------------------------------------------------------------------
--------------------------------------------------------------------------------------------------------------------

CREATE PROCEDURE Select_All_Interests
  AS
BEGIN
	SELECT Interest FROM Interests;
END

--------------------------------------------------------------------------------------------------------------------
--------------------------------------------------------------------------------------------------------------------

GO
CREATE PROCEDURE Add_Visitor_Interest
	@Interest VARCHAR(50), 
	@Visitor_ID INT

AS
BEGIN
INSERT INTO Visitor_Interest(Interest, Visitor_ID)
VALUES (@Interest, @Visitor_ID);
END

--===============================================================================================================================

GO
CREATE PROCEDURE Add_New_Interest
	@Interest VARCHAR(50)

AS
BEGIN
INSERT INTO Interests(Interest)
VALUES (@Interest);
END

--===============================================================================================================================

CREATE PROCEDURE Is_Visitor_Interest_Exists
	@Interest VARCHAR(50),
	@Visitor_ID INT
AS
BEGIN
SELECT COUNT(Visitor_ID)
FROM Visitor_Interest
WHERE Interest = @Interest AND Visitor_ID = @Visitor_ID
END
GO

-----------------------------------------
-- To call the procedure
EXEC Is_Visitor_Interest_Exists @Interest = 'MATH', @Visitor_ID = 500001

select * from Visitor_Interest;

--===============================================================================================================================

CREATE PROCEDURE Is_Interest_Exists
	@Interest VARCHAR(50)

AS
BEGIN
SELECT  COUNT(Interest)
FROM Interests
WHERE Interest = @Interest
END
GO

-----------------------------------------
-- To call the procedure
EXEC Is_Interest_Exists @Interest = 'MATH'

--================================================================================================================================



CREATE PROCEDURE get_Visitor_ID
	@USERNAME VARCHAR(30)
AS
BEGIN
SELECT ID
FROM Visitors
WHERE USERNAME = @USERNAME
END
GO

--------------------------------------------------------------------------------------------------------------------
--------------------------------------------------------------------------------------------------------------------

CREATE PROCEDURE Update_Visitor_atendance_Number
	@ID INT
AS
BEGIN
UPDATE Visitors SET Attendance = Attendance + 1 WHERE ID = @ID;
END
GO

--------------------------------------------------------------------------------------------------------------------
--------------------------------------------------------------------------------------------------------------------

GO
CREATE PROCEDURE get_Organizer_ID 
	@Username VARCHAR(15)
AS
BEGIN
SELECT ID
FROM Organizers
WHERE USERNAME = @Username
END
GO

EXEC get_Organizer_ID @Username = 'Yahya_OL'

--------------------------------------------------------------------------------------------------------------------
--------------------------------------------------------------------------------------------------------------------

GO
CREATE PROCEDURE get_Bookseller_ID 
	@Username VARCHAR(15)
AS
BEGIN
SELECT ID
FROM Book_Seller
WHERE USERNAME = @Username
END

--------------------------------------------------------------------------------------------------------------------
--------------------------------------------------------------------------------------------------------------------

GO
CREATE PROCEDURE get_Media_Man_ID 
	@Username VARCHAR(15)
AS
BEGIN
SELECT ID
FROM Media
WHERE USERNAME = @Username
END
GO

--------------------------------------------------------------------------------------------------------------------
--------------------------------------------------------------------------------------------------------------------

CREATE PROCEDURE get_Ticket_reserver_ID 
	@Username VARCHAR(15)
AS
BEGIN
SELECT ID
FROM Ticket_Reserves
WHERE USERNAME = @Username
END
GO

--------------------------------------------------------------------------------------------------------------------
--------------------------------------------------------------------------------------------------------------------

CREATE PROCEDURE get_Volunteer_ID 
	@Username VARCHAR(15)
AS
BEGIN
SELECT ID
FROM Volunters
WHERE USERNAME = @Username
END
GO

--------------------------------------------------------------------------------------------------------------------
--------------------------------------------------------------------------------------------------------------------

GO
CREATE PROCEDURE Select_Bookseller_All_PhoneNumbers
	@ID INT  
AS
BEGIN
	SELECT PhoneNum FROM Book_Seller_Phones WHERE Book_Seller_ID = @ID;
END

EXEC Select_Bookseller_All_PhoneNumbers @ID = 100001

--------------------------------------------------------------------------------------------------------------------
--------------------------------------------------------------------------------------------------------------------

GO
CREATE PROCEDURE Select_Media_Man_All_PhoneNumbers
	@ID INT  
AS
BEGIN
	SELECT PhoneNum FROM Media_Phones WHERE Media_ID = @ID;
END

EXEC Select_Media_Man_All_PhoneNumbers @ID = 300001

--------------------------------------------------------------------------------------------------------------------
--------------------------------------------------------------------------------------------------------------------

GO
CREATE PROCEDURE Select_Organizer_All_PhoneNumbers
	@ID INT  
AS
BEGIN
	SELECT PhoneNum FROM Organizer_Phones WHERE Organizer_ID = @ID;
END

EXEC Select_Organizer_All_PhoneNumbers @ID = 000001

--------------------------------------------------------------------------------------------------------------------
--------------------------------------------------------------------------------------------------------------------

GO
CREATE PROCEDURE Select_Ticket_Reserver_All_PhoneNumbers
	@ID INT  
AS
BEGIN
	SELECT Phone_Number FROM Ticket_Reserve_Phones WHERE Ticket_Reserve_ID = @ID;
END

EXEC Select_Ticket_Reserver_All_PhoneNumbers @ID = 200001

--------------------------------------------------------------------------------------------------------------------
--------------------------------------------------------------------------------------------------------------------

GO
CREATE PROCEDURE Select_Visitor_All_PhoneNumbers
	@ID INT  
AS
BEGIN
	SELECT Phone_Number FROM Visitor_Phones WHERE Visitor_ID = @ID;
END

EXEC Select_Visitor_All_PhoneNumbers @ID = 500001

--------------------------------------------------------------------------------------------------------------------
--------------------------------------------------------------------------------------------------------------------

GO
CREATE PROCEDURE Select_Volunteer_All_PhoneNumbers
	@ID INT  
AS
BEGIN
	SELECT PhoneNum FROM Volunter_Phone WHERE Volunter_ID = @ID;
END

EXEC Select_Volunteer_All_PhoneNumbers @ID = 400000
select * from Volunter_Phone
--------------------------------------------------------------------------------------------------------------------
--------------------------------------------------------------------------------------------------------------------

CREATE PROCEDURE Is_Bookseller_PhoneNumber_Exists
	@PhoneNum VARCHAR(50)

AS
BEGIN
SELECT  COUNT(PhoneNum)
FROM Book_Seller_Phones
WHERE PhoneNum = @PhoneNum
END
GO

-----------------------------------------
-- To call the procedure
EXEC Is_Bookseller_PhoneNumber_Exists @PhoneNum = 1202006004
select * from Book_Seller_Phones;

--------------------------------------------------------------------------------------------------------------------
--------------------------------------------------------------------------------------------------------------------

CREATE PROCEDURE Is_Volunteer_PhoneNumber_Exists
	@PhoneNum VARCHAR(50)

AS
BEGIN
SELECT  COUNT(PhoneNum)
FROM Volunter_Phone
WHERE PhoneNum = @PhoneNum
END
GO

--------------------------------------------------------------------------------------------------------------------
--------------------------------------------------------------------------------------------------------------------

CREATE PROCEDURE Is_Media_Man_PhoneNumber_Exists
	@PhoneNum VARCHAR(50)

AS
BEGIN
SELECT  COUNT(PhoneNum)
FROM Media_Phones
WHERE PhoneNum = @PhoneNum
END
GO

--------------------------------------------------------------------------------------------------------------------
--------------------------------------------------------------------------------------------------------------------

CREATE PROCEDURE Is_Organizer_PhoneNumber_Exists
	@PhoneNum VARCHAR(50)

AS
BEGIN
SELECT  COUNT(PhoneNum)
FROM Organizer_Phones
WHERE PhoneNum = @PhoneNum
END
GO

--------------------------------------------------------------------------------------------------------------------
--------------------------------------------------------------------------------------------------------------------

CREATE PROCEDURE Is_Ticket_Reserver_PhoneNumber_Exists
	@PhoneNum VARCHAR(50)

AS
BEGIN
SELECT  COUNT(Phone_Number)
FROM Ticket_Reserve_Phones
WHERE Phone_Number = @PhoneNum
END
GO

--------------------------------------------------------------------------------------------------------------------
--------------------------------------------------------------------------------------------------------------------

CREATE PROCEDURE Is_Visitor_PhoneNumber_Exists
	@PhoneNum VARCHAR(50)

AS
BEGIN
SELECT  COUNT(Phone_Number)
FROM Visitor_Phones
WHERE Phone_Number = @PhoneNum
END
GO

--------------------------------------------------------------------------------------------------------------------
--------------------------------------------------------------------------------------------------------------------

GO
CREATE PROCEDURE Change_Volunteer_Password
	@ID INT,
	@OLDPassword VARCHAR(30),
	@NEWPassword VARCHAR(30)
AS
BEGIN
	UPDATE Volunters SET DPASSWORD = @NEWPassword WHERE ID = @ID AND DPASSWORD = @OLDPassword
END

EXEC Change_Volunteer_Password @ID = 400000, @OLDPassword = 'SUCCESS', @NEWPassword = 'YAHYA_VL@123'
select * from Volunters

--------------------------------------------------------------------------------------------------------------------
--------------------------------------------------------------------------------------------------------------------

GO
CREATE PROCEDURE Change_Bookseller_Password
	@ID INT,
	@OLDPassword VARCHAR(30),
	@NEWPassword VARCHAR(30)
AS
BEGIN
	UPDATE Book_Seller SET PASSWORD = @NEWPassword WHERE ID = @ID AND PASSWORD = @OLDPassword
END

--------------------------------------------------------------------------------------------------------------------
--------------------------------------------------------------------------------------------------------------------

GO
CREATE PROCEDURE Change_Media_Man_Password
	@ID INT,
	@OLDPassword VARCHAR(30),
	@NEWPassword VARCHAR(30)
AS
BEGIN
	UPDATE Media SET PASSWORD = @NEWPassword WHERE ID = @ID AND PASSWORD = @OLDPassword
END

--------------------------------------------------------------------------------------------------------------------
--------------------------------------------------------------------------------------------------------------------

GO
CREATE PROCEDURE Change_Organizer_Password
	@ID INT,
	@OLDPassword VARCHAR(30),
	@NEWPassword VARCHAR(30)
AS
BEGIN
	UPDATE Organizers SET PASSWORD = @NEWPassword WHERE ID = @ID AND PASSWORD = @OLDPassword
END

--------------------------------------------------------------------------------------------------------------------
--------------------------------------------------------------------------------------------------------------------

GO
CREATE PROCEDURE Change_Ticket_Reserver_Password
	@ID INT,
	@OLDPassword VARCHAR(30),
	@NEWPassword VARCHAR(30)
AS
BEGIN
	UPDATE Ticket_Reserves SET PASSWORD = @NEWPassword WHERE ID = @ID AND PASSWORD = @OLDPassword
END

--------------------------------------------------------------------------------------------------------------------
--------------------------------------------------------------------------------------------------------------------

GO
CREATE PROCEDURE Change_Visitor_Password
	@ID INT,
	@OLDPassword VARCHAR(30),
	@NEWPassword VARCHAR(30)
AS
BEGIN
	UPDATE Visitors SET PASSWORD = @NEWPassword WHERE ID = @ID AND PASSWORD = @OLDPassword
END

--------------------------------------------------------------------------------------------------------------------
--------------------------------------------------------------------------------------------------------------------

GO
CREATE PROCEDURE get_Volunteer
	@ID INT
AS
BEGIN
SELECT * FROM Volunters WHERE ID = @ID
END

EXEC get_Volunteer 400000

--------------------------------------------------------------------------------------------------------------------
--------------------------------------------------------------------------------------------------------------------

CREATE PROCEDURE get_User_Name
	@ID INT
AS
BEGIN
SELECT FirstName, MidName, LastName FROM Volunters
WHERE ID = @ID
UNION
SELECT FirstName, MidName, LastName FROM Book_Seller
WHERE ID = @ID
UNION
SELECT FirstName, MidName, LastName FROM Media
WHERE ID = @ID
UNION
SELECT FirstName, MidName, LastName FROM Organizers
WHERE ID = @ID
UNION
SELECT FirstName, MidName, LastName FROM Ticket_Reserves
WHERE ID = @ID
END
GO
------------------------------------------
-- To call the procedure 
EXEC get_User_Name @ID = 400000
GO

--------------------------------------------------------------------------------------------------------------------
--------------------------------------------------------------------------------------------------------------------

CREATE PROCEDURE Update_Volunteer_Info
	@ID INT,
	@FName VARCHAR (30),
	@MName VARCHAR (30),
	@LName VARCHAR (30),
	@Username VARCHAR (30),
	@GENDER CHAR
AS
BEGIN
UPDATE Volunters SET FirstName = @FName, MidName = @MName, LastName = @LName, USERNAME = @Username, GENDER = @GENDER WHERE ID = @ID;
END
GO

EXEC  Update_Volunteer_Info @ID = 400000, @FName = YAHYA, @MName = ASHRAF, @LName = MOHAMED, @Username = YAHYA_VL, @GENDER = 'M'

--------------------------------------------------------------------------------------------------------------------
--------------------------------------------------------------------------------------------------------------------

GO
CREATE PROCEDURE get_Volunteer_Shifts
	@ID INT
AS
BEGIN
SELECT SHIFT_TIME_Start, SHIFT_TIME_End FROM Volunter_Shift WHERE Volunter_ID = @ID
END

EXEC get_Volunteer_Shifts 400000

--------------------------------------------------------------------------------------------------------------------
--------------------------------------------------------------------------------------------------------------------
CREATE PROCEDURE Count_Num_volunteer_phone
	@ID INT
AS
BEGIN
SELECT COUNT(PhoneNum)
FROM Volunter_Phone
WHERE Volunter_ID = @ID
END
GO
--------------------------------------------------------------------------------------------------------------------
--------------------------------------------------------------------------------------------------------------------

CREATE PROCEDURE Count_Num_volunteer_shifts
	@ID INT
AS
BEGIN
SELECT COUNT(SHIFT_TIME_Start)
FROM Volunter_Shift
WHERE Volunter_ID = @ID
END
GO

--------------------------------------------------------------------------------------------------------------------
--------------------------------------------------------------------------------------------------------------------
GO
CREATE PROCEDURE get_Event
	@Code INT
AS
BEGIN
SELECT * FROM Events WHERE Code = @Code
UNION
SELECT * FROM Past_Events WHERE Code = @Code
END

EXEC get_Event 1234

--------------------------------------------------------------------------------------------------------------------
--------------------------------------------------------------------------------------------------------------------

GO
CREATE PROCEDURE get_Booths_Location_Letter
AS
BEGIN
SELECT DISTINCT Letter FROM Booth
END

EXEC get_Booths_Location_Letter

--------------------------------------------------------------------------------------------------------------------
--------------------------------------------------------------------------------------------------------------------

GO
CREATE PROCEDURE get_Booths_Location_Hall
AS
BEGIN
SELECT DISTINCT Hall_Number FROM Booth
END

--------------------------------------------------------------------------------------------------------------------
--------------------------------------------------------------------------------------------------------------------

GO
CREATE PROCEDURE get_Booths_Location_Section
AS
BEGIN
SELECT DISTINCT Section_Number FROM Booth
END

--------------------------------------------------------------------------------------------------------------------
--------------------------------------------------------------------------------------------------------------------

GO
CREATE PROCEDURE get_Volanteer_Worked_Event
	@ID INT,
	@Event_Code SMALLINT
AS
BEGIN
SELECT DISTINCT Event_Code FROM Volunters_Past_Events
WHERE Event_Code = @Event_Code AND Volunter_ID = @ID
END

EXEC get_Volanteer_Worked_Event @Event_Code = 1817, @ID = 400007

--------------------------------------------------------------------------------------------------------------------
--------------------------------------------------------------------------------------------------------------------

GO
CREATE PROCEDURE get_Event_Code_ByName
	@Event_Name VARCHAR(30)
AS
BEGIN
SELECT DISTINCT Code FROM Past_Events
WHERE NAME = @Event_Name
UNION
SELECT  DISTINCT Code FROM Events
WHERE  NAME = @Event_Name
END

EXEC get_Event_Code_ByName @Event_Name = 'Physic'


--------------------------------------------------------------------------------------------------------------------
--------------------------------------------------------------------------------------------------------------------

GO
CREATE PROCEDURE get_Event_Code_ByLocation
	@Letter CHAR,
	@Hall SMALLINT,
	@Section SMALLINT

AS
BEGIN
SELECT DISTINCT Code FROM Past_Events
WHERE Letter = @Letter AND Hall_Number = @Hall AND Section_Number = @Section
UNION
SELECT DISTINCT Code FROM Events
WHERE Letter = @Letter AND Hall_Number = @Hall AND Section_Number = @Section
END

EXEC get_Event_Code_ByLocation @Letter = 'B', @Hall = 1, @Section =1

--------------------------------------------------------------------------------------------------------------------
--------------------------------------------------------------------------------------------------------------------

GO
CREATE PROCEDURE get_Event_Code_ByTime
	@Date DATE
AS
BEGIN
SELECT DISTINCT Code FROM Past_Events
WHERE Event_Date = @Date
UNION
SELECT DISTINCT Code FROM Events
WHERE Event_Date = @Date
END

EXEC get_Event_Code_ByTime @Date = '2021-06-25'


--------------------------------------------------------------------------------------------------------------------
--------------------------------------------------------------------------------------------------------------------

GO
CREATE PROCEDURE get_Volanteer_Past_Activity
	@Code INT,
	@ID INT
AS
BEGIN
SELECT Code AS 'Event Code', NAME AS 'Event Name', Subject, Leader_ID AS 'Event Manager',
	   Volunter_Supervisor_ID AS 'Leader_ID', Total_Worked_Hours AS 'Worked Hours', SALARY AS 'Salary', Position AS 'Position', Category AS 'Worked As',
	   Event_Date AS 'Event Date', Start_time AS 'Event Start Time', End_time AS 'Event End Time'
FROM Past_Events
FULL JOIN Volunters_Past_Events 
ON Past_Events.Code = Volunters_Past_Events.Event_Code
WHERE Past_Events.Code = @Code AND Volunters_Past_Events.Volunter_ID = @ID
END

EXEC get_Volanteer_Past_Activity @CODE = 4652, @ID = 400000

--------------------------------------------------------------------------------------------------------------------
--------------------------------------------------------------------------------------------------------------------

GO
CREATE PROCEDURE get_ALL_Volanteer_Past_Activity
	@ID INT
AS
BEGIN
SELECT Code AS 'Event Code', NAME AS 'Event Name', Subject, Leader_ID AS 'Event Manager',
	   Volunter_Supervisor_ID AS 'Leader_ID', Total_Worked_Hours AS 'Worked Hours', SALARY AS 'Salary', Position AS 'Position', Category AS 'Worked As',
	   Event_Date AS 'Event Date', Start_time AS 'Event Start Time', End_time AS 'Event End Time'
FROM Past_Events
FULL JOIN Volunters_Past_Events 
ON Past_Events.Code = Volunters_Past_Events.Event_Code
WHERE Volunters_Past_Events.Volunter_ID = @ID
END

--------------------------------------------------------------------------------------------------------------------
--------------------------------------------------------------------------------------------------------------------
























select * from Past_Events
select * from Volunters_Past_Events

































SELECT * FROM Volunters_Past_Events
select * from Volunters
select * from Book_Seller
select * from Visitors
select * from Media
select * from Ticket_Reserves
select * from Organizers
select * from Visitor_Phones
select * from Media_Phones


-------------------------------------------------tryed----------------------------------

--CREATE PROCEDURE CheckPassword
--    @Username VARCHAR(15),
--    @Password VARCHAR(30)
--AS
--BEGIN

--SET NOCOUNT ON

--SELECT CASE WHEN EXISTS(SELECT NULL FROM Organizer WHERE USERNAME = @Username AND PASSWORD = @Password)
--    THEN CAST(1 AS BIT)
--    ELSE CAST(0 AS BIT)
--END

--END

--select * from Organizers

-----------------------------------------------
--CREATE PROCEDURE test 
--    @Username VARCHAR(15),
--	@password VARCHAR(30)
--AS 
--IF (SELECT PASSWORD
--FROM Organizers
--where USERNAME = @Username) IS NULL
--Return 0
--else
--BEGIN
--IF (SELECT ID
--FROM Organizers
--where PASSWORD = @password) IS NULL
--Return 0
--END
--else
--Return 1
--GO

------------------------------------------------------
--GO
--CREATE PROCEDURE Is_ID_Organizer_unique
--	@ID SMALLINT, 
--	@found SMALLINT OUTPUT
--AS
--BEGIN
--SELECT @found = count(*) 
--FROM Organizers
--WHERE ID = @ID
--END

-------------------------------------------
---- To call the procedure
--DECLARE @pfound SMALLINT	-- Declare var to store proc result (to pass it by ref)
--DECLARE @pID SMALLINT = 3		-- Declare input param

--EXEC Is_ID_Organizer_unique @pID, @pfound OUTPUT  -- Call the proc

--SELECT @pfound  -- Print the value of @pfound var after calling


--CREATE PROCEDURE Is_ID_Organizer_unique
--	@ID SMALLINT
--AS 
--BEGIN
--IF (SELECT ID
--FROM Organizers
--where ID = @ID) IS NULL
--Return 0
--else
--Return 1
--END

-------------------------------------------------------------------------------------------------------------------------------

--GO
--CREATE PROCEDURE Is_ID_Bookseller_unique
--	@ID SMALLINT
--AS 
--BEGIN
--IF (SELECT ID
--FROM Book_Seller
--where ID = @ID) IS NULL
--Return 0
--else
--Return 1
--END

-------------------------------------------------------------------------------------------------------------------------------

--GO
--CREATE PROCEDURE Is_ID_Media_unique
--	@ID SMALLINT
--AS 
--BEGIN
--IF (SELECT ID
--FROM Media
--where ID = @ID) IS NULL
--Return 0
--else
--Return 1
--END

-------------------------------------------------------------------------------------------------------------------------------

--GO
--CREATE PROCEDURE Is_ID_Ticket_Reserves_unique
--	@ID SMALLINT
--AS 
--BEGIN
--IF (SELECT ID
--FROM Ticket_Reserves
--where ID = @ID) IS NULL
--Return 0
--else
--Return 1
--END

-------------------------------------------------------------------------------------------------------------------------------

--GO
--CREATE PROCEDURE Is_ID_Visitors_unique
--	@ID SMALLINT
--AS 
--BEGIN
--IF (SELECT ID
--FROM Visitors
--where ID = @ID) IS NULL
--Return 0
--else
--Return 1
--END

-------------------------------------------------------------------------------------------------------------------------------

--GO
--CREATE PROCEDURE Is_ID_Volunters_unique
--	@ID SMALLINT
--AS 
--BEGIN
--IF (SELECT ID
--FROM Volunters
--where ID = @ID) IS NULL
--Return 0
--else
--Return 1
--END



-------------------------------------------------------------------------------------------------------------------

--CREATE PROCEDURE Check_Volunter_Password 
--	@Username VARCHAR(15),
--	@password VARCHAR(30) OUTPUT
--AS
--BEGIN
--SELECT @password = DPASSWORD
--FROM Volunters
--WHERE USERNAME = @Username
--END
--GO
--------------------------------------------------------------------------------------------------------------------
--------------------------------------------------------------------------------------------------------------------

--CREATE PROCEDURE Recover_Organizer_Password
--	@Username VARCHAR(15),
--	@ID SMALLINT,
--	@Password VARCHAR(30) OUTPUT
--AS
--BEGIN
--SELECT @password = PASSWORD
--FROM Organizers
--WHERE @ID = ID AND @Username = username
--END
--GO

--------------------------------------------
---- To call the procedure 
--DECLARE @password VARCHAR(30)	-- Declare var to store proc result (to pass it by ref)
--DECLARE @Username VARCHAR(15) = 'Yahya_Mohamed'	-- Declare input param
--DECLARE @ID SMALLINT = 000001

--EXEC Recover_Organizer_Password @Username, @ID, @password OUTPUT  -- Call the proc
--SELECT CONVERT(varchar(30), @password)

--GO

----------------------------------------------------------------------------------------------------------------------
----------------------------------------------------------------------------------------------------------------------

--CREATE PROCEDURE Recover_Media_Password
--	@Username VARCHAR(15),
--	@ID SMALLINT,
--	@Password VARCHAR(30) OUTPUT
--AS
--BEGIN
--SELECT @password = PASSWORD
--FROM Media
--WHERE @ID = ID AND @Username = username
--END
--GO

----------------------------------------------------------------------------------------------------------------------
----------------------------------------------------------------------------------------------------------------------

--CREATE PROCEDURE Recover_Bookseller_Password
--	@Username VARCHAR(15),
--	@ID SMALLINT,
--	@Password VARCHAR(30) OUTPUT
--AS
--BEGIN
--SELECT @password = PASSWORD
--FROM Book_Seller
--WHERE @ID = ID AND @Username = username
--END
--GO

----------------------------------------------------------------------------------------------------------------------
----------------------------------------------------------------------------------------------------------------------

--CREATE PROCEDURE Recover_Ticket_Reserver_Password
--	@Username VARCHAR(15),
--	@ID SMALLINT,
--	@Password VARCHAR(30) OUTPUT
--AS
--BEGIN
--SELECT @password = PASSWORD
--FROM Ticket_Reserves
--WHERE @ID = ID AND @Username = username
--END
--GO

----------------------------------------------------------------------------------------------------------------------
----------------------------------------------------------------------------------------------------------------------

--CREATE PROCEDURE Recover_Visitor_Password
--	@Username VARCHAR(15),
--	@ID SMALLINT,
--	@Password VARCHAR(30) OUTPUT
--AS
--BEGIN
--SELECT @password = PASSWORD
--FROM Visitors
--WHERE @ID = ID AND @Username = username
--END
--GO

----------------------------------------------------------------------------------------------------------------------
----------------------------------------------------------------------------------------------------------------------

--CREATE PROCEDURE Recover_Volunters_Password
--	@Username VARCHAR(15),
--	@ID SMALLINT,
--	@Password VARCHAR(30) OUTPUT
--AS
--BEGIN
--SELECT @password = DPASSWORD
--FROM Volunters
--WHERE @ID = ID AND @Username = username
--END
--GO

--------------------------------------------------------------------------------------------------------------------
--------------------------------------------------------------------------------------------------------------------
--------------------------------------------------------------------------------------------------------------------



--CREATE PROCEDURE Check_Visitors_Password 
--	@Username VARCHAR(15),
--	@password VARCHAR(30) OUTPUT
--AS
--BEGIN
--SELECT @password = PASSWORD
--FROM Visitors
--WHERE USERNAME = @Username
--END
--GO


-------------------------------------------------------------------------------------------------------------------

--CREATE PROCEDURE Check_Ticket_reserver_Password 
--	@Username VARCHAR(15),
--	@password VARCHAR(30) OUTPUT
--AS
--BEGIN
--SELECT @password = PASSWORD
--FROM Ticket_Reserves
--WHERE USERNAME = @Username
--END
--GO

-------------------------------------------------------------------------------------------------------------------

--CREATE PROCEDURE Check_Organizer_Password 
--	@Username VARCHAR(15),
--	@password VARCHAR(30) OUTPUT
--AS
--BEGIN
--SELECT @password = PASSWORD
--FROM Organizers
--WHERE USERNAME = @Username
--END
--GO
--------------------------------------------
---- To call the procedure 
--DECLARE @password VARCHAR(30)	-- Declare var to store proc result (to pass it by ref)
--DECLARE @Username VARCHAR(15) = 'Yahya_Mohamed'	-- Declare input param

--EXEC Check_Organizer_Password @Username, @password OUTPUT  -- Call the proc
--SELECT CONVERT(varchar(30), @password)

--GO


-------------------------------------------------------------------------------------------------------------------

--CREATE PROCEDURE Check_Bookseller_Password 
--	@Username VARCHAR(15),
--	@password VARCHAR(30) OUTPUT
--AS
--BEGIN
--SELECT @password = PASSWORD
--FROM Book_Seller
--WHERE USERNAME = @Username
--END
--GO

-------------------------------------------------------------------------------------------------------------------

--CREATE PROCEDURE Check_Media_Password 
--	@Username VARCHAR(15),
--	@password VARCHAR(30) OUTPUT
--AS
--BEGIN
--SELECT @password = PASSWORD
--FROM Media
--WHERE USERNAME = @Username
--END
--GO

--GO
--CREATE PROCEDURE Add_New_Organizer
--	@FirstName VARCHAR(50), 
--	@MidName VARCHAR(50), 
--	@LastName VARCHAR(50), 
--	@ID SMALLINT, 
--	@Supervisor_ID SMALLINT, 
--	@National_ID BIGINT,
--	@SALARY INT, 
--	@GENDER CHAR, 
--	@Team_Name VARCHAR(50), 
--	@Works_At_Event_code SMALLINT, 
--	@Position VARCHAR(30), 
--	@PASSWORD VARCHAR(30), 
--	@USERNAME VARCHAR(15)

--AS
--BEGIN
--INSERT INTO Organizers (FirstName, MidName, LastName, ID, Supervisor_ID, National_ID, SALARY, GENDER, Team_Name, Works_At_Event_code, Position, PASSWORD, USERNAME)
--VALUES (@FirstName, @MidName, @LastName, @ID, @Supervisor_ID, @National_ID, @SALARY, @GENDER, @Team_Name, @Works_At_Event_code, @Position, @PASSWORD, @USERNAME);
--END
--select * from Organizers
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

--CREATE PROCEDURE Is_National_ID_Unique
--	@NID BIGINT
--AS
--BEGIN
--SELECT VO.USERNAME, B.USERNAME, M.USERNAME, O.USERNAME, T.USERNAME
--FROM Volunters AS VO, Book_Seller AS B, Media AS M, Organizers AS O, Ticket_Reserves AS T
--WHERE VO.NationalID = @NID OR B.National_ID = @NID OR M.National_ID = @NID OR O.National_ID = @NID OR T.National_ID = @NID
--END
--GO


--SELECT * FROM Organizers;
--SELECT * FROM Book_Seller

