create database employeeid;
use employeeid;

create table employee(
 employee_id int auto_increment primary key,
 employeename varchar(50) not null unique,
 managerid int 
); 

insert into employee( employee_id, employeename, managerid) values
(1, 'Sachin Raje', NULL),
(2, 'Ramakant Pande', 1),
(3, 'Seeta verma', 1),
(4, 'Ganesh Patil', 2),
(5, 'Sitaram Jadhav', 3);



 