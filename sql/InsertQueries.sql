use ticketease;

Insert into Department values(1, 'IT','Rohan'),(2, 'Admin','Ram'),(3, 'HR','Rohit'),(4, 'L&D','Amey');

Insert into BU values(1, 'Hi- tech', 1),(2, 'IBM', 0),(3, 'CMT', 1),(4, 'HLS', 0);

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


Insert into TicketStatus values(1, 'Open'),(2, 'Pending Approval'),(3, 'Resolved'),(4, 'Closed');


Insert into dbo.RequestTypes values(1, 'Electrical',1, 'Description',0,'[{key:"name",title:"FullName",},{key:"location",title:"Location",},]'),
							  (2, 'Travel Request',1,'Description',0,'[{key:\"name\",title:\"FullName\",},{key:\"location\",title:\"Location\",},]'),
							  (3, 'Pantry Service',1,'Description',0,'[{key:\"name\",title:\"FullName\",},{key:\"location\",title:\"Location\",},]'),
							  (4, 'Salary Related',2,'Description',0,'[{key:\"name\",title:\"FullName\",},{key:\"location\",title:\"Location\",},]'),
							  (5, 'Leaves & Absence',2,'Description',0,'[{key:\"name\",title:\"FullName\",},{key:\"location\",title:\"Location\",},]'),
							  (6, 'Update Profile and skills',2,'Description',0,'[{key:\"name\",title:\"FullName\",},{key:\"location\",title:\"Location\",},]'),
							  (7, 'Gen AI tools',3,'Description',0,'[{key:\"name\",title:\"FullName\",},{key:\"location\",title:\"Location\",},]'),
							  (8, 'Hardware Request',3,'Description',0,'[{key:\"name\",title:\"FullName\",},{key:\"location\",title:\"Location\",},]'),
							  (9, 'Software Installation & uninstallation',3,'Description',0,'[{key:\"name\",title:\"FullName\",},{key:\"location\",title:\"Location\",},]'),
							  (10, 'Training Request & assistance',4,'Description',0,'[{key:\"name\",title:\"FullName\",},{key:\"location\",title:\"Location\",},]'),
							  (11, 'Course Enrollment',4,'Description',0,'[{key:\"name\",title:\"FullName\",},{key:\"location\",title:\"Location\",},]'),
							  (12, 'Certification assistance',4,'Description',0,'[{key:\"name\",title:\"FullName\",},{key:\"location\",title:\"Location\",},]');

Insert into dbo.RequestTypes values(13, 'IT Incident',1,'Description',1,'[{key:\"name\",title:\"FullName\",},{key:\"location\",title:\"Location\",},]'),
							  (14, 'Admin Incident',2,'Description',1,'[{key:\"name\",title:\"FullName\",},{key:\"location\",title:\"Location\",},]'),
							  (15, 'HR Incident',3,'Description',1,'[{key:\"name\",title:\"FullName\",},{key:\"location\",title:\"Location\",},]'),
							  (16, 'L&D Incident',4,'Description',1,'[{key:\"name\",title:\"FullName\",},{key:\"location\",title:\"Location\",},]');


Insert into Ticket Values(1, 'Network Issue',null,1,1,null,1,1,9,1,'2024-01-01','2024-01-05',0),
						 (2, 'Software error',null,2,2,null,2,2,9,2,'2024-01-05','2024-01-10',1),
						 (3, 'Website Downtime',null,3,3,null,3,3,9,3,'2024-01-11','2024-01-15',0),
						 (4, 'Network Outage',null,4,4,null,4,4,9,3,'2024-01-16','2024-01-20',1),
						 (5, 'Electrical',null,9,1,null,4,1,1,1,'2024-01-16','2024-01-20',1),
						 (6, 'Pantry Service',null,10,1,null,4,2,3,3,'2024-01-16','2024-01-20',1),
						 (7, 'Salary Related',null,12,1,null,4,3,4,1,'2024-01-16','2024-01-20',1),
						 (8, 'Leaves & Absence',null,14,1,null,4,4,5,2,'2024-01-16','2024-01-20',1),
						 (9, 'Leaves & Absence',null,2,1,null,4,4,5,2,'2024-01-16','2024-01-20',1),
						 (10, 'Leaves & Absence',null,3,1,null,4,4,5,3,'2024-01-16','2024-01-20',1),
						 (11, 'Update Profile',null,4,1,null,4,2,6,1,'2024-01-16','2024-01-20',1),
						 (12, 'Keyboard Issue',null,6,1,null,1,1,13,0,GETDATE(),GETDATE(),1),
						 (13, 'Access card issue',null,6,2,null,1,2,14,0,GETDATE(),GETDATE(),1),
						 (14, 'Leave issue',null,6,3,null,1,1,15,1,GETDATE(),GETDATE(),1),
						 (15, 'Course issue',null,6,4,null,1,2,16,2,GETDATE(),GETDATE(),1);

insert into dbo.TicketComments Values(1, 'Network Issue In progress',2,'Open',GETDATE(),GETDATE());
insert into dbo.TicketComments Values(2, 'Network Issue Closed',2,'Pending Approval',GETDATE(),GETDATE());

select * from dbo.requesttypes;
