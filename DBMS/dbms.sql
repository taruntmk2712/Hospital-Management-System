create table DOCTOR(d_id varchar(10),
d_name varchar(40) not null,
d_phone int not null,
d_address varchar(50) not null,
d_gender varchar(10) not null,
salary int not null,
d_dfrom varchar(15) not null,
d_dto varchar(15) not null,
primary key(d_id)
);

desc doctor;

create table DEPARTMENT(Dep_id varchar(10), 
Dep_name varchar(20) not null,
Dep_email varchar(30) not null,
Dep_head_id varchar(10) unique not null,
Dep_phone int not null,
primary key(Dep_id) ,
foreign key(Dep_head_id) references DOCTOR(d_id));

desc Department;

create table PATIENT(p_id varchar(10) primary key,
p_name varchar(40) NOT NULL,
p_phone int NOT NULL,
p_address varchar(50) NOT NULL,
p_gender varchar(10) NOT NULL,
p_dob date NOT NULL,
p_status varchar(10) NOT NULL);

desc patient;

create table WARD(w_no varchar(10),
w_type varchar(25) not null,
no_of_days int not null,
p_id varchar(10),
primary key(w_no,p_id),
foreign key(p_id) references PATIENT(p_id));

desc ward;

create table ATTENDS(p_id varchar(10),
d_id varchar(10),
primary key(p_id,d_id),
foreign key (p_id) references patient(p_id), 
foreign key (d_id) references doctor(d_id));

desc attends;

create table BILL(p_id varchar(10),
consultation_fee int not null, 
lab_test_fee int not null,
ward_fee int not null,
icu_fee int not null,
amount int not null,
primary key(p_id), 
foreign key(p_id) references patient(p_id));

desc bill;

create table belongs(d_id varchar(10) not null,
dep_id varchar(10) not null,
foreign key(d_id) references doctor(d_id),
foreign key(dep_id) references department(dep_id));

desc belongs;

create table login(username varchar(20),
pwd varchar(15));

desc login;

select * from doctor;

select * from department;

select * from patient;

select * from ward;

select * from attends;

select * from bill;

select * from belongs;




