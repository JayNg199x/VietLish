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
	[status] bit NULL, -- test start or stop testing
	[date_test] datetime NULL,	
)

CREATE TABLE Part
(
	part_id int identity(1,1) primary key,
	[name_part] nvarchar(50) NOT NULL,
	[image] nvarchar(max) NULL
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
	total_tester int NOT NULL,
	level_of_test nvarchar(max) NULL,
)

--Level--
CREATE TABLE [Level]
(
	level_id int identity(1,1) primary key,
	level_name nvarchar(20),
	[image] nvarchar(max),
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
	level_id int foreign key (level_id) references [Level](level_id) NOT NULL, 
	test_id int foreign key (test_id) references test(test_id) NULL,
	part_id int foreign key (part_id) references Part(part_id) NULL,
)

 -- module study--
CREATE TABLE Module  
(
	module_id int identity(1,1) primary key,
	topic_name varchar(100),
	[image] nvarchar(max),
)

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
	module_id int foreign key (module_id) references module(module_id),
	test_id int foreign key (test_id) references test(test_id) NULL,
)
CREATE TABLE Sentence
(
	sentence_id int identity(1,1) primary key,
	sentence nvarchar(max) NOT NULL,
	means nvarchar(max) NOT NULL,
	[image] varchar(max) NULL,
	module_id int foreign key (module_id) references module(module_id),
	test_id int foreign key (test_id) references test(test_id) NULL,
)

CREATE TABLE Score
(
	score_id int identity(1,1) primary key,
	listening_score int,
	reading_score int,
	total_score int,
	account_id nvarchar(30) foreign key (account_id) references Account(account_id),
)


CREATE TABLE QuestionOfTest
(
	question_of_test_id int primary key NOT NULL,
	question_id int foreign key (question_id) references Question(question_id) NOT NULL,
	test_id int foreign key (test_id) references Test(test_id) NOT NULL,
	number_of_ques int NULL,
	test_day datetime NULL,
)

CREATE TABLE ScoreOfTest
(
	score_test_id int identity(1,1) primary key NOT NULL,
	listening_score int NOT NULL,
	reading_score int NOT NULL,
	total_score int NOT NULL,
	test_id int foreign key (test_id) references Test(test_id) NOT NULL,
	account_id nvarchar(30) foreign key (account_id) references Account(account_id),
	date_created datetime NULL,
)