select * from customers;
select * from orders;

select customers.customerid, customers.customername, customers.contactname, orders.orderid, orders.orderdate
from customers 
left join orders on customers.customerid = orders.customerid;


select customers.customerid, customers.customername, customers.contactname, orders.orderid, orders.orderdate
from customers 
right join orders on orders.customerid = customers.customerid;