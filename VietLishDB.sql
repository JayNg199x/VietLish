--User account--
CREATE TABLE Account
(
    account_id nvarchar(30) primary key NOT NULL,
	full_name nvarchar(50) NULL,
	[username] varchar(20) NOT NULL,
	[password]  varchar(20) NOT NULL,
	dob datetime NULL,
	gender bit NULL,
	[role] bit NOT NULL,
		
)



-- Test--
CREATE TABLE Test
(
	test_id int identity(1,1) primary key,
	[description] nvarchar(200) NULL,
	date_created datetime NULL,
	test_time time NOT NULL,
	num_p1 int NOT NULL,
	num_p2 int NOT NULL,
	num_p3 int NOT NULL,
	num_p4 int NOT NULL,
	num_p5 int NOT NULL,
	num_p6 int NOT NULL,
	num_p7 int NOT NULL,
	
)



CREATE TABLE Question
(
    question_id int identity(1,1) primary key, 
	question nvarchar(max) null, 
	A nvarchar(max) null,
	B nvarchar(max) null,
	C nvarchar(max) null,
	D nvarchar(max) null,
	answer nvarchar(5) not null,
	module_id int foreign key (module_id) references Module(module_id) NULL,
)

 -- module study--
CREATE TABLE Module  
(
	module_id int identity(1,1) primary key,
	topic_name varchar(100),
	[image] nvarchar(max),
)
insert into Module values ('Animal',N'animal.jpg')
insert into Module values ('Color',N'color.jpg')



-- vocabulary---
CREATE TABLE Vocabulary
(
	vocab_id int identity(1,1) primary key,
	vocab_name nvarchar(50) NOT NULL,
	spelling nvarchar(100) NOT NULL, 
	vocab_type nvarchar(100) NULL,
	means nvarchar(100) NOT NULL,
	[synonym] nvarchar(100) NULL,
	antonym nvarchar(100) NULL,
	[image] varchar(max) NULL,
	module_id int foreign key (module_id) references Module(module_id),
)
CREATE TABLE Sentence
(
	sentence_id int identity(1,1) primary key,
	sentence nvarchar(max) NOT NULL,
	means nvarchar(max) NOT NULL,
	[image] varchar(max) NULL,
	module_id int foreign key (module_id) references module(module_id) NULL,
)



CREATE TABLE ScoreOfTest
(
	score_test_id int identity(1,1) primary key NOT NULL,
	listening_score int NOT NULL,
	total_score int NOT NULL,
	test_id int foreign key (test_id) references Test(test_id) NOT NULL,
	account_id nvarchar(30) foreign key (account_id) references Account(account_id),
	date_of_test datetime NULL,
)

CREATE TABLE Studies
(
	studies_id int identity(1,1) primary key NOT NULL,
	status_test nvarchar(max) NOT NULL,
	module_id int foreign key (module_id) references Module(module_id) NOT NULL,
	account_id nvarchar(30) foreign key (account_id) references Account(account_id),
)