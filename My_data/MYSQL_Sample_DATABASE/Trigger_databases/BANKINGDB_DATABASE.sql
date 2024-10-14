CREATE DATABASE bankingdb;
use bankingdb;

CREATE TABLE customers(
	custid INT AUTO_INCREMENT PRIMARY KEY,
    fullname varchar(50) NOT NULL,
    registrationdate DATETIME
-- balance	DECIMAL(10,2)
);
    
INSERT INTO customers(custid, fullname, registrationdate) VALUES
(1, "KaustubhPatil", NOW()),
(2, "ADityaKharade", NOW()),
(3, "NikhilPatil", NOW()),
(4,"pallavipatil", NOW()); 

ALTER TABLE customers
DROP COLUMN balance;

CREATE TABLE accounts(
	acctid INT AUTO_INCREMENT PRIMARY KEY,
    custid INT,
    accounttype ENUM("savings","current"),
    createdon TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
    balance DECIMAL(10,2),
    CONSTRAINT fk_custid FOREIGN KEY (custid) REFERENCES customers(custid) ON UPDATE CASCADE ON DELETE CASCADE
);

CREATE TABLE operations(
	operationid INT AUTO_INCREMENT PRIMARY KEY,
    acctid INT,
    amount INT NOT NULL,
    operationsdate TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
    operationtype ENUM ('D','W'),
    CONSTRAINT fk_acctid FOREIGN KEY (acctid) REFERENCES accounts(acctid) ON UPDATE CASCADE ON DELETE CASCADE
);   

CREATE TABLE log(
	logid INT,
    timespan DATETIME,
    operationid INT,
    STATUS ENUM ("pending","completed"),
    CONSTRAINT fk_operationid FOREIGN KEY (operationid) REFERENCES operations(operationid)
);

DELIMITER $$
CREATE TRIGGER insert_new_customer
AFTER INSERT ON customers
FOR EACH ROW
BEGIN
	DECLARE new_aactid INT;
    DECLARE new_operationid INT;
    INSERT INTO accounts(custid, accounttype, createdon, balance) values (NEW.custid, "savings", NOW(), 15000);
    SET new_aactid = LAST_INSERT_ID();
    INSERT INTO operations(acctid, amount, operationsdate, operationtype) VALUES(new_acctid, 15000, NOW(), 'D');
    SET new_operationid = LAST_INSERT_ID();
    INSERT INTO log(timespan, operationid, status) VALUES(NOW(), new_operationid, "completed");
END $$
DELIMITER ;

SELECT * FROM bankingdb.customers;
INSERT INTO customers(fullname, registrationdate) VALUES
("pallavipatil", NOW());

SELECT * FROM customers WHERE fullname = 'KaustubhPatil';
SELECT * FROM accounts WHERE custid = 7;
SELECT * FROM operations WHERE acctid = 3;
SELECT * FROM log WHERE operationid = 1;


