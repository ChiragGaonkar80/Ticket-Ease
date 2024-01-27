create database ticketease;
use ticketease;

CREATE TABLE dbo.BU (
    bu_id INT IDENTITY (1,1) NOT NULL,
    bu_name varchar(255) NOT NULL,
    is_du Bit,
	Constraint PK_BU PRIMARY KEY CLUSTERED (bu_id)
);


create table dbo.TicketStatus(
status_id int identity(1,1),
status_title varchar(255),
Constraint PK_TicketStatus PRIMARY KEY CLUSTERED (status_id)
);

create table dbo.Department(
dept_id int identity(1,1),
dept_name varchar(255),
dept_head varchar(255),
Constraint PK_Dept PRIMARY KEY CLUSTERED (dept_id)
);

CREATE TABLE dbo.Employees (
    emp_id INT IDENTITY (1,1) NOT NULL,
    firstname varchar(255) NOT NULL,
	lastname varchar(255) NOT NULL,
	email varchar(255) NOT NULL,
	password varchar(255) NOT NULL,
	profile_link varchar(255) NOT NULL,
	dept_id INT NOT NULL,
	bu_id INT NOT NULL,
	manager_id int NULL,
	blood_type char(10) NOT NULL,
	is_admin bit not null,
	joined_on datetime,
	Constraint PK_emp PRIMARY KEY CLUSTERED (emp_id),
	Constraint fk_dept FOREIGN KEY (dept_id)
        REFERENCES dbo.Department(dept_id)
        ON DELETE CASCADE
        ON UPDATE CASCADE,
	Constraint fk_user Foreign key (manager_id) references dbo.Employees(emp_id),
	Constraint fk_bu Foreign key (bu_id) references dbo.BU (bu_id)
);


ALTER TABLE Employees 
ALTER COLUMN manager_id int NULL;

CREATE TABLE dbo.Ticket(
	ticket_id INT IDENTITY (1,1) NOT NULL,
    title varchar(20) NOT NULL,
	description varchar(100) not null,
	emp_id int not null,
	dept_id int not null,
	admin_id int not null,
	manager_id int not null,
	status_id int not null,
	created_on date,
	updated_on date,
	need_approval bit,
	Constraint PK_Ticket PRIMARY KEY CLUSTERED (ticket_id),
	Constraint fk_user_ticket Foreign key (emp_id) references dbo.Employees(emp_id),
	Constraint fk_Manager_ticket Foreign key (manager_id) references dbo.Employees(emp_id),
	Constraint fk_status_ticket Foreign key (status_id) references dbo.TicketStatus(status_id),
	Constraint fk_dept_ticket FOREIGN KEY (dept_id) REFERENCES dbo.Department(dept_id)
);

CREATE TABLE dbo.TicketComments(
	comment_id int IDENTITY (1,1) NOT NULL,
	description varchar(100) not null,
	emp_id int not null,
	created_on date,
	updated_on date,
	Constraint PK_TicketComments PRIMARY KEY CLUSTERED (comment_id),
	Constraint fk_user_ticket_comments Foreign key (emp_id) references dbo.Employees(emp_id),
);






Insert into Department values('IT','Rohan'),('Admin','Ram'),('HR','Rohit'),('L&D','Amey');

Insert into BU values('Hi- tech', 1),('IBM', 0),('CMT', 1),('HLS', 0);

delete from employees;



INSERT INTO Employees (firstname, lastname, email, password, profile_link, dept_id, bu_id, blood_type, is_admin, joined_on)
VALUES
('Siya', 'Kamat', 'siya@gmail.com', 'siya123', 'https://picsum.photos/200/300', 1, 1, 'A+', 0, '2024-01-01'),
('Rahul', 'Rao', 'rahul@gmail.com', 'rahul123', 'https://picsum.photos/200/300', 1, 2, 'B+', 1, '2024-02-01'),
('Riya', 'Jain', 'riya@gmail.com', 'riya123', 'https://picsum.photos/200/300', 1, 3, 'A+', 0, '2024-03-01'),
('Rocky', 'Shah', 'rocky@gmail.com', 'rocky123', 'https://picsum.photos/200/300', 1, 4, 'AB+', 1, '2024-04-01'),
('Rocky', 'Shah', 'rocky@gmail.com', 'rocky123', 'https://picsum.photos/200/300', 1, 4, 'AB-', 1, '2024-05-01'),
('Chirag', 'Gaonkar', 'chirag@gmail.com', 'chirag123', 'https://picsum.photos/200/300', 2, 1, 'A+', 1, '2024-06-01'),
('Ruhi', 'Pai', 'ruhi@gmail.com', 'ruhi123', 'https://picsum.photos/200/300', 2, 2, 'O+', 0, '2024-07-01'),
('Rounak', 'Naik', 'rounak@gmail.com', 'rounak123', 'https://picsum.photos/200/300', 2, 3, 'O+', 1, '2024-08-01'),
('Rohan', 'Kumar', 'rohan@gmail.com', 'rohan123', 'https://picsum.photos/200/300', 2, 4, 'O+', 0, '2024-09-01'),
('Amar', 'Singh', 'amar@gmail.com', 'amar123', 'https://picsum.photos/200/300', 3, 1, 'O+', 1, '2024-10-01'),
('Naveen', 'Naik', 'naveen@gmail.com', 'naveen123', 'https://picsum.photos/200/300', 3, 2, 'B+', 0, '2024-11-01'),
('Sharvani', 'Salgaonkar', 'sharvani@gmail.com', 'sharvani123', 'https://picsum.photos/200/300', 3, 3,'A+', 1, '2024-12-01'),
('Shreyas', 'Naik', 'shreyas@gmail.com', 'shreyas123', 'https://picsum.photos/200/300', 3, 4, 'AB+', 0, '2024-01-01'),
('Sujata', 'Chowdhary', 'sujata@gmail.com', 'sujata123', 'https://picsum.photos/200/300', 4, 1,'A+', 1, '2024-02-01'),
('Muskan', 'Ladiya', 'muskan@gmail.com', 'muskan123', 'https://picsum.photos/200/300', 4, 2, 'B+', 0, '2024-03-01'),
('Lakshita', 'Werulkar', 'lakshita@gmail.com', 'lakshita123', 'https://picsum.photos/200/300', 4, 3, 'A+', 1, '2024-04-01'),
('Ritwik', 'Berra', 'ritwik@gmail.com', 'ritwik123', 'https://picsum.photos/200/300', 4, 4, 'B+', 0, '2024-05-01');



select * from Employees;


DBCC CHECKIDENT ('Employees', RESEED, 0);


-- SP for getting the status counts for admin of specific Department 
CREATE PROCEDURE GetTicketStatusCountsForAdmin
    @emp_id INT
AS
BEGIN
    SET NOCOUNT ON;

    DECLARE @dept_id INT;

    -- Get the department of the Admin employee
    SELECT @dept_id = dept_id
    FROM dbo.Employees
    WHERE emp_id = @emp_id;

    -- Select the count of each status in the specified department for the Admin employee
    SELECT
        ts.status_title,
        COUNT(t.ticket_id) AS ticket_count
    FROM dbo.Ticket t
    INNER JOIN dbo.TicketStatus ts ON t.status_id = ts.status_id
    WHERE t.dept_id = @dept_id
    GROUP BY ts.status_title;
END;



EXEC GetTicketStatusCountsForAdmin @emp_id = 2;
EXEC GetTicketStatusCountsForAdmin @emp_id = 1;
