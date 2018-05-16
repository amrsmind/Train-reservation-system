create table users(
SSN int primary key,
Email varchar(50) unique not null,
pass varchar(50) not null,
FirstName varchar(50) not null,
LastName varchar(50) not null,
);


create table Admins(
SSN int unique foreign key references users(SSN) 
);

create table customers(
SSN int unique foreign key references users(SSN)
);

create table trains(
train_num int primary key,
avail_seat int not null,
controlledby int foreign key references admins(SSN) not null
);

create table fromto(
route_num int primary key,
startpoint varchar(50),
endpoint varchar(50)
);

create table trips(
trip_num int primary key,
StartDate date not null,
EndDate date not null,
StartTime time not null,
EndTime time not null,
Controlledby int foreign key references admins(SSN) not null,
train_num int foreign key references trains(train_num),
route_num int foreign key references fromto(route_num)
);

create table seats(
seat_num int not null,
train_num int foreign key references trains(train_num)
);

create table bookedtrips(
SSN int foreign key references customers(ssn),
trip_num int foreign key references trips(trip_num)
);

create table canceledtrips(
SSN int foreign key references customers(ssn),
trip_num int foreign key references trips(trip_num)
);

alter table trips 
add availseats int;

alter table canceledtrips
add seats int;

alter table bookedtrips
add seats int not null;