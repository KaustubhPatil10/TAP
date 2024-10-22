use trial;
create table customers(
  customerid int auto_increment primary key,
  customername varchar(50) not null unique,
  contactname varchar(50) not null
);

insert into customers(customerid, customername, contactname) values
(1, 'John Doe', 'John'),
(2, 'Jane Smith', 'Jane'),
(3, 'Mike Johnson', 'Mike');

create table orders(
  orderid int auto_increment primary key,
  customerid int not null,
  orderdate date not null
 -- foreign key (customerid) references customers(customerid)
 --	on update cascade
--  on delete cascade
);


insert into orders(orderid, customerid, orderdate) values
(101, 1, '2024-01-10'),
(102, 1, '2024-01-15'),
(103, 2, '2024-02-01'),
(104, 4, '2024-03-15');
