use Exam

select * from Users

create table Roles(
	roleId int identity(1,1) not null,
	roleName varchar(255) not null,
	constraint pk_roleId primary key(roleId)
);

drop table Roles

create table RolesUsers(
id int identity(1,1) not null,
roleId int references Roles(roleId)
);

insert into Roles values('customer'), ('cook'), ('cashier'), ('admin');

select * from Roles

create table ProductMenu(
productMenuId int identity(1,1) not null,
menuName varchar(255) not null,
menuItem1 varchar(100) not null,
roleId int references Roles(roleId),
constraint pk_prodMenuId primary key(ProductMenuId)
);
drop table ProductMenu


insert into ProductMenu values ('product menu', 'product menu item 1', 4),
('food ticket menu', 'food ticket menu item 1', 3),
('order food menu', 'order food menu item 1', 1),
('stock management menu', 'stock management menu item 1', 2)

truncate table ProductMenu

alter table Roles drop column userId

select * from RolesUsers

select * from Roles
select * from Users

delete from Users where Email = 'mitrao1999@outlook.com'

insert into RolesUsers values (1,1),
(1,2),
(2,3),
(2,4),
(4,5),
(2,6),
(3,3)

insert into RolesUsers values (2,48)

select * from Users

alter table RolesUsers add constraint pk_id Primary Key (id)


select * from ProductMenu