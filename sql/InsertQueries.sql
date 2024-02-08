use ticketease;

Insert into Department (dept_id,  dept_name, dept_head) values
('dept_a84c6265-ee5b-4693-8c5e-812dae44ff47', 'IT','Rohan'),
('dept_fd3e3bdf-506c-423e-bfdd-6d75673682d9', 'Admin','Ram'),
('dept_b0272e7b-960e-4442-b154-18d6b98ffde1', 'HR','Rohit'),
('dept_83fc7376-55e0-4713-bec6-84369474abbb', 'L&D','Amey');

Insert into BU (bu_id, bu_name, is_du) values
('bu_a5bdb7d6-b1a0-4fb4-9a56-b035ebf4cb21', 'Hi- tech', 1),
('bu_61a286a2-5807-4ce1-9172-5637e342a8fb', 'IBM', 0),
('bu_0c96abb2-4449-4fed-95f4-09c8d58ac025', 'CMT', 1),
('bu_d4e38c14-31c2-4e15-99aa-bcf7058e6947', 'HLS', 0);

INSERT INTO Employees (emp_id, firstname, lastname, email, password, profile_link, dept_id, bu_id, blood_type, is_admin, joined_on, is_manager, manager_id)
VALUES
('emp_a8728919-b287-4258-a9eb-c25890acae0e', 'Siya', 'Kamat', 'siya@gmail.com', '$2a$12$D8cdgsq6vdHuOt3udbikIeToxLnqqgtzwLrftljRLrY3VJVbZYZoK', 'https://picsum.photos/200/300', 'dept_a84c6265-ee5b-4693-8c5e-812dae44ff47', 'bu_a5bdb7d6-b1a0-4fb4-9a56-b035ebf4cb21', 'A+', 0, '2024-01-01', 1, null),
('emp_496c668a-881d-405c-83f0-d76338133603', 'Rahul', 'Rao', 'rahul@gmail.com', '$2a$12$D8cdgsq6vdHuOt3udbikIeFr.X/1ifbZVSBhD9BzJZEVERBK3oRg.', 'https://picsum.photos/200/300', 'dept_a84c6265-ee5b-4693-8c5e-812dae44ff47', 'bu_61a286a2-5807-4ce1-9172-5637e342a8fb', 'B+', 1, '2024-02-01', 1, 'emp_a8728919-b287-4258-a9eb-c25890acae0e'),
('emp_5427def3-57be-4b71-9c04-93812a5c31f2', 'Riya', 'Jain', 'riya@gmail.com', '$2a$12$D8cdgsq6vdHuOt3udbikIeGVl.CoIc6K8POLGMoJhnThyeyfZavaK', 'https://picsum.photos/200/300', 'dept_a84c6265-ee5b-4693-8c5e-812dae44ff47', 'bu_0c96abb2-4449-4fed-95f4-09c8d58ac025', 'A+', 0, '2024-03-01', 1, 'emp_496c668a-881d-405c-83f0-d76338133603'),
('emp_b68ca3cd-693b-4b53-8c03-f2edfa1b9e7e', 'Rocky', 'Shah', 'rocky@gmail.com', '$2a$12$D8cdgsq6vdHuOt3udbikIeTRUVJw6.wQITXpWzYSWKm7OQkYhPkO2', 'https://picsum.photos/200/300', 'dept_a84c6265-ee5b-4693-8c5e-812dae44ff47', 'bu_d4e38c14-31c2-4e15-99aa-bcf7058e6947', 'AB+', 1, '2024-04-01', 1, 'emp_5427def3-57be-4b71-9c04-93812a5c31f2'),
('emp_a5e98893-66f2-48f3-b29e-31e0fdbc27e5', 'Rocky', 'Shah', 'rocky@gmail.com', '$2a$12$D8cdgsq6vdHuOt3udbikIeTRUVJw6.wQITXpWzYSWKm7OQkYhPkO2', 'https://picsum.photos/200/300', 'dept_a84c6265-ee5b-4693-8c5e-812dae44ff47', 'bu_d4e38c14-31c2-4e15-99aa-bcf7058e6947', 'AB-', 1, '2024-05-01', 0, 'emp_a8728919-b287-4258-a9eb-c25890acae0e'),
('emp_20e73bb5-5474-40c4-badf-152422ffc7cf', 'Chirag', 'Gaonkar', 'chirag@gmail.com', '$2a$12$D8cdgsq6vdHuOt3udbikIezRR1Z9T40Hn0OTh8BKubCDFGBlZ.2kq', 'https://picsum.photos/200/300', 'dept_fd3e3bdf-506c-423e-bfdd-6d75673682d9', 'bu_a5bdb7d6-b1a0-4fb4-9a56-b035ebf4cb21', 'A+', 1, '2024-06-01', 0, 'emp_a8728919-b287-4258-a9eb-c25890acae0e'),
('emp_e6bcbc2e-c666-4151-b5b7-86900e4b5343', 'Ruhi', 'Pai', 'ruhi@gmail.com', '$2a$12$D8cdgsq6vdHuOt3udbikIeMrlBHdKRZkeUY5jPjRcD1S2MtfBp4I6', 'https://picsum.photos/200/300', 'dept_fd3e3bdf-506c-423e-bfdd-6d75673682d9', 'bu_61a286a2-5807-4ce1-9172-5637e342a8fb', 'O+', 0, '2024-07-01', 0, 'emp_a8728919-b287-4258-a9eb-c25890acae0e'),
('emp_65dfd363-291e-4a86-92e7-07105ddc2410', 'Rounak', 'Naik', 'rounak@gmail.com', '$2a$12$D8cdgsq6vdHuOt3udbikIexU9E2GZ9iKQ9CGi9vOr41IVntRt.HRi', 'https://picsum.photos/200/300', 'dept_fd3e3bdf-506c-423e-bfdd-6d75673682d9', 'bu_0c96abb2-4449-4fed-95f4-09c8d58ac025', 'O+', 1, '2024-08-01', 0, 'emp_496c668a-881d-405c-83f0-d76338133603'),
('emp_4d848f45-c124-41ed-984b-98238425f26d', 'Rohan', 'Kumar', 'rohan@gmail.com', '$2a$12$D8cdgsq6vdHuOt3udbikIeC/LnUjgOHTH//krygXKBVDJmq6SyI52', 'https://picsum.photos/200/300', 'dept_fd3e3bdf-506c-423e-bfdd-6d75673682d9', 'bu_d4e38c14-31c2-4e15-99aa-bcf7058e6947', 'O+', 0, '2024-09-01', 0, 'emp_496c668a-881d-405c-83f0-d76338133603'),
('emp_0983f5b6-5834-459b-94fc-2305a187ecc5', 'Amar', 'Singh', 'amar@gmail.com', '$2a$12$D8cdgsq6vdHuOt3udbikIeqhdLJ3vJutOUV3SdrQQvMKtbCeE8QPG', 'https://picsum.photos/200/300', 'dept_b0272e7b-960e-4442-b154-18d6b98ffde1', 'bu_a5bdb7d6-b1a0-4fb4-9a56-b035ebf4cb21', 'O+', 1, '2024-10-01', 0, 'emp_496c668a-881d-405c-83f0-d76338133603'),
('emp_7e1db320-0d2d-4d69-8122-01ff2aa1eef9', 'Naveen', 'Naik', 'naveen@gmail.com', '$2a$12$D8cdgsq6vdHuOt3udbikIe1pa2WbQIvmZ0.3j7DBErz9/Z7XMWSum', 'https://picsum.photos/200/300', 'dept_b0272e7b-960e-4442-b154-18d6b98ffde1', 'bu_61a286a2-5807-4ce1-9172-5637e342a8fb', 'B+', 0, '2024-11-01', 0, 'emp_496c668a-881d-405c-83f0-d76338133603'),
('emp_ec72d277-9542-4856-bc4b-b38969aba809', 'Sharvani', 'Salgaonkar', 'sharvani@gmail.com', '$2a$12$D8cdgsq6vdHuOt3udbikIe7yxTyZgZOd9M7DR5ph2fklrDA0qRNQO', 'https://picsum.photos/200/300', 'dept_b0272e7b-960e-4442-b154-18d6b98ffde1', 'bu_0c96abb2-4449-4fed-95f4-09c8d58ac025','A+', 1, '2024-12-01', 0,'emp_5427def3-57be-4b71-9c04-93812a5c31f2'),
('emp_abd849f7-d591-4a40-997e-5a9ed0e2631e', 'Shreyas', 'Naik', 'shreyas@gmail.com', '$2a$12$D8cdgsq6vdHuOt3udbikIekGIVNM511tY/lreuMhvryY30YSst22m', 'https://picsum.photos/200/300', 'dept_b0272e7b-960e-4442-b154-18d6b98ffde1', 'bu_d4e38c14-31c2-4e15-99aa-bcf7058e6947', 'AB+', 0, '2024-01-01', 0, 'emp_5427def3-57be-4b71-9c04-93812a5c31f2'),
('emp_dfc2bca0-afe9-49c4-90ae-e46ad3be1a60', 'Sujata', 'Chowdhary', 'sujata@gmail.com', '$2a$12$D8cdgsq6vdHuOt3udbikIee8jHl2.63/6TpCk8CKhlq3t0K0QguY6', 'https://picsum.photos/200/300', 'dept_83fc7376-55e0-4713-bec6-84369474abbb', 'bu_a5bdb7d6-b1a0-4fb4-9a56-b035ebf4cb21','A+', 1, '2024-02-01', 0, 'emp_b68ca3cd-693b-4b53-8c03-f2edfa1b9e7e'),
('emp_f0820294-789d-405e-a68e-09d596eb503a', 'Muskan', 'Ladiya', 'muskan@gmail.com', '$2a$12$D8cdgsq6vdHuOt3udbikIe1Wr57z8YFouYE3TRLwQgFGnQfIK8zNy', 'https://picsum.photos/200/300', 'dept_83fc7376-55e0-4713-bec6-84369474abbb', 'bu_61a286a2-5807-4ce1-9172-5637e342a8fb', 'B+', 0, '2024-03-01', 0, 'emp_b68ca3cd-693b-4b53-8c03-f2edfa1b9e7e'),
('emp_810fbbdf-7856-4c89-a907-f40e1c7605df', 'Lakshita', 'Werulkar', 'lakshita@gmail.com', '$2a$12$D8cdgsq6vdHuOt3udbikIeMTaH1scpI3AxRmCdS.1DgWgzcgxg/ia', 'https://picsum.photos/200/300', 'dept_83fc7376-55e0-4713-bec6-84369474abbb', 'bu_0c96abb2-4449-4fed-95f4-09c8d58ac025', 'A+', 1, '2024-04-01', 0, 'emp_b68ca3cd-693b-4b53-8c03-f2edfa1b9e7e'),
('emp_94ded31a-61f9-4d07-8116-c8f99c94bdf5', 'Ritwik', 'Berra', 'ritwik@gmail.com', '$2a$12$D8cdgsq6vdHuOt3udbikIepQjof16oIezP79hqbAbXyGvk5HKNYGm', 'https://picsum.photos/200/300', 'dept_83fc7376-55e0-4713-bec6-84369474abbb', 'bu_d4e38c14-31c2-4e15-99aa-bcf7058e6947', 'B+', 0, '2024-05-01', 0, 'emp_b68ca3cd-693b-4b53-8c03-f2edfa1b9e7e');


Insert into TicketStatus (status_id, status_title) values('tktsts_dcf37724-5e04-42a3-8748-dff1281a8566', 'Open'),('tktsts_15c68b50-da8d-42bb-8605-30a0402ace5f', 'Pending Approval'),('tktsts_b4251227-c68d-4da7-a278-5fd8c9268923', 'Resolved'),('tktsts_fcc9c55b-e391-4370-b99d-49ee0dacf6d5', 'Closed');


Insert into dbo.RequestTypes (request_type_id, request_type, dept_id, description, is_incident, structure) values('rqsttyp_f27cfea1-750e-40aa-898a-4c34704be6e1', 'Electrical','dept_a84c6265-ee5b-4693-8c5e-812dae44ff47', 'Description',0,'[{key:"name",title:"FullName",},{key:"location",title:"Location",},]'),
							  ('rqsttyp_2eff02a9-4fac-4e51-b1b0-870f44a866e4', 'Travel Request','dept_a84c6265-ee5b-4693-8c5e-812dae44ff47','Description',0,'[{key:"name",title:"FullName",},{key:"location",title:"Location",},]'),
							  ('rqsttyp_b1e0a6ea-0de8-419a-a7d6-59843678cca1', 'Pantry Service','dept_a84c6265-ee5b-4693-8c5e-812dae44ff47','Description',0,'[{key:"name",title:"FullName",},{key:"location",title:"Location",},]'),
							  ('rqsttyp_c096c9be-c10b-4085-a15c-cf331242fd0b', 'Salary Related','dept_fd3e3bdf-506c-423e-bfdd-6d75673682d9','Description',0,'[{key:"name",title:"FullName",},{key:"location",title:"Location",},]'),
							  ('rqsttyp_697b837b-be66-4fa1-b1f6-16a8a16a132a', 'Leaves & Absence','dept_fd3e3bdf-506c-423e-bfdd-6d75673682d9','Description',0,'[{key:"name",title:"FullName",},{key:"location",title:"Location",},]'),
							  ('rqsttyp_4abbd4c6-8f41-41a4-bbb4-b958580bcd8b', 'Update Profile and skills','dept_fd3e3bdf-506c-423e-bfdd-6d75673682d9','Description',0,'[{key:"name",title:"FullName",},{key:"location",title:"Location",},]'),
							  ('rqsttyp_50d2cfd0-8e10-4e02-b3aa-558b32963292', 'Gen AI tools','dept_b0272e7b-960e-4442-b154-18d6b98ffde1','Description',0,'[{key:"name",title:"FullName",},{key:"location",title:"Location",},]'),
							  ('rqsttyp_b7932c1c-e396-4ec1-bebe-b07660bacd57', 'Hardware Request','dept_b0272e7b-960e-4442-b154-18d6b98ffde1','Description',0,'[{key:"name",title:"FullName",},{key:"location",title:"Location",},]'),
							  ('rqsttyp_02c91bdd-f10d-4f79-b7eb-d15e9c3c3c6f', 'Software Installation & uninstallation','dept_b0272e7b-960e-4442-b154-18d6b98ffde1','Description',0,'[{key:"name",title:"FullName",},{key:"location",title:"Location",},]'),
							  ('rqsttyp_55fff4a2-085e-46cb-8f07-28fff82873ec', 'Training Request & assistance','dept_83fc7376-55e0-4713-bec6-84369474abbb','Description',0,'[{key:"name",title:"FullName",},{key:"location",title:"Location",},]'),
							  ('rqsttyp_4a2585e9-c69c-4e5c-bf99-381a75ee3fea', 'Course Enrollment','dept_83fc7376-55e0-4713-bec6-84369474abbb','Description',0,'[{key:"name",title:"FullName",},{key:"location",title:"Location",},]'),
							  ('rqsttyp_cbd6b224-3fd0-402a-9f07-43ea2fefd34a', 'Certification assistance','dept_83fc7376-55e0-4713-bec6-84369474abbb','Description',0,'[{key:"name",title:"FullName",},{key:"location",title:"Location",},]');

Insert into dbo.RequestTypes (request_type_id, request_type, dept_id, description, is_incident, structure) values('rqsttyp_0296a34e-9003-43cd-b360-c6156496974b', 'IT Incident','dept_a84c6265-ee5b-4693-8c5e-812dae44ff47','Description',1,'[{key:"name",title:"FullName",},{key:"location",title:"Location",},]'),
							  ('rqsttyp_2ae6621e-4344-4fb5-9ec7-0107e1fe3fe7', 'Admin Incident','dept_fd3e3bdf-506c-423e-bfdd-6d75673682d9','Description',1,'[{key:"name",title:"FullName",},{key:"location",title:"Location",},]'),
							  ('rqsttyp_69d7b96f-546a-458a-9333-10a95c76847c', 'HR Incident','dept_b0272e7b-960e-4442-b154-18d6b98ffde1','Description',1,'[{key:"name",title:"FullName",},{key:"location",title:"Location",},]'),
							  ('rqsttyp_5d6c971a-a94c-4afc-a8c0-a424090c94ac', 'L&D Incident','dept_83fc7376-55e0-4713-bec6-84369474abbb','Description',1,'[{key:"name",title:"FullName",},{key:"location",title:"Location",},]');


Insert into Ticket (ticket_id, title, formdata, emp_id, dept_id, admin_id, manager_id, status_id, request_type_id, priority, created_on, updated_on, need_approval) Values
	('tkt_314a8a66-3177-4ace-b96d-91adf3d153bf', 'Network Issue',null,'emp_a8728919-b287-4258-a9eb-c25890acae0e','dept_a84c6265-ee5b-4693-8c5e-812dae44ff47',null,null,'tktsts_dcf37724-5e04-42a3-8748-dff1281a8566','rqsttyp_02c91bdd-f10d-4f79-b7eb-d15e9c3c3c6f',1,'2024-01-01','2024-01-05',0),
	('tkt_e75272e7-8dd0-4096-b2c2-5041d7630db8', 'Software error',null,'emp_496c668a-881d-405c-83f0-d76338133603','dept_a84c6265-ee5b-4693-8c5e-812dae44ff47',null,'emp_a8728919-b287-4258-a9eb-c25890acae0e','tktsts_15c68b50-da8d-42bb-8605-30a0402ace5f','rqsttyp_02c91bdd-f10d-4f79-b7eb-d15e9c3c3c6f',2,'2024-01-05','2024-01-10',1),
	('tkt_6dc62708-3dcd-4659-be4f-27d5e9cd8a1c', 'Website Downtime',null,'emp_5427def3-57be-4b71-9c04-93812a5c31f2','dept_a84c6265-ee5b-4693-8c5e-812dae44ff47',null,'emp_496c668a-881d-405c-83f0-d76338133603','tktsts_b4251227-c68d-4da7-a278-5fd8c9268923','rqsttyp_02c91bdd-f10d-4f79-b7eb-d15e9c3c3c6f',3,'2024-01-11','2024-01-15',0),
	('tkt_a1317c64-d879-46c2-8325-eb7b072e3194', 'Network Outage',null,'emp_b68ca3cd-693b-4b53-8c03-f2edfa1b9e7e','dept_a84c6265-ee5b-4693-8c5e-812dae44ff47',null,'emp_5427def3-57be-4b71-9c04-93812a5c31f2','tktsts_fcc9c55b-e391-4370-b99d-49ee0dacf6d5','rqsttyp_02c91bdd-f10d-4f79-b7eb-d15e9c3c3c6f',3,'2024-01-16','2024-01-20',1),
	('tkt_aef2d3ec-4388-4a9a-84a8-4cd391d10bc2', 'Electrical',null,'emp_4d848f45-c124-41ed-984b-98238425f26d','dept_fd3e3bdf-506c-423e-bfdd-6d75673682d9',null,'emp_496c668a-881d-405c-83f0-d76338133603','tktsts_dcf37724-5e04-42a3-8748-dff1281a8566','rqsttyp_f27cfea1-750e-40aa-898a-4c34704be6e1',1,'2024-01-16','2024-01-20',1),
	('tkt_7786f990-9145-4fc7-8a27-d6e3ba9ff27e', 'Pantry Service',null,'emp_0983f5b6-5834-459b-94fc-2305a187ecc5','dept_b0272e7b-960e-4442-b154-18d6b98ffde1',null,'emp_496c668a-881d-405c-83f0-d76338133603','tktsts_15c68b50-da8d-42bb-8605-30a0402ace5f','rqsttyp_b1e0a6ea-0de8-419a-a7d6-59843678cca1',3,'2024-01-16','2024-01-20',1),
	('tkt_c2e5b4a0-12b1-457d-8380-9a78813668da', 'Salary Related',null,'emp_ec72d277-9542-4856-bc4b-b38969aba809','dept_b0272e7b-960e-4442-b154-18d6b98ffde1',null,'emp_5427def3-57be-4b71-9c04-93812a5c31f2','tktsts_b4251227-c68d-4da7-a278-5fd8c9268923','rqsttyp_c096c9be-c10b-4085-a15c-cf331242fd0b',1,'2024-01-16','2024-01-20',1),
	('tkt_c43ad084-3f29-47d6-8907-76cc0e494eb4', 'Leaves & Absence',null,'emp_dfc2bca0-afe9-49c4-90ae-e46ad3be1a60','dept_83fc7376-55e0-4713-bec6-84369474abbb',null,'emp_b68ca3cd-693b-4b53-8c03-f2edfa1b9e7e','tktsts_fcc9c55b-e391-4370-b99d-49ee0dacf6d5','rqsttyp_697b837b-be66-4fa1-b1f6-16a8a16a132a',2,'2024-01-16','2024-01-20',1),
	('tkt_86a50b28-8241-4af5-b192-12503a159c19', 'Leaves & Absence',null,'emp_496c668a-881d-405c-83f0-d76338133603','dept_a84c6265-ee5b-4693-8c5e-812dae44ff47',null,'emp_a8728919-b287-4258-a9eb-c25890acae0e','tktsts_fcc9c55b-e391-4370-b99d-49ee0dacf6d5','rqsttyp_697b837b-be66-4fa1-b1f6-16a8a16a132a',2,'2024-01-16','2024-01-20',1),
	('tkt_287773dd-ea64-4b5b-922f-3a1b343ac438', 'Leaves & Absence',null,'emp_5427def3-57be-4b71-9c04-93812a5c31f2','dept_a84c6265-ee5b-4693-8c5e-812dae44ff47',null,'emp_496c668a-881d-405c-83f0-d76338133603','tktsts_fcc9c55b-e391-4370-b99d-49ee0dacf6d5','rqsttyp_697b837b-be66-4fa1-b1f6-16a8a16a132a',3,'2024-01-16','2024-01-20',1),
	('tkt_3d708f2e-a226-47cf-a98a-2d91588ed2cf', 'Update Profile',null,'emp_b68ca3cd-693b-4b53-8c03-f2edfa1b9e7e','dept_a84c6265-ee5b-4693-8c5e-812dae44ff47',null,'emp_5427def3-57be-4b71-9c04-93812a5c31f2','tktsts_15c68b50-da8d-42bb-8605-30a0402ace5f','rqsttyp_4abbd4c6-8f41-41a4-bbb4-b958580bcd8b',1,'2024-01-16','2024-01-20',1),
	('tkt_82b55c2d-8239-4dd2-a7d8-7709b0122644', 'Keyboard Issue',null,'emp_20e73bb5-5474-40c4-badf-152422ffc7cf','dept_fd3e3bdf-506c-423e-bfdd-6d75673682d9',null,'emp_a8728919-b287-4258-a9eb-c25890acae0e','tktsts_dcf37724-5e04-42a3-8748-dff1281a8566','rqsttyp_0296a34e-9003-43cd-b360-c6156496974b',0,GETDATE(),GETDATE(),1),
	('tkt_0636aa58-dad6-4c20-9280-a4b15b9c1312', 'Access card issue',null,'emp_20e73bb5-5474-40c4-badf-152422ffc7cf','dept_fd3e3bdf-506c-423e-bfdd-6d75673682d9',null,'emp_a8728919-b287-4258-a9eb-c25890acae0e','tktsts_15c68b50-da8d-42bb-8605-30a0402ace5f','rqsttyp_2ae6621e-4344-4fb5-9ec7-0107e1fe3fe7',0,GETDATE(),GETDATE(),1),
	('tkt_5525d65b-3d8c-4e3a-b6dc-863d29202777', 'Leave issue',null,'emp_20e73bb5-5474-40c4-badf-152422ffc7cf','dept_fd3e3bdf-506c-423e-bfdd-6d75673682d9',null,'emp_a8728919-b287-4258-a9eb-c25890acae0e','tktsts_dcf37724-5e04-42a3-8748-dff1281a8566','rqsttyp_69d7b96f-546a-458a-9333-10a95c76847c',1,GETDATE(),GETDATE(),1),
	('tkt_2c7c2047-04af-436b-8bb5-d4b2c0e44f76', 'Course issue',null,'emp_20e73bb5-5474-40c4-badf-152422ffc7cf','dept_fd3e3bdf-506c-423e-bfdd-6d75673682d9',null,'emp_a8728919-b287-4258-a9eb-c25890acae0e','tktsts_15c68b50-da8d-42bb-8605-30a0402ace5f','rqsttyp_5d6c971a-a94c-4afc-a8c0-a424090c94ac',2,GETDATE(),GETDATE(),1);

insert into dbo.TicketComments (comment_id, description, ticket_id, status_title,created_on,updated_on) Values('tktcmnts_90a98a0b-689d-44ed-bb79-538f860f2548', 'Network Issue In progress','tkt_314a8a66-3177-4ace-b96d-91adf3d153bf','Open',GETDATE(),GETDATE());
insert into dbo.TicketComments (comment_id, description, ticket_id, status_title,created_on,updated_on) Values('tktcmnts_35c22565-09c5-44a3-8408-35fee6147ce5', 'Network Issue Closed','tkt_314a8a66-3177-4ace-b96d-91adf3d153bf','Pending Approval',GETDATE(),GETDATE());


