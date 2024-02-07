create database ticketease;
use ticketease;

-- BU Table
CREATE TABLE dbo.BU (
	sr_no int identity(1,1),
    bu_id varchar(50) not null,
    bu_name varchar(255) NOT NULL,
    is_du Bit,
	Constraint PK_BU PRIMARY KEY CLUSTERED (bu_id)
);

-- TicketStatus Table
create table dbo.TicketStatus(
sr_no int identity(1,1),
status_id varchar(50) not null,
status_title varchar(255),
Constraint PK_TicketStatus PRIMARY KEY CLUSTERED (status_id)
);



-- Department Table
create table dbo.Department(
sr_no int identity(1,1),
dept_id varchar(50) not null,
dept_name varchar(255),
dept_head varchar(255),
Constraint PK_Dept PRIMARY KEY CLUSTERED (dept_id)
);



-- Employees Table
CREATE TABLE dbo.Employees (
	sr_no int identity(1,1),
    emp_id varchar(50) NOT NULL,
    firstname varchar(255) NOT NULL,
	lastname varchar(255) NOT NULL,
	email varchar(255) NOT NULL,
	password varchar(255) NOT NULL,
	profile_link varchar(255) NOT NULL,
	dept_id varchar(50) NOT NULL,
	bu_id varchar(50) NOT NULL,
	manager_id varchar(50) NULL,
	blood_type char(10) NOT NULL,
	is_admin bit not null,
	is_manager bit not null default 0,
	joined_on datetime,
	Constraint PK_emp PRIMARY KEY CLUSTERED (emp_id),
	Constraint fk_dept FOREIGN KEY (dept_id)
        REFERENCES dbo.Department(dept_id)
        ON DELETE CASCADE
        ON UPDATE CASCADE,
	Constraint fk_user Foreign key (manager_id) references dbo.Employees(emp_id),
	Constraint fk_bu Foreign key (bu_id) references dbo.BU (bu_id)
);

-- RequestTypes Table
CREATE TABLE dbo.RequestTypes(
	sr_no int identity(1,1), 
	request_type_id varchar(50) NOT NULL,
	request_type varchar(255) not null,
	dept_id varchar(50) not null,
	description varchar(max) not null,
	is_incident bit not null default 0,
	structure varchar(max) null,
	Constraint PK_request_type PRIMARY KEY CLUSTERED (request_type_id),
	Constraint fk_dept_request_type Foreign key (dept_id) references dbo.Department(dept_id)
);



-- Ticket Table
CREATE TABLE dbo.Ticket(
	sr_no int identity(1,1), 
	ticket_id varchar(50) NOT NULL,
    title varchar(255) NOT NULL,
	formdata varchar(max) null,
	emp_id varchar(50) not null,
	dept_id varchar(50) not null,
	admin_id varchar(50) null,
	manager_id varchar(50) null,
	status_id varchar(50) not null,
	request_type_id varchar(50) not null,
	priority int,
	created_on date,
	updated_on date,
	need_approval bit,
	Constraint PK_Ticket PRIMARY KEY CLUSTERED (ticket_id),
	Constraint fk_user_ticket Foreign key (emp_id) references dbo.Employees(emp_id),
	Constraint fk_Admin_ticket Foreign key (admin_id) references dbo.Employees(emp_id),
	Constraint fk_Manager_ticket Foreign key (manager_id) references dbo.Employees(emp_id),
	Constraint fk_status_ticket Foreign key (status_id) references dbo.TicketStatus(status_id),
	Constraint fk_dept_ticket FOREIGN KEY (dept_id) REFERENCES dbo.Department(dept_id),
	Constraint fk_requesttype_ticket FOREIGN KEY (request_type_id) REFERENCES dbo.RequestTypes(request_type_id)
);

-- TicketComments Table
CREATE TABLE dbo.TicketComments(
	sr_no int identity(1,1),
	comment_id varchar(50) NOT NULL,
	description varchar(255) not null,
	ticket_id varchar(50) not null,
	status_title varchar(255) not null,
	created_on date,
	updated_on date,
	Constraint PK_TicketComments PRIMARY KEY CLUSTERED (comment_id),
	Constraint fk_ticket_and_comments Foreign key (ticket_id) references dbo.Ticket(ticket_id),
);

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
    FROM dbo.TicketStatus ts
    LEFT JOIN dbo.Ticket t ON ts.status_id = t.status_id AND t.dept_id = @dept_id
    GROUP BY ts.status_title;
END;

--EXEC GetTicketStatusCountsForAdmin @emp_id = 2;
--EXEC GetTicketStatusCountsForAdmin @emp_id = 1;

--SP for getting ticket comments for particular ticket
CREATE PROCEDURE GetTicketCommentsForTicket
    @ticket_id varchar(50)
AS
BEGIN
	DECLARE @status_id varchar(50);
	DECLARE @status_title VARCHAR(255);

	Select status_id=@status_id
	From dbo.Ticket
	where ticket_id=@ticket_id;


	Select @status_title = status_title from TicketStatus
	where status_id=@status_id;

    SELECT
        t.ticket_id,t.description,@status_id as Status
    FROM dbo.TicketComments t
    WHERE t.ticket_id = @ticket_id;
END;

--exec GetTicketCommentsForTicket @ticket_id=2;

-- SP for updating status and adding comments for particular Ticket
CREATE PROCEDURE UpdateTicketStatusandAddComments
    @ticket_id INT,
	@status_title Varchar(255),
	@comment Varchar(255)
AS
BEGIN
    SET NOCOUNT ON;

	DECLARE @status_id INT;

    -- Get the status_id of the Ticket
	SELECT @status_id=status_id from dbo.TicketStatus
	where status_title=@status_title;
    
	UPDATE dbo.Ticket
	SET status_id = @status_id
	WHERE ticket_id = @ticket_id;
	
	INSERT INTO dbo.TicketComments([description],[ticket_id],[status_title],[created_on],[updated_on]) 
	VALUES (@comment,@ticket_id,status_title,GETDATE(),GETDATE())
END;

EXEC UpdateTicketStatusandAddComments @ticket_id = 2,@status_title='Closed',@comment='Now this is closed';

-- Addition of priority column with values 1,2,3 -- 1 being the high priority
Alter Table Ticket add priority int;

--SP for getting counts of tickets by priority
CREATE PROCEDURE GetTicketPriorityCountsForAdmin
    @emp_id varchar(50)
AS
BEGIN
    SET NOCOUNT ON;

    DECLARE @dept_id varchar(50);

    -- Get the department of the Admin employee
    SELECT @dept_id = dept_id
    FROM dbo.Employees
    WHERE emp_id = @emp_id;

    -- Select the count of each priority in the specified department for the Admin employee
    SELECT
        t.priority,COUNT(t.ticket_id) AS ticket_count
    FROM dbo.Ticket t
    WHERE t.dept_id = @dept_id
    GROUP BY t.priority;
END;


use ticketease;


  alter table employees add is_manager bit not null default 0;

  drop table TicketComments;
  drop table Ticket;
  drop table RequestTypes;
  drop table Employees;
  drop table BU;
  drop table Department;
  drop table TicketStatus;

  
