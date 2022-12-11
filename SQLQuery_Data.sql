INSERT INTO Booth (Capacity, Letter, Section_Number, Hall_Number)
VALUES (35, 'A', 1, 1);

INSERT INTO Booth (Capacity, Letter, Section_Number, Hall_Number)
VALUES (30, 'A', 2, 1);

INSERT INTO Booth (Capacity, Letter, Section_Number, Hall_Number)
VALUES (20, 'A', 3, 1);

INSERT INTO Booth (Capacity, Letter, Section_Number, Hall_Number)
VALUES (25, 'A', 1, 2);

INSERT INTO Booth (Capacity, Letter, Section_Number, Hall_Number)
VALUES (30, 'A', 2, 2);

INSERT INTO Booth (Capacity, Letter, Section_Number, Hall_Number)
VALUES (40, 'B', 1, 1);

INSERT INTO Booth (Capacity, Letter, Section_Number, Hall_Number)
VALUES (50, 'B', 2, 1);

INSERT INTO Booth (Capacity, Letter, Section_Number, Hall_Number)
VALUES (25, 'B', 1, 2);

INSERT INTO Booth (Capacity, Letter, Section_Number, Hall_Number)
VALUES (35, 'B', 2, 2);

INSERT INTO Booth (Capacity, Letter, Section_Number, Hall_Number)
VALUES (15, 'B', 3, 2);

INSERT INTO Booth (Capacity, Letter, Section_Number, Hall_Number)
VALUES (70, 'C', 1, 1);

INSERT INTO Booth (Capacity, Letter, Section_Number, Hall_Number)
VALUES (60, 'C', 2, 1);

INSERT INTO Booth (Capacity, Letter, Section_Number, Hall_Number)
VALUES (50, 'C', 3, 1);

INSERT INTO Booth (Capacity, Letter, Section_Number, Hall_Number)
VALUES (40, 'C', 4, 1);

INSERT INTO Booth (Capacity, Letter, Section_Number, Hall_Number)
VALUES (20, 'C', 1, 2);

INSERT INTO Booth (Capacity, Letter, Section_Number, Hall_Number)
VALUES (40, 'C', 2, 2);

INSERT INTO Booth (Capacity, Letter, Section_Number, Hall_Number)
VALUES (35, 'C', 3, 2);

INSERT INTO Booth (Capacity, Letter, Section_Number, Hall_Number)
VALUES (45, 'C', 1, 3);

INSERT INTO Booth (Capacity, Letter, Section_Number, Hall_Number)
VALUES (45, 'C', 2, 3);

INSERT INTO Booth (Capacity, Letter, Section_Number, Hall_Number)
VALUES (25, 'C', 3, 3);

INSERT INTO Booth (Capacity, Letter, Section_Number, Hall_Number)
VALUES (9999, 'X', 1, 1);

SELECT * FROM Booth;
----------------------------------------------------------------------------------------------------------------------------------------------

INSERT INTO Organizers (FirstName, 
						MidName, 
						LastName, 
						ID, 
						Supervisor_ID, 
						National_ID, 
						SALARY, 
						GENDER, 
						Team_Name, 
						Works_At_Event_code, 
						Position, 
						PASSWORD, 
						USERNAME)
VALUES ('Yahya', 'Ashraf', 'Mohamed', 000000, Null, 28301092293254, 10000, 'M', 'Team 1', Null, 'Leader', 'Yahya_OL@123', 'Yahya_OL');



INSERT INTO Organizers (FirstName, MidName, LastName, ID, Supervisor_ID, National_ID, SALARY, GENDER, Team_Name, Works_At_Event_code, Position, PASSWORD, USERNAME)
VALUES ('Yahya', 'Mohamed', 'Ashraf', 000001, 000000, 28610242157826, 7000, 'M', 'Team 1', Null, 'Vice-Leader', 'Yahya_OVL@123', 'Yahya_OVL');

INSERT INTO Organizers (FirstName, MidName, LastName, ID, Supervisor_ID, National_ID, SALARY, GENDER, Team_Name, Works_At_Event_code, Position, PASSWORD, USERNAME)
VALUES ('Mohamed', 'Ashraf', 'Ahmed', 000002, 000000, 29812231200693, 5000, 'M', 'Team 1', Null, 'Member', 'Yahya_OM@123', 'Yahya_OM');

--===================================================================== NEW =========================================================================
INSERT INTO Organizers (FirstName, MidName, LastName, ID, Supervisor_ID, National_ID, SALARY, GENDER, Team_Name, Works_At_Event_code, Position, PASSWORD, USERNAME)
VALUES ('Yasser', 'Ashraf', 'Yahya', 000003, 000000, 30707071944041, 4500, 'M', 'Team 1', Null, 'Member', 'Yasser_12', 'Yasser_Yahya');

INSERT INTO Organizers (FirstName, MidName, LastName, ID, Supervisor_ID, National_ID, SALARY, GENDER, Team_Name, Works_At_Event_code, Position, PASSWORD, USERNAME)
VALUES ('Mario', 'Ashraf', 'younes', 000004, 000000, 31203130426233, 5000, 'M', 'Team 1', Null, 'Member', 'Momo_478', 'MarioM');

INSERT INTO Organizers (FirstName, MidName, LastName, ID, Supervisor_ID, National_ID, SALARY, GENDER, Team_Name, Works_At_Event_code, Position, PASSWORD, USERNAME)
VALUES ('Younes', 'Medhat', 'Saleh', 000005, 000000, 29312032966929, 6000, 'M', 'Team 1', Null, 'Member', 'YounesMS@123', 'YounesMS');

INSERT INTO Organizers (FirstName, MidName, LastName, ID, Supervisor_ID, National_ID, SALARY, GENDER, Team_Name, Works_At_Event_code, Position, PASSWORD, USERNAME)
VALUES ('Yara', 'Ashraf', 'Mohamed', 000006, 000000, 29301313313642, 5500, 'F', 'Team 1', Null, 'Member', 'Yara@123', 'Yara');

INSERT INTO Organizers (FirstName, MidName, LastName, ID, Supervisor_ID, National_ID, SALARY, GENDER, Team_Name, Works_At_Event_code, Position, PASSWORD, USERNAME)
VALUES ('Mosa', 'Rafat', 'Ahmed', 000007, 000000, 29503122998412, 3500, 'M', 'Team 1', Null, 'Member', 'Mesmes', 'MoasaRA');

INSERT INTO Organizers (FirstName, MidName, LastName, ID, Supervisor_ID, National_ID, SALARY, GENDER, Team_Name, Works_At_Event_code, Position, PASSWORD, USERNAME)
VALUES ('Rana', 'Mohamed', 'Khalefa', 000008, 000000, 29510070179489, 4000, 'F', 'Team 1', Null, 'Member', 'Rana987', 'RanaMK');


INSERT INTO Organizers (FirstName, MidName, LastName, ID, Supervisor_ID, National_ID, SALARY, GENDER, Team_Name, Works_At_Event_code, Position, PASSWORD, USERNAME)
VALUES ('Mariam', 'Mustafa', 'Mahmoud', 000009, 000000, 30407312716504, 8000, 'F', 'Team 2', Null, 'Leader', 'Mariam_OL@123', 'Mariam_OL');

INSERT INTO Organizers (FirstName, MidName, LastName, ID, Supervisor_ID, National_ID, SALARY, GENDER, Team_Name, Works_At_Event_code, Position, PASSWORD, USERNAME)
VALUES ('Mustafa', 'Mohamed', 'Ahmed', 000010, 000009, 28908063461917, 6500, 'M', 'Team 2', Null, 'Vice-Leader', 'Mustafa_OVL@123', 'Mustafa_OVL');

INSERT INTO Organizers (FirstName, MidName, LastName, ID, Supervisor_ID, National_ID, SALARY, GENDER, Team_Name, Works_At_Event_code, Position, PASSWORD, USERNAME)
VALUES ('Rahma', 'Tamer', 'Ali', 000011, 000009, 28105141767170, 6000, 'F', 'Team 2', Null, 'Member', 'Rahma_OM@123', 'Rahma_OM');

INSERT INTO Organizers (FirstName, MidName, LastName, ID, Supervisor_ID, National_ID, SALARY, GENDER, Team_Name, Works_At_Event_code, Position, PASSWORD, USERNAME)
VALUES ('Aya', 'Mamdouh', 'Ali', 000012, 000009, 28810063292933, 5000, 'F', 'Team 2', Null, 'Member', 'Aya@123', 'AyaMA');

INSERT INTO Organizers (FirstName, MidName, LastName, ID, Supervisor_ID, National_ID, SALARY, GENDER, Team_Name, Works_At_Event_code, Position, PASSWORD, USERNAME)
VALUES ('Yassen', 'Ashraf', 'Ahmed', 000013, 000009, 28105091315227, 6000, 'M', 'Team 2', Null, 'Member', 'Yassen@123', 'YassenAA');

INSERT INTO Organizers (FirstName, MidName, LastName, ID, Supervisor_ID, National_ID, SALARY, GENDER, Team_Name, Works_At_Event_code, Position, PASSWORD, USERNAME)
VALUES ('Tolai', 'Yahya', 'Yousef', 000014, 000009, 30805060229760, 5500, 'F', 'Team 2', Null, 'Member', 'Tolai_OM@123', 'Tolai_OM');


INSERT INTO Organizers (FirstName, MidName, LastName, ID, Supervisor_ID, National_ID, SALARY, GENDER, Team_Name, Works_At_Event_code, Position, PASSWORD, USERNAME)
VALUES ('Yassin', 'Ashraf', 'Mohamed', 000015, 000000, 29912281978956, 7000, 'M', 'Team 3', Null, 'Leader', 'Yassin_OL@123', 'Yassin_OL');

INSERT INTO Organizers (FirstName, MidName, LastName, ID, Supervisor_ID, National_ID, SALARY, GENDER, Team_Name, Works_At_Event_code, Position, PASSWORD, USERNAME)
VALUES ('Yousef', 'Ahmed', 'Ali', 000016, 000015, 30401231401272, 6500, 'M', 'Team 3', Null, 'Vice-Leader', 'Yousef_OVL@123', 'Yousef_OVL');

INSERT INTO Organizers (FirstName, MidName, LastName, ID, Supervisor_ID, National_ID, SALARY, GENDER, Team_Name, Works_At_Event_code, Position, PASSWORD, USERNAME)
VALUES ('Mina', 'Mohamed', 'Adel', 000017, 000015, 30703292704096, 5000, 'F', 'Team 3', Null, 'Member', 'Mina@123', 'MinaOM');

INSERT INTO Organizers (FirstName, MidName, LastName, ID, Supervisor_ID, National_ID, SALARY, GENDER, Team_Name, Works_At_Event_code, Position, PASSWORD, USERNAME)
VALUES ('Esra', 'Moamdouh', 'Ali', 000018, 000015, 28412283484519, 6000, 'F', 'Team 3', Null, 'Member', 'Esra_OM@123', 'EsraMA');

INSERT INTO Organizers (FirstName, MidName, LastName, ID, Supervisor_ID, National_ID, SALARY, GENDER, Team_Name, Works_At_Event_code, Position, PASSWORD, USERNAME)
VALUES ('Khaled', 'Ramy', 'Rabey', 000019, 000015, 20206544563256, 5500, 'M', 'Team 3', Null, 'Member', 'Khaled_OM@123', 'Khaled_RR');

INSERT INTO Organizers (FirstName, MidName, LastName, ID, Supervisor_ID, National_ID, SALARY, GENDER, Team_Name, Works_At_Event_code, Position, PASSWORD, USERNAME)
VALUES ('Nourhan', 'Nour', 'Naser', 000020, 000015, 29608311598168, 5000, 'F', 'Team 3', Null, 'Member', 'Nourhan@123', 'Nourhan_Nour');


UPDATE Organizers
SET Supervisor_ID = 000001
WHERE Team_Name = 'Team 1';

UPDATE Organizers
SET Supervisor_ID = 000000, Position = 'Leader', USERNAME = 'Yahya_OL', PASSWORD = 'Yahya_OL@123'
WHERE ID = 000001;

UPDATE Organizers
SET Position = 'Vice-Leader', USERNAME = 'Mohamed_OVL', PASSWORD = 'Mohamed_OVL@123'
WHERE ID = 000002;

UPDATE Organizers
SET Supervisor_ID = NULL, Works_At_Event_code = NULL, Team_Name = 'All', Position = 'Organizers Manager', USERNAME = 'Yahya_OLM', PASSWORD = 'Yahya_OLM@123'
WHERE ID = 000000;
--===================================================================== END NEW =========================================================================

select * from Organizers;
--===============================================

INSERT INTO Events (NAME, Subject, Code, Leader_ID, Event_Date, Start_time, End_time, Attendees_Number, Letter, Section_Number, Hall_Number)
VALUES ('Banorama','pyramid', 1234, 000000, '2022-05-25', '12:00', '02:00', 15, 'A', 3, 1);

--===================================================================== NEW =========================================================================

INSERT INTO Events (NAME, Subject, Code, Leader_ID, Event_Date, Start_time, End_time, Attendees_Number, Letter, Section_Number, Hall_Number)
VALUES ('Physic','Earth', 4652, 000009, '2022-05-25', '15:00', '16:30', 30, 'C', 2, 2);

INSERT INTO Events (NAME, Subject, Code, Leader_ID, Event_Date, Start_time, End_time, Attendees_Number, Letter, Section_Number, Hall_Number)
VALUES ('Math','Calculus', 1817, 0000015, '2022-05-26', '12:00', '02:00', 17, 'B', 1, 1);

INSERT INTO Events (NAME, Subject, Code, Leader_ID, Event_Date, Start_time, End_time, Attendees_Number, Letter, Section_Number, Hall_Number)
VALUES ('Save Nile','Enviroment', 5522, 000001, '2022-05-26', '09:00', '11:59', 25, 'A', 2, 2);

INSERT INTO Events (NAME, Subject, Code, Leader_ID, Event_Date, Start_time, End_time, Attendees_Number, Letter, Section_Number, Hall_Number)
VALUES ('Android','Programing', 1021, 000009, '2022-05-25', '12:00', '02:00', 30, 'C', 1, 1);

UPDATE Events
SET Leader_ID = 000001
WHERE Code = 1234;

--===================================================================== END NEW =========================================================================

select * from Events;
--===============================================

UPDATE Organizers
SET Works_At_Event_code = 1234
WHERE Team_Name = 'Team 1';

--===================================================================== NEW =========================================================================

UPDATE Organizers
SET Works_At_Event_code = 4652
WHERE Team_Name = 'Team 2';

UPDATE Organizers
SET Works_At_Event_code = 1817
WHERE Team_Name = 'Team 3';

--===================================================================== END NEW =========================================================================

--===============================================

INSERT INTO Organizer_Phones (PhoneNum, Organizer_ID)
VALUES (01202006004, 000000);

INSERT INTO Organizer_Phones (PhoneNum, Organizer_ID)
VALUES (01021664887, 000000);

INSERT INTO Organizer_Phones (PhoneNum, Organizer_ID)
VALUES (01136448551, 000001);

INSERT INTO Organizer_Phones (PhoneNum, Organizer_ID)
VALUES (01207469128, 000002);

SELECT * FROM Organizer_Phones;
--------------------------------------------

INSERT INTO Organizer_Shifts (SHIFT_TIME_Start, SHIFT_TIME_End, Organizer_ID)
VALUES ('07:00','14:00', 000000);

INSERT INTO Organizer_Shifts (SHIFT_TIME_Start, SHIFT_TIME_End, Organizer_ID)
VALUES ('07:00','11:00', 000001);

INSERT INTO Organizer_Shifts (SHIFT_TIME_Start, SHIFT_TIME_End, Organizer_ID)
VALUES ('14:00','17:00', 000001);

INSERT INTO Organizer_Shifts (SHIFT_TIME_Start, SHIFT_TIME_End, Organizer_ID)
VALUES ('07:00','17:00', 000002);

--===================================================================== NEW =========================================================================

INSERT INTO Organizer_Shifts (SHIFT_TIME_Start, SHIFT_TIME_End, Organizer_ID)
VALUES ('07:00','17:00', 000003);

INSERT INTO Organizer_Shifts (SHIFT_TIME_Start, SHIFT_TIME_End, Organizer_ID)
VALUES ('07:00','17:00', 000004);

INSERT INTO Organizer_Shifts (SHIFT_TIME_Start, SHIFT_TIME_End, Organizer_ID)
VALUES ('07:00','17:00', 000005);

INSERT INTO Organizer_Shifts (SHIFT_TIME_Start, SHIFT_TIME_End, Organizer_ID)
VALUES ('07:00','17:00', 000006);

INSERT INTO Organizer_Shifts (SHIFT_TIME_Start, SHIFT_TIME_End, Organizer_ID)
VALUES ('07:00','17:00', 000007);

INSERT INTO Organizer_Shifts (SHIFT_TIME_Start, SHIFT_TIME_End, Organizer_ID)
VALUES ('07:00','17:00', 000008);

INSERT INTO Organizer_Shifts (SHIFT_TIME_Start, SHIFT_TIME_End, Organizer_ID)
VALUES ('07:00','17:00', 000009);

INSERT INTO Organizer_Shifts (SHIFT_TIME_Start, SHIFT_TIME_End, Organizer_ID)
VALUES ('07:00','17:00', 000010);

INSERT INTO Organizer_Shifts (SHIFT_TIME_Start, SHIFT_TIME_End, Organizer_ID)
VALUES ('07:00','17:00', 000011);

INSERT INTO Organizer_Shifts (SHIFT_TIME_Start, SHIFT_TIME_End, Organizer_ID)
VALUES ('07:00','17:00', 000012);

INSERT INTO Organizer_Shifts (SHIFT_TIME_Start, SHIFT_TIME_End, Organizer_ID)
VALUES ('07:00','17:00', 000013);

INSERT INTO Organizer_Shifts (SHIFT_TIME_Start, SHIFT_TIME_End, Organizer_ID)
VALUES ('07:00','17:00', 000014);

INSERT INTO Organizer_Shifts (SHIFT_TIME_Start, SHIFT_TIME_End, Organizer_ID)
VALUES ('07:00','17:00', 000015);

INSERT INTO Organizer_Shifts (SHIFT_TIME_Start, SHIFT_TIME_End, Organizer_ID)
VALUES ('07:00','17:00', 000016);

INSERT INTO Organizer_Shifts (SHIFT_TIME_Start, SHIFT_TIME_End, Organizer_ID)
VALUES ('07:00','17:00', 000017);

INSERT INTO Organizer_Shifts (SHIFT_TIME_Start, SHIFT_TIME_End, Organizer_ID)
VALUES ('07:00','17:00', 000018);

INSERT INTO Organizer_Shifts (SHIFT_TIME_Start, SHIFT_TIME_End, Organizer_ID)
VALUES ('07:00','17:00', 000019);

INSERT INTO Organizer_Shifts (SHIFT_TIME_Start, SHIFT_TIME_End, Organizer_ID)
VALUES ('07:00','17:00', 000020);

--===================================================================== END NEW =========================================================================

SELECT * FROM Organizer_Shifts;

--=================================================================================================================================================

INSERT INTO Publishing_House (Publishing_House_NAME, Contacts)
VALUES ('«·ÃœÊ· «·ÕÌ', 01234567894)

INSERT INTO Publishing_House (Publishing_House_NAME, Contacts)
VALUES ('«·ﬂ—„… ··‰‘—', 01132546786)

INSERT INTO Publishing_House (Publishing_House_NAME, Contacts)
VALUES ('„ﬂ »… «·ﬂÊ‰', 01031587619)

--===================================================================== NEW =========================================================================

UPDATE Publishing_House
SET Publishing_House_NAME = 'Hindawi Publishing Corporation'
WHERE Contacts = 01234567894;

UPDATE Publishing_House
SET Publishing_House_NAME = 'Dar El-Farouk for Publishing and Distribution'
WHERE Contacts = 01132546786;

UPDATE Publishing_House
SET Publishing_House_NAME = 'Al-Dar Al-Masriah Al-Lubnaniah'
WHERE Contacts = 01031587619;

INSERT INTO Publishing_House (Publishing_House_NAME, Contacts)
VALUES ('EduGate Publishing and Distribution', 01003468591)

INSERT INTO Publishing_House (Publishing_House_NAME, Contacts)
VALUES ('Kalemat Arabia', 01025544221)

INSERT INTO Publishing_House (Publishing_House_NAME, Contacts)
VALUES ('Egyptian Cultural Assembly', 01254689523)

INSERT INTO Publishing_House (Publishing_House_NAME, Contacts)
VALUES ('Boustany', 01544662231)

INSERT INTO Publishing_House (Publishing_House_NAME, Contacts)
VALUES ('Al Arabi Publishing & Distributing', 01548263749)

INSERT INTO Publishing_House (Publishing_House_NAME, Contacts)
VALUES ('Malamih For Publishing & Distributing Books', 01032547985)

INSERT INTO Publishing_House (Publishing_House_NAME, Contacts)
VALUES ('Book House for Publishing & Media', 01187956854)

INSERT INTO Publishing_House (Publishing_House_NAME, Contacts)
VALUES ('Saray Publishing', 01098564585)

INSERT INTO Publishing_House (Publishing_House_NAME, Contacts)
VALUES ('Elias Modern', 01588969988)

INSERT INTO Publishing_House (Publishing_House_NAME, Contacts)
VALUES ('Dar El-Shams', 01236963696)

INSERT INTO Publishing_House (Publishing_House_NAME, Contacts)
VALUES ('International House for Cultural Investments', 01154878784)

INSERT INTO Publishing_House (Publishing_House_NAME, Contacts)
VALUES ('Atlas for Publishing and Informative Production', 01020545554)

INSERT INTO Publishing_House (Publishing_House_NAME, Contacts)
VALUES ('Nour Bag Printing', 01548777995)

INSERT INTO Publishing_House (Publishing_House_NAME, Contacts)
VALUES ('Mer Book House', 01000225546)


--===================================================================== END NEW =========================================================================

select * FROM Publishing_House;

--=================================================================================================================================================

INSERT INTO Book_Seller(FirstName, 
						MidName, 
						LastName, 
						ID, 
						Supervisor_ID, 
						National_ID,
						SALARY, 
						GENDER, 
						Position, 
						PASSWORD, 
						USERNAME)
VALUES ('Yahya', 'Ashraf', 'Mohamed', 100000, Null, 29712233336588, 10000, 'M', 'Leader', 'Yahya_BL@123', 'Yahya_BL');

INSERT INTO Book_Seller(FirstName, MidName, LastName, ID, Supervisor_ID, National_ID, SALARY, GENDER, Position, PASSWORD, USERNAME)
VALUES ('Malek', 'Yahya', 'yousef', 100001, 100000, 29105012515203, 8000, 'M', 'Vice-Leader', 'Yahya_BVL@123', 'Yahya_BVL');

INSERT INTO Book_Seller(FirstName, MidName, LastName, ID, Supervisor_ID, National_ID, SALARY, GENDER, Position, PASSWORD, USERNAME)
VALUES ('khaled', 'yasser', 'Ali', 100002, 100000, 31108313469873, 7000, 'M', 'Member', 'Yahya_BM@123', 'Yahya_BM');

--===================================================================== NEW =========================================================================

UPDATE Book_Seller
SET Supervisor_ID = NULL, Position = 'Book Seller Manager'
WHERE ID = 100000;

UPDATE Book_Seller
SET Supervisor_ID = 100000, Position = 'Leader'
WHERE ID = 100001;

UPDATE Book_Seller
SET Supervisor_ID = 100001, Position = 'Vice-Leader', National_ID = 30302535214683
WHERE ID = 100002;

INSERT INTO Book_Seller(FirstName, MidName, LastName, ID, Supervisor_ID, National_ID, SALARY, GENDER, Position, PASSWORD, USERNAME)
VALUES ('khaled', 'yasser', 'Ali', 100003, 100001, 28201281498619, 6500, 'M', 'Member', 'khaledBM@123', 'khaled_BM');

INSERT INTO Book_Seller(FirstName, MidName, LastName, ID, Supervisor_ID, National_ID, SALARY, GENDER, Position, PASSWORD, USERNAME)
VALUES ('Hagar', 'Noah', 'Ali', 100004, 100001, 28410220402001, 6000, 'M', 'Member', 'Hagar_BM@123', 'Hagar_BM');

INSERT INTO Book_Seller(FirstName, MidName, LastName, ID, Supervisor_ID, National_ID, SALARY, GENDER, Position, PASSWORD, USERNAME)
VALUES ('Ali', 'yasser', 'Mohamed', 100005, 100001, 31207221219061, 6000, 'M', 'Member', 'Ali_BM@123', 'Ali_BM');

INSERT INTO Book_Seller(FirstName, MidName, LastName, ID, Supervisor_ID, National_ID, SALARY, GENDER, Position, PASSWORD, USERNAME)
VALUES ('Basel', 'El sayed', 'Ali', 100006, 100001, 31012033303530, 6000, 'M', 'Member', 'Basel_BM@123', 'Basel_BM');

INSERT INTO Book_Seller(FirstName, MidName, LastName, ID, Supervisor_ID, National_ID, SALARY, GENDER, Position, PASSWORD, USERNAME)
VALUES ('Bahy', 'Yahya', 'Mohamed', 100007, 100001, 28801041322811, 5500, 'M', 'Member', 'Bahy_BM@123', 'Bahy_BM');

INSERT INTO Book_Seller(FirstName, MidName, LastName, ID, Supervisor_ID, National_ID, SALARY, GENDER, Position, PASSWORD, USERNAME)
VALUES ('Mariam', 'Nour', 'Adel', 100008, 100001, 29510012437976, 6000, 'F', 'Member', 'MariamNA@123', 'MariamANA');

INSERT INTO Book_Seller(FirstName, MidName, LastName, ID, Supervisor_ID, National_ID, SALARY, GENDER, Position, PASSWORD, USERNAME)
VALUES ('Marwa', 'Yassien', 'Ashraf', 100009, 100001, 30303230101245, 6000, 'F', 'Member', 'MarwaBM@123', 'MarwaBM');

INSERT INTO Book_Seller(FirstName, MidName, LastName, ID, Supervisor_ID, National_ID, SALARY, GENDER, Position, PASSWORD, USERNAME)
VALUES ('Yousra', 'Naser', 'Khaled', 100010, 100001, 31001303315751, 5000, 'F', 'Member', 'Yousra_BM@123', 'Yousra_BM');

INSERT INTO Book_Seller(FirstName, MidName, LastName, ID, Supervisor_ID, National_ID, SALARY, GENDER, Position, PASSWORD, USERNAME)
VALUES ('Naser', 'Marwan', 'Yahya', 100011, 100001, 29210172599481, 6000, 'M', 'Member', 'Naser@123', 'YNaserM');

INSERT INTO Book_Seller(FirstName, MidName, LastName, ID, Supervisor_ID, National_ID, SALARY, GENDER, Position, PASSWORD, USERNAME)
VALUES ('Kalefa', 'yasser', 'Ali', 100012, 100001, 30708192693215, 6000, 'M', 'Member', 'Kalefa_BM@123', 'Kalefa_BM');

INSERT INTO Book_Seller(FirstName, MidName, LastName, ID, Supervisor_ID, National_ID, SALARY, GENDER, Position, PASSWORD, USERNAME)
VALUES ('Marwan', 'Meki', 'Mohamed', 100013, 100001, 29903210482593, 6000, 'M', 'Member', 'Marwan@123', 'Marwan');

INSERT INTO Book_Seller(FirstName, MidName, LastName, ID, Supervisor_ID, National_ID, SALARY, GENDER, Position, PASSWORD, USERNAME)
VALUES ('Meki', 'Metwwaly', 'Rezk', 100014, 100001, 29910173387912, 6000, 'M', 'Member', 'Meki_BM@123', 'Meki_BM');

INSERT INTO Book_Seller(FirstName, MidName, LastName, ID, Supervisor_ID, National_ID, SALARY, GENDER, Position, PASSWORD, USERNAME)
VALUES ('Resk', 'Ahmed', 'Samy', 100015, 100001, 29505231402422, 6600, 'M', 'Member', 'ReskBM@123', 'Resk_BM');

INSERT INTO Book_Seller(FirstName, MidName, LastName, ID, Supervisor_ID, National_ID, SALARY, GENDER, Position, PASSWORD, USERNAME)
VALUES ('Samy', 'Samer', 'Ahmed', 100016, 100001, 30605310114816, 6500, 'M', 'Member', 'Samy@123', 'SamyAS');

INSERT INTO Book_Seller(FirstName, MidName, LastName, ID, Supervisor_ID, National_ID, SALARY, GENDER, Position, PASSWORD, USERNAME)
VALUES ('Samya', 'Yahya', 'Samy', 100017, 100001, 29212171672483, 5000, 'F', 'Member', 'Samya_BM@123', 'Samya');

INSERT INTO Book_Seller(FirstName, MidName, LastName, ID, Supervisor_ID, National_ID, SALARY, GENDER, Position, PASSWORD, USERNAME)
VALUES ('Somaya', 'Khaled', 'Rezk', 100018, 100001, 29308042487409, 6000, 'F', 'Member', 'Somayaa_BM@123', 'Somaya_BM');

INSERT INTO Book_Seller(FirstName, MidName, LastName, ID, Supervisor_ID, National_ID, SALARY, GENDER, Position, PASSWORD, USERNAME)
VALUES ('Sara', 'Resk', 'El-sayed', 100019, 100001, 28601241577473, 5000, 'F', 'Member', 'Saraa_BM@123', 'SaraRES_BM');

--===================================================================== END NEW =========================================================================

SELECT * FROM Book_Seller;

-----------------------------------------------------------

INSERT INTO Book_Seller_Works_IN(Letter, Section_Number, Hall_Number, Bookseller_ID)
VALUES ('B', 1, 1, 100000);

INSERT INTO Book_Seller_Works_IN(Letter, Section_Number, Hall_Number, Bookseller_ID)
VALUES ('B', 1, 1, 100001);

INSERT INTO Book_Seller_Works_IN(Letter, Section_Number, Hall_Number, Bookseller_ID)
VALUES ('B', 1, 1, 100002);

--===================================================================== NEW =========================================================================

INSERT INTO Book_Seller_Works_IN(Letter, Section_Number, Hall_Number, Bookseller_ID)
VALUES ('B', 1, 1, 100003);

INSERT INTO Book_Seller_Works_IN(Letter, Section_Number, Hall_Number, Bookseller_ID)
VALUES ('B', 1, 1, 100004);

INSERT INTO Book_Seller_Works_IN(Letter, Section_Number, Hall_Number, Bookseller_ID)
VALUES ('B', 2, 2, 100005);

INSERT INTO Book_Seller_Works_IN(Letter, Section_Number, Hall_Number, Bookseller_ID)
VALUES ('B', 2, 2, 100006);

INSERT INTO Book_Seller_Works_IN(Letter, Section_Number, Hall_Number, Bookseller_ID)
VALUES ('B', 2, 2, 100007);

INSERT INTO Book_Seller_Works_IN(Letter, Section_Number, Hall_Number, Bookseller_ID)
VALUES ('B', 2, 2, 100008);

INSERT INTO Book_Seller_Works_IN(Letter, Section_Number, Hall_Number, Bookseller_ID)
VALUES ('C', 2, 3, 100009);

INSERT INTO Book_Seller_Works_IN(Letter, Section_Number, Hall_Number, Bookseller_ID)
VALUES ('C', 2, 3, 100010);

INSERT INTO Book_Seller_Works_IN(Letter, Section_Number, Hall_Number, Bookseller_ID)
VALUES ('C', 2, 3, 100011);

INSERT INTO Book_Seller_Works_IN(Letter, Section_Number, Hall_Number, Bookseller_ID)
VALUES ('A', 1, 1, 100012);

INSERT INTO Book_Seller_Works_IN(Letter, Section_Number, Hall_Number, Bookseller_ID)
VALUES ('A', 1, 1, 100013);

INSERT INTO Book_Seller_Works_IN(Letter, Section_Number, Hall_Number, Bookseller_ID)
VALUES ('A', 1, 1, 100014);

INSERT INTO Book_Seller_Works_IN(Letter, Section_Number, Hall_Number, Bookseller_ID)
VALUES ('A', 1, 1, 100015);

INSERT INTO Book_Seller_Works_IN(Letter, Section_Number, Hall_Number, Bookseller_ID)
VALUES ('C', 1, 1, 100016);

INSERT INTO Book_Seller_Works_IN(Letter, Section_Number, Hall_Number, Bookseller_ID)
VALUES ('C', 1, 1, 100017);

INSERT INTO Book_Seller_Works_IN(Letter, Section_Number, Hall_Number, Bookseller_ID)
VALUES ('C', 1, 1, 100018);

INSERT INTO Book_Seller_Works_IN(Letter, Section_Number, Hall_Number, Bookseller_ID)
VALUES ('C', 1, 1, 100019);

--===================================================================== END NEW =========================================================================

SELECT * FROM Book_Seller_Works_IN;

------------------------------------------------------------

INSERT INTO Book_Seller_Phones(PhoneNum, Book_Seller_ID)
VALUES (01202006004, 100000);

INSERT INTO Book_Seller_Phones (PhoneNum, Book_Seller_ID)
VALUES (01532116004, 100001);

INSERT INTO Book_Seller_Phones (PhoneNum, Book_Seller_ID)
VALUES (01069552113, 100002);

SELECT * FROM Book_Seller_Phones;

--------------------------------------------------------

INSERT INTO Book_Seller_Shifts (SHIFT_TIME_Start, SHIFT_TIME_End, Book_Seller_ID)
VALUES ('07:00','14:00', 100000);

INSERT INTO Book_Seller_Shifts (SHIFT_TIME_Start, SHIFT_TIME_End, Book_Seller_ID)
VALUES ('07:00','11:00', 100002);

INSERT INTO Book_Seller_Shifts (SHIFT_TIME_Start, SHIFT_TIME_End, Book_Seller_ID)
VALUES ('14:00','17:00', 100002);

INSERT INTO Book_Seller_Shifts (SHIFT_TIME_Start, SHIFT_TIME_End, Book_Seller_ID)
VALUES ('07:00','17:00', 100001);

--===================================================================== NEW =========================================================================

INSERT INTO Book_Seller_Shifts (SHIFT_TIME_Start, SHIFT_TIME_End, Book_Seller_ID)
VALUES ('07:00','17:00', 100003);

INSERT INTO Book_Seller_Shifts (SHIFT_TIME_Start, SHIFT_TIME_End, Book_Seller_ID)
VALUES ('07:00','17:00', 100004);

INSERT INTO Book_Seller_Shifts (SHIFT_TIME_Start, SHIFT_TIME_End, Book_Seller_ID)
VALUES ('07:00','17:00', 100005);

INSERT INTO Book_Seller_Shifts (SHIFT_TIME_Start, SHIFT_TIME_End, Book_Seller_ID)
VALUES ('07:00','17:00', 100006);

INSERT INTO Book_Seller_Shifts (SHIFT_TIME_Start, SHIFT_TIME_End, Book_Seller_ID)
VALUES ('07:00','17:00', 100007);

INSERT INTO Book_Seller_Shifts (SHIFT_TIME_Start, SHIFT_TIME_End, Book_Seller_ID)
VALUES ('07:00','17:00', 100008);

INSERT INTO Book_Seller_Shifts (SHIFT_TIME_Start, SHIFT_TIME_End, Book_Seller_ID)
VALUES ('07:00','17:00', 100009);

INSERT INTO Book_Seller_Shifts (SHIFT_TIME_Start, SHIFT_TIME_End, Book_Seller_ID)
VALUES ('07:00','17:00', 100010);

INSERT INTO Book_Seller_Shifts (SHIFT_TIME_Start, SHIFT_TIME_End, Book_Seller_ID)
VALUES ('07:00','17:00', 100011);

INSERT INTO Book_Seller_Shifts (SHIFT_TIME_Start, SHIFT_TIME_End, Book_Seller_ID)
VALUES ('07:00','17:00', 100012);

INSERT INTO Book_Seller_Shifts (SHIFT_TIME_Start, SHIFT_TIME_End, Book_Seller_ID)
VALUES ('07:00','17:00', 100013);

INSERT INTO Book_Seller_Shifts (SHIFT_TIME_Start, SHIFT_TIME_End, Book_Seller_ID)
VALUES ('07:00','17:00', 100014);

INSERT INTO Book_Seller_Shifts (SHIFT_TIME_Start, SHIFT_TIME_End, Book_Seller_ID)
VALUES ('07:00','17:00', 100015);

INSERT INTO Book_Seller_Shifts (SHIFT_TIME_Start, SHIFT_TIME_End, Book_Seller_ID)
VALUES ('07:00','17:00', 100016);

INSERT INTO Book_Seller_Shifts (SHIFT_TIME_Start, SHIFT_TIME_End, Book_Seller_ID)
VALUES ('07:00','17:00', 100017);

INSERT INTO Book_Seller_Shifts (SHIFT_TIME_Start, SHIFT_TIME_End, Book_Seller_ID)
VALUES ('07:00','17:00', 100018);

INSERT INTO Book_Seller_Shifts (SHIFT_TIME_Start, SHIFT_TIME_End, Book_Seller_ID)
VALUES ('07:00','17:00', 100019);

--===================================================================== END NEW =========================================================================

SELECT * FROM Book_Seller_Shifts;

--==================================================================================

INSERT INTO Volunters(FirstName, 
						MidName, 
						LastName, 
						ID, 
						Supervisor_ID, 
						NationalID,
						SALARY, 
						GENDER,
						Event_Code,
						Position, 
						DPASSWORD, 
						USERNAME,
						CATEGORY)
VALUES ('Yahya', 'Ashraf', 'Mohamed', 400000, 000000, 28505280129356, 0, 'M', 1234, 'Leader', 'Yahya_VL@123', 'Yahya_VL', 'Event Organizer');

INSERT INTO Volunters(FirstName, MidName, LastName, ID, Supervisor_ID, NationalID,SALARY, GENDER, Event_Code, Position, DPASSWORD, USERNAME, CATEGORY)
VALUES ('Fawzy', 'Yassser', 'Ali', 400001, 000000, 29812021301303, 0, 'M', 1234, 'Vice-Leader', 'Yahya_VVL@123', 'Yahya_VVL', 'Event Organizer');

INSERT INTO Volunters(FirstName, MidName, LastName, ID, Supervisor_ID, NationalID,SALARY, GENDER, Event_Code, Position, DPASSWORD, USERNAME, CATEGORY)
VALUES ('Mariam', 'Mokhtar', 'Ali', 400002, 000000, 28310048814407, 0, 'F', 1234, 'Member', 'Mariam_VM@123', 'Mariam_VM', 'Tour guide');

--===================================================================== NEW =========================================================================

UPDATE Volunters
SET Supervisor_ID = 000001, FirstName = 'Yahya', MidName = 'Ashraf', LastName = 'Mohamed'
WHERE ID = 400000;

UPDATE Volunters
SET Supervisor_ID = 000001
WHERE ID = 400001;

UPDATE Volunters
SET Supervisor_ID = 000001, NationalID = 20304269139582
WHERE ID = 400002;

INSERT INTO Volunters(FirstName, MidName, LastName, ID, Supervisor_ID, NationalID,SALARY, GENDER, Event_Code, Position, DPASSWORD, USERNAME, CATEGORY)
VALUES ('Yousra', 'Mokhtar', 'Ahmed', 400003, 000001, 28612021291436, 0, 'F', 1234, 'Member', 'Yousra_VM@123', 'Yousra_VM', 'Tour guide');

INSERT INTO Volunters(FirstName, MidName, LastName, ID, Supervisor_ID, NationalID,SALARY, GENDER, Event_Code, Position, DPASSWORD, USERNAME, CATEGORY)
VALUES ('Yara', 'Mokhtar', 'Ali', 400004, 000001, 30103043214169, 0, 'F', 1234, 'Member', 'Yara_VM@123', 'Yara_VM', 'Cafeteria');

INSERT INTO Volunters(FirstName, MidName, LastName, ID, Supervisor_ID, NationalID,SALARY, GENDER, Event_Code, Position, DPASSWORD, USERNAME, CATEGORY)
VALUES ('Yousra', 'Mohamed', 'Ali', 400005, 000009, 28205051695125, 1500, 'F', 4652, 'Leader', 'Yousra23', 'Yousra_VL', 'Event Organizer');

INSERT INTO Volunters(FirstName, MidName, LastName, ID, Supervisor_ID, NationalID,SALARY, GENDER, Event_Code, Position, DPASSWORD, USERNAME, CATEGORY)
VALUES ('Tamer', 'Nouh', 'Adel', 400006, 000009, 29612051417449, 1000, 'M', 4652, 'Vice-Leader', 'Tamer_VM@123', 'TamerVL', 'Event Organizer');

INSERT INTO Volunters(FirstName, MidName, LastName, ID, Supervisor_ID, NationalID,SALARY, GENDER, Event_Code, Position, DPASSWORD, USERNAME, CATEGORY)
VALUES ('Taha', 'Musa', 'Adel', 400007, 000009, 28108172306687, 0, 'M', 4652, 'Member', 'Taha_VM@123', 'Taha_VM', 'Event Organizer');

INSERT INTO Volunters(FirstName, MidName, LastName, ID, Supervisor_ID, NationalID,SALARY, GENDER, Event_Code, Position, DPASSWORD, USERNAME, CATEGORY)
VALUES ('Yousef', 'Yahya', 'Yassin', 400008, 000009, 28805311111204, 0, 'M', 4652, 'Member', 'Yousef_VM@123', 'Yousef_VM', 'Tour guide');

INSERT INTO Volunters(FirstName, MidName, LastName, ID, Supervisor_ID, NationalID,SALARY, GENDER, Event_Code, Position, DPASSWORD, USERNAME, CATEGORY)
VALUES ('Lobna', 'Nour', 'EL-sayed', 400009, 000009, 30710033145161, 0, 'F', 4652, 'Member', 'Lobna_VM@123', 'Lobna_VM', 'Tour guide');

INSERT INTO Volunters(FirstName, MidName, LastName, ID, Supervisor_ID, NationalID,SALARY, GENDER, Event_Code, Position, DPASSWORD, USERNAME, CATEGORY)
VALUES ('Yahya', 'Nader', 'Ali', 400010, 000015, 28305053554049, 0, 'M', 1817, 'Leader', 'Yahya_VM@123', 'Yahya_VM', 'Event Organizer');

INSERT INTO Volunters(FirstName, MidName, LastName, ID, Supervisor_ID, NationalID,SALARY, GENDER, Event_Code, Position, DPASSWORD, USERNAME, CATEGORY)
VALUES ('Nader', 'Nabel', 'Naser', 400011, 000015, 28301223234797, 0, 'M', 1817, 'Vice-Leader', 'Nader_VM@123', 'Nader_VM', 'Event Organizer');

INSERT INTO Volunters(FirstName, MidName, LastName, ID, Supervisor_ID, NationalID,SALARY, GENDER, Event_Code, Position, DPASSWORD, USERNAME, CATEGORY)
VALUES ('Nabawya', 'El-sayed', 'Ali', 400012, 000015, 28010271789672, 0, 'F', 1817, 'Member', 'Nabawya_VM@123', 'Nabawya_VM', 'Event Organizer');

INSERT INTO Volunters(FirstName, MidName, LastName, ID, Supervisor_ID, NationalID,SALARY, GENDER, Event_Code, Position, DPASSWORD, USERNAME, CATEGORY)
VALUES ('Mariam', 'Mohamed', 'Mokhtar', 400013, 000015, 28510170279846, 0, 'F', 1817, 'Member', 'Mero_VM@123', 'Mero_VM', 'Event Organizer');

INSERT INTO Volunters(FirstName, MidName, LastName, ID, Supervisor_ID, NationalID,SALARY, GENDER, Event_Code, Position, DPASSWORD, USERNAME, CATEGORY)
VALUES ('Tarek', 'Tamer', 'Tohamy', 400014, 000015, 28403200483219, 0, 'M', 1817, 'Member', 'Tarek_VM@123', 'TarekVM', 'Event Organizer');

INSERT INTO Volunters(FirstName, MidName, LastName, ID, Supervisor_ID, NationalID,SALARY, GENDER, Event_Code, Position, DPASSWORD, USERNAME, CATEGORY)
VALUES ('Malek', 'Mansour', 'Yahya', 400015, 000015, 28212073582312, 0, 'M', 1817, 'Member', 'Malek_VM@123', 'Malek_VM', 'Tour guide');

INSERT INTO Volunters(FirstName, MidName, LastName, ID, Supervisor_ID, NationalID,SALARY, GENDER, Event_Code, Position, DPASSWORD, USERNAME, CATEGORY)
VALUES ('Mohamed', 'Nader', 'Ibrahem', 400016, 000015, 30705110119962, 0, 'M', 1817, 'Member', 'Mohamed123', 'Mohamed777', 'Tour guide');

INSERT INTO Volunters(FirstName, MidName, LastName, ID, Supervisor_ID, NationalID,SALARY, GENDER, Event_Code, Position, DPASSWORD, USERNAME, CATEGORY)
VALUES ('Maram', 'Yassin', 'Younes', 400017, 000015, 28512181468192, 0, 'F', 1817, 'Member', 'Maram@123', 'Maram_VM', 'Tour guide');

INSERT INTO Volunters(FirstName, MidName, LastName, ID, Supervisor_ID, NationalID,SALARY, GENDER, Event_Code, Position, DPASSWORD, USERNAME, CATEGORY)
VALUES ('Mario', 'Mosa', 'Ali', 400018, 000015, 28903123330526, 0, 'M', 1817, 'Member', 'Mario879', 'Mario55', 'Cafeteria');

INSERT INTO Volunters(FirstName, MidName, LastName, ID, Supervisor_ID, NationalID,SALARY, GENDER, Event_Code, Position, DPASSWORD, USERNAME, CATEGORY)
VALUES ('Abd-Allah', 'Ahmed', 'Rezk', 400019, 000015, 28512033230972, 0, 'M', 1817, 'Member', 'Abd-Allah@123', 'Abd-Allah', 'Cafeteria');

--===================================================================== END NEW =========================================================================

SELECT * FROM Volunters;
SELECT * FROM Organizers;
-----------------------------------------------------------------------

INSERT INTO Volunter_Phone (PhoneNum, Volunter_ID)
VALUES (01201342689, 400000);

INSERT INTO Volunter_Phone (PhoneNum, Volunter_ID)
VALUES (01078426158, 400000);

INSERT INTO Volunter_Phone (PhoneNum, Volunter_ID)
VALUES (01132664819, 400001);

INSERT INTO Volunter_Phone (PhoneNum, Volunter_ID)
VALUES (01242693581, 400002);

SELECT * FROM Volunter_Phone;
--------------------------------------------

INSERT INTO Volunter_Shift (SHIFT_TIME_Start, SHIFT_TIME_End, Volunter_ID)
VALUES ('08:00','14:00', 400000);

INSERT INTO Volunter_Shift (SHIFT_TIME_Start, SHIFT_TIME_End, Volunter_ID)
VALUES ('08:00','14:00', 400001);

INSERT INTO Volunter_Shift (SHIFT_TIME_Start, SHIFT_TIME_End, Volunter_ID)
VALUES ('08:00','14:00', 400002);

--===================================================================== NEW =========================================================================

INSERT INTO Volunter_Shift (SHIFT_TIME_Start, SHIFT_TIME_End, Volunter_ID)
VALUES ('10:00','14:00', 400003);

INSERT INTO Volunter_Shift (SHIFT_TIME_Start, SHIFT_TIME_End, Volunter_ID)
VALUES ('10:00','14:00', 400004);

INSERT INTO Volunter_Shift (SHIFT_TIME_Start, SHIFT_TIME_End, Volunter_ID)
VALUES ('10:00','14:00', 400005);

INSERT INTO Volunter_Shift (SHIFT_TIME_Start, SHIFT_TIME_End, Volunter_ID)
VALUES ('10:00','14:00', 400006);

INSERT INTO Volunter_Shift (SHIFT_TIME_Start, SHIFT_TIME_End, Volunter_ID)
VALUES ('10:00','14:00', 400007);

INSERT INTO Volunter_Shift (SHIFT_TIME_Start, SHIFT_TIME_End, Volunter_ID)
VALUES ('10:00','14:00', 400008);

INSERT INTO Volunter_Shift (SHIFT_TIME_Start, SHIFT_TIME_End, Volunter_ID)
VALUES ('10:00','14:00', 400009);

INSERT INTO Volunter_Shift (SHIFT_TIME_Start, SHIFT_TIME_End, Volunter_ID)
VALUES ('10:00','14:00', 400010);

INSERT INTO Volunter_Shift (SHIFT_TIME_Start, SHIFT_TIME_End, Volunter_ID)
VALUES ('10:00','14:00', 400011);

INSERT INTO Volunter_Shift (SHIFT_TIME_Start, SHIFT_TIME_End, Volunter_ID)
VALUES ('10:00','14:00', 400012);

INSERT INTO Volunter_Shift (SHIFT_TIME_Start, SHIFT_TIME_End, Volunter_ID)
VALUES ('10:00','14:00', 400013);

INSERT INTO Volunter_Shift (SHIFT_TIME_Start, SHIFT_TIME_End, Volunter_ID)
VALUES ('10:00','14:00', 400014);

INSERT INTO Volunter_Shift (SHIFT_TIME_Start, SHIFT_TIME_End, Volunter_ID)
VALUES ('10:00','14:00', 400015);

INSERT INTO Volunter_Shift (SHIFT_TIME_Start, SHIFT_TIME_End, Volunter_ID)
VALUES ('10:00','14:00', 400016);

INSERT INTO Volunter_Shift (SHIFT_TIME_Start, SHIFT_TIME_End, Volunter_ID)
VALUES ('10:00','14:00', 400017);

INSERT INTO Volunter_Shift (SHIFT_TIME_Start, SHIFT_TIME_End, Volunter_ID)
VALUES ('10:00','14:00', 400018);

INSERT INTO Volunter_Shift (SHIFT_TIME_Start, SHIFT_TIME_End, Volunter_ID)
VALUES ('10:00','14:00', 400019);

--===================================================================== END NEW =========================================================================

SELECT * FROM Volunter_Shift;

--=====================================================================================


INSERT INTO Media(FirstName, 
						MidName, 
						LastName, 
						ID, 
						Supervisor_ID, 
						National_ID,
						GENDER,
						Event_Code,  
						Channel_Name,
						Position, 
						PASSWORD, 
						USERNAME)
VALUES ('Yahya', 'Ali', 'Mohamed', 300000, NULL, 29103311241643, 'M', 1234, 'El-Haya', 'Leader', 'Yahya_ML@123', 'Yahya_ML');

INSERT INTO Media(FirstName, MidName, LastName, ID, Supervisor_ID, National_ID, GENDER, Event_Code, Channel_Name, Position, PASSWORD, USERNAME)
VALUES ('Yahya', 'Mohamed', 'Ali', 300001, 300000, 29805072806930, 'M', 1234, 'El-Haya', 'Vice-Leader', 'Yahya_MVL@123', 'Yahya_MVL');

INSERT INTO Media(FirstName, MidName, LastName, ID, Supervisor_ID, National_ID, GENDER, Event_Code, Channel_Name, Position, PASSWORD, USERNAME)
VALUES ('khaled', 'yasser', 'Ali', 300002, 300000, 31112253521554, 'M', 1234, 'El-Haya', 'Member', 'khaled_MM@123', 'khaled_MM');

--===================================================================== NEW =========================================================================

UPDATE Media
SET Supervisor_ID = NULL, Position = 'Media Manager'
WHERE ID = 300000;

UPDATE Media
SET Supervisor_ID = 300000, Position = 'Leader'
WHERE ID = 300001;

UPDATE Media
SET Supervisor_ID = 300001, Position = 'Vice-Leader'
WHERE ID = 300002;

INSERT INTO Media(FirstName, MidName, LastName, ID, Supervisor_ID, National_ID, GENDER, Event_Code, Channel_Name, Position, PASSWORD, USERNAME)
VALUES ('Younes', 'Naser', 'Ali', 300003, 300001, 31012141400160, 'M', 1234, 'El-Haya', 'Member', 'Younes_MM@123', 'Younes_MM');


INSERT INTO Media(FirstName, MidName, LastName, ID, Supervisor_ID, National_ID, GENDER, Event_Code, Channel_Name, Position, PASSWORD, USERNAME)
VALUES ('Jaser', 'Nader', 'Nabel', 300004, 300001, 31010031305890, 'M', 1234, 'El-Haya', 'Member', 'Jaser_MM@123', 'Jaser_MM');


INSERT INTO Media(FirstName, MidName, LastName, ID, Supervisor_ID, National_ID, GENDER, Event_Code, Channel_Name, Position, PASSWORD, USERNAME)
VALUES ('Yara', 'Ashraf', 'Ali', 300005, 300001, 30205272142531, 'M', 1234, 'El-Haya', 'Member', 'Yara_MM@123', 'Yara_MM');


INSERT INTO Media(FirstName, MidName, LastName, ID, Supervisor_ID, National_ID, GENDER, Event_Code, Channel_Name, Position, PASSWORD, USERNAME)
VALUES ('Talal', 'Yahya', 'Mansour', 300006, 300001, 30512252395381, 'M', 4652, 'El-Nour', 'Leader', 'Talal_MM@123', 'Talal_MM');


INSERT INTO Media(FirstName, MidName, LastName, ID, Supervisor_ID, National_ID, GENDER, Event_Code, Channel_Name, Position, PASSWORD, USERNAME)
VALUES ('Kasem', 'yasser', 'Ali', 300007, 300001, 30412248883766, 'M', 4652, 'El-Nour', 'Vice-Leader', 'Kasem_MM@123', 'Kasem_MM');


INSERT INTO Media(FirstName, MidName, LastName, ID, Supervisor_ID, National_ID, GENDER, Event_Code, Channel_Name, Position, PASSWORD, USERNAME)
VALUES ('Nada', 'Ismail', 'Hatem', 300008, 300001, 28203250411036, 'F', 4652, 'El-Nour', 'Member', 'Nada_MM@123', 'Nada_MM');


INSERT INTO Media(FirstName, MidName, LastName, ID, Supervisor_ID, National_ID, GENDER, Event_Code, Channel_Name, Position, PASSWORD, USERNAME)
VALUES ('Islam', 'Nasser', 'Yousef', 300009, 300001, 30312130468726, 'M', 4652, 'El-Nour', 'Member', 'Islam_MM@123', 'Islam_MM');


INSERT INTO Media(FirstName, MidName, LastName, ID, Supervisor_ID, National_ID, GENDER, Event_Code, Channel_Name, Position, PASSWORD, USERNAME)
VALUES ('Nasra', 'Mohamed', 'Ismail', 300010, 300001, 29110242586378, 'F', 4652, 'El-Nour', 'Member', 'Nasra_MM@123', 'Nasra_MM');


INSERT INTO Media(FirstName, MidName, LastName, ID, Supervisor_ID, National_ID, GENDER, Event_Code, Channel_Name, Position, PASSWORD, USERNAME)
VALUES ('Kalefa', 'Kaled', 'Ali', 300011, 300001, 28001121267218, 'M', 4652, 'El-Nour', 'Member', 'Kalefa_MM@123', 'Kalefa_MM');


INSERT INTO Media(FirstName, MidName, LastName, ID, Supervisor_ID, National_ID, GENDER, Event_Code, Channel_Name, Position, PASSWORD, USERNAME)
VALUES ('Maleka', 'Mohamed', 'Ahmed', 300013, 300001, 28307091935321, 'M', 1817, 'Awl be Awl', 'Leader', 'maleka_MM@123', 'Maleka_MM');


INSERT INTO Media(FirstName, MidName, LastName, ID, Supervisor_ID, National_ID, GENDER, Event_Code, Channel_Name, Position, PASSWORD, USERNAME)
VALUES ('Kasem', 'Kaream', 'Yahya', 300014, 300001, 29305091990793, 'M', 1817, 'Awl be Awl', 'Vice-Leader', 'Kasem@123', 'Kasem70');


INSERT INTO Media(FirstName, MidName, LastName, ID, Supervisor_ID, National_ID, GENDER, Event_Code, Channel_Name, Position, PASSWORD, USERNAME)
VALUES ('Marwa', 'Malek', 'Khalefa', 300015, 300001, 30905111284520, 'F', 1817, 'Awl be Awl', 'Member', 'Marwa_MM@123', 'Marwa_MM');


INSERT INTO Media(FirstName, MidName, LastName, ID, Supervisor_ID, National_ID, GENDER, Event_Code, Channel_Name, Position, PASSWORD, USERNAME)
VALUES ('Asmaa', 'Mamdouh', 'Malek', 300016, 300001, 29601112171075, 'F', 1817, 'Awl be Awl', 'Member', 'Asmaa_MM@123', 'Asmaa_MM');


INSERT INTO Media(FirstName, MidName, LastName, ID, Supervisor_ID, National_ID, GENDER, Event_Code, Channel_Name, Position, PASSWORD, USERNAME)
VALUES ('Marwan', 'El-sayed', 'Ali', 300017, 300001, 28405071980970, 'M', 1817, 'Awl be Awl', 'Member', 'Marwan@123', 'MarwanSA_MM');


INSERT INTO Media(FirstName, MidName, LastName, ID, Supervisor_ID, National_ID, GENDER, Event_Code, Channel_Name, Position, PASSWORD, USERNAME)
VALUES ('Nasra', 'Yahya', 'Mohamed', 300018, 300001, 31101312110591, 'F', 1817, 'Awl be Awl', 'Member', 'Nasra@123', 'NasraYM');


INSERT INTO Media(FirstName, MidName, LastName, ID, Supervisor_ID, National_ID, GENDER, Event_Code, Channel_Name, Position, PASSWORD, USERNAME)
VALUES ('Khalefa', 'Yahya', 'Nabel', 300019, 300001, 30612252145677, 'M', 1817, 'Awl be Awl', 'Member', 'KhalefaMM@123', 'KhalefaYN_MM30');

--===================================================================== END NEW =========================================================================

SELECT * FROM Media;

------------------------------------------------------------

INSERT INTO Media_Phones(PhoneNum, Media_ID)
VALUES (01036429418, 300000);

INSERT INTO Media_Phones (PhoneNum, Media_ID)
VALUES (01523446859, 300001);

INSERT INTO Media_Phones (PhoneNum, Media_ID)
VALUES (01030102405, 300002);

SELECT * FROM Media_Phones;

--------------------------------------------------------

INSERT INTO Media_Shifts (SHIFT_TIME_Start, SHIFT_TIME_End, Media_ID)
VALUES ('09:00','14:00', 300000);

INSERT INTO Media_Shifts (SHIFT_TIME_Start, SHIFT_TIME_End, Media_ID)
VALUES ('09:00','14:00', 300001);

INSERT INTO Media_Shifts (SHIFT_TIME_Start, SHIFT_TIME_End, Media_ID)
VALUES ('09:00','14:00', 300002);

--===================================================================== NEW =========================================================================

INSERT INTO Media_Shifts (SHIFT_TIME_Start, SHIFT_TIME_End, Media_ID)
VALUES ('09:00','14:00', 300003);

INSERT INTO Media_Shifts (SHIFT_TIME_Start, SHIFT_TIME_End, Media_ID)
VALUES ('09:00','14:00', 300004);

INSERT INTO Media_Shifts (SHIFT_TIME_Start, SHIFT_TIME_End, Media_ID)
VALUES ('09:00','14:00', 300005);

INSERT INTO Media_Shifts (SHIFT_TIME_Start, SHIFT_TIME_End, Media_ID)
VALUES ('09:00','14:00', 300006);

INSERT INTO Media_Shifts (SHIFT_TIME_Start, SHIFT_TIME_End, Media_ID)
VALUES ('09:00','14:00', 300007);

INSERT INTO Media_Shifts (SHIFT_TIME_Start, SHIFT_TIME_End, Media_ID)
VALUES ('09:00','14:00', 300008);

INSERT INTO Media_Shifts (SHIFT_TIME_Start, SHIFT_TIME_End, Media_ID)
VALUES ('09:00','14:00', 300009);

INSERT INTO Media_Shifts (SHIFT_TIME_Start, SHIFT_TIME_End, Media_ID)
VALUES ('09:00','14:00', 300010);

INSERT INTO Media_Shifts (SHIFT_TIME_Start, SHIFT_TIME_End, Media_ID)
VALUES ('09:00','14:00', 300011);

INSERT INTO Media_Shifts (SHIFT_TIME_Start, SHIFT_TIME_End, Media_ID)
VALUES ('09:00','14:00', 300012);

INSERT INTO Media_Shifts (SHIFT_TIME_Start, SHIFT_TIME_End, Media_ID)
VALUES ('09:00','14:00', 300013);

INSERT INTO Media_Shifts (SHIFT_TIME_Start, SHIFT_TIME_End, Media_ID)
VALUES ('09:00','14:00', 300014);

INSERT INTO Media_Shifts (SHIFT_TIME_Start, SHIFT_TIME_End, Media_ID)
VALUES ('09:00','14:00', 300015);

INSERT INTO Media_Shifts (SHIFT_TIME_Start, SHIFT_TIME_End, Media_ID)
VALUES ('09:00','14:00', 300016);

INSERT INTO Media_Shifts (SHIFT_TIME_Start, SHIFT_TIME_End, Media_ID)
VALUES ('09:00','14:00', 300017);

INSERT INTO Media_Shifts (SHIFT_TIME_Start, SHIFT_TIME_End, Media_ID)
VALUES ('09:00','14:00', 300018);

INSERT INTO Media_Shifts (SHIFT_TIME_Start, SHIFT_TIME_End, Media_ID)
VALUES ('09:00','14:00', 300019);

--===================================================================== END NEW =========================================================================

SELECT * FROM Media_Shifts;

--================================================================================================================

INSERT INTO Ticket_Reserves(FirstName, 
						MidName, 
						LastName, 
						ID, 
						Supervisor_ID, 
						National_ID,
						SALARY, 
						GENDER, 
						Position, 
						PASSWORD, 
						USERNAME)
VALUES ('Yahya', 'Ashraf', 'Mohamed', 200000, NULL, 28608062366843, 3500, 'M', 'Ticket Reserves Manager', 'Yahya_TVL@123', 'Yahya_TVL');

INSERT INTO Ticket_Reserves(FirstName, MidName, LastName, ID, Supervisor_ID, National_ID, SALARY, GENDER, Position, PASSWORD, USERNAME)
VALUES ('Malek', 'Yahya', 'yousef', 200001, 200001, 28812202152521, 3000, 'M', 'Leader', 'Malek_TM@123', 'Malek_TM');

INSERT INTO Ticket_Reserves(FirstName, MidName, LastName, ID, Supervisor_ID, National_ID, SALARY, GENDER, Position, PASSWORD, USERNAME)
VALUES ('khaled', 'yasser', 'Ali', 200002, 200001, 31207183509746, 3000, 'M', 'Vice-Leader', 'khaled_TM@123', 'khaled_TM');

--===================================================================== NEW =========================================================================


INSERT INTO Ticket_Reserves(FirstName, MidName, LastName, ID, Supervisor_ID, National_ID, SALARY, GENDER, Position, PASSWORD, USERNAME)
VALUES ('Kasem', 'Yahya', 'Ali', 200003, 200001, 28605011474313, 3000, 'M', 'Vice-Leader', 'Kasem_TM@123', 'Kasem_TM');

--change from her
INSERT INTO Ticket_Reserves(FirstName, MidName, LastName, ID, Supervisor_ID, National_ID, SALARY, GENDER, Position, PASSWORD, USERNAME)
VALUES ('Marwan', 'yasser', 'Saleh', 200004, 200001, 30403071911269, 3000, 'M', 'Member', 'khaled_TM@123', 'khaled_TM');


INSERT INTO Ticket_Reserves(FirstName, MidName, LastName, ID, Supervisor_ID, National_ID, SALARY, GENDER, Position, PASSWORD, USERNAME)
VALUES ('Saleh', 'Mahmoud', 'Ali', 200005, 200001, 29710183538851, 3000, 'M', 'Member', 'khaled_TM@123', 'khaled_TM');


INSERT INTO Ticket_Reserves(FirstName, MidName, LastName, ID, Supervisor_ID, National_ID, SALARY, GENDER, Position, PASSWORD, USERNAME)
VALUES ('Ali', 'El-Dean', 'Mahmoud', 200006, 200001, 29112288854924, 3000, 'M', 'Member', 'khaled_TM@123', 'khaled_TM');


INSERT INTO Ticket_Reserves(FirstName, MidName, LastName, ID, Supervisor_ID, National_ID, SALARY, GENDER, Position, PASSWORD, USERNAME)
VALUES ('Mohamed', 'Wael', 'Mohamed', 200007, 200001, 28812238897459, 3000, 'M', 'Member', 'khaled_TM@123', 'khaled_TM');


INSERT INTO Ticket_Reserves(FirstName, MidName, LastName, ID, Supervisor_ID, National_ID, SALARY, GENDER, Position, PASSWORD, USERNAME)
VALUES ('Wael', 'yasser', 'Mansour', 200008, 200001, 30303053145898, 3000, 'M', 'Member', 'khaled_TM@123', 'khaled_TM');


INSERT INTO Ticket_Reserves(FirstName, MidName, LastName, ID, Supervisor_ID, National_ID, SALARY, GENDER, Position, PASSWORD, USERNAME)
VALUES ('Khalefa', 'Naser', 'Ali', 200009, 200001, 30208213283359, 3000, 'M', 'Member', 'khaled_TM@123', 'khaled_TM');


INSERT INTO Ticket_Reserves(FirstName, MidName, LastName, ID, Supervisor_ID, National_ID, SALARY, GENDER, Position, PASSWORD, USERNAME)
VALUES ('Medhat', 'Saleh', 'Adel', 200010, 200001, 30603260200259, 3000, 'M', 'Member', 'khaled_TM@123', 'khaled_TM');


INSERT INTO Ticket_Reserves(FirstName, MidName, LastName, ID, Supervisor_ID, National_ID, SALARY, GENDER, Position, PASSWORD, USERNAME)
VALUES ('Basel', 'Ahmed', 'Abel-Al', 200011, 200001, 30507021461637, 3000, 'M', 'Member', 'khaled_TM@123', 'khaled_TM');


INSERT INTO Ticket_Reserves(FirstName, MidName, LastName, ID, Supervisor_ID, National_ID, SALARY, GENDER, Position, PASSWORD, USERNAME)
VALUES ('Tawfek', 'Hakem', 'Nouh', 200012, 200001, 28801250195191, 3000, 'M', 'Member', 'khaled_TM@123', 'khaled_TM');


INSERT INTO Ticket_Reserves(FirstName, MidName, LastName, ID, Supervisor_ID, National_ID, SALARY, GENDER, Position, PASSWORD, USERNAME)
VALUES ('Hakem', 'Tawfek', 'Yahya', 200013, 200001, 29505050119550, 3000, 'M', 'Member', 'khaled_TM@123', 'khaled_TM');


INSERT INTO Ticket_Reserves(FirstName, MidName, LastName, ID, Supervisor_ID, National_ID, SALARY, GENDER, Position, PASSWORD, USERNAME)
VALUES ('Nour', 'Yahya', 'Ashraf', 200014, 200001, 29708081513937, 3000, 'F', 'Member', 'khaled_TM@123', 'khaled_TM');


INSERT INTO Ticket_Reserves(FirstName, MidName, LastName, ID, Supervisor_ID, National_ID, SALARY, GENDER, Position, PASSWORD, USERNAME)
VALUES ('Tasneem', 'yasser', 'Ali', 200015, 200001, 28612121810796, 3000, 'F', 'Member', 'khaled_TM@123', 'khaled_TM');


INSERT INTO Ticket_Reserves(FirstName, MidName, LastName, ID, Supervisor_ID, National_ID, SALARY, GENDER, Position, PASSWORD, USERNAME)
VALUES ('Tasneem', 'Medhat', 'Saleh', 200016, 200001, 30308168862614, 3000, 'F', 'Member', 'khaled_TM@123', 'khaled_TM');


INSERT INTO Ticket_Reserves(FirstName, MidName, LastName, ID, Supervisor_ID, National_ID, SALARY, GENDER, Position, PASSWORD, USERNAME)
VALUES ('Sara', 'Salama', 'Nabel', 200017, 200001, 29107091877367, 3000, 'F', 'Member', 'khaled_TM@123', 'khaled_TM');


INSERT INTO Ticket_Reserves(FirstName, MidName, LastName, ID, Supervisor_ID, National_ID, SALARY, GENDER, Position, PASSWORD, USERNAME)
VALUES ('Esra', 'Yassin', 'Khaled', 200018, 200001, 30910093495269, 3000, 'F', 'Member', 'khaled_TM@123', 'khaled_TM');


INSERT INTO Ticket_Reserves(FirstName, MidName, LastName, ID, Supervisor_ID, National_ID, SALARY, GENDER, Position, PASSWORD, USERNAME)
VALUES ('Shorouk', 'Mahmoud', 'Ali', 200019, 200001, 30801021596732, 3000, 'F', 'Member', 'khaled_TM@123', 'khaled_TM');


--===================================================================== END NEW =========================================================================


SELECT * FROM Ticket_Reserves;

-----------------------------------------------------------

INSERT INTO Ticket_Reserve_Phones(Phone_Number, Ticket_Reserve_ID)
VALUES (01212352684, 200000);

INSERT INTO Ticket_Reserve_Phones (Phone_Number, Ticket_Reserve_ID)
VALUES (01598745623, 200001);

INSERT INTO Ticket_Reserve_Phones (Phone_Number, Ticket_Reserve_ID)
VALUES (01001254031, 200002);

SELECT * FROM Ticket_Reserve_Phones;

--------------------------------------------------------

INSERT INTO Ticket_Reserve_Shifts (SHIFT_TIME_Start, SHIFT_TIME_End, Ticket_Reserve_ID)
VALUES ('07:00','14:00', 200000);

INSERT INTO Ticket_Reserve_Shifts (SHIFT_TIME_Start, SHIFT_TIME_End, Ticket_Reserve_ID)
VALUES ('07:00','14:00', 200001);

INSERT INTO Ticket_Reserve_Shifts (SHIFT_TIME_Start, SHIFT_TIME_End, Ticket_Reserve_ID)
VALUES ('07:00','14:00', 200002);

SELECT * FROM Ticket_Reserve_Shifts;

--==================================================================================

INSERT INTO Ticket (Serial_Number, Available_Day, Payment_Time_Start, Payment_Time_Ends, Reserver_ID)
VALUES (123456, '2022-06-27', '14:00','17:00', 200001);

INSERT INTO Ticket (Serial_Number, Available_Day, Payment_Time_Start, Payment_Time_Ends, Reserver_ID)
VALUES (654321, '2022-06-28', '10:00','13:00', 200001);

INSERT INTO Ticket (Serial_Number, Available_Day, Payment_Time_Start, Payment_Time_Ends, Reserver_ID)
VALUES (258963, '2022-06-28', '15:00','18:00', 200002);

INSERT INTO Ticket (Serial_Number, Available_Day, Payment_Time_Start, Payment_Time_Ends, Reserver_ID)
VALUES (852085, '2022-06-27', '14:00','17:00', 200002);

INSERT INTO Ticket (Serial_Number, Available_Day, Payment_Time_Start, Payment_Time_Ends, Reserver_ID)
VALUES (2514, '2022-06-27', '14:00','17:00', 200002);

INSERT INTO Ticket (Serial_Number, Available_Day, Payment_Time_Start, Payment_Time_Ends, Reserver_ID)
VALUES (987456, '2022-01-17', '14:00','17:00', 200002);

INSERT INTO Ticket (Serial_Number, Available_Day, Payment_Time_Start, Payment_Time_Ends, Reserver_ID)
VALUES (147852, '2022-05-10', '13:00','16:00', 200001);

INSERT INTO Ticket (Serial_Number, Available_Day, Payment_Time_Start, Payment_Time_Ends, Reserver_ID)
VALUES (369852, '2022-06-30', '12:00','15:00', 200001);


INSERT INTO Ticket (Serial_Number, Available_Day, Payment_Time_Start, Payment_Time_Ends, Reserver_ID)
VALUES (258123, '2022-01-17', '14:00','17:00', 200002);

INSERT INTO Ticket (Serial_Number, Available_Day, Payment_Time_Start, Payment_Time_Ends, Reserver_ID)
VALUES (789852, '2022-05-10', '13:00','16:00', 200001);

INSERT INTO Ticket (Serial_Number, Available_Day, Payment_Time_Start, Payment_Time_Ends, Reserver_ID)
VALUES (364102, '2022-06-30', '12:00','15:00', 200001);


INSERT INTO Ticket (Serial_Number, Available_Day, Payment_Time_Start, Payment_Time_Ends, Reserver_ID)
VALUES (012321, '2022-01-17', '14:00','17:00', 200002);

INSERT INTO Ticket (Serial_Number, Available_Day, Payment_Time_Start, Payment_Time_Ends, Reserver_ID)
VALUES (248625, '2022-05-10', '13:00','16:00', 200001);

INSERT INTO Ticket (Serial_Number, Available_Day, Payment_Time_Start, Payment_Time_Ends, Reserver_ID)
VALUES (976134, '2022-06-30', '12:00','15:00', 200001);

INSERT INTO Ticket (Serial_Number, Available_Day, Payment_Time_Start, Payment_Time_Ends, Reserver_ID)
VALUES (012213, '2022-01-17', '14:00','17:00', 200002);

INSERT INTO Ticket (Serial_Number, Available_Day, Payment_Time_Start, Payment_Time_Ends, Reserver_ID)
VALUES (510024, '2022-05-10', '13:00','16:00', 200001);

INSERT INTO Ticket (Serial_Number, Available_Day, Payment_Time_Start, Payment_Time_Ends, Reserver_ID)
VALUES (336594, '2022-06-30', '12:00','15:00', 200001);
SELECT * FROM Ticket;

--===================================================================================

INSERT INTO Visitors(FirstName, 
						MidName, 
						LastName, 
						ID, 
						GENDER, 
						PASSWORD, 
						USERNAME,
						Birth_Date,
						Attendance
						)
VALUES ('Yahya', 'Ashraf', 'Mohamed', 500000, 'M','Yahya_G@123', 'Yahya_G', '2003-02-13', 3);

INSERT INTO Visitors(FirstName, MidName, LastName, ID, GENDER, PASSWORD, USERNAME, Birth_Date, Attendance)
VALUES ('Yara', 'Ashraf', 'Mohamed', 500001, 'F','Yara_G@123', 'Yara_G', '2012-01-11', 1);

INSERT INTO Visitors(FirstName, MidName, LastName, ID, GENDER, PASSWORD, USERNAME, Birth_Date, Attendance)
VALUES ('Yassin', 'Ashraf', 'Mohamed', 500002, 'M','Yassin_G@123', 'Yassin_G', '2006-07-19', 2);

SELECT * FROM Visitors;

-----------------------------------------------------------

INSERT INTO Visitor_Phones(Phone_Number, Visitor_ID)
VALUES (01235469182, 500000);

INSERT INTO Visitor_Phones (Phone_Number, Visitor_ID)
VALUES (01532561478, 500001);

INSERT INTO Visitor_Phones (Phone_Number, Visitor_ID)
VALUES (01098745231, 500002);

SELECT * FROM Visitor_Phones;

--------------------------------------------------------

INSERT INTO Interests(Interest)
VALUES ('Science');

INSERT INTO Interests(Interest)
VALUES ('Math');

INSERT INTO Interests(Interest)
VALUES ('Arts');

INSERT INTO Interests(Interest)
VALUES ('Editing');

SELECT * FROM Interests;

-------------------------------------------------------
INSERT INTO Visitor_Interest(Interest, Visitor_ID)
VALUES ('Science', 500000);

INSERT INTO Visitor_Interest (Interest, Visitor_ID)
VALUES ('Math', 500001);

INSERT INTO Visitor_Interest (Interest, Visitor_ID)
VALUES ('Arts', 500002);

INSERT INTO Visitor_Interest (Interest, Visitor_ID)
VALUES ('Editing', 500002);

SELECT * FROM Visitor_Interest;

-----------------------------------------------------------------
INSERT INTO Used_Tickets(Serial_Number, Visitor_ID, Time_Used_in)
VALUES (123456, 500000, '2022-07-28 14:42:56');

INSERT INTO Used_Tickets(Serial_Number, Visitor_ID, Time_Used_in)
VALUES (654321, 500001, '2022-07-28 10:12:36');

INSERT INTO Used_Tickets(Serial_Number, Visitor_ID, Time_Used_in)
VALUES (258963, 500002, '2022-07-28 08:03:11');

--Delete Used_Tickets;
SELECT * FROM Used_Tickets;

--======================================================================

INSERT INTO AUDIENCE(Event_Code, Visitor_ID)
VALUES (1234, 500000);

INSERT INTO AUDIENCE(Event_Code, Visitor_ID)
VALUES (1234, 500001);

INSERT INTO AUDIENCE(Event_Code, Visitor_ID)
VALUES (1234, 500002);

SELECT * FROM AUDIENCE;

--=======================================================================


INSERT INTO Books(Code, Book_Name, Author, Offer, Catetory, Price, Available, Num_Of_Books)
VALUES (1234, 'Atomic Habits', 'James Clear', 0, 'Self Improvement', 35, 1, 70);

INSERT INTO Books(Code, Book_Name, Author, Offer, Series, Catetory, Price, Available, Num_Of_Books)
VALUES (8520, 'University Physics', 'Hugh D. Young', 10, 'Physics', 'Academic', 50, 1, 40);

INSERT INTO Books(Code, Book_Name, Author, Offer, Series, Catetory, Price, Available, Num_Of_Books)
VALUES (7413, 'Thomas Calculus', 'George B. Thomas', 0, 'Mathematics', 'Academic', 45, 1, 55);

SELECT * FROM Books;
--=========================================================================

INSERT INTO Book_Location(Code, Publishing_House_Name, Letter, Section_Number, Hall_Number)
VALUES (1234, 'Mer Book House', 'A', 1, 1);

INSERT INTO Book_Location(Code, Publishing_House_Name, Letter, Section_Number, Hall_Number)
VALUES (8520, 'EduGate Publishing and Distribution', 'A', 1, 2);

INSERT INTO Book_Location(Code, Publishing_House_Name, Letter, Section_Number, Hall_Number)
VALUES (7413, 'Kalemat Arabia', 'A', 1, 2);

SELECT * FROM Book_Location;

--===========================================================================

INSERT INTO Sold_Books(Publishing_House_Name, Book_Seller_ID, Visitor_ID, Book_Code, Sold_Time, Sold_Price)
VALUES ('Mer Book House', 100000, 500000, 1234, '2022-06-28 10:36:56', 35);

INSERT INTO Sold_Books(Publishing_House_Name, Book_Seller_ID, Visitor_ID, Book_Code, Sold_Time, Sold_Price)
VALUES ('EduGate Publishing and Distribution', 100001, 500001, 8520, '2022-06-28 12:00:12', 45);

INSERT INTO Sold_Books(Publishing_House_Name, Book_Seller_ID, Visitor_ID, Book_Code, Sold_Time, Sold_Price)
VALUES ('Kalemat Arabia', 100001, 500001, 7413, '2022-06-28 12:01:10', 45);

SELECT * FROM Sold_Books;
--===========================================================================

INSERT INTO Booth_Visitors(Letter, Section_Number, Hall_Number, Visitor_ID, Enter_Time, Exit_Time)
VALUES ('A', 1, 1, 500000, '13:00','14:36');

INSERT INTO Booth_Visitors(Letter, Section_Number, Hall_Number, Visitor_ID, Enter_Time, Exit_Time)
VALUES ('A', 1, 2, 500001, '11:00','13:48');

SELECT * FROM Booth_Visitors;

--===========================================================================

INSERT INTO Past_Events (NAME, Subject, Code, Leader_ID, Event_Date, Start_time, End_time, Attendees_Number, Letter, Section_Number, Hall_Number)
VALUES ('Physic','Earth', 4652, 000000, '2021-06-25', '15:00', '16:30', 30, 'C', 2, 2);

INSERT INTO Past_Events (NAME, Subject, Code, Leader_ID, Event_Date, Start_time, End_time, Attendees_Number, Letter, Section_Number, Hall_Number)
VALUES ('Math','Calculus', 1817, 000000, '2020-04-11', '12:00', '02:00', 17, 'B', 1, 1);

SELECT * FROM Past_Events;

--=============================================================================
INSERT INTO Volunters_Past_Events
VALUES (400000, 4652, 000000, 30,5000, 'Leader', 'Organiser');

INSERT INTO Volunters_Past_Events
VALUES (400001, 4652, 000000, 41, 3000, 'Vice-Leader', 'FR');

INSERT INTO Volunters_Past_Events
VALUES (400002, 4652, 000000, 56,1500, 'Member', 'HR');

INSERT INTO Volunters_Past_Events
VALUES (400000, 1817, 000000, 70, 4000, 'Member', 'Social-Media');

INSERT INTO Volunters_Past_Events
VALUES (400001, 1817, 000000, 70, 2500, 'Member', 'Organiser');

INSERT INTO Volunters_Past_Events
VALUES (400002, 1817, 000000, 40, 2000, 'Member', 'Organiser');


SELECT * FROM Volunters_Past_Events;

















----==================================================================================================================================================================
--INSERT INTO Organizers (FirstName, MidName, LastName, ID, Supervisor_ID, National_ID, SALARY, GENDER, Team_Name, Works_At_Event_code, Position, PASSWORD, USERNAME)
--VALUES ('Mariam', 'Mokhtar', 'Mohamed', 000003, 000000, 26582687940, 5500, 'F', 'Team 1', Null, 'Member', 'KMM1', 'Mariam');

--INSERT INTO Organizers (FirstName, MidName, LastName, ID, Supervisor_ID, National_ID, SALARY, GENDER, Team_Name, Works_At_Event_code, Position, PASSWORD, USERNAME)
--VALUES ('Omar', 'Morgan', 'Ali', 000004, 000000, 26352487940, 8000, 'M', 'Team 1', Null, 'Member', 'khaled', 'Khaled');

--INSERT INTO Organizers (FirstName, MidName, LastName, ID, Supervisor_ID, National_ID, SALARY, GENDER, Team_Name, Works_At_Event_code, Position, PASSWORD, USERNAME)
--VALUES ('Mario', 'Mikle', 'Malek', 000010, Null, 23154686250, 9000, 'M', 'Team 2', Null, 'Leader', 'M@123', 'Mario');

--INSERT INTO Organizers (FirstName, MidName, LastName, ID, Supervisor_ID, National_ID, SALARY, GENDER, Team_Name, Works_At_Event_code, Position, PASSWORD, USERNAME)
--VALUES ('kaled', 'Ashraf', 'Yahya', 000011, 000010, 23154258147, 6000, 'M', 'Team 2', Null, 'Vice-Leader', 'K123', 'kaled_YAhya');

--INSERT INTO Organizers (FirstName, MidName, LastName, ID, Supervisor_ID, National_ID, SALARY, GENDER, Team_Name, Works_At_Event_code, Position, PASSWORD, USERNAME)
--VALUES ('Ashraf', 'kaled', 'Mohamed', 000012, 000010, 23169824540, 6500, 'M', 'Team 2', Null, 'Member', 'AM1583', 'Ashraf_Mohamed');

--INSERT INTO Organizers (FirstName, MidName, LastName, ID, Supervisor_ID, National_ID, SALARY, GENDER, Team_Name, Works_At_Event_code, Position, PASSWORD, USERNAME)
--VALUES ('Mohamed', 'Ashraf', 'kaled', 000013, 000010, 23165421440, 5000, 'M', 'Team 2', Null, 'Member', 'Yhagb23', 'Mohamed_Ashraf');

--INSERT INTO Organizers (FirstName, MidName, LastName, ID, Supervisor_ID, National_ID, SALARY, GENDER, Team_Name, Works_At_Event_code, Position, PASSWORD, USERNAME)
--VALUES ('Yahya', 'Ashraf', 'Mohamed', 000014, 000010, 2368547440, 6000, 'M', 'Team 2', Null, 'Member', 'Yah1852', 'Y_Y_Y');

--INSERT INTO Organizers (FirstName, MidName, LastName, ID, Supervisor_ID, National_ID, SALARY, GENDER, Team_Name, Works_At_Event_code, Position, PASSWORD, USERNAME)
--VALUES ('Hatem', 'Yassin', 'Mohamed', 000015, 000010, 28562417940, 7000, 'M', 'Team 2', Null, 'Member', 'Hatem99', 'Hatem_K');

--INSERT INTO Organizers (FirstName, MidName, LastName, ID, Supervisor_ID, National_ID, SALARY, GENDER, Team_Name, Works_At_Event_code, Position, PASSWORD, USERNAME)
--VALUES ('Yassin', 'Hatem', 'kaled', 000016, 000010, 23165842140, 4000, 'M', 'Team 2', Null, 'Member', 'Yassin', 'Yassin_H');

--INSERT INTO Organizers (FirstName, MidName, LastName, ID, Supervisor_ID, National_ID, SALARY, GENDER, Team_Name, Works_At_Event_code, Position, PASSWORD, USERNAME)
--VALUES ('Mariam', 'Mosa', 'Yasser', 000020, Null, 23154482540, 11000, 'F', 'Team 3', Null, 'Leader', 'Ynah23', 'M_mosa');

--INSERT INTO Organizers (FirstName, MidName, LastName, ID, Supervisor_ID, National_ID, SALARY, GENDER, Team_Name, Works_At_Event_code, Position, PASSWORD, USERNAME)
--VALUES ('Yasmeen', 'Ashraf', 'Yahya', 000021, 000020, 23654687940, 8000, 'F', 'Team 3', Null, 'Vice-Leader', 'asdn523', 'Yasmeen_Ashraf');

--INSERT INTO Organizers (FirstName, MidName, LastName, ID, Supervisor_ID, National_ID, SALARY, GENDER, Team_Name, Works_At_Event_code, Position, PASSWORD, USERNAME)
--VALUES ('Kolod', 'Malek', 'Ali', 000022, 000020, 23847527940, 9000, 'F', 'Team 3', Null, 'Member', 'cnauc56', 'Kholod1');

--INSERT INTO Organizers (FirstName, MidName, LastName, ID, Supervisor_ID, National_ID, SALARY, GENDER, Team_Name, Works_At_Event_code, Position, PASSWORD, USERNAME)
--VALUES ('Nada', 'Yasser', 'Ali', 000023, 000020, 23159657940, 8500, 'F', 'Team 3', Null, 'Member', 'idha841', 'Nada_A');

--INSERT INTO Organizers (FirstName, MidName, LastName, ID, Supervisor_ID, National_ID, SALARY, GENDER, Team_Name, Works_At_Event_code, Position, PASSWORD, USERNAME)
--VALUES ('Ahmed', 'Ashraf', 'Fareed', 000024, 000020, 23151427940, 7500, 'M', 'Team 3', Null, 'Member', 'jado84', 'AA');

--INSERT INTO Organizers (FirstName, MidName, LastName, ID, Supervisor_ID, National_ID, SALARY, GENDER, Team_Name, Works_At_Event_code, Position, PASSWORD, USERNAME)
--VALUES ('Malek', 'Mamdoh', 'Ali', 000025, 000020, 23112487940, 6500, 'M', 'Team 3', Null, 'Member', 'Yadhja3', 'Malek_m');

--INSERT INTO Organizers (FirstName, MidName, LastName, ID, Supervisor_ID, National_ID, SALARY, GENDER, Team_Name, Works_At_Event_code, Position, PASSWORD, USERNAME)
--VALUES ('Yara', 'Ashraf', 'Mohamed', 000026, 000020, 23159637940, 50000, 'F', 'Team 3', Null, 'Member', 'moca@6', 'Yara');

--INSERT INTO Organizers (FirstName, MidName, LastName, ID, Supervisor_ID, National_ID, SALARY, GENDER, Team_Name, Works_At_Event_code, Position, PASSWORD, USERNAME)
--VALUES ('Yahya', 'Ashraf', 'Mohamed', 000027, 000020, 23147587940, 55000, 'M', 'Team 3', Null, 'Member', 'nfkaf88', 'MYA');

--select * from Organizers;

---------------------------------------------------------------------------------------------------------------------------------------------------------------

--INSERT INTO Organizer_Phones (PhoneNum, Organizer_ID)
--VALUES (1202006004, 000000);

--INSERT INTO Organizer_Phones (PhoneNum, Organizer_ID)
--VALUES (1212534814, 000001);

--INSERT INTO Organizer_Phones (PhoneNum, Organizer_ID)
--VALUES (1269412534, 000001);

--INSERT INTO Organizer_Phones (PhoneNum, Organizer_ID)
--VALUES (1118254926, 000002);

--INSERT INTO Organizer_Phones (PhoneNum, Organizer_ID)
--VALUES (1013264816, 000003);

--INSERT INTO Organizer_Phones (PhoneNum, Organizer_ID)
--VALUES (1125481625, 000004);

--INSERT INTO Organizer_Phones (PhoneNum, Organizer_ID)
--VALUES (1044545135, 000010);

--INSERT INTO Organizer_Phones (PhoneNum, Organizer_ID)
--VALUES (1125151535, 000010);

--INSERT INTO Organizer_Phones (PhoneNum, Organizer_ID)
--VALUES (1125131335, 000011);

--INSERT INTO Organizer_Phones (PhoneNum, Organizer_ID)
--VALUES (1445151511, 000012);

--INSERT INTO Organizer_Phones (PhoneNum, Organizer_ID)
--VALUES (1125481515, 000012);

--INSERT INTO Organizer_Phones (PhoneNum, Organizer_ID)
--VALUES (1121516235, 000015);

--INSERT INTO Organizer_Phones (PhoneNum, Organizer_ID)
--VALUES (12954816235, 000015);

--INSERT INTO Organizer_Phones (PhoneNum, Organizer_ID)
--VALUES (12254816235, 000020);

--INSERT INTO Organizer_Phones (PhoneNum, Organizer_ID)
--VALUES (10264816235, 000021);

--INSERT INTO Organizer_Phones (PhoneNum, Organizer_ID)
--VALUES (12154816235, 000021);

--INSERT INTO Organizer_Phones (PhoneNum, Organizer_ID)
--VALUES (12635481635, 000021);

--INSERT INTO Organizer_Phones (PhoneNum, Organizer_ID)
--VALUES (11254816335, 000022);

--INSERT INTO Organizer_Phones (PhoneNum, Organizer_ID)
--VALUES (11254811535, 000022);

--INSERT INTO Organizer_Phones (PhoneNum, Organizer_ID)
--VALUES (11254817435, 000024);

--INSERT INTO Organizer_Phones (PhoneNum, Organizer_ID)
--VALUES (11254812635, 000027);

--select * from Organizer_Phones;
-------------------------------------------------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------------------------------------------------

-------------------------------------------------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------------------------------------------------

--INSERT INTO Organizer_Shifts (SHIFT_TIME_Start, SHIFT_TIME_End, Organizer_ID)
--VALUES ('07:00','14:00', 000000);

--INSERT INTO Organizer_Shifts (SHIFT_TIME_Start, SHIFT_TIME_End, Organizer_ID)
--VALUES ('07:00','12:00', 000001);

--INSERT INTO Organizer_Shifts (SHIFT_TIME_Start, SHIFT_TIME_End, Organizer_ID)
--VALUES ('14:00','17:00', 000001);

--INSERT INTO Organizer_Shifts (SHIFT_TIME_Start, SHIFT_TIME_End, Organizer_ID)
--VALUES ('07:00','17:00', 000002);

--INSERT INTO Organizer_Shifts (SHIFT_TIME_Start, SHIFT_TIME_End, Organizer_ID)
--VALUES ('07:00','17:00', 000003);

--INSERT INTO Organizer_Shifts (SHIFT_TIME_Start, SHIFT_TIME_End, Organizer_ID)
--VALUES ('07:00','17:00', 000004);

--INSERT INTO Organizer_Shifts (SHIFT_TIME_Start, SHIFT_TIME_End, Organizer_ID)
--VALUES ('07:00','14:00', 000010);

--INSERT INTO Organizer_Shifts (SHIFT_TIME_Start, SHIFT_TIME_End, Organizer_ID)
--VALUES ('07:00','17:00', 000011);

--INSERT INTO Organizer_Shifts (SHIFT_TIME_Start, SHIFT_TIME_End, Organizer_ID)
--VALUES ('07:00','12:00', 000012);

--INSERT INTO Organizer_Shifts (SHIFT_TIME_Start, SHIFT_TIME_End, Organizer_ID)
--VALUES ('14:00','18:00', 000012);

--INSERT INTO Organizer_Shifts (SHIFT_TIME_Start, SHIFT_TIME_End, Organizer_ID)
--VALUES ('07:00','11:00', 000015);

--INSERT INTO Organizer_Shifts (SHIFT_TIME_Start, SHIFT_TIME_End, Organizer_ID)
--VALUES ('15:00','19:00', 000015);

--INSERT INTO Organizer_Shifts (SHIFT_TIME_Start, SHIFT_TIME_End, Organizer_ID)
--VALUES ('07:00','14:00', 000020);

--INSERT INTO Organizer_Shifts (SHIFT_TIME_Start, SHIFT_TIME_End, Organizer_ID)
--VALUES ('07:00','17:00', 000021);

--INSERT INTO Organizer_Shifts (SHIFT_TIME_Start, SHIFT_TIME_End, Organizer_ID)
--VALUES ('07:00','17:00', 000022);

--INSERT INTO Organizer_Shifts (SHIFT_TIME_Start, SHIFT_TIME_End, Organizer_ID)
--VALUES ('07:00','17:00', 000022);

--INSERT INTO Organizer_Shifts (SHIFT_TIME_Start, SHIFT_TIME_End, Organizer_ID)
--VALUES ('07:00','17:00', 000024);

--INSERT INTO Organizer_Shifts (SHIFT_TIME_Start, SHIFT_TIME_End, Organizer_ID)
--VALUES ('07:00','17:00', 000027);

--select * from Organizer_Shifts;
--------------------------------------------------------------------------------------------------------------------------------------------
--------------------------------------------------------------------------------------------------------------------------------------------
--------------------------------------------------------------------------------------------------------------------------------------------
--------------------------------------------------------------------------------------------------------------------------------------------

----INSERT INTO Events (NAME, Subject, Code, Leader_ID, Event_Date, Start_time, End_time, Attendees_Number, Letter, Section_Number, Hall_Number)
----VALUES ('Banorama','pyramid', 1234, 000000, '2022-05-25', '12:00', '02:00', 15, 'A', 3, 1);

--INSERT INTO Events (NAME, Subject, Code, Leader_ID, Event_Date, Start_time, End_time, Attendees_Number, Letter, Section_Number, Hall_Number)
--VALUES ('Physic','Earth', 4652, 000010, '2022-05-25', '15:00', '16:30', 30, 'C', 2, 2);

--INSERT INTO Events (NAME, Subject, Code, Leader_ID, Event_Date, Start_time, End_time, Attendees_Number, Letter, Section_Number, Hall_Number)
--VALUES ('Math','Calculus', 1817, 000020, '2022-05-26', '12:00', '02:00', 17, 'B', 1, 1);

--select * from Events;
-----------------------------------------------------------------------------------------------------------------------------------------------
----UPDATE Organizers
----SET Works_At_Event_code = 1234
----WHERE Team_Name = 'Team 1';

--UPDATE Organizers
--SET Works_At_Event_code = 4652
--WHERE Team_Name = 'Team 2';

--UPDATE Organizers
--SET Works_At_Event_code = 1817
--WHERE Team_Name = 'Team 3';

--select * from Organizers;
-----------------------------------------------------------------------------------------------------------------------------------------------
--INSERT INTO Publishing_House (Publishing_House_NAME, Contacts)
--VALUES ('«·ÃœÊ· «·ÕÌ', 1234567894)

--INSERT INTO Publishing_House (Publishing_House_NAME, Contacts)
--VALUES ('«·ﬂ—„… ··‰‘—', 1132546786)

--INSERT INTO Publishing_House (Publishing_House_NAME, Contacts)
--VALUES ('„ﬂ »… «·ﬂÊ‰', 1031587619)

--select * FROM Publishing_House;
-----------------------------------------------------------------------------------------------------------------------------------------------
-----------------------------------------------------------------------------------------------------------------------------------------------
----ALTER TABLE Book_Seller
----ADD CONSTRAINT Supervisor_ID
----DEFAULT (11111) FOR Supervisor_ID;

----ALTER TABLE Book_Seller
----ALTER COLUMN Supervisor_ID
----DROP DEFAULT (11111);

----ALTER TABLE Book_Seller
----ALTER COLUMN Supervisor_ID DROP DEFAULT;

----ALTER TABLE Book_Seller
----ALTER COLUMN Supervisor_ID
----SET DEFAULT (11111);
-----------------------------------------------------------------------------------------------------------------------------------------------
-----------------------------------------------------------------------------------------------------------------------------------------------

--INSERT INTO Book_Seller(FirstName, 
--						MidName, 
--						LastName, 
--						ID, 
--						Supervisor_ID, 
--						National_ID,
--						SALARY, 
--						GENDER, 
--						Position, 
--						PASSWORD, 
--						USERNAME)
--VALUES ('Youssef', 'Yahya', 'Mohamed', 11111, Null, 23154627940, 10000, 'M', 'Leader', 'Yousef123', 'Youssef');

--INSERT INTO Book_Seller(FirstName, MidName, LastName, ID, Supervisor_ID, National_ID, SALARY, GENDER, Position, PASSWORD, USERNAME)
--VALUES ('Malek', 'Yahya', 'yousef', 11112, 11111, 23184236940, 8000, 'M', 'Vice-Leader', 'Yoef123', 'Yous');

--INSERT INTO Book_Seller(FirstName, MidName, LastName, ID, Supervisor_ID, National_ID, SALARY, GENDER, Position, PASSWORD, USERNAME)
--VALUES ('khaled', 'yasser', 'Ali', 11114, 11111, 20120234210, 7000, 'M', 'Member', 'KH555', 'KYA');

--INSERT INTO Book_Seller(FirstName, MidName, LastName, ID, Supervisor_ID, National_ID, SALARY, GENDER, Position, PASSWORD, USERNAME)
--VALUES ('Nada', 'Essam', 'Ismail', 11115, 11111, 23184258040, 6000, 'F', 'Member', 'N123', 'Nona');

--INSERT INTO Book_Seller(FirstName, MidName, LastName, ID, Supervisor_ID, National_ID, SALARY, GENDER, Position, PASSWORD, USERNAME)
--VALUES ('Rahma', 'Mohamed', 'Abass', 11116, 11111, 30134236940, 8000, 'F', 'Member', 'RRR888', 'Rahma');

--INSERT INTO Book_Seller(FirstName, MidName, LastName, ID, Supervisor_ID, National_ID, SALARY, GENDER, Position, PASSWORD, USERNAME)
--VALUES ('Fawzy', 'Yahya', 'Khaled', 11117, 11111, 23413526940, 7500, 'M', 'Member', 'Fawzy', 'Fawzy');





--SELECT * FROM Book_Seller;



--INSERT INTO Volunters(FirstName, 
--						MidName, 
--						LastName, 
--						ID, 
--						Supervisor_ID, 
--						NationalID,
--						SALARY, 
--						GENDER, 
--						Position, 
--						DPASSWORD, 
--						USERNAME)
--VALUES ('Youssef', 'Yahya', 'Mohamed', 11111, Null, 23154627940, 10000, 'M', 'Leader', 'Yousef123', 'Youssef');


--INSERT INTO Volunters(FirstName, MidName, LastName, ID, Supervisor_ID, NationalID, GENDER, DPASSWORD, USERNAME)
--VALUES ('Fawzy', 'Yahya', 'Khaled', 11117, 0, 20230135249440, 'M', 'Fawzy', 'Fawzyyy');

--SELECT * FROM Volunters;
