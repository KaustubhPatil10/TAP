create database HRDB;
use HRDB;
CREATE TABLE employees (
    id INT AUTO_INCREMENT PRIMARY KEY,
    name VARCHAR(100),
    department VARCHAR(100),
    last_updated TIMESTAMP DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP
);

delimiter //
CREATE TRIGGER update_last_updated_on_update
BEFORE UPDATE ON employees
FOR EACH ROW
BEGIN
    SET NEW.last_updated = CURRENT_TIMESTAMP;
END;
//
DELIMITER ;

insert into employees(name, department) values('Ravi Tambade', 'training'),('kaustubh', 'student'); 

UPDATE  employees  
SET department="BOD" 
WHERE id=1;

select * from employees;

