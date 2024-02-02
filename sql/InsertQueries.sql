Insert into Department values('IT','Rohan'),('Admin','Ram'),('HR','Rohit'),('L&D','Amey');

Insert into BU values('Hi- tech', 1),('IBM', 0),('CMT', 1),('HLS', 0);

INSERT INTO Employees (emp_id, firstname, lastname, email, password, profile_link, dept_id, bu_id, blood_type, is_admin, joined_on, is_manager, manager_id)
VALUES
(1, 'Siya', 'Kamat', 'siya@gmail.com', 'siya123', 'https://picsum.photos/200/300', 1, 1, 'A+', 0, '2024-01-01', 1, null),
(2, 'Rahul', 'Rao', 'rahul@gmail.com', 'rahul123', 'https://picsum.photos/200/300', 1, 2, 'B+', 1, '2024-02-01', 1, 1),
(3, 'Riya', 'Jain', 'riya@gmail.com', 'riya123', 'https://picsum.photos/200/300', 1, 3, 'A+', 0, '2024-03-01', 1, 2),
(4, 'Rocky', 'Shah', 'rocky@gmail.com', 'rocky123', 'https://picsum.photos/200/300', 1, 4, 'AB+', 1, '2024-04-01', 1, 3),
(5, 'Rocky', 'Shah', 'rocky@gmail.com', 'rocky123', 'https://picsum.photos/200/300', 1, 4, 'AB-', 1, '2024-05-01', 0, 1),
(6, 'Chirag', 'Gaonkar', 'chirag@gmail.com', 'chirag123', 'https://picsum.photos/200/300', 2, 1, 'A+', 1, '2024-06-01', 0, 1),
(7, 'Ruhi', 'Pai', 'ruhi@gmail.com', 'ruhi123', 'https://picsum.photos/200/300', 2, 2, 'O+', 0, '2024-07-01', 0, 1),
(8, 'Rounak', 'Naik', 'rounak@gmail.com', 'rounak123', 'https://picsum.photos/200/300', 2, 3, 'O+', 1, '2024-08-01', 0, 2),
(9, 'Rohan', 'Kumar', 'rohan@gmail.com', 'rohan123', 'https://picsum.photos/200/300', 2, 4, 'O+', 0, '2024-09-01', 0, 2),
(10, 'Amar', 'Singh', 'amar@gmail.com', 'amar123', 'https://picsum.photos/200/300', 3, 1, 'O+', 1, '2024-10-01', 0, 2),
(11, 'Naveen', 'Naik', 'naveen@gmail.com', 'naveen123', 'https://picsum.photos/200/300', 3, 2, 'B+', 0, '2024-11-01', 0, 3),
(12, 'Sharvani', 'Salgaonkar', 'sharvani@gmail.com', 'sharvani123', 'https://picsum.photos/200/300', 3, 3,'A+', 1, '2024-12-01', 0, 3),
(13, 'Shreyas', 'Naik', 'shreyas@gmail.com', 'shreyas123', 'https://picsum.photos/200/300', 3, 4, 'AB+', 0, '2024-01-01', 0, 3),
(14, 'Sujata', 'Chowdhary', 'sujata@gmail.com', 'sujata123', 'https://picsum.photos/200/300', 4, 1,'A+', 1, '2024-02-01', 0, 4),
(15, 'Muskan', 'Ladiya', 'muskan@gmail.com', 'muskan123', 'https://picsum.photos/200/300', 4, 2, 'B+', 0, '2024-03-01', 0, 4),
(16, 'Lakshita', 'Werulkar', 'lakshita@gmail.com', 'lakshita123', 'https://picsum.photos/200/300', 4, 3, 'A+', 1, '2024-04-01', 0, 4),
(17, 'Ritwik', 'Berra', 'ritwik@gmail.com', 'ritwik123', 'https://picsum.photos/200/300', 4, 4, 'B+', 0, '2024-05-01', 0, 4);


Insert into TicketStatus values('Open'),('Pending Approval'),('Resolved'),('Closed');
delete from Ticket;

--Insertions added with priority value

Insert into Ticket Values('Network Issue','Cannot connect to internet',1,1,1,1,1,9,1,'2024-01-01','2024-01-05',0),
						 ('Software error','Application crashing',2,2,2,2,2,9,2,'2024-01-05','2024-01-10',1),
						 ('Website Downtime','Company website down',3,3,3,3,3,9,3,'2024-01-11','2024-01-15',0),
						 ('Network Outage','Network outage affecting all departments',4,4,4,4,4,9,3,'2024-01-16','2024-01-20',1);


Insert into dbo.Ticket Values('Electrical','Electrical',9,1,9,4,1,1,1,'2024-01-16','2024-01-20',1),
						 ('Pantry Service','Pantry Service',10,1,10,4,2,3,3,'2024-01-16','2024-01-20',1),
						 ('Salary Related','Salary Related',12,1,12,4,3,4,1,'2024-01-16','2024-01-20',1),
						 ('Leaves & Absence','Leaves & Absence',14,1,14,4,4,5,2,'2024-01-16','2024-01-20',1),
						 ('Leaves & Absence','Leaves & Absence',2,1,2,4,4,5,2,'2024-01-16','2024-01-20',1),
						 ('Leaves & Absence','Leaves & Absence',3,1,3,4,4,5,3,'2024-01-16','2024-01-20',1),
						 ('Update Profile','Update Profile',4,1,4,4,2,6,1,'2024-01-16','2024-01-20',1);

insert into dbo.TicketComments Values('Network Issue In progress',2,'Open',GETDATE(),GETDATE());
insert into dbo.TicketComments Values('Network Issue Closed',2,'Pending Approval',GETDATE(),GETDATE());
insert into dbo.Department values('Admin','Rohan'),('HR','Raj'),('IT','Rahul'),('L&D','Reharsh');

Insert into dbo.RequestTypes values('Electrical',1,GETDATE(),GETDATE()),
							  ('Travel Request',1,GETDATE(),GETDATE()),
							  ('Pantry Service',1,GETDATE(),GETDATE()),
							  ('Salary Related',2,GETDATE(),GETDATE()),
							  ('Leaves & Absence',2,GETDATE(),GETDATE()),
							  ('Update Profile and skills',2,GETDATE(),GETDATE()),
							  ('Gen AI tools',3,GETDATE(),GETDATE()),
							  ('Hardware Request',3,GETDATE(),GETDATE()),
							  ('Software Installation & uninstallation',3,GETDATE(),GETDATE()),
							  ('Training Request & assistance',4,GETDATE(),GETDATE()),
							  ('Course Enrollment',4,GETDATE(),GETDATE()),
							  ('Certification assistance',4,GETDATE(),GETDATE());

Insert into dbo.RequestTypes values('IT Incident',1,GETDATE(),GETDATE()),
							  ('Admin Incident',2,GETDATE(),GETDATE()),
							  ('HR Incident',3,GETDATE(),GETDATE()),
							  ('L&D Incident',4,GETDATE(),GETDATE());

