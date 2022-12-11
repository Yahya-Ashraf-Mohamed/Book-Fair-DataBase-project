CREATE DATABASE [BookFair]
GO
USE BookFair
GO


CREATE TABLE Booth
(
  Capacity SMALLINT,
  Letter CHAR,
  Section_Number SMALLINT,
  Hall_Number SMALLINT,
  PRIMARY KEY (Letter, Hall_Number, Section_Number)
)

--GO
--CREATE TABLE Administrators
--(
--  FirstName VARCHAR(50) NOT NULL,
--  MidName VARCHAR(50) NOT NULL,
--  LastName VARCHAR(50) NOT NULL,
--  ID SMALLINT,
--  Manager_ID SMALLINT DEFAULT (0000000) NOT NULL,
--  NationalID BIGINT NOT NULL UNIQUE,
--  SALARY INT DEFAULT (0),
--  GENDER CHAR,
--  Position VARCHAR(30) NOT NULL DEFAULT ('Worker'),
--  PASSWORD VARCHAR(30) NOT NULL UNIQUE,
--  USERNAME VARCHAR(15) NOT NULL UNIQUE,
--  PRIMARY KEY(ID),
--)

--GO
--CREATE TABLE Administrator_Phones
--(
--  PhoneNum INT,
--  Administrator_ID SMALLINT,
--  PRIMARY KEY (Administrator_ID, PhoneNum),
--  FOREIGN KEY (Administrator_ID) REFERENCES Administrators
--	ON UPDATE CASCADE
--	ON DELETE CASCADE
--)
--GO
--CREATE TABLE Administrator_Shifts
--(
--  SHIFT_TIMES TIME,
--  Administrator_ID SMALLINT ,
--  PRIMARY KEY (Administrator_ID, SHIFT_TIMES),
--  FOREIGN KEY (Administrator_ID) REFERENCES Administrators
--	ON UPDATE CASCADE
--	ON DELETE CASCADE
--)

GO
CREATE TABLE Organizers
(
  FirstName VARCHAR(50) NOT NULL,
  MidName VARCHAR(50) NOT NULL,
  LastName VARCHAR(50) NOT NULL,
  ID INT,
  Supervisor_ID INT DEFAULT (000000),
  National_ID BIGINT NOT NULL UNIQUE,
  SALARY INT DEFAULT (0),
  GENDER CHAR,
  Team_Name VARCHAR(50) NOT NULL,
  Works_At_Event_code SMALLINT,
  Position VARCHAR(30) NOT NULL DEFAULT ('Worker'),
  PASSWORD VARCHAR(30) NOT NULL,
  USERNAME VARCHAR(15) NOT NULL UNIQUE,
  PRIMARY KEY(ID),
  FOREIGN KEY (Supervisor_ID) REFERENCES Organizers
	ON UPDATE NO ACTION
	ON DELETE NO ACTION
)

GO
CREATE TABLE Organizer_Phones
(
  PhoneNum INT,
  Organizer_ID INT,
  PRIMARY KEY (Organizer_ID, PhoneNum),
  FOREIGN KEY (Organizer_ID) REFERENCES Organizers
    ON UPDATE CASCADE
    ON DELETE CASCADE
)

GO
CREATE TABLE Organizer_Shifts
(
  SHIFT_TIME_Start TIME,
  SHIFT_TIME_End TIME,
  Organizer_ID INT ,
  PRIMARY KEY (Organizer_ID, SHIFT_TIME_Start, SHIFT_TIME_End),
  FOREIGN KEY (Organizer_ID) REFERENCES Organizers
	ON UPDATE CASCADE
	ON DELETE CASCADE
)


GO
CREATE TABLE Events
(
  NAME VARCHAR(50),
  Subject VARCHAR(50),
  Code SMALLINT,
  Leader_ID INT NOT NULL DEFAULT (000000),
  Event_Date DATE,
  Start_time TIME,
  End_time TIME,
  Attendees_Number smallint,
  Letter CHAR,
  Section_Number SMALLINT,
  Hall_Number SMALLINT,
  --Location VARCHAR(50),
  PRIMARY KEY (Code),
  FOREIGN KEY ( Leader_ID ) REFERENCES Organizers ( ID )
	ON UPDATE NO ACTION
	ON DELETE NO ACTION,
  FOREIGN KEY (Letter, Hall_Number, Section_Number) REFERENCES Booth
  ON UPDATE CASCADE
  ON DELETE NO ACTION,
)

GO
CREATE TABLE Past_Events
(
  NAME VARCHAR(50),
  Subject VARCHAR(50),
  Code SMALLINT,
  Leader_ID INT NOT NULL DEFAULT (000000),
  Event_Date DATE,
  Start_time TIME,
  End_time TIME,
  Attendees_Number smallint,
  Letter CHAR,
  Section_Number SMALLINT,
  Hall_Number SMALLINT,
  --Location VARCHAR(50),
  PRIMARY KEY (Code),
  FOREIGN KEY ( Leader_ID ) REFERENCES Organizers ( ID )
	ON UPDATE NO ACTION
	ON DELETE NO ACTION,
  FOREIGN KEY (Letter, Hall_Number, Section_Number) REFERENCES Booth
  ON UPDATE CASCADE
  ON DELETE NO ACTION,
)



GO
ALTER TABLE Organizers 
ADD CONSTRAINT Event_Code 
FOREIGN KEY (Works_At_Event_code) 
REFERENCES Events
	ON UPDATE CASCADE
	ON DELETE SET NULL;


GO
CREATE TABLE Publishing_House 
(
  Publishing_House_NAME VARCHAR(50),
  --Letter CHAR,
  --Section_Number SMALLINT,
  --Hall_Number SMALLINT,
  --Manager_ID SMALLINT DEFAULT (111111),
  Contacts INT UNIQUE NOT NULL,
  PRIMARY KEY (Publishing_House_NAME),
  --FOREIGN KEY (Letter, Hall_Number, Section_Number) REFERENCES Booth
  --ON UPDATE CASCADE
  --ON DELETE NO ACTION,
  --FOREIGN KEY (Manager_ID) REFERENCES Publishing_House
  --ON UPDATE CASCADE
  --ON DELETE SET DEFAULT
)

GO
CREATE TABLE Book_Seller
(
  FirstName VARCHAR(50) NOT NULL,
  MidName VARCHAR(50) NOT NULL,
  LastName VARCHAR(50) NOT NULL,
  ID INT,
  Supervisor_ID INT DEFAULT (100000),
  National_ID BIGINT NOT NULL UNIQUE,
  SALARY INT DEFAULT (0),
  GENDER CHAR,
  --Publishing_House_Name VARCHAR(50) NOT NULL,
  Position VARCHAR(30) NOT NULL DEFAULT ('Worker'),
  PASSWORD VARCHAR(30) NOT NULL,
  USERNAME VARCHAR(15) NOT NULL UNIQUE,
  PRIMARY KEY(ID),
  FOREIGN KEY (Supervisor_ID) REFERENCES Book_Seller
	ON UPDATE NO ACTION
	ON DELETE NO ACTION
 -- FOREIGN KEY (Publishing_House_Name) REFERENCES Publishing_House
	--ON UPDATE CASCADE
	--ON DELETE CASCADE
)

GO
CREATE TABLE Book_Seller_Works_IN
(
  Letter CHAR DEFAULT ('X'),
  Section_Number SMALLINT DEFAULT (1),
  Hall_Number SMALLINT DEFAULT (1),
  Bookseller_ID INT,
  --===================================================================== NEW =========================================================================
  PRIMARY KEY(Bookseller_ID),
  --===================================================================== END NEW =========================================================================

  FOREIGN KEY (Bookseller_ID) REFERENCES Book_Seller
	ON UPDATE CASCADE
	ON DELETE CASCADE,
  FOREIGN KEY (Letter, Hall_Number, Section_Number) REFERENCES Booth
  ON UPDATE CASCADE
  ON DELETE SET DEFAULT 
)

GO
CREATE TABLE Book_Seller_Phones
(
  PhoneNum INT,
  Book_Seller_ID INT,
  PRIMARY KEY (Book_Seller_ID, PhoneNum),
  FOREIGN KEY (Book_Seller_ID) REFERENCES Book_Seller
    ON UPDATE CASCADE
	ON DELETE CASCADE
)

GO
CREATE TABLE Book_Seller_Shifts
(
  SHIFT_TIME_Start TIME DEFAULT ('07:00'),
  SHIFT_TIME_End TIME DEFAULT ('17:00'),
  Book_Seller_ID INT ,
  PRIMARY KEY (Book_Seller_ID, SHIFT_TIME_Start, SHIFT_TIME_End),
  FOREIGN KEY (Book_Seller_ID) REFERENCES Book_Seller
	ON UPDATE CASCADE
	ON DELETE CASCADE
)

GO
CREATE TABLE Volunters
( 
  FirstName VARCHAR(50) NOT NULL,
  MidName VARCHAR(50) NOT NULL,
  LastName VARCHAR(50) NOT NULL,
  ID INT NOT NULL UNIQUE,
  Supervisor_ID INT DEFAULT (400000) NOT NULL,
  NationalID BIGINT NOT NULL UNIQUE,
  SALARY INT DEFAULT (0),
  GENDER CHAR,
  Event_Code SMALLINT,
  Position VARCHAR(30) NOT NULL DEFAULT ('Worker'),
  DPASSWORD VARCHAR(15) NOT NULL,
  USERNAME VARCHAR(15) NOT NULL UNIQUE,
  CATEGORY VARCHAR(30)
  PRIMARY KEY(ID),
  FOREIGN KEY (Supervisor_ID) REFERENCES Organizers
	ON UPDATE NO ACTION
	ON DELETE SET DEFAULT,
  FOREIGN KEY (Event_Code) 
  REFERENCES Events
	ON UPDATE CASCADE
	ON DELETE SET NULL
)

GO
CREATE TABLE Volunter_Phone
(
  PhoneNum INT,
  Volunter_ID INT ,
  PRIMARY KEY (PhoneNum,Volunter_ID),
  FOREIGN KEY (Volunter_ID) REFERENCES Volunters
	ON UPDATE CASCADE
	ON DELETE CASCADE
)
GO
CREATE TABLE Volunter_Shift
(
  SHIFT_TIME_Start TIME,
  SHIFT_TIME_End TIME,
  Volunter_ID INT ,
  PRIMARY KEY (Volunter_ID, SHIFT_TIME_Start, SHIFT_TIME_End),
  FOREIGN KEY (Volunter_ID) REFERENCES Volunters
	ON UPDATE CASCADE
	ON DELETE CASCADE
)

GO
CREATE TABLE Media 
(
  FirstName VARCHAR(50) NOT NULL,
  MidName VARCHAR(50) NOT NULL,
  LastName VARCHAR(50) NOT NULL,
  ID INT,
  Supervisor_ID INT DEFAULT (300000),
  National_ID BIGINT NOT NULL UNIQUE,
  GENDER CHAR,
  Event_Code SMALLINT,
  Channel_Name VARCHAR(50) NOT NULL,
  Position VARCHAR(30) NOT NULL DEFAULT ('Worker'),
  PASSWORD VARCHAR(30) NOT NULL,
  USERNAME VARCHAR(15) NOT NULL UNIQUE,
  PRIMARY KEY(ID),
  FOREIGN KEY (Supervisor_ID) REFERENCES Media
	ON UPDATE NO ACTION
	ON DELETE NO ACTION,
  FOREIGN KEY (Event_Code) REFERENCES Events
    ON UPDATE CASCADE
    ON DELETE SET Null
)


GO
CREATE TABLE Media_Phones
(
  PhoneNum INT,
  Media_ID INT,
  PRIMARY KEY (Media_ID, PhoneNum),
  FOREIGN KEY (Media_ID) REFERENCES Media
    ON UPDATE CASCADE
	ON DELETE CASCADE
)
GO
CREATE TABLE Media_Shifts
(
  SHIFT_TIME_Start TIME,
  SHIFT_TIME_End TIME,
  Media_ID INT,
  PRIMARY KEY (Media_ID, SHIFT_TIME_Start, SHIFT_TIME_End),
  FOREIGN KEY (Media_ID) REFERENCES Media
    ON UPDATE CASCADE
	ON DELETE CASCADE
)



GO
CREATE TABLE Ticket_Reserves 
(
  FirstName VARCHAR(50) NOT NULL,
  MidName VARCHAR(50) NOT NULL,
  LastName VARCHAR(50) NOT NULL,
  ID INT,
  Supervisor_ID INT DEFAULT (200000),
  National_ID BIGINT NOT NULL UNIQUE,
  SALARY INT DEFAULT (0),
  GENDER CHAR,
  Position VARCHAR(30) NOT NULL DEFAULT ('Worker'),
  PASSWORD VARCHAR(30) NOT NULL,
  USERNAME VARCHAR(15) NOT NULL UNIQUE,
  PRIMARY KEY(ID),
  FOREIGN KEY (Supervisor_ID) REFERENCES Ticket_Reserves
  ON UPDATE NO ACTION
  ON DELETE NO ACTION
)
GO
CREATE TABLE Ticket_Reserve_Phones
(
  Phone_Number INT,
  Ticket_Reserve_ID INT,
  PRIMARY KEY (Ticket_Reserve_ID, Phone_Number),
  FOREIGN KEY (Ticket_Reserve_ID) REFERENCES Ticket_Reserves
    ON UPDATE CASCADE
	ON DELETE CASCADE
)
GO
CREATE TABLE Ticket_Reserve_Shifts
(
  SHIFT_TIME_Start TIME,
  SHIFT_TIME_End TIME,
  Ticket_Reserve_ID INT,
  PRIMARY KEY (Ticket_Reserve_ID, SHIFT_TIME_Start, SHIFT_TIME_End),
  FOREIGN KEY (Ticket_Reserve_ID) REFERENCES Ticket_Reserves
    ON UPDATE CASCADE
	ON DELETE CASCADE
)


GO
CREATE TABLE Ticket
(
  Serial_Number INT PRIMARY KEY,
  Available_Day	DATE,
  Payment_Time_Start DATETIME,
  Payment_Time_Ends DATETIME,
  Reserver_ID INT DEFAULT (200000),
  FOREIGN KEY (Reserver_ID) REFERENCES Ticket_Reserves
	ON UPDATE CASCADE
	ON DELETE SET DEFAULT
)


GO
CREATE TABLE Visitors
(
  FirstName VARCHAR(50) NOT NULL,
  MidName VARCHAR(50) NOT NULL,
  LastName VARCHAR(50) NOT NULL,
  ID INT,
  --National_ID BIGINT NOT NULL UNIQUE,
  Gender CHAR,
  PASSWORD VARCHAR(30) NOT NULL,
  USERNAME VARCHAR(15) NOT NULL UNIQUE,
  Birth_Date DATE,
  Attendance INT,
  PRIMARY KEY(ID),
)

GO
CREATE TABLE Visitor_Phones
(
  Phone_Number INT,
  Visitor_ID INT,
  PRIMARY KEY (Phone_Number,Visitor_ID),
  FOREIGN KEY (Visitor_ID) REFERENCES Visitors
    ON UPDATE CASCADE
	ON DELETE CASCADE
)
GO
CREATE TABLE Visitor_Interest
(
  Interest VARCHAR(50),
  Visitor_ID INT ,
  PRIMARY KEY (Interest,Visitor_ID),
  FOREIGN KEY (Visitor_ID) REFERENCES Visitors
	ON UPDATE CASCADE
	ON DELETE CASCADE
)

GO
CREATE TABLE Interests
(
  Interest VARCHAR(50),
  PRIMARY KEY (Interest)
)


GO
CREATE TABLE AUDIENCE
(
  visitor_ID INT NOT NULL, 
  Event_Code SMALLINT NOT NULL,
  FOREIGN KEY (visitor_ID) REFERENCES Visitors
	ON UPDATE NO ACTION
	ON DELETE NO ACTION,
  FOREIGN KEY (Event_Code) REFERENCES Events
	ON UPDATE CASCADE
	ON DELETE CASCADE
)

--GO
--CREATE TABLE Schedule
--(
--  Schedule_Number SMALLINT,
--  Event_Day DATE,
--  Event_Code SMALLINT,
--  Start_Time TIME,
--  End_Time TIME,
--  Event_Name VARCHAR(50),
--  PRIMARY KEY (Event_Code, Event_Name, Start_Time),
--  FOREIGN KEY (Event_Code) REFERENCES Events
--	ON UPDATE CASCADE
--	ON DELETE CASCADE
--)


GO
CREATE TABLE Books
(
  Code SMALLINT NOT NULL,
  Book_Name VARCHAR(50) NOT NULL,
  Author VARCHAR(50) NOT NULL,
  Offer VARCHAR(100) DEFAULT (0),
  Series VARCHAR(100),
  Catetory VARCHAR(30) NOT NULL DEFAULT ('other'),
  Price FLOAT NOT NULL,
  Available BIT DEFAULT (1),
  Num_Of_Books SMALLINT DEFAULT (1),
  --Publishing_House_Name VARCHAR (50),
  UNIQUE (Author,Book_Name),
  --PRIMARY KEY (Publishing_House_Name, Code),
  PRIMARY KEY (Code),
 -- FOREIGN KEY (Publishing_House_Name) REFERENCES Publishing_House
	--ON UPDATE CASCADE
	--ON DELETE CASCADE
)


GO
CREATE TABLE Book_Location
(
  Code SMALLINT NOT NULL,
  Publishing_House_Name VARCHAR (50),
  Letter CHAR,
  Section_Number SMALLINT,
  Hall_Number SMALLINT,
  FOREIGN KEY (Code) REFERENCES Books
	ON UPDATE CASCADE
	ON DELETE CASCADE,
  FOREIGN KEY (Publishing_House_Name) REFERENCES Publishing_House
	ON UPDATE CASCADE
	ON DELETE CASCADE,  
  FOREIGN KEY (Letter, Hall_Number, Section_Number) REFERENCES Booth
  ON UPDATE CASCADE
  ON DELETE NO ACTION

)



GO
CREATE TABLE Sold_Books
(
  Publishing_House_Name VARCHAR (50),
  Book_Seller_ID INT DEFAULT (100000),
  Visitor_ID INT,
  Book_Code SMALLINT,
  Sold_Time DATETIME,
  Sold_Price SMALLINT,
  FOREIGN KEY (Book_Seller_ID) REFERENCES Book_Seller
	ON UPDATE CASCADE
	ON DELETE SET DEFAULT,
  FOREIGN KEY (Visitor_ID) REFERENCES Visitors
	ON UPDATE NO ACTION
	ON DELETE NO ACTION,
 FOREIGN KEY (Book_Code) REFERENCES Books
	ON UPDATE NO ACTION
	ON DELETE NO ACTION
)


--GO
--CREATE TABLE Publishing_House_Visitors
--(
--  Publishing_House_Name VARCHAR (50),
--  Visitor_ID SMALLINT,
--  Enter_Time TIME,
--  Exit_Time TIME,
--  FOREIGN KEY (Publishing_House_Name) REFERENCES Publishing_House
--	ON UPDATE CASCADE
--	ON DELETE CASCADE,
--  FOREIGN KEY (Visitor_ID) REFERENCES Visitors
--	ON UPDATE NO ACTION
--	ON DELETE NO ACTION,
--)



GO
CREATE TABLE Booth_Visitors
(
  Letter CHAR,
  Section_Number SMALLINT,
  Hall_Number SMALLINT,
  Visitor_ID INT,
  Enter_Time TIME,
  Exit_Time TIME,
  FOREIGN KEY (Visitor_ID) REFERENCES Visitors
	ON UPDATE NO ACTION
	ON DELETE NO ACTION,
  FOREIGN KEY (Letter, Hall_Number, Section_Number) REFERENCES Booth
  ON UPDATE CASCADE
  ON DELETE NO ACTION,

)



GO
CREATE TABLE Volunters_Past_Events
(
	Volunter_ID INT,
	Event_Code SMALLINT,
	Volunter_Supervisor_ID INT,
	Total_Worked_Hours SMALLINT,
	SALARY INT,
	Position VARCHAR (30),
	Category VARCHAR (30),
	FOREIGN KEY (Volunter_ID) REFERENCES Volunters
		ON UPDATE CASCADE
		ON DELETE NO ACTION,
	FOREIGN KEY (Event_Code) REFERENCES Past_Events
		ON UPDATE NO ACTION
		ON DELETE NO ACTION,
	FOREIGN KEY (Volunter_Supervisor_ID) REFERENCES Organizers
		ON UPDATE NO ACTION
		ON DELETE NO ACTION
)


GO
CREATE TABLE Guests 
(
	Guest_Name varchar(50),
	Category varchar(50),
	Event_Code smallint,
	Date DATE,
	FOREIGN KEY (Event_Code ) REFERENCES Events ( Code )
	ON UPDATE CASCADE
	ON DELETE CASCADE,
)

GO
CREATE TABLE Used_Tickets 
(
	Serial_Number INT,
	Visitor_ID INT,
	Time_Used_in DATETIME,
	
	--PRIMARY KEY (Serial_Number, Visitor_ID, Time_Used_in),
	FOREIGN KEY (Serial_Number) REFERENCES Ticket ( Serial_Number )
	ON UPDATE CASCADE
	ON DELETE CASCADE,
	FOREIGN KEY (Visitor_ID ) REFERENCES Visitors ( ID )
	ON UPDATE CASCADE
	ON DELETE CASCADE
)
