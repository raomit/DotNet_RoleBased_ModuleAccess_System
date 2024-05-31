create database RaoMit

use RaoMit

create table Users(
	userId int identity(1,1) primary key not null,
	email varchar(100) not null,
	birthDate varchar(100) not null,
	contactNo varchar(15) not null,
	fullName varchar(100) not null,
	password varchar(100) not null,
	type varchar(100) not null
)

create table Role(
	roleId int identity(1,1) not null primary key,
	roleType varchar(100) not null
);

create table Menu(
	menuId int identity(1,1) not null primary key,
	menuType varchar(100) not null
);

create table RolesUsers(
	id int identity(1,1) not null primary key,
	roleId int references Role(roleId),
	userId int references Users(userId)
);

create table RolesMenus(
	id int identity(1,1) not null primary key,
	roleId int references Role(roleId),
	menuId int references Menu(menuId)
);
use RaoMit

insert into Users values('mitrao@outlook.com', '22-05-2000', '9081641373', 'Mit Rao', 'aA@1', 'admin');

insert into Role values('admin');

select * from Role
select * from Users

insert into RolesUsers values(1,1);